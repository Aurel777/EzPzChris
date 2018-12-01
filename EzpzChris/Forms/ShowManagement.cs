namespace EzpzChris.Forms
{
    #region Using Statements

    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using Show;
    using Utilities;

    #endregion

    public partial class ShowManagement : Form
    {
        #region Private Fields

        List<Show> shows;
        Show selectedShow;

        #endregion

        #region Constructors

        public ShowManagement()
        {
            InitializeComponent();
            LoadFile();
        }

        #endregion

        #region UI Events

        void ButtonAdd_Click(object sender, EventArgs e)
        {
            var newShow = new NewShow();
            newShow.ShowAdded += ShowAdded;
            newShow.FormClosing += (o, args) => newShow.ShowAdded -= ShowAdded; 
            newShow.ShowDialog();
        }
        
        void ButtonDelete_Click(object sender, EventArgs e)
        {

        }

        void ButtonEdit_Click(object sender, EventArgs e)
        {

        }

        void ButtonCancel_Click(object sender, EventArgs e) => Close();

        void ButtonOK_Click(object sender, EventArgs e)
        {
            SaveFile();
            Close();
        }

        void ShowAdded(object sender, ShowAddedEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Methods

        #region Load / Save Json

        void LoadFile()
        {
            shows = JsonHelper.LoadShows<Show>();

            //foreach (var show in shows)
            //    LvShow.Items.Add(show.Name);
        }

        void SaveFile() => JsonHelper.SaveShows(shows);
        
        #endregion

        #endregion
    }
}
