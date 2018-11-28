namespace EzpzChris.UserControls
{
    #region Using Statements

    using System.ComponentModel;
    using System.Drawing;
    using System.Security;
    using System.Security.Permissions;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;

    #endregion

    [ToolboxBitmap(typeof(TextBox)),ToolboxItem(true),ToolboxItemFilter("System.Windows.Forms"),Description("NumericTextBox")]
    public class NumericTextBox : TextBox
    {
        #region Constants

        const int WM_PASTE = 0x0302;

        #endregion Constants

        #region Private Fields

        static readonly Regex NumericRegex = new Regex(@"^\d$");

        #endregion

        #region Constructors

        public NumericTextBox() => Size = new Size(100, 23);
        
        #endregion

        #region Properties

        [Description("Get or set a numerical text"), DefaultValue(1)]
        public new int Text
        {
            get => string.IsNullOrWhiteSpace(base.Text) ? 0 : int.Parse(base.Text);
            set
            {
                if (value == 0)
                {
                    base.Text = string.Empty;
                    return;
                }

                base.Text = value.ToString();
            }
        }

        #endregion

        #region Methods

        #region Overriden Methods
        
        [SecurityCritical,EnvironmentPermission(SecurityAction.LinkDemand, Unrestricted = true)]
        protected override void WndProc(ref Message message)
        {
            while (true)
            {
                if (message.Msg == WM_PASTE)
                    continue;

                base.WndProc(ref message);
                break;
            }
        }

        protected override void OnKeyPress(KeyPressEventArgs e) => e.Handled = Validate(e.KeyChar.ToString());

        #endregion

        static bool Validate(string input) => !NumericRegex.IsMatch(input);

        #endregion Methods
    }
}