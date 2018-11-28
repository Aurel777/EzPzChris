namespace EzpzChris.Show
{
    #region Using Statements

    using System;

    using Newtonsoft.Json;

    #endregion

    [Serializable]
    public class Show : IShow
    {
        #region Events

        public event EventHandler<NextEpisodeEventArgs> NextEpisode; // heyeyeyheyeeeeeh smoke weed everyday

        #endregion

        #region Constructors

        public Show() { }

        [JsonConstructor]
        public Show(string name, int seasonNumber, int episodeNumber)
        {
            Name = name;
            SeasonNumber = seasonNumber;
            EpisodeNumber = episodeNumber;
        }

        #endregion
        
        #region Properties

        [JsonProperty(PropertyName = "EpisodeNumber")]
        public int EpisodeNumber { get; set; }

        [JsonProperty(PropertyName = "SeasonNumber")]
        public int SeasonNumber { get; set; }

        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        #endregion
    }
}
