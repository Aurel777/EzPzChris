namespace EzpzChris.Imdb
{
    using System;

    public class ShowFetchedEventArgs : EventArgs
    {
        public ShowFetchedEventArgs(int count, string name)
        {
            Count = count;
            Name = name;
        }

        public int Count;

        public string Name;
    }
}
