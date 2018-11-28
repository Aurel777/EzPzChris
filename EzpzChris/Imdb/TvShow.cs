namespace EzpzChris.Imdb
{
    #region Using Statements

    using System;

    using EzpzChris.Show;

    using Newtonsoft.Json;

    #endregion

    [Serializable]
    public class TvShow : IShow
    {
        #region Private Fields

        static readonly Uri DomainName = new Uri("https://www.imdb.com/");

        #endregion

        #region Constructors

        [JsonConstructor]
        public TvShow(string name, string link)
        {
            Name = name;
            Link = link.StartsWith("/", StringComparison.Ordinal) ? new Uri(DomainName, link).AbsoluteUri : link;
        }

            #endregion

        #region Properties

        [JsonProperty(PropertyName = "Name")]
        public string Name { get; }

        [JsonProperty(PropertyName = "Link")]
        public string Link { get; }

        #endregion

        #region Members

        public override string ToString() => Name;

        #endregion
    }
}
