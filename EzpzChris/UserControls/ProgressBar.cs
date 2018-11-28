namespace EzpzChris.UserControls
{
    #region Using Statements

    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Globalization;
    using System.Windows.Forms;

    #endregion

    [DefaultProperty("Value"), DefaultEvent("Click")]
    public class ProgressBar : Button
    {
        #region Private Fields

        bool disposed;
        int minimum;
        int maximum;
        double value;
        readonly int borderWidth;

        Rectangle clientRectangle;
        
        Color progressBarBorderColor;
        Color progressBarColor;
        
        Brush foreBrush;
        Brush backBrush;
        Brush progressBarBrush;
        Pen progressBarBorderPen;

        #endregion Private Fields

        #region Constructor

        public ProgressBar()
        {
            borderWidth = FlatAppearance.BorderSize;
            clientRectangle = ClientRectangle;
            clientRectangle.Inflate(-FlatAppearance.BorderSize - 1, -FlatAppearance.BorderSize - 1);
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.SupportsTransparentBackColor |
                     ControlStyles.UserPaint, true);
            ApplyDefaultValues(this);
        }

        ~ProgressBar() => Dispose(false);

        #endregion Constructor

        #region Properties

        [Browsable(true), Category("Appearance"), DefaultValue(typeof(Color), "#4AA5D2")]
        public override Color BackColor
        {
            get { return base.BackColor; }
            set
            {
                base.BackColor = value;
                backBrush = new SolidBrush(value);
                Invalidate(true);
            }
        }

        [Browsable(true), Category("Appearance"), DefaultValue(typeof(Color), "#FFFFFF")]
        public override Color ForeColor
        {
            get { return base.ForeColor; }
            set
            {
                base.ForeColor = value;
                foreBrush = new SolidBrush(value);
                Invalidate(true);
            }
        }

        [Browsable(true), Category("Apparence"), Description("Get or set the progress bar color."), DefaultValue(typeof(Color), "#4AA5D2")]
        public Color ProgressBarColor
        {
            get { return progressBarColor; }
            set
            {
                progressBarColor = value;
                progressBarBrush = new SolidBrush(value);
                Invalidate(true);
            }
        }

        [Browsable(true), Category("Apparence"), Description("Get or set the progress bar color."), DefaultValue(typeof(Color), "#2C87B4")]
        public Color ProgressBarBorderColor
        {
            get { return progressBarBorderColor; }
            set
            {
                progressBarBorderColor = value;
                progressBarBorderPen = new Pen(value, 0.5F);
                Invalidate(true);
            }
        }

        [Browsable(true), Category("Value"), Description("Get or set the maximum value of the progress bar."), DefaultValue(100)]
        public int Maximum
        {
            get { return maximum; }
            set
            {
                maximum = value;
                if (this.value > maximum)
                    this.value = maximum;

                Invalidate(true);
            }
        }

        [Category("Value"), Description("Get or set the minimum value of the progress bar."), DefaultValue(0)]
        public int Minimum
        {
            get { return minimum; }
            set
            {
                minimum = value;
                if (this.value < minimum)
                    this.value = minimum;

                Invalidate(true);
            }
        }

        [Category("Value"), Description("Get or set the value of the progress bar."), DefaultValue(0)]
        public double Value
        {
            get { return value; }
            set
            {
                this.value = value;
                if (this.value < minimum)
                    this.value = minimum;
                if (this.value > maximum)
                    this.value = maximum;

                var percentage = value * 100D / Maximum;
                base.Text = $"{Value} / {Maximum} ({Math.Round(percentage, 2)}%)";
                Invalidate(true);
            }
        }

        #endregion Properties

        #region Overriden Members

        protected override void Dispose(bool disposing)
        {
            if (!disposed)
            {
                disposed = true;
                backBrush?.Dispose();
                foreBrush?.Dispose();
                progressBarBrush?.Dispose();
                progressBarBorderPen?.Dispose();
                if (disposing)
                    GC.SuppressFinalize(this);
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            clientRectangle = ClientRectangle;
            clientRectangle.Inflate(-FlatAppearance.BorderSize - 3, -FlatAppearance.BorderSize - 3);

            Invalidate(true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if(backBrush == null || progressBarBrush == null)
                return;

            var percentage = Value * 100F / Maximum;
            var width = float.Parse((percentage * Width / 100F).ToString(CultureInfo.InvariantCulture));
            var progressRectangle = new RectangleF(PointF.Empty, new SizeF(width, Height));
            e.Graphics.FillRectangle(backBrush, ClientRectangle);
            e.Graphics.FillRectangle(progressBarBrush, progressRectangle);
            e.Graphics.DrawRectangle(progressBarBorderPen, 0, 0, Width - 2, Height - 2); 

            if (string.IsNullOrWhiteSpace(base.Text) || foreBrush == null)
                return;

            var textSize = e.Graphics.MeasureString(base.Text, Font);
            var textLocation = new PointF(textSize.Width > Width ? borderWidth + 1 : (Width - textSize.Width) / 2, textSize.Height > Height ? borderWidth + 1 : (Height - textSize.Height) / 2);

            e.Graphics.DrawString(base.Text, Font, foreBrush, textLocation);
        }

        #endregion Overriden methods

        static void ApplyDefaultValues(object self)
        {
            if (!(self is ProgressBar))
                return;

            foreach (PropertyDescriptor property in TypeDescriptor.GetProperties(self))
            {
                if (!(property.Attributes[typeof(DefaultValueAttribute)] is DefaultValueAttribute attribute))
                    continue;

                property.SetValue(self, attribute.Value);
            }
        }
    }
}
