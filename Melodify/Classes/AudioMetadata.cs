using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace Melodify.Classes
{
    public class AudioMetadata
    {
        public string Title { get; set; }
        public string Album { get; set; }
        public string[] Artists { get; set; }
        public string Year { get; set; }
        public string Track { get; set; }
        public string TrackCount { get; set; }
        public string Disc { get; set; }
        public string DiscCount { get; set; }
        public string[] Composers { get; set; }
        public string[] Genres { get; set; }
        public string Grouping { get; set; }
        public string Lyrics { get; set; }
        public Image Cover { get; set; }

        // Other properties can be added here as needed

        public AudioMetadata()
        {
            Artists = new string[0];
            Composers = new string[0];
            Genres = new string[0];
        }
    }
}
