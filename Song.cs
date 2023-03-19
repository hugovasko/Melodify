using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melodify
{
    public class Song : MusicItem
    {
        public Artist Artist { get; set; }
        public Album Album { get; set; }
        public Genre Genre { get; set; }
        public string FilePath { get; set; }

        public Song(string title, int duration, Artist artist, Album album, Genre genre, string filePath) : base(title, duration)
        {
            Artist = artist;
            Album = album;
            Genre = genre;
            FilePath = filePath;
        }
    }
}
