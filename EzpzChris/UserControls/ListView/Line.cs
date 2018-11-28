namespace EzpzChris.UserControls.ListView
{
    #region Using Statements

    using System.ComponentModel;
    using System.Drawing;
    using System.Drawing.Design;

    #endregion

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public sealed class Line 
    {
        #region Private Fields

        CellCollection cells;

        #endregion

        #region Constructors

        public Line() { } 

        public Line(int id, int y, Size size, int numberOfCells)
        {
            cells = new CellCollection(this);
            Id = id;
            Location = new Point(0, y);
            Name = id.ToString();
            Size = size;
            for(var i = 0; i < numberOfCells; i++)
                cells.Add(new Cell(i));
        }

        #endregion

        #region Properties

        public Rectangle Bounds => new Rectangle(Location, Size);

        [Editor(typeof(CellCollectionEditor), typeof(UITypeEditor)),DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public CellCollection Cells => cells ?? (cells = new CellCollection(this)); 
        
        [Browsable(false)]
        public int Height => Size.Height;

        [Browsable(false), DefaultValue(0)]
        public int Id { get; set; }

        [Browsable(false), ReadOnly(true)]
        public Point Location { get; set; } = Point.Empty;

        [Category("Design"), DefaultValue("Line")]
        public string Name { get; set; } = "Line";

        [Browsable(false)]
        public Size Size { get; set; } = new Size(60, 36);

        [Browsable(false)]
        public int Width => Size.Width;

        #endregion

        #region Overriden Members

        public override string ToString() =>  cells.Count == 0 ? "No cell" : cells.Count + " cells";
        
        #endregion
    }
}