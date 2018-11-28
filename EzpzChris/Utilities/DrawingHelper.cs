namespace EzpzChris.Utilities
{
    using System;
    using System.Drawing;

    public static class DrawingHelper
    {
        public static Pen GetPen(Color color, int width) => new Pen(new SolidBrush(color), width);

        public static Color GetDarkColor(Color color) => GetNewColor(color, -20);

        public static Color GetDarkDarkColor(Color color) => GetNewColor(color, -40);

        public static Color GetLightColor(Color color) => GetNewColor(color, 20);

        public static Color GetLightLightColor(Color color) => GetNewColor(color, 40);
        
        public static Color GetNewColor(Color colorBase, int addValue)
        {
            var red = Math.Max(0, Math.Min(colorBase.R + addValue, 255));
            var green = Math.Max(0, Math.Min(colorBase.G + addValue, 255));
            var blue = Math.Max(0, Math.Min(colorBase.B + addValue, 255));
            
            return Color.FromArgb(red, green, blue);
        }

        public static PointF GetStringPosition(Graphics graphics, SizeF size, ContentAlignment alignment, Rectangle rectangle)
        {
            float left = rectangle.Left + 2;
            float top = rectangle.Top + 2;

            if (alignment == ContentAlignment.MiddleLeft || alignment == ContentAlignment.MiddleCenter || alignment == ContentAlignment.MiddleRight)
                top = rectangle.Top + (rectangle.Height - size.Height) / 2;
            else if (alignment == ContentAlignment.BottomLeft || alignment == ContentAlignment.BottomCenter || alignment == ContentAlignment.BottomRight)
                top = rectangle.Top + rectangle.Height - size.Height;
            
            if (alignment == ContentAlignment.TopCenter || alignment == ContentAlignment.MiddleCenter || alignment == ContentAlignment.BottomCenter)
                left = rectangle.Left + (rectangle.Width - size.Width) / 2;
            else if (alignment == ContentAlignment.TopRight || alignment == ContentAlignment.MiddleRight || alignment == ContentAlignment.BottomRight)
                left = rectangle.Left + rectangle.Width - size.Width;

            return new PointF(left, top);
        }
    }
}
