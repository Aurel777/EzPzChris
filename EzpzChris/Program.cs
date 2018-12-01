namespace EzpzChris
{
    #region Using Statements

    using System;
    using System.Windows.Forms;
    using Forms;

    #endregion

    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ShowManagement());
        }
    }
}
