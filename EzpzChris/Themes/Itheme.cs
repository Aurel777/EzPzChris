namespace EzpzChris.Themes
{
    #region Using Statements

    using System;
    using System.Drawing;

    #endregion
    
    public interface ITheme : IDisposable
    {
        #region Properties

        Color BackgroundColor { get; set; }
        Color BackgroundColor2 { get; set; }
        Color BorderDarkerColor { get; set; }
        Color BorderColor { get; set; }

        Font Font { get; set; }

        Color ForeColor { get; set; }
        Color HoveredColor { get; set; }
        Color HoveredColor2 { get; set; }
        Color HoveredBorderColor { get; set; }
        Color SelectedBorderColor { get; set; }
        Color SelectedColor { get; set; }
        Color SelectedColor2 { get; set; }

        string ThemeName { get; }

        #endregion
    }
}