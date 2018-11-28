namespace EzpzChris.Themes
{
    #region Using Statements

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    #endregion

    static class ThemeManager
    {
        #region Members

        internal static List<string> Themes { get; } = Assembly.GetExecutingAssembly().GetTypes()
            .Where(type => typeof(ITheme).IsAssignableFrom(type) && !type.IsInterface && !type.IsAbstract)
            .Select(type => (ITheme)Activator.CreateInstance(type))
            .Select(theme => theme.ThemeName).ToList();

        internal static ITheme GetTheme(string themeName) => Assembly.GetExecutingAssembly().GetTypes()
            .Where(type => typeof(ITheme).IsAssignableFrom(type) && !type.IsInterface && !type.IsAbstract)
            .Select(type => (ITheme)Activator.CreateInstance(type))
            .FirstOrDefault(theme => theme.ThemeName == themeName);

        #endregion
    }
}
