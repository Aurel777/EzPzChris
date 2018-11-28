namespace EzpzChris.Show
{
    using System;

    public class NextEpisodeEventArgs : EventArgs
    {
        public NextEpisodeEventArgs(int episodeNumber) => EpisodeNumber = episodeNumber;

        public int EpisodeNumber { get; protected set; }
    }
}