namespace EzpzChris.Forms
{
    #region Using Statements

    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;

    using EzpzChris.Imdb;
    using EzpzChris.Show;
    using EzpzChris.Utilities;

    #endregion

    public partial class NewShow : Form
    {
        #region Private Fields

        const string ERROR = "Please specify the {0}.";
        AutoCompleteStringCollection showNames;
        List<TvShow> shows;
 
        #endregion

        #region Constructors

        public NewShow()
        {
            InitializeComponent();
            LoadImdbTvShow();
        }

        #endregion

        #region Events

        public EventHandler<ShowAddedEventArgs> ShowAdded;

        #endregion

        #region UI Events

        void ButtonAdd_Click(object sender, EventArgs e) => AddShow();

        void ButtonAddAndExit_Click(object sender, EventArgs e)
        {
            AddShow();
            Close();
        }

        void ButtonCancel_Click(object sender, EventArgs e) => Close();

        void EraseTimer_Tick(object sender, EventArgs e)
        {
            LabelInfo.Text = string.Empty;
            EraseTimer.Enabled = false;
        }

        void LinkLabelImdbPage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start(LinkLabelImdbPage.Links[0].LinkData.ToString());

        void TextBoxName_Leave(object sender, EventArgs e) => SetLinkLabel();

        #endregion

        #region Protected Members

        protected virtual void OnShowAdded(ShowAddedEventArgs e)
        {
            var handler = ShowAdded;
            handler?.Invoke(this, e);
        }

        #endregion

        #region Private Members

        void AddShow()
        {
            if (!IsValid())
                return;

            var show = new Show(TextBoxName.Text, TextBoxSeasonNumber.Text, TextBoxEpisodeNumber.Text);
            OnShowAdded(new ShowAddedEventArgs(show));
            LabelInfo.ForeColor = Color.FromArgb(74, 164, 210);
            LabelInfo.Text = $"{show.Name} added.";
        }

        bool IsValid()
        {
            if (string.IsNullOrWhiteSpace(TextBoxName.Text))
            {
                SetError(string.Format(ERROR, "show name"));
                return false;
            }

            if (TextBoxSeasonNumber.Text == 0)
            {
                SetError(string.Format(ERROR, "season number"));
                return false;
            }

            if (TextBoxEpisodeNumber.Text == 0)
            {
                SetError(string.Format(ERROR, "episode number"));
                return false;
            }

            return true;
        }

        void LoadImdbTvShow()
        {
            shows = JsonHelper.LoadShows<TvShow>();
            showNames = new AutoCompleteStringCollection();

            foreach (var show in shows)
                showNames.Add(show.Name);

            TextBoxName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            TextBoxName.AutoCompleteMode = AutoCompleteMode.Suggest;
            TextBoxName.AutoCompleteCustomSource = showNames;
        }

        void SetError(string errorMessage)
        {
            LabelInfo.ForeColor = Color.Red;
            LabelInfo.Text = errorMessage;
            EraseTimer.Enabled = true;
        }

        void SetLinkLabel()
        {
            if(shows == null)
                return;

            var matchingShow = shows.FirstOrDefault(show => show.Name.Trim() == TextBoxName.Text.Trim());
            if (matchingShow != null)
            {
                LinkLabelImdbPage.Visible = true;
                LinkLabelImdbPage.Links.Add(new LinkLabel.Link(0,0, matchingShow.Link));
            }
            else
            {
                LinkLabelImdbPage.Links.Clear();
                LinkLabelImdbPage.Visible = false;
            }
    }


        #endregion
    }

    public class ShowAddedEventArgs : EventArgs
    {
        #region Constructors

        public ShowAddedEventArgs(Show show) => Show = show;

        #endregion

        #region Properties

        public Show Show;

        #endregion
    }
}
