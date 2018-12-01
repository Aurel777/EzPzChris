namespace EzpzChris.Imdb
{
    #region Using Statements

    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Utilities;
    using Web;

    using HtmlAgilityPack;

    #endregion

    public class ShowFetcher
    {
        #region Constants

        const string TV_SHOWS_URL = "https://www.imdb.com/search/title?title_type=tv_series&start={0}&ref_=adv_nxt";
        const string RECENTLY_ADDED_TV_SHOWS_URL = "https://www.imdb.com/list/ls069248990/?sort=date_added,desc&st_dt=&mode=detail&page=1";
        const int INCREMENT = 50;
        const string SHOW_COUNT_TEXT_START = " of ";
        const string SHOW_COUNT_TEXT_END = " titles.";

        #endregion

        #region Event

        public event EventHandler<ShowFetchedEventArgs> ShowFetched;
        public event EventHandler<AllShowsFetchedEventArgs> AllShowsFetch;

        #endregion

        #region Constructors

        public ShowFetcher() => Count = GetTotalOfShows();

        #endregion
        
        public int Count { get; }
        
        public void Fetch()
        {
            var count = 0;
            var shows = new List<TvShow>(Count);
            var max = Count / INCREMENT;
            var pageId = 1;

            for (var i = 0; i < max; i++)
            {
                var currentUrl = string.Format(TV_SHOWS_URL, pageId);
                foreach (var show in FetchShowsFromUrl(currentUrl))
                {
                    shows.Add(show);
                    count++;
                    OnShowFetched(new ShowFetchedEventArgs(count, show.Name));
                }
                pageId += INCREMENT;
            }

            JsonHelper.SaveShows(shows);
            OnAllShowsFetched(new AllShowsFetchedEventArgs());
        }

        public int Update()
        {
            var count = 0;
            var shows = JsonHelper.LoadShows<TvShow>();
            foreach (var newShow in FetchShowsFromUrl(RECENTLY_ADDED_TV_SHOWS_URL))
                if (!shows.Contains(newShow))
                {
                    shows.Add(newShow);
                    count++;
                    OnShowFetched(new ShowFetchedEventArgs(count, newShow.Name));
                }
                else
                    break;

            JsonHelper.SaveShows(shows);
            return count;
        }

        #region Virtual Members

        protected virtual void OnShowFetched(ShowFetchedEventArgs e)
        {
            var handler = ShowFetched;
            handler?.Invoke(this, e);
        }

        protected virtual void OnAllShowsFetched(AllShowsFetchedEventArgs e)
        {
            var handler = AllShowsFetch;
            handler?.Invoke(this, e);
        }

        #endregion

        static IEnumerable<TvShow> FetchShowsFromUrl(string url)
        {
            var nodes = GetNodes(url, "//div[@class='lister-item-image float-left']/a");

            foreach (var node in nodes)
                if (node.Attributes.Contains("href") && node.ChildNodes[1].Attributes.Contains("alt"))
                {
                    var link = node.Attributes["href"].DeEntitizeValue;
                    var title = node.ChildNodes[1].Attributes["alt"].DeEntitizeValue;
                    if (!string.IsNullOrWhiteSpace(link) && !string.IsNullOrWhiteSpace(title))
                        yield return new TvShow(title, link);
                }
        }

        static HtmlNodeCollection GetNodes(string url, string query)
        {
            var html = Downloader.DownloadHtml(url);
            var document = new HtmlDocument();
            document.LoadHtml(html);

            return document.DocumentNode.SelectNodes(query);
        }

        static async Task<HtmlNodeCollection> GetNodesTaskAsync(string url, string query)
        {
            var html = await Downloader.DownloadHtmlTaskAsync(url).ConfigureAwait(false);
            var document = new HtmlDocument();
            await Task.Run(() => document.LoadHtml(html)).ConfigureAwait(false);

            return document.DocumentNode.SelectNodes(query);
        }

        static int GetTotalOfShows()
        {
            var nodes = GetNodes(string.Format(TV_SHOWS_URL, "1"), "//div[@class='desc']/span");
            var textNode = nodes?[0].InnerText;
            if (textNode?.Contains(SHOW_COUNT_TEXT_START) != true || !textNode.Contains(" titles."))
                return 0;

            var start = textNode.IndexOf(SHOW_COUNT_TEXT_START, StringComparison.Ordinal) + SHOW_COUNT_TEXT_START.Length;
            var end = textNode.IndexOf(SHOW_COUNT_TEXT_END, StringComparison.Ordinal) - SHOW_COUNT_TEXT_END.Length;
            var count = textNode.Substring(start, end).Replace(",", "");
            return int.TryParse(count, out var showCount) ? showCount : 0;
        }


        static async Task<int> GetTotalOfShowsTaskAsync()
        {
            var nodes = await GetNodesTaskAsync(string.Format(TV_SHOWS_URL, "1"), "//div[@class='desc']/span").ConfigureAwait(false);
            var textNode = nodes?[0].InnerText;
            if (textNode?.Contains(SHOW_COUNT_TEXT_START) != true || !textNode.Contains(" titles."))
                return 0;

            var start = textNode.IndexOf(SHOW_COUNT_TEXT_START, StringComparison.Ordinal) + SHOW_COUNT_TEXT_START.Length;
            var end = textNode.IndexOf(SHOW_COUNT_TEXT_END, StringComparison.Ordinal) - SHOW_COUNT_TEXT_END.Length;
            var count = textNode.Substring(start, end).Replace(",", "");
            return int.TryParse(count, out var showCount) ? showCount : 0;
        }
    }
}
