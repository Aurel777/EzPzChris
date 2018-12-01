using System.Collections.Generic;

namespace EzpzChris.UserControls
{
    #region Using Statements

    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Windows.Forms;
    using Themes;
    using Utilities;

    #endregion

    [DefaultProperty("Checked"), DefaultEvent("Click")]
    public class CheckBox : Panel
    {
        #region Private Fields

        #region Checked and Disabled Points

        static readonly List<Point> CrossPoints = new List<Point>(4)
        {
            new Point(41, 6),
            new Point(47, 13),
            new Point(41, 13),
            new Point(47, 6)
        };

        static readonly List<Point> CheckPoints = new List<Point>(4)
        {
            new Point(9, 9),
            new Point(13, 13),
            new Point(13, 13),
            new Point(18, 6)
        };

        #endregion

        bool isChecked;
        ITheme theme;
        Rectangle checkedRectangle;
        Rectangle uncheckedRectangle;

        #endregion

        #region Constructors

        public CheckBox()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.SupportsTransparentBackColor |
                     ControlStyles.UserPaint, true);
            Size = new Size(60, 21);
            theme = ThemeManager.GetTheme("Blue");
        }

        #endregion

        #region Events

        public event EventHandler<CheckedChangedEventArgs> CheckChanged;

        #endregion Events

        #region Properties

        [Browsable(true), Category("Behavior"), Description("Get or set the check state."), DisplayName("Checked"), DefaultValue(true)]
        public bool Checked
        {
            get => isChecked;
            set
            {
                isChecked = value;
                Invalidate();
            }
        }

        [Browsable(true), Category("Appearance"), Description("Gets or sets the current theme."), TypeConverter(typeof(ThemeConverter)), DefaultValue("Blue")]
        public string ThemeName
        {
            get => theme.ThemeName;
            set
            {
                theme = ThemeManager.GetTheme(value);
                Invalidate();
            }
        }

        #endregion

        #region Members

        #region Overriden Members

        protected override void OnClick(EventArgs e)
        {
            isChecked = !isChecked;
            OnCheckChanged(new CheckedChangedEventArgs(isChecked));
            Invalidate();
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            
            using(var backgroundBrush = new SolidBrush(theme.BackgroundColor))
                e.Graphics.FillRectangle(backgroundBrush, ClientRectangle);

            if (isChecked)
                Draw(e.Graphics, checkedRectangle, theme.SelectedColor, theme.BackgroundColor, CheckPoints);
            else
                Draw(e.Graphics, uncheckedRectangle, theme.BackgroundColorDisabled, theme.ForeColor, CrossPoints);

            using (var borderPen = DrawingHelper.GetPen(theme.BorderColor, 1))
                e.Graphics.DrawRectangle(borderPen, 0, 0, Width -2, Height - 2);
        }
        
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            checkedRectangle = new Rectangle(Point.Empty, new Size(Width / 2, Height));
            uncheckedRectangle = new Rectangle(new Point(Width / 2, 0), new Size(Width / 2, Height));
            Invalidate();
        }

        void Draw(Graphics graphics, Rectangle area, Color backColor, Color foreColor, IReadOnlyList<Point> points)
        {
            using (var brush = new SolidBrush(backColor))
                graphics.FillRectangle(brush, area);

            using (var pen = DrawingHelper.GetPen(foreColor, 2))
            {
                graphics.DrawLine(pen, points[0], points[1]);
                graphics.DrawLine(pen, points[2], points[3]);
            }
        }

        #endregion

        protected virtual void OnCheckChanged(CheckedChangedEventArgs e)
        {
            var handler = CheckChanged;
            handler?.Invoke(this, e);
        }

        #endregion
    }

    public sealed class CheckedChangedEventArgs : EventArgs
    {
        readonly bool Checked;

        internal CheckedChangedEventArgs(bool isChecked) => Checked = isChecked;
    }
}
