using System;
using System.Windows.Forms;
using Melodify.Classes;

namespace Melodify
{
    public partial class LyricsForm : Form
    {
        private readonly string _musicPath;

        public LyricsForm()
        {
            InitializeComponent();
        }

        public LyricsForm(string musicPath)
        {
            InitializeComponent();

            _musicPath = musicPath;
        }

        private void LyricsForm_Load(object sender, EventArgs e)
        {
            RichTextBoxLyrics.Text = TagFile.GetLyrics(_musicPath);
            Text = TagFile.GetArtists(_musicPath) + @" - " + TagFile.GetTitle(_musicPath) + @" :Lyrics:";

            RichTextBoxLyrics.SelectAll();
            RichTextBoxLyrics.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
