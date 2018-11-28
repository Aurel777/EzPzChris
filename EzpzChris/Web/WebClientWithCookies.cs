namespace EzpzChris.Web
{
    #region Using Statements

    using System.Net;

    #endregion

    public class WebClientWithCookies : WebClient
    {
        #region Properties

        public CookieContainer CookieContainer { get; }

        #endregion

        #region Constructor

        public WebClientWithCookies() => CookieContainer = new CookieContainer();

        #endregion

        #region Methods

        protected override WebRequest GetWebRequest(System.Uri address)
        {
            var request = base.GetWebRequest(address);
            if (request is HttpWebRequest webRequest)
                webRequest.CookieContainer = CookieContainer;

            return request;
        }

        #endregion
    }
}
