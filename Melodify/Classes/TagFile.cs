using System;
using System.Drawing;
using System.IO;
using System.Net.Mime;
using System.Windows.Forms;
using Melodify.Properties;
using TagLib;
using File = TagLib.File;

namespace Melodify.Classes
{
    internal class TagFile
    {
        public static string GetTitle(string musicPath)
        {
            using (var title = new Title(musicPath))
            {
                return title.ToString();
            }
        }

        public static string GetArtists(string musicPath)
        {
            using (var artists = new Artists(musicPath))
            {
                return artists.ToString();
            }
        }

        public static string GetAlbum(string musicPath)
        {
            using (var album = new Album(musicPath))
            {
                return album.ToString();
            }
        }

        public static string GetYear(string musicPath)
        {
            using (var year = new Year(musicPath))
            {
                return year.ToString();
            }
        }

        public static string GetTrack(string musicPath)
        {
            using (var track = new Track(musicPath))
            {
                return track.ToString();
            }
        }

        public static string GetTrackCount(string musicPath)
        {
            using (var trackCount = new TrackCount(musicPath))
            {
                return trackCount.ToString();
            }
        }

        public static string GetGenre(string musicPath)
        {
            using (var genres = new Genre(musicPath))
            {
                return genres.ToString();
            }
        }

        public static string GetLyrics(string musicPath)
        {
            using (var lyrics = new Lyrics(musicPath))
            {
                return lyrics.ToString();
            }
        }

        public static Image GetCover(string musicPath)
        {
            try
            {
                var pic = File.Create(musicPath).Tag.Pictures[0]; //pic contains data for image.
                var stream = new MemoryStream(pic.Data.Data); // create an image in memory stream
                return new Bitmap(stream);
            }
            catch
            {
                return Resources.Melodify;
            }
        }


        public static void SetTitle(string musicPath, string title)
        {
            var track = File.Create(musicPath);

            track.Tag.Title = title;
            track.Save();
        }

        public static void SetArtists(string musicPath, string artists)
        {
            var track = File.Create(musicPath);

            track.Tag.AlbumArtists = artists.Split(',');
            track.Save();
        }

        public static void SetAlbum(string musicPath, string album)
        {
            var track = File.Create(musicPath);

            track.Tag.Album = album;
            track.Save();
        }

        public static void SetYear(string musicPath, string year)
        {
            var track = File.Create(musicPath);

            track.Tag.Year = uint.Parse(year);
            track.Save();
        }

        public static void SetTrackN(string musicPath, string trackN)
        {
            var track = File.Create(musicPath);

            track.Tag.Track = uint.Parse(trackN);
            track.Save();
        }

        public static void SetTrackCount(string musicPath, string trackCount)
        {
            var track = File.Create(musicPath);

            track.Tag.TrackCount = uint.Parse(trackCount);
            track.Save();
        }

        public static void SetGenre(string musicPath, string genres)
        {
            var track = File.Create(musicPath);

            track.Tag.Genres = genres.Split(',');
            track.Save();
        }

        public static void SetLyrics(string musicPath, string lyrics)
        {
            var track = File.Create(musicPath);

            track.Tag.Lyrics = lyrics;
            track.Save();
        }

        public static void SetCover(string musicPath, Image picture)
        {
            try
            {
                var track = File.Create(musicPath);

                track.Tag.Pictures = new IPicture[]
                {
                    new Picture(new ByteVector((byte[])new ImageConverter().ConvertTo(picture, typeof(byte[]))))
                    {
                        Type = PictureType.FrontCover,
                        Description = "Cover",
                        MimeType = MediaTypeNames.Image.Jpeg
                    }
                };
                track.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), @"====:TagLib -SetCover- :====");
                MessageBox.Show(ex.GetType().ToString(), @"====:TagLib -SetCover- :====");
            }
        }
    }
}