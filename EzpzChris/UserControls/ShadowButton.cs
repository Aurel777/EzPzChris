namespace EzpzChris.UserControls
{
    #region Using Statements

    using System.ComponentModel;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Drawing.Text;
    using System.Windows.Forms;

    #endregion

    [DefaultEvent("Click"), DefaultProperty("Text")]
    public class ShadowButton : Panel
    {
        #region Private Fields

        Rectangle clientRectangle;
        Bitmap bitmap;
        bool drawShadow;
        Color backgroundColorDisabled;
        Color shadowColor;
        Color shadowColorDisabled;
        string text;

        #endregion

        #region Constructors

        public ShadowButton()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.DoubleBuffer |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.SupportsTransparentBackColor |
                     ControlStyles.UserPaint, true);
            ApplyDefaultValues(this);
            Size = new Size(75, 30);
        }

        #endregion

        #region Properties

        [Category("Appearance"), Description("Get or set the color of the shadow."),
         DefaultValue(typeof(Color), "#D8D8D8")]
        public Color BackgroundColorDisabled
        {
            get => backgroundColorDisabled;
            set
            {
                backgroundColorDisabled = value;
                Redraw();
            }
        } 

        [Category("Appearance"),Description("Get or set whether a shadow will be drawn."),DefaultValue(true)]
        public bool DrawShadow
        {
            get => drawShadow;
            set
            {
                drawShadow = value;
                clientRectangle = drawShadow ? new Rectangle(1, 1, Width - 2, Height - 2) : ClientRectangle;
                Redraw();
            }
        }

        [Category("Appearance"), Description("Get or set the color of the shadow."),
         DefaultValue(typeof(Color), "#E4E4E4")]
        public Color ShadowColor
        {
            get => shadowColor;
            set
            {
                shadowColor = value;
                Redraw();
            }
        }

        [Category("Appearance"), Description("Get or set the color of the shadow."),
         DefaultValue(typeof(Color), "#C2C2C2")]
        public Color ShadowColorDisabled
        {
            get => shadowColorDisabled;
            set
            {
                shadowColorDisabled = value;
                Redraw();
            }
        }

        [EditorBrowsable(EditorBrowsableState.Always),Browsable(true),DesignerSerializationVisibility(DesignerSerializationVisibility.Visible),Bindable(true),Category("Appearance"),DefaultValue("Button")]
        public override string Text
        {
            get => text;
            set
            {
                text = value;
                Redraw();
            }
        }

        #endregion

        protected override void OnPaint(PaintEventArgs e)
        {
            if (bitmap != null)
                e.Graphics.DrawImage(bitmap, Bounds);
        }

        void Redraw()
        {
            bitmap = new Bitmap(Width, Height);
            using (var graphics = Graphics.FromImage(bitmap))
            {
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
                graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

                if (DrawShadow)
                    using (var shadowBrush = Enabled ? new SolidBrush(ShadowColor) : new SolidBrush(ShadowColorDisabled))
                        graphics.FillRectangle(shadowBrush, new Rectangle(new Point(Location.X + 1, Location.Y + 1), Size));

                using (var backgroundBrush = Enabled ? new SolidBrush(BackColor) : new SolidBrush(BackgroundColorDisabled))
                    graphics.FillRectangle(backgroundBrush, clientRectangle);

                if (!string.IsNullOrWhiteSpace(Text))
                {
                    var textLength = graphics.MeasureString(Text, Font);
                    var offset = new PointF((Width - textLength.Width) / 2, (Height - textLength.Height) / 2);
                    using (var textBrush = new SolidBrush(ForeColor))
                        graphics.DrawString(Text, Font, textBrush, offset);
                }
            }

            Invalidate();
        }

        static void ApplyDefaultValues(object self)
        {
            foreach (PropertyDescriptor propertyDescriptor in TypeDescriptor.GetProperties(self))
            {
                if (!(propertyDescriptor.Attributes[typeof(DefaultValueAttribute)] is DefaultValueAttribute attribute))
                    continue;

                propertyDescriptor.SetValue(self, attribute.Value);
            }
        }
    }
}
