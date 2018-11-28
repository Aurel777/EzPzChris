namespace EzpzChris.Themes
{
    #region Using Statements

    using System.ComponentModel;

    #endregion

    public class ThemeConverter : StringConverter
    {
        #region Overriden Members

        public override bool GetStandardValuesSupported(ITypeDescriptorContext context) => true; 

        public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) => true;

        public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) => 
            new StandardValuesCollection(ThemeManager.Themes);

        #endregion
    }
}
