using System;
using System.Drawing;
using System.Windows.Forms;
using Melodify.Classes;

namespace Melodify
{
    class MusicPanel : Panel
    {
        private readonly PictureBox MusicCover = new PictureBox();
        public string MusicPath = "";
        private readonly Label MusicTitle = new Label();

        public MusicPanel()
        {
            PanelInisialize();

            MusicTitle.Text = "Music Title";
            MusicCover.Image = Properties.Resources.MusicTon;
        }

        public MusicPanel(string path)
        {
            PanelInisialize();

            this.MusicPath = path;
            MusicTitle.Text = TagFile.GetTitle(path);
            MusicCover.Image = TagFile.GetCover(path).GetThumbnailImage(40, 40, null, IntPtr.Zero);
        }

        void PanelInisialize()
        {
            this.Cursor = Cursors.Hand;
            this.Size = new Size(155, 47);
            this.Enabled = true;

            MusicTitle.ForeColor = Color.White;
            MusicTitle.Size = new Size(103, 40);
            MusicTitle.Location = new Point(49, 3);
            MusicTitle.TextAlign = ContentAlignment.MiddleLeft;
            MusicTitle.BackColor = Color.Transparent;
            MusicTitle.Enabled = false;
            this.Controls.Add(MusicTitle);

            MusicCover.Location = new Point(3, 3);
            MusicCover.Size = new Size(40, 40);
            MusicCover.SizeMode = PictureBoxSizeMode.Zoom;
            MusicCover.BackColor = Color.Transparent;
            MusicCover.Enabled = false;
            this.Controls.Add(MusicCover);
        }

    }
}