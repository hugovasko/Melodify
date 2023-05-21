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
            return new Title(musicPath).ToString();
        }

        public static string GetArtists(string musicPath)
        {
            return new Artists(musicPath).ToString();
        }

        public static string GetAlbum(string musicPath)
        {
            try
            {
                return File.Create(musicPath).Tag.Album;
            }
            catch
            {
                return "";
            }
        }

        public static string GetYear(string musicPath)
        {
            try
            {
                return File.Create(musicPath).Tag.Year.ToString();
            }
            catch
            {
                return "";
            }
        }

        public static string GetTrack(string musicPath)
        {
            try
            {
                if (File.Create(musicPath).Tag.Track.ToString().Length == 1)
                {
                    return "0" + File.Create(musicPath).Tag.Track;
                }

                return File.Create(musicPath).Tag.Track.ToString();
            }
            catch
            {
                return "";
            }
        }

        public static string GetTrackCount(string musicPath)
        {
            try
            {
                return File.Create(musicPath).Tag.TrackCount.ToString();
            }
            catch
            {
                return "";
            }
        }

        public static string GetDisc(string musicPath)
        {
            return File.Create(musicPath).Tag.Disc.ToString();
        }

        public static string GetDiscCount(string musicPath)
        {
            return File.Create(musicPath).Tag.DiscCount.ToString();
        }

        public static string GetComposers(string musicPath)
        {
            return string.Join(",", File.Create(musicPath).Tag.Composers);
        }

        public static string GetGenre(string musicPath)
        {
            try
            {
                return string.Join(",", File.Create(musicPath).Tag.Genres);
            }
            catch
            {
                return "";
            }
        }

        public static string GetGrouping(string musicPath)
        {
            return File.Create(musicPath).Tag.Grouping;
        }

        public static string GetLyrics(string musicPath)
        {
            try
            {
                return File.Create(musicPath).Tag.Lyrics;
            }
            catch
            {
                return "";
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

        public static void SetDisc(string musicPath, string disc)
        {
            var track = File.Create(musicPath);

            track.Tag.Disc = uint.Parse(disc);
            track.Save();
        }

        public static void SetDiscCount(string musicPath, string discCount)
        {
            var track = File.Create(musicPath);

            track.Tag.DiscCount = uint.Parse(discCount);
            track.Save();
        }

        public static void SetComposers(string musicPath, string composers)
        {
            var track = File.Create(musicPath);

            track.Tag.Composers = composers.Split(',');
            track.Save();
        }

        public static void SetGenre(string musicPath, string genres)
        {
            var track = File.Create(musicPath);

            track.Tag.Genres = genres.Split(',');
            track.Save();
        }

        public static void SetGrouping(string musicPath, string grouping)
        {
            var track = File.Create(musicPath);

            track.Tag.Grouping = grouping;
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