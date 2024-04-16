using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tp_linq_spotif
{
    public static class Database
    {
        public static List<Music> MusicList { get; set; } = new List<Music>();

        public static List<Music> Search(Genre searchGenre)
        {
            IEnumerable<Music> list = MusicList
                .Where(music => music.Genre == searchGenre)
                .OrderByDescending(music => music.NumberOfStreams);

            return list.ToList();
        }

        public static List<Music> Search(string searchString)
        {
            IEnumerable<Music> list = MusicList
                .Where(music => music.Title.Contains(searchString) && music.Artist.Contains(searchString))
                .OrderByDescending(music => music.NumberOfStreams);

            return list.ToList();
        }
    }
}