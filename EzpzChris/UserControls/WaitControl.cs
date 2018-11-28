namespace EzpzChris.UserControls
{
    #region Using Statements

    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Windows.Forms;

    using EzpzChris.Utilities;

    #endregion

    public class WaitControl : Panel
    {
        #region Private Fields

        bool disposed;

        #region Inline Circle

        System.Timers.Timer timerProgress;
        bool showInlineCircle;
        int inlineCircleWidth;
        Color inlineCircleColor = Color.Black;
        Pen inlineCirclePen = new Pen(Brushes.Black, 2);
        Rectangle inlineCircleRectangle = Rectangle.Empty;

        #endregion

        #region Inner Circle

        int innerCircleWidth = 16;
        Color innerCircleColor = Color.CornflowerBlue;
        Pen innerCirclePen = new Pen(Brushes.CornflowerBlue, 16);
        Rectangle innerCircleRectangle = Rectangle.Empty;

        #endregion

        #region Outline Circle

        bool showOutlineCircle;
        int outlineCircleWidth;
        Color outlineCircleColor = Color.Black;
        Pen outlineCirclePen = new Pen(Brushes.Black, 2);
        Rectangle outlineCircleRectangle = Rectangle.Empty;

        #endregion

        #region Progression

        int circleProgress;
        int progressionSpeed = 50;
        int progressionUpdateInterval;
        Color progressionCircleColor = Color.Blue;
        Pen progressionCirclePen = new Pen(Brushes.Blue, 16);

        #endregion

        #endregion

        #region Constructors

        public WaitControl()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer | ControlStyles.UserPaint, true);
            SetTimer();
            ApplyDefaultValues(this);
            Invalidate();
        }
        
        public WaitControl(int width, int height)
        {
            Size = new Size(width, height);
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.DoubleBuffer |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.SupportsTransparentBackColor |
                     ControlStyles.UserPaint, true);
            ApplyDefaultValues(this);
            Invalidate();
        }

        ~WaitControl() => Dispose(false);

        #endregion

        #region Properties

        #region Inline circle

        [Category("Behavior"), DefaultValue(true),Description("Show or hide the inline circle.")]
        public bool ShowInlineCircle
        {
            get => showInlineCircle;
            set
            {
                showInlineCircle = value;
                Invalidate();
            }
        }

        [Category("Appearance"), DefaultValue(typeof(Color), "Black"),Description("Get or set the inline circle color.")]
        public Color InlineCircleColor
        {
            get => inlineCircleColor;
            set
            {
                inlineCircleColor = value;
                inlineCirclePen = DrawingHelper.GetPen(inlineCircleColor, innerCircleWidth);
                Invalidate();
            }
        }

        [Category("Appearance"), DefaultValue(2),Description("Get or set the inline circle size.")]
        public int InlineCircleWidth
        {
            get => inlineCircleWidth;
            set
            {
                inlineCircleWidth = value;
                inlineCirclePen = DrawingHelper.GetPen(inlineCircleColor, inlineCircleWidth);
                Invalidate();
            }
        }

        [Category("Appearance"),DefaultValue(typeof(Rectangle), "344, 344"),Description("Get or set the inline circle rectangle area.")]
        public Rectangle InlineCircleRectangle
        {
            get => inlineCircleRectangle;
            set
            {
                inlineCircleRectangle = value;
                Invalidate();
            }
        }

        #endregion

        #region Inner circle

        [Category("Appearance"), DefaultValue(typeof(Color), "CornflowerBlue"),Description("Get or set the inner circle color.")]
        public Color InnerCircleColor
        {
            get => innerCircleColor;
            set
            {
                innerCircleColor = value;
                innerCirclePen = DrawingHelper.GetPen(innerCircleColor, innerCircleWidth);
                Invalidate();
            }
        }

        [Category("Appearance"), DefaultValue(typeof(Rectangle), "360, 360"),Description("Get or set the inner circle rectangle area.")]
        public Rectangle InnerCircleRectangle
        {
            get => innerCircleRectangle;
            set
            {
                innerCircleRectangle = value;
                Invalidate();
            }
        }


        [Category("Appearance"), Description("Get or set the inner circle size."),DefaultValue(16)]
        public int InnerCircleWidth
        {
            get => innerCircleWidth;
            set
            {
                innerCircleWidth = value;
                innerCirclePen = new Pen(innerCircleColor, innerCircleWidth);
                progressionCirclePen = new Pen(progressionCircleColor, innerCircleWidth);
                Invalidate();
            }
        }

        #endregion

        #region Outline circle

        [Category("Behavior"), DefaultValue(true),Description("Show or hide the outline circle.")]
        public bool ShowOutlineCircle
        {
            get => showOutlineCircle;
            set
            {
                showOutlineCircle = value;
                Invalidate();
            }
        }

        [Category("Appearance"), DefaultValue(typeof(Color), "Black"),Description("Get or set the outline circle color.")]
        public Color OutlineCircleColor
        {
            get => outlineCircleColor;
            set
            {
                outlineCircleColor = value;
                outlineCirclePen = DrawingHelper.GetPen(outlineCircleColor, outlineCircleWidth);
                Invalidate();
            }
        }

        [Category("Appearance"), DefaultValue(2),Description("Get or set the outline circle size.")]
        public int OutlineCircleWidth
        {
            get => outlineCircleWidth;
            set
            {
                outlineCircleWidth = value;
                outlineCirclePen = DrawingHelper.GetPen(outlineCircleColor, outlineCircleWidth);
                Invalidate();
            }
        }

        [Category("Appearance"),DefaultValue(typeof(Rectangle), "376, 376"),Description("Get or set the outline circle rectangle area.")]
        public Rectangle OutlineCircleRectangle
        {
            get => outlineCircleRectangle;
            set
            {
                outlineCircleRectangle = value;
                Invalidate();
            }
        }

        #endregion

        #region Overriden

        [Category("Apperance"), DefaultValue(typeof(DockStyle), "Fill")]
        public new DockStyle Dock => DockStyle.Fill;

        #endregion

        #region Progression

        [Category("Progression"), DefaultValue(typeof(Color), "Blue"),Description("Get or set the progression of the circle color.")]
        public Color ProgressionCircleColor
        {
            get => progressionCircleColor;
            set
            {
                progressionCircleColor = value;
                progressionCirclePen = DrawingHelper.GetPen(progressionCircleColor, innerCircleWidth);
                Invalidate();
            }
        }

        [Category("Progression"), DefaultValue(4),Description("Get or set the speed of progression.")]
        public int ProgressionSpeed
        {
            get => progressionSpeed;
            set
            {
                progressionSpeed = value;
                Invalidate();
            }
        }

        [Category("Progression"), DefaultValue(50),Description("Get or set the progression circle speed.")]
        public int ProgressionUpdateInterval
        {
            get => progressionUpdateInterval;
            set
            {
                if (value < 0)
                    return;

                progressionUpdateInterval = value;
                timerProgress.Interval = progressionUpdateInterval;
                Invalidate();
            }
        }

        #endregion

        #endregion

        #region Methods

        #region Overriden Methods

        #region IDisposable Members

        protected override void Dispose(bool disposing)
        {
            if (!disposed)
            {
                disposed = true;
                inlineCirclePen?.Dispose();
                innerCirclePen?.Dispose();
                outlineCirclePen?.Dispose();
                progressionCirclePen?.Dispose();
                if(disposing)
                    GC.WaitForPendingFinalizers();
            }
            base.Dispose(disposed);
        }

        #endregion IDisposable Members

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (inlineCirclePen == null || innerCirclePen == null || outlineCirclePen == null || progressionCirclePen == null)
                return;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.CompositingQuality = CompositingQuality.HighQuality;

            if (circleProgress == 0 || circleProgress > 360)
                circleProgress = 0;

            e.Graphics.DrawEllipse(innerCirclePen, innerCircleRectangle);
            e.Graphics.DrawArc(progressionCirclePen, innerCircleRectangle, 0, circleProgress);

            if (showInlineCircle)
                e.Graphics.DrawEllipse(inlineCirclePen, inlineCircleRectangle);

            if (showOutlineCircle)
                e.Graphics.DrawEllipse(outlineCirclePen, outlineCircleRectangle);

            circleProgress += progressionSpeed;
        }

        protected override void OnResize(EventArgs e)
        {
            innerCircleRectangle = new Rectangle(innerCircleWidth, innerCircleWidth, ClientRectangle.Width - innerCircleWidth * 2, ClientRectangle.Height - innerCircleWidth * 2);
            inlineCircleRectangle = new Rectangle(innerCircleRectangle.X - innerCircleWidth / 2, innerCircleRectangle.Y - innerCircleWidth / 2, innerCircleRectangle.Width + innerCircleWidth, innerCircleRectangle.Height + innerCircleWidth);
            outlineCircleRectangle = new Rectangle(innerCircleRectangle.X + innerCircleWidth / 2, innerCircleRectangle.Y + innerCircleWidth / 2, innerCircleRectangle.Width - innerCircleWidth, innerCircleRectangle.Height - innerCircleWidth);

            Invalidate();
        }

        #endregion

        void SetTimer()
        {
            timerProgress = new System.Timers.Timer(50) {Enabled = true};
            timerProgress.Elapsed += (o, e) => Invalidate(true);
        }

        static void ApplyDefaultValues(object waitControl)
        {
            if (!(waitControl is WaitControl))
                return;

            foreach (PropertyDescriptor property in TypeDescriptor.GetProperties(waitControl))
            {
                if (!(property.Attributes[typeof(DefaultValueAttribute)] is DefaultValueAttribute attribute))
                    continue;

                property.SetValue(waitControl, attribute.Value);
            }
        }
        
        #endregion
    }
}
