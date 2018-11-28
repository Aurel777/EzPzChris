namespace EzpzChris.Forms
{
    #region Using Statements

    using System;
    using System.Collections.Specialized;
    using System.Net;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    using EzpzChris.EzTV;
    using EzpzChris.Web;

    #endregion

    public partial class Login : Form
    {
        #region Private Fields

        bool isConnecting;
        readonly Properties.Settings settings = Properties.Settings.Default;
        NameValueCollection credentialsValues = new NameValueCollection(3);

        #endregion

        #region Constructors

        public Login()
        {
            InitializeComponent();
            Initialize();
        }

        #endregion

        #region Events

        async void ButtonConnect_Click(object sender, EventArgs e)
        {
            if (!isConnecting)
                await ConnectTaskAsync().ConfigureAwait(false);
        }

        void ButtonCancel_Click(object sender, EventArgs e) => Close();

        void ChkShowPassword_CheckedChanged(object sender, EventArgs e) => MaskedTextBoxtPassword.PasswordChar = CheckBoxShowPassword.Checked ? '\0' : '*';

        #endregion

        #region Private Members

        async Task ConnectTaskAsync()
        {
            if(isConnecting)
                return;
            
            isConnecting = true;
            if (!ValidateLogin())
            {
                MessageBox.Show(Constants.LoginUsernameAndPasswordRequired, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                isConnecting = false;
                return;
            }

            if (await LoginTaskAsync(TextBoxUserName.Text, MaskedTextBoxtPassword.Text).ConfigureAwait(true))
                LoadMainForm(TextBoxUserName.Text, MaskedTextBoxtPassword.Text);
            else 
                isConnecting = false;
        }

        //TODO : Find a better way to connect, but registration are closed
        async Task<bool> LoginTaskAsync(string userName, string password)
        {
            var httpUtility = new HttpUtility();
            var postData = EzTvHtmlData.GetPostData(userName, password);
            var postTask = httpUtility.PostRequestTaskAsync(settings.LoginUrl, postData);
            await postTask.ConfigureAwait(true);
            if (postTask.Result.StatusCode != HttpStatusCode.OK)
                return false;

            var loginTask =
                httpUtility.LoginTaskAsync(settings.DomainName, settings.LoginUrl, settings.HomeUrl, postData);
            await loginTask.ConfigureAwait(true);
            return !string.IsNullOrWhiteSpace(loginTask.Result);
            //var html = await HttpUtility.GetSourcePageAfterLoginTaskAsync(settings.LoginUrl, settings.HomeUrl, values).ConfigureAwait(true);
        }
        
        void Initialize()
        {
            if (string.IsNullOrWhiteSpace(settings.UserName) && !string.IsNullOrWhiteSpace(settings.Password))
                return;
            
            credentialsValues = new NameValueCollection(3)
            {
                {Constants.LoginName, settings.UserName},
                {Constants.Password, settings.Password},
                {Constants.Submit, Constants.Login}
            };

            TextBoxUserName.Text = settings.UserName;
            MaskedTextBoxtPassword.Text = settings.Password;
        }

        void LoadMainForm(string eztvUserName, string eztvPassword)
        {
            Hide();
            var mainForm = new EztvChris();
            mainForm.Closed += (s, e) => Close();
            mainForm.Show();
        }
        
        bool ValidateLogin() => !string.IsNullOrWhiteSpace(TextBoxUserName.Text) && !string.IsNullOrWhiteSpace(MaskedTextBoxtPassword.Text);

        #endregion
    }
}
