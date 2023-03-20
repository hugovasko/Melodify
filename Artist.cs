using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melodify
{
    public class Artist
    {
        public string Name { get; set; }
        public List<Album> Albums { get; set; }

        public Artist(string name)
        {
            Name = name;
            Albums = new List<Album>();
        }

        internal void AddAlbum(Album album)
        {
            Albums.Add(album);
            album.Artist = this;
        }

        internal void RemoveAlbum(Album album)
        {
                Albums.Remove(album);
                album.Artist = null;
        }
    }
}
