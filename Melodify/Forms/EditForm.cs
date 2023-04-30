using System;
using System.Drawing;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows.Forms;
using Melodify.Classes;
using Newtonsoft.Json;

namespace Melodify.Forms
{
    public partial class EditForm : Form
    {
        private static readonly HttpClient Client = new() { BaseAddress = new Uri("https://api.genius.com") };
        private int _currentPlayingMusicIndex;
        private readonly Size _editFormSize = new(611, 535);
        private readonly Size _searchFormSize = new(438, 535);

        public EditForm()
        {
            InitializeComponent();
        }

        public EditForm(int currentPlayingMusicIndex)
        {
            InitializeComponent();
            this.Size = _editFormSize;

            this._currentPlayingMusicIndex = currentPlayingMusicIndex;

            EditFormInitialise(currentPlayingMusicIndex);
        }

        private void EditForm_Load(object sender, EventArgs e)
        {

        }

        private void EditFormInitialise(int index)
        {
            TextBoxGenre.AutoCompleteCustomSource.AddRange(TagLib.Genres.Audio);

            var trackPath = MainForm.Music[index];
            TextBoxTitle.Text = TagFile.GetTitle(trackPath);
            TextBoxArtists.Text = TagFile.GetArtists(trackPath);
            TextBoxAlbum.Text = TagFile.GetAlbum(trackPath);
            TextBoxTrack.Text = TagFile.GetTrack(trackPath);
            TextBoxTrackCount.Text = TagFile.GetTrackCount(trackPath);
            TextBoxGenre.Text = TagFile.GetGenre(trackPath);
            RichTextBoxLyrics.Text = TagFile.GetLyrics(trackPath);
            PictureBoxCover.Image = TagFile.GetCover(trackPath);
            TextBoxYear.Text = TagFile.GetYear(trackPath);

            this.Text = TextBoxTitle.Text;
        }

        private void ButtonChooseCover_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog
            {
                Multiselect = false,
                Filter = @"Image Files|*.png; *.jpg *.jpeg | All files |*.*"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (ofd.FileName.EndsWith(".png") || ofd.FileName.EndsWith(".jpg") || ofd.FileName.EndsWith(".jpeg"))
                {
                    PictureBoxCover.Image = new Bitmap(ofd.FileName);
                    PictureBoxCover.Tag = "Ok";
                }
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBoxTitle.Tag?.ToString() == "Ok")
                {
                    TagFile.SetTitle(MainForm.Music[_currentPlayingMusicIndex], TextBoxTitle.Text);
                    TextBoxTitle.Tag = "";
                }

                if (TextBoxArtists.Tag?.ToString() == "Ok")
                {
                    TagFile.SetArtists(MainForm.Music[_currentPlayingMusicIndex], TextBoxArtists.Text);
                    TextBoxArtists.Tag = "";
                }

                try
                {
                    if (TextBoxAlbum.Tag?.ToString() == "Ok")
                    {
                        TagFile.SetAlbum(MainForm.Music[_currentPlayingMusicIndex], TextBoxAlbum.Text);
                        TextBoxAlbum.Tag = "";
                    }
                }
                catch (NullReferenceException)
                {
                    //  Add Code later
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString(), @"====:TextBoxAlbum:====");
                    MessageBox.Show(exc.GetType().ToString(), @"====:TextBoxAlbum:====");
                }

                if (TextBoxTrack.Tag?.ToString() == "Ok")
                {
                    TagFile.SetTrackN(MainForm.Music[_currentPlayingMusicIndex], TextBoxTrack.Text);
                    TextBoxTrack.Tag = "";
                }

                if (TextBoxTrackCount.Tag?.ToString() == "Ok")
                {
                    TagFile.SetTrackCount(MainForm.Music[_currentPlayingMusicIndex], TextBoxTrackCount.Text);
                    TextBoxTrackCount.Tag = "";
                }

                if (TextBoxYear.Tag?.ToString() == "Ok")
                {
                    TagFile.SetYear(MainForm.Music[_currentPlayingMusicIndex], TextBoxYear.Text);
                    TextBoxYear.Tag = "";
                }

                if (TextBoxGenre.Tag.ToString() == "Ok")
                {
                    TagFile.SetGenre(MainForm.Music[_currentPlayingMusicIndex], TextBoxGenre.Text);
                    TextBoxGenre.Tag = "";
                }

                try
                {
                    if (PictureBoxCover.Tag.ToString() == "Ok")
                    {
                        TagFile.SetCover(MainForm.Music[_currentPlayingMusicIndex], PictureBoxCover.Image);
                        PictureBoxCover.Tag = "";
                    }
                }
                catch (NullReferenceException)
                {
                    //  Add Code later
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString(), @"====:PictureBoxCover:====");
                    MessageBox.Show(exc.GetType().ToString(), @"====:PictureBoxCover:====");
                }

                TagFile.SetLyrics(MainForm.Music[_currentPlayingMusicIndex], RichTextBoxLyrics.Text);

                MessageBox.Show(@"All Tags Saved");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), @"====:Save:====");
                MessageBox.Show(ex.GetType().ToString(), @"====:Save:====");
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonPrevious_Click(object sender, EventArgs e)
        {
            if (_currentPlayingMusicIndex != 0)
                EditFormInitialise(--_currentPlayingMusicIndex);
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            if (_currentPlayingMusicIndex != MainForm.Music.Count - 1)
                EditFormInitialise(++_currentPlayingMusicIndex);
        }

        private void RadioButtonRTL_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButtonRTL.Checked)
                RichTextBoxLyrics.RightToLeft = RightToLeft.Yes;
        }

        private void RadioButtonLTR_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButtonLTR.Checked)
                RichTextBoxLyrics.RightToLeft = RightToLeft.No;
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            ((TextBox)sender).Tag = "Ok";
        }

        private void ButtonAuto_Click(object sender, EventArgs e)
        {
            SearchTextBox.Text = TextBoxTitle.Text;

            if (TextBoxArtists.Text != "")
                SearchTextBox.Text += @" - " + TextBoxArtists.Text;

            AlertTheFlowLayoutPanelSongs();
        }

        private void AlertTheFlowLayoutPanelSongs()
        {
            EditPanel.Visible = false;
            SearchPanel.Visible = true;
            SearchPanel.Location = new Point(4, 8);
            this.Size = _searchFormSize;

            SearchButton.PerformClick();
        }

        private async void SearchButton_Click(object sender, EventArgs e)
        {
            FlowLayoutPanelSong.Controls.Clear();

            try
            {
                Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "fxjPUENH-tGJthT1vzpZtH4EcdZAOTfj_zIDA1xicETAQXc7xhuBVs1j1sr3yb68");

                var response = await Client.GetAsync("search?q=" + SearchTextBox.Text);
                string value = await response.Content.ReadAsStringAsync();
                dynamic answer = JsonConvert.DeserializeObject(value);

                try
                {
                    for (int i = 0; i < 4;)
                    {
                        if (answer.response.hits[i].type == "song")
                        {
                            int id = answer.response.hits[i].result.id;
                            string url = answer.response.hits[i].result.song_art_image_thumbnail_url;
                            var cover = await GetImageAsync(url);

                            if (cover == null)
                                cover = (Bitmap)new PictureBox().Image;

                            string title = answer.response.hits[i].result.title_with_featured;
                            string artist = answer.response.hits[i].result.primary_artist.name;

                            FlowLayoutPanelSong.Controls.Add(CreateSongCard(id, cover, title, artist));
                            i++;
                        }
                        else
                        {
                            i--;
                        }
                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                    //  Add Code Later
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString(), @"===:Answer Response Hits:===");
                    MessageBox.Show(exc.GetType().ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), @"===:Search Button Click -Answer-:===");
                MessageBox.Show(ex.GetType().ToString());
            }

        }

        private static async Task<Bitmap> GetImageAsync(string url)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    using (var response = await client.GetAsync(url))
                    {
                        using (var responseStream = await response.Content.ReadAsStreamAsync())
                        {
                            return new Bitmap(responseStream);
                        }
                    }
                }
            }
            catch (HttpRequestException httpExc)
            {
                var result = MessageBox.Show(httpExc.Message + "\nWould you like to try Get the image again??", "HTTP Request Exception!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

                if (result == DialogResult.Yes)
                    return await GetImageAsync(url);
                else
                    return null;
            }
            catch (ArgumentException argExc)
            {
                // Add code later
                MessageBox.Show(argExc.ToString(), @"===:GetImage ArgumentException:===");
                return null;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString(), @"===:Get Image:===");
                MessageBox.Show(exc.GetType().ToString());

                return null;
            }
        }


        private Panel CreateSongCard(int id, Image cover, string title, string artist)
        {
            var songContainerPanel = new Panel()
            {
                BackColor = Color.FromArgb(18, 18, 18),
                Size = new Size(194, 194)
            };
            var songCover = new PictureBox()
            {
                Location = new Point(47, 3),
                Size = new Size(100, 100),
                SizeMode = PictureBoxSizeMode.Zoom,
                Image = cover
            };
            var songTitle = new Label()
            {
                Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0),
                Location = new Point(5, 106),
                Size = new Size(185, 38),
                ForeColor = Color.White,
                AutoSize = false,
                TextAlign = ContentAlignment.TopCenter,
                Text = title
            };
            var songArtist = new Label()
            {
                ForeColor = Color.White,
                Location = new Point(23, 153),
                Size = new Size(148, 15),
                TextAlign = ContentAlignment.TopCenter,
                Text = artist,
                AutoSize = false
            };
            var songPanelSeparate = new Panel()
            {
                BackColor = SystemColors.Control,
                Location = new Point(24, 147),
                Size = new Size(146, 2)
            };
            var songThisOneButton = new Button()
            {
                Location = new Point(47, 176),
                Size = new Size(100, 20),
                Text = "This One",
                UseVisualStyleBackColor = true,
                BackColor = Color.FromArgb(64, 64, 64),
                Cursor = Cursors.Hand,
                FlatStyle = FlatStyle.Popup,
                ForeColor = Color.White,
                Tag = id.ToString()
            };
            songThisOneButton.Click += ThisSongCard_Click;

            songContainerPanel.Controls.Add(songCover);
            songContainerPanel.Controls.Add(songTitle);
            songContainerPanel.Controls.Add(songArtist);
            songContainerPanel.Controls.Add(songPanelSeparate);
            songContainerPanel.Controls.Add(songThisOneButton);

            return songContainerPanel;
        }

        private async void ThisSongCard_Click(object sender, EventArgs e)
        {
            var id = ((Button)sender).Tag?.ToString();

            try
            {
                Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "fxjPUENH-tGJthT1vzpZtH4EcdZAOTfj_zIDA1xicETAQXc7xhuBVs1j1sr3yb68");

                var response = await Client.GetAsync("songs/" + id);
                var value = await response.Content.ReadAsStringAsync();
                dynamic answer = JsonConvert.DeserializeObject(value);

                string url = answer.response.song.song_art_image_url;
                var cover = await GetImageAsync(url);
                if (cover != null)
                {
                    PictureBoxCover.Image = cover;
                    PictureBoxCover.Tag = "Ok";
                }

                TextBoxTitle.Text = answer.response.song.title_with_featured;
                TextBoxArtists.Text = answer.response.song.primary_artist.name;

                try
                {
                    TextBoxAlbum.Text = answer.response.song.album.name;
                }
                catch
                {
                    TextBoxAlbum.Text = answer.response.song.album;
                }

                DateTime releaseDate = answer.response.song.release_date;
                TextBoxYear.Text = releaseDate.Year.ToString();

                CancelButton.PerformClick();

                TextBoxTitle.Tag = "Ok";
                TextBoxAlbum.Tag = "Ok";
                TextBoxArtists.Tag = "Ok";
                TextBoxYear.Tag = "Ok";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), @"===:ThisOne:===");
                MessageBox.Show(ex.GetType().ToString());
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            FlowLayoutPanelSong.Controls.Clear();
            SearchTextBox.Text = "";

            EditPanel.Visible = true;
            SearchPanel.Visible = false;
            this.Size = _editFormSize;
        }

        private void EditPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
