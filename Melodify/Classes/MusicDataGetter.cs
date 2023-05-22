using Melodify.Properties;
using System;
using System.Drawing;
using System.IO;
using File = TagLib.File;

namespace Melodify.Classes
{
    public abstract class MusicDataGetter<T> : IDisposable
    {
        protected File MusicFile { get; }
        public T Data { get; protected set; }
        protected MusicDataGetter(string musicPath)
        {
            MusicFile = File.Create(musicPath);
            ExtractData();
        }
        public void Dispose()
        {
            MusicFile?.Dispose();
        }
        protected abstract T GetMusicData();
        public void ExtractData()
        {
            try
            {
                Data = GetMusicData();
            }
            catch (Exception ex)
            {
                // Handle error
                Console.WriteLine($@"Error while extracting music data: {ex.Message}");
                Data = default;
            }
        }
    }

    public abstract class StringMusicDataGetter : MusicDataGetter<string>
    {
        protected StringMusicDataGetter(string musicPath) : base(musicPath) {}
    }
    public abstract class ImageMusicDataGetter : MusicDataGetter<Image>
    {
        protected ImageMusicDataGetter(string musicPath) : base(musicPath) { }
    }

    public class TitleGetter : StringMusicDataGetter
    {
        public TitleGetter(string musicPath) : base(musicPath) {}

        protected override string GetMusicData()
        {
            return !string.IsNullOrEmpty(MusicFile.Tag.Title) ? MusicFile.Tag.Title : "No Title";
        }
    }

    public class ArtistsGetter : StringMusicDataGetter
    {
        public ArtistsGetter(string musicPath) : base(musicPath) {}
        
        protected override string GetMusicData()
        {
            string artists = string.Join(",", MusicFile.Tag.AlbumArtists);
            return !string.IsNullOrEmpty(artists) ? artists : "No Artists";
        }
    }

    public class AlbumGetter : StringMusicDataGetter
    {
        public AlbumGetter(string musicPath) : base(musicPath) {}

        protected override string GetMusicData()
        {
            return !string.IsNullOrEmpty(MusicFile.Tag.Album) ? MusicFile.Tag.Album : "No Album";
        }
    }

    public class YearGetter : StringMusicDataGetter
    {
        public YearGetter(string musicPath) : base(musicPath) {}

        protected override string GetMusicData()
        {
            return !string.IsNullOrEmpty(MusicFile.Tag.Year.ToString()) ? MusicFile.Tag.Year.ToString() : "0000";
        }
    }

    public class TrackGetter : StringMusicDataGetter
    {
        public TrackGetter(string musicPath) : base(musicPath) { }

        protected override string GetMusicData()
        {
            var trackNumber = MusicFile.Tag.Track.ToString();
            return trackNumber.Length == 1 ? "0" + trackNumber : trackNumber;
        }
    }

    public class TrackCountGetter : StringMusicDataGetter
    {
        public TrackCountGetter(string musicPath) : base(musicPath) { }

        protected override string GetMusicData()
        {
            return !string.IsNullOrEmpty(MusicFile.Tag.TrackCount.ToString()) ? MusicFile.Tag.TrackCount.ToString() : "0";
        }
    }

    public class GenreGetter : StringMusicDataGetter
    {
        public GenreGetter(string musicPath) : base(musicPath) { }

        protected override string GetMusicData()
        {
            string genres = string.Join(",", MusicFile.Tag.Genres);
            return !string.IsNullOrEmpty(genres) ? genres : "No Genres";
        }
    }

    public class LyricsGetter : StringMusicDataGetter
    {
        public LyricsGetter(string musicPath) : base(musicPath) { }

        protected override string GetMusicData()
        {
            return !string.IsNullOrEmpty(MusicFile.Tag.Lyrics) ? MusicFile.Tag.Lyrics : "No Lyrics";
        }
    }

    public class CoverGetter : ImageMusicDataGetter
    {
        public CoverGetter(string musicPath) : base(musicPath) { }

        protected override Image GetMusicData()
        {
            try
            {
                var pic = MusicFile.Tag.Pictures[0]; //pic contains data for image.
                var stream = new MemoryStream(pic.Data.Data); // create an image in memory stream
                return new Bitmap(stream);
            }
            catch
            {
                return Resources.Melodify;
            }
        }
    }

}
