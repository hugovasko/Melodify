using System;
using File = TagLib.File;

namespace Melodify.Classes
{
    public abstract class MusicData : IDisposable
    {
        protected File MusicFile { get; }
        private string Data { get;  set; } = "";
        protected MusicData(File file)
        {
            MusicFile = file;
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
        public Title(string musicPath) : base(File.Create(musicPath))
        {
            ExtractData();
        }
        protected override string GetMusicData()
        {
            return !string.IsNullOrEmpty(MusicFile.Tag.Title) ? MusicFile.Tag.Title : "No Title";
        }
    }

    public class Artists : MusicData
    {
        public Artists(string musicPath) : base(File.Create(musicPath))
        {
            ExtractData();
        }
        protected override string GetMusicData()
        {
            string artists = string.Join(",", MusicFile.Tag.AlbumArtists);
            return !string.IsNullOrEmpty(artists) ? artists : "No Artists";
        }
    }

    public class Album : MusicData
    {
        public Album(string musicPath) : base(File.Create(musicPath))
        {
            ExtractData();
        }

        protected override string GetMusicData()
        {
            return !string.IsNullOrEmpty(MusicFile.Tag.Album) ? MusicFile.Tag.Album : "No Album";
        }
    }

    public class Year : MusicData
    {
        public Year(string musicPath) : base(File.Create(musicPath))
        {
            ExtractData();
        }

        protected override string GetMusicData()
        {
            return !string.IsNullOrEmpty(MusicFile.Tag.Year.ToString()) ? MusicFile.Tag.Year.ToString() : "0000";
        }
    }
}
