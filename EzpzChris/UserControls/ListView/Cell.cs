namespace EzpzChris.UserControls.ListView
{
    #region Using Statements

    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    #endregion

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class Cell 
    {
        #region Constructors

        public Cell() { }

        public Cell(int id) // , string Text 
        {
            name =  id.ToString();
            Id = id;
            Size = Size;
        }

        #endregion

        #region Properties

        [Browsable(false)]
        public Rectangle Bounds => new Rectangle(Location, Size);

        [Browsable(false)]

        public bool Clicked { get; set; }

        [Browsable(false)]
        public int Id { get; set; }

        [Browsable(false)]
        public int Height => Size.Height;

        [Browsable(false)]
        public bool Hovered { get; set; }

        [Category("Layout")]
        public Point Location { get; set; } = Point.Empty;

        [Category("Design"), DefaultValue("Cell")]
        public string Name
        {
            get { return name; }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    MessageBox.Show("You must provide a name.");
                    return;
                }
                name = value;
            }
        }

        string name = "Cell";

        [Browsable(false)]
        public bool Selected { get; set; }

        [Category("Layout"), DefaultValue(typeof(Size), "60;38")]
        public Size Size { get; set; } = new Size(60,36);

        [Category("Behavior"), DefaultValue(SortOrder.Ascending)]
        public SortOrder SortOrder { get; set; } = SortOrder.Ascending;

        [Category("Appearance"), DefaultValue("Cell")]
        public string Text { get; set; } = "Cell";

        [Category("Behavior"), DefaultValue(ContentAlignment.MiddleCenter)]
        public ContentAlignment TextAlignment { get; set; } = ContentAlignment.MiddleCenter;

        [Browsable(false)]
        public int Width => Size.Width;

        [Browsable(false)]
        public int X => Location.X;

        [Browsable(false)]
        public int Y => Location.Y;

        [Category("Appearance"), DefaultValue(true)]
        public bool Visible { get; set; } = true;

        #endregion Properties
        
        #region Overridden Members

        public override string ToString() => $"{name} ({Text})";

        #endregion
    }
}
