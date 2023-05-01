using System;
using System.Drawing;
using System.Windows.Forms;
using Melodify.Classes;
using TagLib;
using TextBox = System.Windows.Forms.TextBox;

namespace Melodify.Forms
{
    public partial class EditForm : Form
    {
        private readonly Size _editFormSize = new(611, 535);
        private int _currentPlayingMusicIndex;

        public EditForm()
        {
            InitializeComponent();
        }

        public EditForm(int currentPlayingMusicIndex)
        {
            InitializeComponent();
            Size = _editFormSize;

            _currentPlayingMusicIndex = currentPlayingMusicIndex;

            EditFormInitialise(currentPlayingMusicIndex);
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
        }

        private void EditFormInitialise(int index)
        {
            TextBoxGenre.AutoCompleteCustomSource.AddRange(Genres.Audio);

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

            Text = TextBoxTitle.Text;
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

                if (TextBoxGenre.Tag?.ToString() == "Ok")
                {
                    TagFile.SetGenre(MainForm.Music[_currentPlayingMusicIndex], TextBoxGenre.Text);
                    TextBoxGenre.Tag = "";
                }

                try
                {
                    if (PictureBoxCover.Tag?.ToString() == "Ok")
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
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), @"====:Save:====");
                MessageBox.Show(ex.GetType().ToString(), @"====:Save:====");
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonPrevious_Click(object sender, EventArgs e)
        {
            if (_currentPlayingMusicIndex != 0)
            {
                EditFormInitialise(--_currentPlayingMusicIndex);
            }
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            if (_currentPlayingMusicIndex != MainForm.Music.Count - 1)
            {
                EditFormInitialise(++_currentPlayingMusicIndex);
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            ((TextBox)sender).Tag = "Ok";
        }

        private void EditPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void RichTextBoxLyrics_TextChanged(object sender, EventArgs e)
        {
        }
    }
}