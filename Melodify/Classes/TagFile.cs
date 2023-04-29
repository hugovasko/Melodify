using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Melodify.Classes
{
    class TagFile
    {
        public static string GetTitle(string MusicPath)
        {
            try
            {
                return TagLib.File.Create(MusicPath).Tag.Title;
            }
            catch
            {
                return "";
            }
        }

        public static string GetArtists(string MusicPath)
        {
            try
            {
                return string.Join(",", TagLib.File.Create(MusicPath).Tag.AlbumArtists);
            }
            catch
            {
                return "";
            }
        }

        public static string GetAlbum(string MusicPath)
        {
            try
            {
                return TagLib.File.Create(MusicPath).Tag.Album;
            }
            catch
            {
                return "";
            }
        }

        public static string GetYear(string MusicPath)
        {
            try
            {
                return TagLib.File.Create(MusicPath).Tag.Year.ToString();
            }
            catch
            {
                return "";
            }
        }

        public static string GetTrack(string MusicPath)
        {
            try
            {
                if (TagLib.File.Create(MusicPath).Tag.Track.ToString().Length == 1)
                    return ("0" + TagLib.File.Create(MusicPath).Tag.Track.ToString());
                else
                    return TagLib.File.Create(MusicPath).Tag.Track.ToString();
            }
            catch
            {
                return "";
            }
        }

        public static string GetTrackCount(string MusicPath)
        {
            try
            {
                return TagLib.File.Create(MusicPath).Tag.TrackCount.ToString();
            }
            catch
            {
                return "";
            }
        }

        public static string GetDisc(string MusicPath)
        {
            return TagLib.File.Create(MusicPath).Tag.Disc.ToString();
        }

        public static string GetDiscCount(string MusicPath)
        {
            return TagLib.File.Create(MusicPath).Tag.DiscCount.ToString();
        }

        public static string GetComposers(string MusicPath)
        {
            return string.Join(",", TagLib.File.Create(MusicPath).Tag.Composers);
        }

        public static string GetGenre(string MusicPath)
        {
            try
            {
                return string.Join(",", TagLib.File.Create(MusicPath).Tag.Genres);
            }
            catch
            {
                return "";
            }
        }

        public static string GetGrouping(string MusicPath)
        {
            return TagLib.File.Create(MusicPath).Tag.Grouping;
        }

        public static string GetLyrics(string MusicPath)
        {
            try
            {
                return TagLib.File.Create(MusicPath).Tag.Lyrics;
            }
            catch
            {
                return "";
            }
        }

        public static Image GetCover(string MusicPath)
        {
            try
            {
                TagLib.IPicture pic = TagLib.File.Create(MusicPath).Tag.Pictures[0];  //pic contains data for image.
                MemoryStream stream = new MemoryStream(pic.Data.Data);  // create an image in memory stream
                return new Bitmap(stream);
            }
            catch
            {
                return Properties.Resources.MusicTon;
            }
        }


        public static void SetTitle(string MusicPath, string Title)
        {
            try
            {
                var Track = TagLib.File.Create(MusicPath);

                Track.Tag.Title = Title;
                Track.Save();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void SetArtists(string MusicPath, string Artists)
        {
            try
            {
                var Track = TagLib.File.Create(MusicPath);

                Track.Tag.AlbumArtists = Artists.Split(',');
                Track.Save();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void SetAlbum(string MusicPath, string Album)
        {
            try
            {
                var Track = TagLib.File.Create(MusicPath);

                Track.Tag.Album = Album;
                Track.Save();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void SetYear(string MusicPath, string Year)
        {
            try
            {
                var Track = TagLib.File.Create(MusicPath);

                Track.Tag.Year = uint.Parse(Year);
                Track.Save();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void SetTrackN(string MusicPath, string TrackN)
        {
            try
            {
                var Track = TagLib.File.Create(MusicPath);

                Track.Tag.Track = uint.Parse(TrackN);
                Track.Save();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void SetTrackCount(string MusicPath, string TrackCount)
        {
            try
            {
                var Track = TagLib.File.Create(MusicPath);

                Track.Tag.TrackCount = uint.Parse(TrackCount);
                Track.Save();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void SetDisc(string MusicPath, string Disc)
        {
            try
            {
                var Track = TagLib.File.Create(MusicPath);

                Track.Tag.Disc = uint.Parse(Disc);
                Track.Save();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void SetDiscCount(string MusicPath, string DiscCount)
        {
            try
            {
                var Track = TagLib.File.Create(MusicPath);

                Track.Tag.DiscCount = uint.Parse(DiscCount);
                Track.Save();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void SetComposers(string MusicPath, string Composers)
        {
            try
            {
                var Track = TagLib.File.Create(MusicPath);

                Track.Tag.Composers = Composers.Split(',');
                Track.Save();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void SetGenre(string MusicPath, string Genres)
        {
            try
            {
                var Track = TagLib.File.Create(MusicPath);

                Track.Tag.Genres = Genres.Split(',');
                Track.Save();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void SetGrouping(string MusicPath, string Grouping)
        {
            try
            {
                var Track = TagLib.File.Create(MusicPath);

                Track.Tag.Grouping = Grouping;
                Track.Save();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void SetLyrics(string MusicPath, string Lyrics)
        {
            try
            {
                var Track = TagLib.File.Create(MusicPath);

                Track.Tag.Lyrics = Lyrics;
                Track.Save();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void SetCover(string MusicPath, Image Picture)
        {
            try
            {
                var Track = TagLib.File.Create(MusicPath);

                Track.Tag.Pictures = new TagLib.IPicture[]
                {
                new TagLib.Picture(new TagLib.ByteVector((byte[])new ImageConverter().ConvertTo(Picture, typeof(byte[]))))
                {
                    Type = TagLib.PictureType.FrontCover,
                    Description = "Cover",
                    MimeType = System.Net.Mime.MediaTypeNames.Image.Jpeg
                }
                };
                Track.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "====:TagLib -SetCover- :====");
                MessageBox.Show(ex.GetType().ToString(), "====:TagLib -SetCover- :====");
            }
        }

    }
}