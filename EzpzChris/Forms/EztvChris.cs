namespace EzpzChris.Forms
{
    #region Using Statements

    using System;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    using EzpzChris.Imdb;

    #endregion

    public partial class EztvChris : Form
    {

        #region Constructor

        public EztvChris()
        {
            InitializeComponent();
        }

        #endregion

        #region UI Events

        #region Form

        void EztvChris_Load(object sender, EventArgs e)
        {
            NotifyIcon.BalloonTipTitle = Text;
            NotifyIcon.BalloonTipText = "Application is running in background";
            NotifyIcon.Text = Text;
        }

        void EztvChris_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
                NotifyIcon.ShowBalloonTip(1000);
            }
        }

        #endregion

        #region NotifyIcon

        void ToolStripMenuItemManageShows_Click(object sender, EventArgs e) => new ShowManagement().ShowDialog();

        void ToolStripMenuItemSettings_Click(object sender, EventArgs e) => new Settings().ShowDialog();

        void ToolStripMenuItemExit_Click(object sender, EventArgs e) => Application.Exit();

        void NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        #endregion

        #region MenuStip

        void ConnectToolStripMenuItem_Click(object sender, EventArgs e) => new Login().ShowDialog();

        void ExitToolStripMenuItem_Click(object sender, EventArgs e) => Close();

        void FetchShowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This operation will take a while regardless of you connection.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            FetchShowFromImdb();
        }

        void OptionsToolStripMenuItem_Click(object sender, EventArgs e) => new Settings().ShowDialog();

        void ManageShowsToolStripMenuItem_Click(object sender, EventArgs e) => new ShowManagement().ShowDialog();

        void UpdateShowsToolStripMenuItem_Click(object sender, EventArgs e) => UpdateShowsFromImdb();

        #endregion

        void FetcherOnShowFetched(object sender, ShowFetchedEventArgs e)
        {
            ProgressBarImdbTvShow.Invoke((MethodInvoker)(() => ProgressBarImdbTvShow.Value = e.Count));
            LabelCount.Invoke((MethodInvoker)(() => LabelCount.Text = e.Count.ToString()));
        }

        //TODO : code...
        void ShowAdded(object sender, ShowAddedEventArgs e)
        {
            throw new NotImplementedException();
        }

       

        #endregion

        #region Methods

        void FetchShowFromImdb()
        {
            var fetcher = new ShowFetcher();
            LabelTotal.Text = fetcher.Count.ToString();
            fetcher.ShowFetched += FetcherOnShowFetched;
            ProgressBarImdbTvShow.Maximum = fetcher.Count;
            ProgressBarImdbTvShow.Visible = true;
            Task.Run(() => fetcher.Fetch());
        }

        static void UpdateShowsFromImdb()
        {
            var fetcher = new ShowFetcher();
            var count = 0;
            Task.Run(() => count = fetcher.Update());
            MessageBox.Show($"{count} shows added.");
        }

        #endregion
    }
}
