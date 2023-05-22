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
            using (var title = new TitleGetter(musicPath))
            {
                return title.Data;
            }
        }

        public static string GetArtists(string musicPath)
        {
            using (var artists = new ArtistsGetter(musicPath))
            {
                return artists.Data;
            }
        }

        public static string GetAlbum(string musicPath)
        {
            using (var album = new AlbumGetter(musicPath))
            {
                return album.Data;
            }
        }

        public static string GetYear(string musicPath)
        {
            using (var year = new YearGetter(musicPath))
            {
                return year.Data;
            }
        }

        public static string GetTrack(string musicPath)
        {
            using (var track = new TrackGetter(musicPath))
            {
                return track.Data;
            }
        }

        public static string GetTrackCount(string musicPath)
        {
            using (var trackCount = new TrackCountGetter(musicPath))
            {
                return trackCount.Data;
            }
        }

        public static string GetGenre(string musicPath)
        {
            using (var genres = new GenreGetter(musicPath))
            {
                return genres.Data;
            }
        }

        public static string GetLyrics(string musicPath)
        {
            using (var lyrics = new LyricsGetter(musicPath))
            {
                return lyrics.Data;
            }
        }

        public static Image GetCover(string musicPath)
        {
            using (var cover = new CoverGetter(musicPath))
            {
                return cover.Data;
            }
        }

        public static void SetTitle(string musicPath, string title)
        {
            using (var titleSetter = new TitleSetter(musicPath))
            {
                titleSetter.SetMusicData(title);
            }
        }

        public static void SetArtists(string musicPath, string artists)
        {
            using (var artistsSetter = new ArtistsSetter(musicPath))
            {
                artistsSetter.SetMusicData(artists);
            }
        }

        public static void SetAlbum(string musicPath, string album)
        {
            using (var albumSetter = new AlbumSetter(musicPath))
            {
                albumSetter.SetMusicData(album);
            }
        }

        public static void SetYear(string musicPath, string year)
        {
            using (var yearSetter = new YearSetter(musicPath))
            {
                yearSetter.SetMusicData(year);
            }
        }

        public static void SetTrackN(string musicPath, string trackN)
        {
            using (var trackSetter = new TrackSetter(musicPath))
            {
                trackSetter.SetMusicData(trackN);
            }
        }

        public static void SetTrackCount(string musicPath, string trackCount)
        {
            using (var trackCountSetter = new TrackCountSetter(musicPath))
            {
                trackCountSetter.SetMusicData(trackCount);
            }
        }

        public static void SetGenre(string musicPath, string genres)
        {
            using (var genreSetter = new GenreSetter(musicPath))
            {
                genreSetter.SetMusicData(genres);
            }
        }

        public static void SetLyrics(string musicPath, string lyrics)
        {
            using (var lyricsSetter = new LyricsSetter(musicPath))
            {
                lyricsSetter.SetMusicData(lyrics);
            }
        }

        public static void SetCover(string musicPath, Image cover)
        {
            using (var coverSetter = new CoverSetter(musicPath))
            {
                coverSetter.SetMusicData(cover);
            }
        }
    }
}