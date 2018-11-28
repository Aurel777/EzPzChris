using System.Windows.Forms.VisualStyles;

namespace EzpzChris.UserControls.ListView
{
    #region Using Statements

    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Linq;
    using System.Windows.Forms;
    using Themes;
    using Utilities;

    #endregion

    [DefaultProperty("Header")]
    sealed class ListView : Panel
    {
        #region  Private Fields

        bool rebuild;
        readonly List<Line> lines = new List<Line>();
        ITheme theme;

        #endregion

        #region Constructors

        public ListView() => Initialize();

        #endregion
        
        #region Properties

        [Category("Data")]
        public Line Headers { get; set; } = new Line();

        [Category("Behaviour"), DisplayName("Item line height."),Description("Sets the height of an item line.")]
        public int ItemHeight { set; get; }

        [Category("Behavior"), DisplayName("Sort triangle size"), DefaultValue(8),Description("Gets or sets the size of the sort triangle.")]
        public int SortTriangleSize { get; set; } = 8;

        [Category("Appearance"), Description("Gets or sets the current theme."), TypeConverter(typeof(ThemeConverter)), DefaultValue("Blue")]
        public string ThemeName
        {
            get => theme.ThemeName; 
            set =>  theme = ThemeManager.GetTheme(value);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                var createParameters = base.CreateParams;
                createParameters.ExStyle |= 0x00000020;
                return createParameters;
            }
        }
        
        #endregion

        #region Overriden Members

        protected override void OnMouseMove(MouseEventArgs e) => UpdateCellsProperties(PropertyToEdit.Hovered, true);

        protected override void OnMouseDown(MouseEventArgs e) => UpdateCellsProperties(PropertyToEdit.Selected, false);

        protected override void OnMouseUp(MouseEventArgs e) => UpdateCellsProperties(PropertyToEdit.Selected, true);
           
        protected override void OnClick(EventArgs e) => UpdateCellsProperties(PropertyToEdit.Clicked, true);
        
        protected override void OnPaint(PaintEventArgs e) => Draw(e.Graphics);

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            using (var brush = new SolidBrush(BackColor))
                e.Graphics.FillRectangle(brush, Bounds);
        }
        
        protected override void OnLayout(LayoutEventArgs e)
        {
            base.OnLayout(e);
            if (e.AffectedProperty == "Bounds"  && Size != Size.Empty)
                Build();
        }
        
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            foreach (var line in lines)
                line.Size = new Size(Width, line.Height);
            Invalidate();
        }

        #endregion

        #region Members

        public void Build()
        {
            lines.Clear();
            if (Headers == null)
                return;

            var x = 0;
            foreach (Cell cell in Headers.Cells)
            {
                cell.Location = new Point(x, 0);
                x += cell.Width;
            }
            Headers.Size = new Size(Width, Headers.Height);
            lines.Add(Headers);
        
            Invalidate();
        }

        void Idle(object sender, EventArgs e)
        {
            if (!rebuild)
                return;

            rebuild = false;
        }

        static Cell GetCell(Point mouseLocation, Line targetLine)
        {
            var hitPoint = new Rectangle(mouseLocation, new Size(1, 1));
            return targetLine.Cells.ToList().FirstOrDefault(c => c.Bounds.IntersectsWith(hitPoint));
        }

        Line GetLine(Point mouseLocation)
        {
            var hitPoint = new Rectangle(mouseLocation, new Size(1, 1));
            return (from line in lines
                select line into l
                where l.Bounds.IntersectsWith(hitPoint)
                select l).FirstOrDefault();
        }
        
        void Draw(Graphics graphics)
        {
            DrawHeaders(graphics);
            //DrawItems(Graphics);
            rebuild = false;
        }

        void DrawHeaders(Graphics graphics)
        {
            if (lines == null)
                return;

            var background = new Rectangle(lines[0].Location, new Size(Width, lines[0].Height));
            using (var backgroundBrush = new SolidBrush(theme.BackgroundColor))
                graphics.FillRectangle(backgroundBrush, background);
            
            using (var topBorderLinePen = DrawingHelper.GetPen(theme.BorderColor, 1))
                graphics.DrawLine(topBorderLinePen, lines[0].Location, new Point(Width, lines[0].Location.Y));

            using (var bottomBorderLinePen = DrawingHelper.GetPen(theme.BorderDarkerColor, 1))
                graphics.DrawLine(bottomBorderLinePen, new Point(lines[0].Location.X, lines[0].Height - 1), new Point(Width, lines[0].Height - 1));
        
            foreach (Cell cell in lines[0].Cells)
            {
                using (var borderPen = new Pen(theme.BorderColor, 1))
                {
                    if (cell.Name.EndsWith("0", StringComparison.Ordinal))
                    {
                        graphics.DrawLine(borderPen, cell.Location, new Point(cell.Location.X, cell.Height - 1));
                        graphics.DrawLine(borderPen, new Point(cell.Location.X + cell.Width, cell.Location.Y), new Point(cell.Location.X + cell.Width, cell.Height - 1));
                    }
                    else
                        graphics.DrawLine(borderPen, new Point(cell.Location.X + cell.Width, cell.Location.Y), new Point(cell.Location.X + cell.Width, cell.Height - 1));

                }
                if (cell.Hovered)
                {
                    var backgroundColor1 = cell.Selected ? theme.SelectedColor : theme.HoveredColor;
                    var backgroundColor2 = cell.Selected ? theme.SelectedColor2 : theme.HoveredColor2;
                    var borderColor = cell.Selected ? theme.SelectedBorderColor : theme.HoveredBorderColor;

                    using (var backgroundBrush = new SolidBrush(backgroundColor1))
                        graphics.FillRectangle(backgroundBrush, new Rectangle(cell.Location.X, cell.Location.Y + 1, cell.Width, SortTriangleSize));

                    using (var backgroundBrush = new SolidBrush(backgroundColor2))
                        graphics.FillRectangle(backgroundBrush, new Rectangle(cell.Location.X, SortTriangleSize - 1, cell.Width, cell.Height - SortTriangleSize));

                    using (var borderPen = new Pen(borderColor, 1))
                    {
                        graphics.DrawLine(borderPen, cell.Location, new Point(cell.Location.X, cell.Height - 1));
                        graphics.DrawLine(borderPen, new Point(cell.Location.X + cell.Width, cell.Location.Y), new Point(cell.Location.X + cell.Width, cell.Height - 1));
                        graphics.DrawLine(borderPen, new Point(cell.Location.X, cell.Height - 1), new Point(cell.Location.X + cell.Width, cell.Height - 1));
                    }
                    if (cell.Clicked)
                    {
                        graphics.PixelOffsetMode = PixelOffsetMode.Half;
                        if (cell.SortOrder == SortOrder.Ascending)
                            graphics.FillPolygon(Brushes.Black, new[] { new Point((cell.Width - SortTriangleSize)/2 + cell.Location.X, 0),
                                                                new Point(((cell.Width - SortTriangleSize)/ 2) + SortTriangleSize + cell.Location.X, 0),
                                                                new Point(cell.Width /2 + cell.Location.X, SortTriangleSize/2) });
                        else
                            graphics.FillPolygon(Brushes.Black, new[] { new Point(cell.Width /2 + cell.Location.X, 0),
                                                                new Point(((cell.Width - SortTriangleSize)/ 2) + cell.Location.X, SortTriangleSize /2),
                                                                new Point(((cell.Width - SortTriangleSize)/ 2) + SortTriangleSize + cell.Location.X, SortTriangleSize /2)});
                    }
                }
                DrawText(graphics, cell);
            }
        }

        void DrawText(Graphics graphics, Cell cell)
        {
            if (!string.IsNullOrEmpty(cell.Text))
            {
                var size = TextRenderer.MeasureText(cell.Text, theme.Font);
                var textLocation = PointF.Empty;
                switch (cell.TextAlignment)
                {
                    case ContentAlignment.MiddleCenter: textLocation = new PointF(cell.X + ((cell.Width - size.Width) / 2), size.Height / 2); break;
                    case ContentAlignment.MiddleLeft: textLocation = new PointF(65, (Size.Height - size.Height) / 2); break;
                }
                using (var textBrush = new SolidBrush(theme.ForeColor))
                    graphics.DrawString(cell.Text, theme.Font, textBrush, textLocation);
            }
        }

        void Initialize()
        {
            lines.Add(new Line());
            //theme = ThemeManager.GetTheme("Blue");
            AutoScroll = true;
            HScroll = false;
            VScroll = true;
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.SupportsTransparentBackColor |
                     ControlStyles.UserPaint, true);
            Application.Idle += Idle;
        }

        void UpdateCellsProperties(PropertyToEdit property, bool value)
        {
            var line = GetLine(PointToClient(MousePosition));
            if (line == null)
                return;

            var cell = GetCell(PointToClient(MousePosition), line);
            if (cell == null)
                return;

            var index = lines.IndexOf(line);
            switch (property)
            {
                case PropertyToEdit.Clicked:
                    lines[index].Cells[cell].Clicked = value;
                    break;
                case PropertyToEdit.Hovered:
                    lines[index].Cells.ToList().ForEach(c => c.Hovered = !value);
                    lines[index].Cells[cell].Hovered = value;
                    break;
                case PropertyToEdit.Selected:
                    lines[index].Cells.ToList().ForEach(c => c.Selected = !value);
                    lines[index].Cells[cell].Selected = value;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(property), property, null);
            }
            Invalidate();
        }

        #endregion
    }
}
