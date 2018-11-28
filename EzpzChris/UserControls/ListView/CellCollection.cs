namespace EzpzChris.UserControls.ListView
{
    #region Using Statements

    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;

    #endregion

    public class CellCollection : CollectionBase, INotifyPropertyChanged
    {
        #region Events

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Consutrctors

        public CellCollection(Line owner) => Owner = owner;
        
        #endregion
        
        #region Properties

        public Cell this[Cell cell] => this[IndexOf(cell)];

        public Cell this[int index] => (Cell)InnerList[index];

        public Line Owner { get; }
        
        #endregion

        #region Public Members

        public void Add(Cell cell)
        {
            InnerList.Add(cell);
            OnPropertyChanged(new PropertyChangedEventArgs($"{cell.Name} added."));
        }

        public void AddRange(Cell[] cells)
        {
            InnerList.AddRange(cells);
            OnPropertyChanged(new PropertyChangedEventArgs($"{cells.Length} cells added."));
        } 

        public bool Contains(Cell cell) => InnerList.Contains(cell);

        public int IndexOf(Cell cell) => InnerList.IndexOf(cell);

        public void Remove(Cell cell)
        {
            InnerList.Remove(cell);
            OnPropertyChanged(new PropertyChangedEventArgs($"{cell.Name} removed."));
        } 

        public Cell[] ToArray()
        {
            var cell = new Cell[InnerList.Count];
            InnerList.CopyTo(0, cell, 0, InnerList.Count);
            return cell;
        }

        public List<Cell> ToList() => ToArray().ToList();
        
        #endregion

        #region Protected Members

        protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            var eventHandler = PropertyChanged;
            eventHandler?.Invoke(this, e);
        }

        #endregion
    }
}
