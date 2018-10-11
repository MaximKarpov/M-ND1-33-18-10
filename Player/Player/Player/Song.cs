﻿namespace Player
{
    public class Song
    {
        public Song(string title = "Unknown", string lirycs = "Unknown", int duration = 0)
        {
            this.Title = title;
            this.Lyrics = lirycs;
            this.Duration = duration;
        }

        public string Title { get; set; }

        public string Lyrics { get; set; }

        public int Duration { get; set; }

        public Artist Artist { get; set; }

        public Album Album { get; set; }
    }
}