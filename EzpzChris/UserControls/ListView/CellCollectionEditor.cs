namespace EzpzChris.UserControls.ListView
{
    #region Using Statements

    using System;
    using System.ComponentModel.Design;

    #endregion

    public class CellCollectionEditor : CollectionEditor
    {
        #region Private Fields

        int index;

        #endregion 

        #region Constructors

        public CellCollectionEditor(Type type) : base(type) { }

        #endregion

        #region Overidden Members

        protected override object CreateInstance(Type itemType)
        {
            if (!(Activator.CreateInstance(itemType, true) is Cell instance))
                return null;

            instance.Name += index.ToString();
            instance.Id = index;
            index++;
            return instance;
        }

        protected override string GetDisplayText(object value)
        {
            if (!(value is Cell cell))
                return base.GetDisplayText(value);

            return $"{base.GetDisplayText(cell.Text)} ({cell})";
        }

        #endregion
    }
}

