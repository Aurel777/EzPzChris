namespace EzpzChris.Utilities
{
    #region Using Statements

    using System.IO;
    using System.Windows.Forms;

    #endregion

    public static class Settings
    {
        #region Properties
        
        public static string SettingDirectory => Path.Combine(Application.StartupPath, typeof(Settings).Name);

        #endregion

        #region Methods

        public static string GetConfigurationFilePath(string fileName)
        {
            if (!Directory.Exists(SettingDirectory))
                Directory.CreateDirectory(SettingDirectory);

            if (Path.GetExtension(fileName) != JsonHelper.EXTENSION)
                fileName += JsonHelper.EXTENSION;

            var filePath = Path.Combine(Application.StartupPath, typeof(Settings).Name, fileName);

            if (!File.Exists(filePath))
                using (File.Create(filePath)) { }

            return filePath;
        }

        #endregion
    }
}
