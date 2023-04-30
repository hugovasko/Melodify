using System;
using System.Drawing;
using System.Windows.Forms;
using Melodify.Classes;
using Melodify.Properties;

namespace Melodify.Components
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
            _musicCover.Image = Resources.MusicTon;
        }

        public MusicPanel(string path)
        {
            PanelInitialize();

            MusicPath = path;
            _musicTitle.Text = TagFile.GetTitle(path);
            _musicCover.Image = TagFile.GetCover(path).GetThumbnailImage(40, 40, null, IntPtr.Zero);
        }

        private void PanelInitialize()
        {
            Cursor = Cursors.Hand;
            Size = new Size(155, 47);
            Enabled = true;

            _musicTitle.ForeColor = Color.White;
            _musicTitle.Size = new Size(103, 40);
            _musicTitle.Location = new Point(49, 3);
            _musicTitle.TextAlign = ContentAlignment.MiddleLeft;
            _musicTitle.BackColor = Color.Transparent;
            _musicTitle.Enabled = false;
            Controls.Add(_musicTitle);

            _musicCover.Location = new Point(3, 3);
            _musicCover.Size = new Size(40, 40);
            _musicCover.SizeMode = PictureBoxSizeMode.Zoom;
            _musicCover.BackColor = Color.Transparent;
            _musicCover.Enabled = false;
            Controls.Add(_musicCover);
        }

    }
}