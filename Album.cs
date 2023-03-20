using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melodify
{
    public class Album : MusicItem
    {
        public Artist Artist { get; set; }
        public Genre Genre { get; set; }
        public int Year { get; set; }
        public List<Song> Songs { get; set; }

        public Album(string title, Artist artist, Genre genre, int year, int duration) : base(title, duration)
        {
            Artist = artist;
            Genre = genre;
            Year = year;
            Songs = new List<Song>();
        }

        public void AddSong(Song song)
        {
            Songs.Add(song);
        }

        public void RemoveSong(Song song)
        {
            Songs.Remove(song);
        }
    }
}
