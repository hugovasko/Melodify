using System;
using System.Windows.Forms;
using Melodify.Classes;

namespace Melodify
{
    public partial class LyricsForm : Form
    {
        private string MusicPath;

        public LyricsForm()
        {
            InitializeComponent();
        }

        public LyricsForm(string MusicPath)
        {
            InitializeComponent();

            this.MusicPath = MusicPath;
        }

        private void LyricsForm_Load(object sender, EventArgs e)
        {
            RichTextBoxLyrics.Text = TagFile.GetLyrics(MusicPath);
            this.Text = TagFile.GetArtists(MusicPath) + " - " + TagFile.GetTitle(MusicPath) + " :Lyrics:";

            RichTextBoxLyrics.SelectAll();
            RichTextBoxLyrics.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
