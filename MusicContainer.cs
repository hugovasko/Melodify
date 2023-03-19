using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Melodify
{
    public class MusicContainer
    {
        public string Title { get; set; }
        public List<Song> Songs { get; set; }
        internal List<Album> Albums { get; set; }
        public List<Playlist> Playlists { get; set; }

        public MusicContainer(string title)
        {
            this.Title = title;
            this.Songs = new List<Song>();
            this.Albums = new List<Album>();
            this.Playlists = new List<Playlist>();
        }

        public void Add(object item)
        {
            if (item is Song song)
            {
                this.Songs.Add(song);
            }
            else if (item is Album album)
            {
                this.Albums.Add(album);
            }
            else if (item is Playlist playlist)
            {
                this.Playlists.Add(playlist);
            }
            else
            {
                throw new ArgumentException("Invalid music item");
            }
        }

        public void Remove(object item)
        {
            if (item is Song song)
            {
                this.Songs.Remove(song);
            }
            else if (item is Album album)
            {
                this.Albums.Remove(album);
            }
            else if (item is Playlist playlist)
            {
                this.Playlists.Remove(playlist);
            }
            else
            {
                throw new ArgumentException("Invalid music item");
            }
        }

        public int GetTotalDuration()
        {
            int totalDuration = 0;

            // Get total duration of all songs in the container
            foreach (Song song in Songs)
            {
                totalDuration += song.Duration;
            }

            return totalDuration;
        }
    }
}
