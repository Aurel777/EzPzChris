namespace EzpzChris.UserControls.ListView
{
    #region Using Statements

    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;

    #endregion

    public class CellCollection : CollectionBase
    {
        #region Events

        public event EventHandler CollectionChanged;

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
            OnCollectionChanged(EventArgs.Empty);
        }

        public void AddRange(Cell[] cells)
        {
            InnerList.AddRange(cells);
            OnCollectionChanged(EventArgs.Empty);
        } 

        public bool Contains(Cell cell) => InnerList.Contains(cell);

        public int IndexOf(Cell cell) => InnerList.IndexOf(cell);

        public void Remove(Cell cell)
        {
            InnerList.Remove(cell);
            OnCollectionChanged(EventArgs.Empty);
        }

        IEnumerable<Cell> ToArray()
        {
            var cell = new Cell[InnerList.Count];
            InnerList.CopyTo(0, cell, 0, InnerList.Count);
            return cell;
        }

        internal List<Cell> ToList() => ToArray().ToList();
        
        #endregion

        #region Protected Members

        protected virtual void OnCollectionChanged(EventArgs e)
        {
            var eventHandler = CollectionChanged;
            eventHandler?.Invoke(this, e);
        }

        #endregion
    }
}
