using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tp_linq_spotif
{
    public class Music
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public Genre Genre { get; set; }
        public int Duration { get; set; }
        public int NumberOfStreams { get; set; }

        public Music(string title, string artist, Genre genre, int duration)
        {
            Title = title;
            Artist = artist;
            Genre = genre;
            Duration = duration;
            NumberOfStreams = 0;
        }

        public Music(string title, string artist, Genre genre, int duration, int initNumberOfStreams)
        {
            Title = title;
            Artist = artist;
            Genre = genre;
            Duration = duration;
            NumberOfStreams = initNumberOfStreams;
        }

        public override string ToString()
        {
            return Title + " - " + Artist;
        }
    }
}