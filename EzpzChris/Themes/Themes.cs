namespace EzpzChris.Themes
{
    #region Using Statements

    using System;
    using System.Drawing;

    #endregion

    public static class Themes
    {
        public class Blue : ITheme, IDisposable
        {
            public Color BackgroundColor { get; set; } = SystemColors.ControlLightLight;
            public Color BackgroundColor2 { get; set; } = SystemColors.ControlLightLight;
            public Color BorderColor { get; set; } = Color.FromArgb(255, 222, 222, 222);
            public Color BorderDarkerColor { get; set; } = Color.FromArgb(255, 214, 214, 214);

            public Font Font { get; set; } = new Font("Corbel", 11, FontStyle.Regular);

            public Color ForeColor { get; set; } = Color.Black;
            public Color HoveredBorderColor { get; set; } = Color.FromArgb(255, 136, 203, 235);
            public Color HoveredColor { get; set; } = Color.FromArgb(255, 227, 247, 255);
            public Color HoveredColor2 { get; set; } = Color.FromArgb(255, 185, 233, 253);

            public Color SelectedBorderColor { get; set; } = Color.FromArgb(255, 122, 158, 177);
            public Color SelectedColor { get; set; } = Color.FromArgb(255, 188, 228, 249);
            public Color SelectedColor2 { get; set; } = Color.FromArgb(255, 139, 211, 246);

            public Color TextColor { get; set; } = Color.Black;

            public string ThemeName => "Blue";

            public void Dispose()=> Font?.Dispose();
        }

        public sealed class Dark : ITheme, IDisposable
        {
            public Color BackgroundColor { get; set; }
            public Color BackgroundColor2 { get; set; }
            public Color BorderDarkerColor { get; set; }
            public Color BorderColor { get; set; }
            public Font Font { get; set; }
            public Color ForeColor { get; set; }
            public Color HoveredColor { get; set; }
            public Color HoveredColor2 { get; set; }
            public Color HoveredBorderColor { get; set; }
            public Color SelectedBorderColor { get; set; }
            public Color SelectedColor { get; set; }
            public Color SelectedColor2 { get; set; }
            public string ThemeName => "Dark";

            public void Dispose() => Font?.Dispose();
        }

        public sealed class Light : ITheme, IDisposable
        {
            public Color BackgroundColor { get; set; }
            public Color BackgroundColor2 { get; set; }
            public Color BorderDarkerColor { get; set; }
            public Color BorderColor { get; set; }
            public Font Font { get; set; }
            public Color ForeColor { get; set; }
            public Color HoveredColor { get; set; }
            public Color HoveredColor2 { get; set; }
            public Color HoveredBorderColor { get; set; }
            public Color SelectedBorderColor { get; set; }
            public Color SelectedColor { get; set; }
            public Color SelectedColor2 { get; set; }
            public string ThemeName => "Light";

            public void Dispose() => Font?.Dispose();
        }
    }
}
