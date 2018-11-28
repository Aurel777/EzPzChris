namespace EzpzChris.Web.Uri
{
    using System;

    public static class UriHelper
    {
        public static Uri GetUriFromUrl(string url)
        {
            if(!IsValid(url))
                throw new UriFormatException();

            return new Uri(url);
        }

        public static Uri GetUriFromUrl(string url, UriKind kind)
        {
            if (!IsValid(url, kind))
                throw new UriFormatException();

            return new Uri(url);
        }

        public static bool IsValid(string url, UriKind kind)
        {
            if (string.IsNullOrWhiteSpace(url))
                throw new ArgumentNullException();

            return !Uri.IsWellFormedUriString(url, kind);
        }

        public static bool IsValid(string url)
        {
            if (string.IsNullOrWhiteSpace(url))
                throw new ArgumentNullException();


            return !Uri.IsWellFormedUriString(url, UriKind.Absolute);
        }
    }
}
