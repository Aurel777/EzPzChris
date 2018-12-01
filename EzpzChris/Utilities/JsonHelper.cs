namespace EzpzChris.Utilities
{
    #region Using Statements

    using System.Collections.Generic;
    using System.IO;

    using Imdb;
    using Show;

    using Newtonsoft.Json;

    using Config = Properties.Settings;

    #endregion

    static class JsonHelper
    {
        #region Constants

        public const string EXTENSION = ".json";

        #endregion

        #region Members

        public static List<T> LoadShows<T>() where T : class, IShow
        {
            var fileName = typeof(T) == typeof(TvShow) ? Config.Default.ImdbShows : Config.Default.ShowToMonitor;
            var filePath = Settings.GetConfigurationFilePath(fileName);
            using (var file = File.OpenText(filePath))
                return JsonConvert.DeserializeObject<List<T>>(file.ReadToEnd());
        }

        public static void SaveShows<T>(List<T> list) where T : class, IShow
        {
            var fileName = typeof(T) == typeof(TvShow) ? Config.Default.ImdbShows : Config.Default.ShowToMonitor;
            var filePath = Settings.GetConfigurationFilePath(fileName);
            using (var file = File.CreateText(filePath))
            {
                var serializer = new JsonSerializer { Formatting = Formatting.Indented };
                serializer.Serialize(file, list);
            }
        }

        #endregion
    }
}
