namespace EzpzChris.UserControls
{
    #region Using Statements

    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    using EzpzChris.Utilities;

    #endregion

    public class LineSeparator : Panel
    {
        #region Private Fields

        int borderHeight;

        #endregion

        #region Constuctors

        public LineSeparator()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.DoubleBuffer |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.SupportsTransparentBackColor |
                     ControlStyles.UserPaint, true);
            BorderHeight = 1;
        }

        #endregion

        #region Region Properties

        [Description("Get or set the size of the line."), DefaultValue(1)]
        public int BorderHeight
        {
            get => borderHeight;
            set
            {
                borderHeight = value;
                Size = new Size(Width, BorderHeight);
                Invalidate();
            }
        }

        #endregion

        #region Overriden Members

        protected override void OnPaint(PaintEventArgs e)
        {
            using(var pen = DrawingHelper.GetPen(BackColor, borderHeight))
                e.Graphics.DrawLine(pen, Point.Empty, new Point(Width, borderHeight));
        }

        #endregion
    }
}
