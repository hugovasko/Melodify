using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melodify
{
    public class Playlist : IMusicItem
    {
        public string Title { get; set; }
        public int Duration { get; set; }
        public string Description { get; set; }
        public List<Song> Songs { get; set; }

        public Playlist(string title, int duration)
        {
            Title = title;
            Duration = duration;
            Songs = new List<Song>();
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
