using System;
using System.Drawing;
using System.Windows.Forms;
using Melodify.Classes;

namespace Melodify
{
    internal class MusicPanel : Panel
    {
        private readonly PictureBox _musicCover = new();
        public string MusicPath = "";
        private readonly Label _musicTitle = new();

        public MusicPanel()
        {
            PanelInitialize();

            _musicTitle.Text = @"Music Title";
            _musicCover.Image = Properties.Resources.MusicTon;
        }

        public MusicPanel(string path)
        {
            PanelInitialize();

            this.MusicPath = path;
            _musicTitle.Text = TagFile.GetTitle(path);
            _musicCover.Image = TagFile.GetCover(path).GetThumbnailImage(40, 40, null, IntPtr.Zero);
        }

        private void PanelInitialize()
        {
            this.Cursor = Cursors.Hand;
            this.Size = new Size(155, 47);
            this.Enabled = true;

            _musicTitle.ForeColor = Color.White;
            _musicTitle.Size = new Size(103, 40);
            _musicTitle.Location = new Point(49, 3);
            _musicTitle.TextAlign = ContentAlignment.MiddleLeft;
            _musicTitle.BackColor = Color.Transparent;
            _musicTitle.Enabled = false;
            this.Controls.Add(_musicTitle);

            _musicCover.Location = new Point(3, 3);
            _musicCover.Size = new Size(40, 40);
            _musicCover.SizeMode = PictureBoxSizeMode.Zoom;
            _musicCover.BackColor = Color.Transparent;
            _musicCover.Enabled = false;
            this.Controls.Add(_musicCover);
        }

    }
}