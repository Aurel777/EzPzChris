namespace EzpzChris.Web
{
    #region Using Statements

    using System.Net;
    using System.Threading.Tasks;

    #endregion

    public static class Downloader
    {
        public static async Task<string> DownloadHtmlTaskAsync(string url)
        {
            var client = new WebClient();
            var download = Task.Run(() =>
            {
                try
                {
                    return client.DownloadString(url);
                }
                catch
                {
                    return string.Empty;
                }
            });
            await download.ConfigureAwait(false);

            return download.Result;
        }

        public static string DownloadHtml(string url) => new WebClient().DownloadString(url);
    }
}
