namespace EzpzChris.EzTV
{
    #region Using Statements

    using System;

    #endregion

    public static class EzTvHtmlData
    {
        public static string GetPostData(string userName, string password)
        {
            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(password))
                throw new ArgumentNullException();

            return $"{Constants.LoginName}=&{userName}&{Constants.Password}={password}&{Constants.Submit}={Constants.Login}";
        }
    }
}
