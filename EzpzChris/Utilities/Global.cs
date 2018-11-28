namespace EzpzChris.Utilities
{
    // TODO : store cookies, session ID, etc...
    public sealed class SessionManager
    {
        #region Private Fields

        static SessionManager instance;
        static readonly object Padlock = new object();
        static readonly Properties.Settings Settings = Properties.Settings.Default;

        #endregion

        #region Constructor

        public SessionManager() { }

        #endregion
 
        #region Properties

        public static string Password
        {
            get => Settings.Password;
            set => Settings.Password = value;
        }

        public static string UserName
        {
            get => Settings.UserName;
            set => Settings.UserName = value;
        }

        public static string Session { get; set; }

        public static SessionManager Instance
        {
            get
            {
                lock (Padlock)
                {
                    return instance ?? (instance = new SessionManager());
                }
            }
        }

        #endregion
    }
}
