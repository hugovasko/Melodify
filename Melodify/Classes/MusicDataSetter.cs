using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using File = TagLib.File;
using System.Net.Mime;
using TagLib;

namespace Melodify.Classes
{
    public abstract class MusicDataSetter<T> : IDisposable
    {
        protected File MusicFile { get; }

        protected MusicDataSetter(string musicPath)
        {
            MusicFile = File.Create(musicPath);
        }

        public void Dispose()
        {
            MusicFile?.Dispose();
        }

        public abstract void SetMusicData(T data);
    }

    public abstract class StringMusicDataSetter : MusicDataSetter<string>
    {
        protected StringMusicDataSetter(string musicPath) : base(musicPath) { }
    }

    public abstract class ImageMusicDataSetter : MusicDataSetter<Image>
    {
        protected ImageMusicDataSetter(string musicPath) : base(musicPath) { }
    }

    public class TitleSetter : StringMusicDataSetter
    {
        public TitleSetter(string musicPath) : base(musicPath) { }

        public override void SetMusicData(string data)
        {
            MusicFile.Tag.Title = data;
            MusicFile.Save();
        }
    }

    public class ArtistsSetter : StringMusicDataSetter
    {
        public ArtistsSetter(string musicPath) : base(musicPath) { }

        public override void SetMusicData(string data)
        {
            MusicFile.Tag.AlbumArtists = data.Split(',');
            MusicFile.Save();
        }
    }

    public class AlbumSetter : StringMusicDataSetter
    {
        public AlbumSetter(string musicPath) : base(musicPath) { }

        public override void SetMusicData(string data)
        {
            MusicFile.Tag.Album = data;
            MusicFile.Save();
        }
    }

    public class YearSetter : StringMusicDataSetter
    {
        public YearSetter(string musicPath) : base(musicPath) { }

        public override void SetMusicData(string data)
        {
            MusicFile.Tag.Year = uint.Parse(data);
            MusicFile.Save();
        }
    }

    public class TrackSetter : StringMusicDataSetter
    {
        public TrackSetter(string musicPath) : base(musicPath) { }

        public override void SetMusicData(string data)
        {
            MusicFile.Tag.Track = uint.Parse(data);
            MusicFile.Save();
        }
    }

    public class TrackCountSetter : StringMusicDataSetter
    {
        public TrackCountSetter(string musicPath) : base(musicPath) { }

        public override void SetMusicData(string data)
        {
            MusicFile.Tag.TrackCount = uint.Parse(data);
            MusicFile.Save();
        }
    }

    public class GenreSetter : StringMusicDataSetter
    {
        public GenreSetter(string musicPath) : base(musicPath) { }

        public override void SetMusicData(string data)
        {
            MusicFile.Tag.Genres = data.Split(',');
            MusicFile.Save();
        }
    }

    public class LyricsSetter : StringMusicDataSetter
    {
        public LyricsSetter(string musicPath) : base(musicPath) { }

        public override void SetMusicData(string data)
        {
            MusicFile.Tag.Lyrics = data;
            MusicFile.Save();
        }
    }


    public class CoverSetter : ImageMusicDataSetter
    {
        public CoverSetter(string musicPath) : base(musicPath) { }

        public override void SetMusicData(Image data)
        {
            try
            {
                MusicFile.Tag.Pictures = new IPicture[]
                {
                    new Picture(new ByteVector((byte[])new ImageConverter().ConvertTo(data, typeof(byte[]))))
                    {
                        Type = PictureType.FrontCover,
                        Description = "Cover",
                        MimeType = MediaTypeNames.Image.Jpeg
                    }
                };
                MusicFile.Save();
            }
            catch (Exception ex)
            {
                Console.WriteLine($@"Error while setting cover: {ex.Message}");
            }
        }
    }
}
