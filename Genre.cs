using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Melodify
{
    public class Genre
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Song> Songs { get; set; }

        public Genre(string name, string description)
        {
            Name = name;
            Description = description;
            Songs = new List<Song>();
        }

        public void AddSong(Song song)
        {
            Songs.Add(song);
            song.Genre = this;
        }

        public void RemoveSong(Song song)
        {
            Songs.Remove(song);
            song.Genre = null;
        }

        public List<Song> GetSongs()
        {
            return Songs;
        }
    }
}
