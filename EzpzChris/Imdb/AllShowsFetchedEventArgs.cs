namespace EzpzChris.Imdb
{
    using System;

    public class AllShowsFetchedEventArgs : EventArgs
    {
        const string MESSAGE = "All shows from IMDB has been fetched.";

        public string Message => MESSAGE;
    }
}
