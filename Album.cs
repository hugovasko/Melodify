using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melodify
{
    public class Album : IMusicItem
    {
        public string Title { get; set; }
        public int Duration { get; set; }
        public Artist Artist { get; set; }
        public Genre Genre { get; set; }
        public int Year { get; set; }
        public List<Song> Songs { get; set; }

        public Album(string title, Artist artist, Genre genre, int year, int duration)
        {
            Title = title;
            Duration = duration;
            Songs = new List<Song>();
            Artist = artist;
            Genre = genre;
            Year = year;
        }

        public void AddSong(Song song)
        {
            Songs.Add(song);
            Duration += song.Duration;
        }

        public void RemoveSong(Song song)
        {
            Songs.Remove(song);
            Duration -= song.Duration;
        }
    }
}
