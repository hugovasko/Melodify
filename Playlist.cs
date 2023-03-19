using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melodify
{
    public class Playlist : MusicItem
    {
        public string Description { get; set; }
        public List<Song> Songs { get; set; }

        public Playlist(string title, int duration) : base(title, duration)
        {
            Songs = new List<Song>();
        }

        public void addSong(Song song)
        {
            Songs.Add(song);
        }

        public void removeSong(Song song)
        {
            Songs.Remove(song);
        }
    }
}
