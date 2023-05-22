using System;
using File = TagLib.File;

namespace Melodify.Classes
{
    public abstract class MusicData : IDisposable
    {
        protected File MusicFile { get; }
        private string Data { get;  set; } = "";
        protected MusicData(string musicPath)
        {
            MusicFile = File.Create(musicPath);
            ExtractData();
        }
        public void Dispose()
        {
            MusicFile?.Dispose();
        }
        public override string ToString()
        {
            return Data;
        }
        protected abstract string GetMusicData();
        public void ExtractData()
        {
            try
            {
                Data = GetMusicData();
            }
            catch
            {
                Data = "Error with fetching the metadata";
            }
        }
    }

    public class Title : MusicData
    {
        public Title(string musicPath) : base(musicPath) {}

        protected override string GetMusicData()
        {
            return !string.IsNullOrEmpty(MusicFile.Tag.Title) ? MusicFile.Tag.Title : "No Title";
        }
    }

    public class Artists : MusicData
    {
        public Artists(string musicPath) : base(musicPath) {}
        
        protected override string GetMusicData()
        {
            string artists = string.Join(",", MusicFile.Tag.AlbumArtists);
            return !string.IsNullOrEmpty(artists) ? artists : "No Artists";
        }
    }

    public class Album : MusicData
    {
        public Album(string musicPath) : base(musicPath) {}

        protected override string GetMusicData()
        {
            return !string.IsNullOrEmpty(MusicFile.Tag.Album) ? MusicFile.Tag.Album : "No Album";
        }
    }

    public class Year : MusicData
    {
        public Year(string musicPath) : base(musicPath) {}

        protected override string GetMusicData()
        {
            return !string.IsNullOrEmpty(MusicFile.Tag.Year.ToString()) ? MusicFile.Tag.Year.ToString() : "0000";
        }
    }

    public class Track : MusicData
    {
        public Track(string musicPath) : base(musicPath) { }

        protected override string GetMusicData()
        {
            var trackNumber = MusicFile.Tag.Track.ToString();
            return trackNumber.Length == 1 ? "0" + trackNumber : trackNumber;
        }
    }

    public class TrackCount : MusicData
    {
        public TrackCount(string musicPath) : base(musicPath) { }

        protected override string GetMusicData()
        {
            return !string.IsNullOrEmpty(MusicFile.Tag.TrackCount.ToString()) ? MusicFile.Tag.TrackCount.ToString() : "0";
        }
    }

    public class Genre : MusicData
    {
        public Genre(string musicPath) : base(musicPath) { }

        protected override string GetMusicData()
        {
            string genres = string.Join(",", MusicFile.Tag.Genres);
            return !string.IsNullOrEmpty(genres) ? genres : "No Genres";
        }
    }

    public class Lyrics : MusicData
    {
        public Lyrics(string musicPath) : base(musicPath) { }

        protected override string GetMusicData()
        {
            return !string.IsNullOrEmpty(MusicFile.Tag.Lyrics) ? MusicFile.Tag.Lyrics : "No Lyrics";
        }
    }

}
