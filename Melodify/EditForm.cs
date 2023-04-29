using Newtonsoft.Json;
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Windows.Forms;
using Melodify.Classes;

namespace Melodify
{
    public partial class EditForm : Form
    {
        private static readonly HttpClient Client = new HttpClient { BaseAddress = new Uri("https://api.genius.com") };
        private int CurrentPlayingMusicIndex;
        private Size EditFormSize = new Size(611, 535);
        private Size SearchFormSize = new Size(438, 535);

        public EditForm()
        {
            InitializeComponent();
        }

        public EditForm(int CurrentPlayingMusicIndex)
        {
            InitializeComponent();
            this.Size = EditFormSize;

            this.CurrentPlayingMusicIndex = CurrentPlayingMusicIndex;

            EditFormInitialise(CurrentPlayingMusicIndex);
        }

        private void EditForm_Load(object sender, EventArgs e)
        {

        }

        private void EditFormInitialise(int Index)
        {
            TextBoxGenre.AutoCompleteCustomSource.AddRange(TagLib.Genres.Audio);

            string TrackPath = MainForm.Music[Index];
            TextBoxTitle.Text = TagFile.GetTitle(TrackPath);
            TextBoxArtists.Text = TagFile.GetArtists(TrackPath);
            TextBoxAlbum.Text = TagFile.GetAlbum(TrackPath);
            TextBoxTrack.Text = TagFile.GetTrack(TrackPath);
            TextBoxTrackCount.Text = TagFile.GetTrackCount(TrackPath);
            TextBoxGenre.Text = TagFile.GetGenre(TrackPath);
            RichTextBoxLyrics.Text = TagFile.GetLyrics(TrackPath);
            PictureBoxCover.Image = TagFile.GetCover(TrackPath);
            TextBoxYear.Text = TagFile.GetYear(TrackPath);

            this.Text = TextBoxTitle.Text;
        }

        private void ButtonChooseCover_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog
            {
                Multiselect = false,
                Filter = "Image Files|*.png; *.jpg *.jpeg | All files |*.*"
            };

            if (OFD.ShowDialog() == DialogResult.OK)
            {
                if (OFD.FileName.EndsWith(".png") || OFD.FileName.EndsWith(".jpg") || OFD.FileName.EndsWith(".jpeg"))
                {
                    PictureBoxCover.Image = new Bitmap(OFD.FileName);
                    PictureBoxCover.Tag = "Ok";
                }
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBoxTitle.Tag.ToString() == "Ok")
                {
                    TagFile.SetTitle(MainForm.Music[CurrentPlayingMusicIndex], TextBoxTitle.Text);
                    TextBoxTitle.Tag = "";
                }

                if (TextBoxArtists.Tag.ToString() == "Ok")
                {
                    TagFile.SetArtists(MainForm.Music[CurrentPlayingMusicIndex], TextBoxArtists.Text);
                    TextBoxArtists.Tag = "";
                }

                try
                {
                    if (TextBoxAlbum.Tag.ToString() == "Ok")
                    {
                        TagFile.SetAlbum(MainForm.Music[CurrentPlayingMusicIndex], TextBoxAlbum.Text);
                        TextBoxAlbum.Tag = "";
                    }
                }
                catch (NullReferenceException)
                {
                    //  Add Code later
                }
                catch (Exception Exc)
                {
                    MessageBox.Show(Exc.ToString(), "====:TextBoxAlbum:====");
                    MessageBox.Show(Exc.GetType().ToString(), "====:TextBoxAlbum:====");
                }

                if (TextBoxTrack.Tag.ToString() == "Ok")
                {
                    TagFile.SetTrackN(MainForm.Music[CurrentPlayingMusicIndex], TextBoxTrack.Text);
                    TextBoxTrack.Tag = "";
                }

                if (TextBoxTrackCount.Tag.ToString() == "Ok")
                {
                    TagFile.SetTrackCount(MainForm.Music[CurrentPlayingMusicIndex], TextBoxTrackCount.Text);
                    TextBoxTrackCount.Tag = "";
                }

                if (TextBoxYear.Tag.ToString() == "Ok")
                {
                    TagFile.SetYear(MainForm.Music[CurrentPlayingMusicIndex], TextBoxYear.Text);
                    TextBoxYear.Tag = "";
                }

                if (TextBoxGenre.Tag.ToString() == "Ok")
                {
                    TagFile.SetGenre(MainForm.Music[CurrentPlayingMusicIndex], TextBoxGenre.Text);
                    TextBoxGenre.Tag = "";
                }

                try
                {
                    if (PictureBoxCover.Tag.ToString() == "Ok")
                    {
                        TagFile.SetCover(MainForm.Music[CurrentPlayingMusicIndex], PictureBoxCover.Image);
                        PictureBoxCover.Tag = "";
                    }
                }
                catch (NullReferenceException)
                {
                    //  Add Code later
                }
                catch (Exception Exc)
                {
                    MessageBox.Show(Exc.ToString(), "====:PictureBoxCover:====");
                    MessageBox.Show(Exc.GetType().ToString(), "====:PictureBoxCover:====");
                }

                TagFile.SetLyrics(MainForm.Music[CurrentPlayingMusicIndex], RichTextBoxLyrics.Text);

                MessageBox.Show("All Tags Saved");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "====:Save:====");
                MessageBox.Show(ex.GetType().ToString(), "====:Save:====");
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonPrevieus_Click(object sender, EventArgs e)
        {
            if (CurrentPlayingMusicIndex != 0)
                EditFormInitialise(--CurrentPlayingMusicIndex);
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            if (CurrentPlayingMusicIndex != MainForm.Music.Count - 1)
                EditFormInitialise(++CurrentPlayingMusicIndex);
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
            (sender as TextBox).Tag = "Ok";
        }

        private void ButtonAuto_Click(object sender, EventArgs e)
        {
            SearchTextBox.Text = TextBoxTitle.Text;

            if (TextBoxArtists.Text != "")
                SearchTextBox.Text += " - " + TextBoxArtists.Text;

            AlertTheFlowLayoutPanelSongs();
        }

        void AlertTheFlowLayoutPanelSongs()
        {
            EditPanel.Visible = false;
            SearchPanel.Visible = true;
            SearchPanel.Location = new Point(4, 8);
            this.Size = SearchFormSize;

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
                dynamic Answer = JsonConvert.DeserializeObject(value);

                try
                {
                    for (int i = 0; i < 4;)
                    {
                        if (Answer.response.hits[i].type == "song")
                        {
                            int id = Answer.response.hits[i].result.id;
                            string url = Answer.response.hits[i].result.song_art_image_thumbnail_url;
                            Bitmap Cover = GetImage(url);

                            if (Cover == null)
                                Cover = (Bitmap)new PictureBox().Image;

                            string Title = Answer.response.hits[i].result.title_with_featured;
                            string Artist = Answer.response.hits[i].result.primary_artist.name;

                            FlowLayoutPanelSong.Controls.Add(CreateSongCard(id, Cover, Title, Artist));
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
                catch (Exception Exc)
                {
                    MessageBox.Show(Exc.ToString(), "===:Answer Response Hits:===");
                    MessageBox.Show(Exc.GetType().ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "===:Search Button Click -Answer-:===");
                MessageBox.Show(ex.GetType().ToString());
            }

        }

        private Bitmap GetImage(string Url)
        {
            try
            {
                WebRequest request = WebRequest.Create(Url);
                Stream responseStream = request.GetResponse().GetResponseStream();
                return new Bitmap(responseStream);
            }
            catch (WebException WebExc)
            {
                DialogResult result = MessageBox.Show(WebExc.Message + "\nWould you like to try Get the image again??", "Web Exception!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

                if (result == DialogResult.Yes)
                    return GetImage(Url);
                else
                    return null;
            }
            catch (ArgumentException AExc)
            {
                //  Add code later
                MessageBox.Show(AExc.ToString(), "===:GetImage ArgumentException:===");
                return null;
            }
            catch (Exception Exc)
            {
                MessageBox.Show(Exc.ToString(), "===:Get Image:===");
                MessageBox.Show(Exc.GetType().ToString());

                return null;
            }
        }

        Panel CreateSongCard(int Id, Bitmap Cover, string Title, string Artist)
        {
            Panel SongContainerPanel = new Panel()
            {
                BackColor = Color.FromArgb(18, 18, 18),
                Size = new Size(194, 194)
            };
            PictureBox SongCover = new PictureBox()
            {
                Location = new Point(47, 3),
                Size = new Size(100, 100),
                SizeMode = PictureBoxSizeMode.Zoom,
                Image = Cover
            };
            Label SongTitle = new Label()
            {
                Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0),
                Location = new Point(5, 106),
                Size = new Size(185, 38),
                ForeColor = Color.White,
                AutoSize = false,
                TextAlign = ContentAlignment.TopCenter,
                Text = Title
            };
            Label SongArtist = new Label()
            {
                ForeColor = Color.White,
                Location = new Point(23, 153),
                Size = new Size(148, 15),
                TextAlign = ContentAlignment.TopCenter,
                Text = Artist,
                AutoSize = false
            };
            Panel SongPanelSepar = new Panel()
            {
                BackColor = SystemColors.Control,
                Location = new Point(24, 147),
                Size = new Size(146, 2)
            };
            Button SongThisOneButton = new Button()
            {
                Location = new Point(47, 176),
                Size = new Size(100, 20),
                Text = "This One",
                UseVisualStyleBackColor = true,
                BackColor = Color.FromArgb(64, 64, 64),
                Cursor = Cursors.Hand,
                FlatStyle = FlatStyle.Popup,
                ForeColor = Color.White,
                Tag = Id.ToString()
            };
            SongThisOneButton.Click += ThisSongCard_Click;

            SongContainerPanel.Controls.Add(SongCover);
            SongContainerPanel.Controls.Add(SongTitle);
            SongContainerPanel.Controls.Add(SongArtist);
            SongContainerPanel.Controls.Add(SongPanelSepar);
            SongContainerPanel.Controls.Add(SongThisOneButton);

            return SongContainerPanel;
        }

        private async void ThisSongCard_Click(object sender, EventArgs e)
        {
            string id = (sender as Button).Tag.ToString();

            try
            {
                Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "fxjPUENH-tGJthT1vzpZtH4EcdZAOTfj_zIDA1xicETAQXc7xhuBVs1j1sr3yb68");

                var response = await Client.GetAsync("songs/" + id);
                var value = await response.Content.ReadAsStringAsync();
                dynamic Answer = JsonConvert.DeserializeObject(value);

                string url = Answer.response.song.song_art_image_url;
                Bitmap Cover = GetImage(url);
                if (Cover != null)
                {
                    PictureBoxCover.Image = Cover;
                    PictureBoxCover.Tag = "Ok";
                }

                TextBoxTitle.Text = Answer.response.song.title_with_featured;
                TextBoxArtists.Text = Answer.response.song.primary_artist.name;

                try
                {
                    TextBoxAlbum.Text = Answer.response.song.album.name;
                }
                catch
                {
                    TextBoxAlbum.Text = Answer.response.song.album;
                }

                DateTime ReleaseDate = Answer.response.song.release_date;
                TextBoxYear.Text = ReleaseDate.Year.ToString();

                CancelButton.PerformClick();

                TextBoxTitle.Tag = "Ok";
                TextBoxAlbum.Tag = "Ok";
                TextBoxArtists.Tag = "Ok";
                TextBoxYear.Tag = "Ok";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "===:ThisOne:===");
                MessageBox.Show(ex.GetType().ToString());
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            FlowLayoutPanelSong.Controls.Clear();
            SearchTextBox.Text = "";

            EditPanel.Visible = true;
            SearchPanel.Visible = false;
            this.Size = EditFormSize;
        }

        private void EditPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
