using System;
using System.Drawing;
using System.Windows.Forms;

namespace Melodify.Components
{
    public partial class PlaybackBarControl : UserControl
    {
        private Point _mousePosition;
        private int _val;
        public bool IsMouseDown;

        public PlaybackBarControl()
        {
            InitializeComponent();

            _val = 0;

            ConfigPlaybackBarControlColor();
        }

        public int Max { get; set; } = 100;

        public int Val
        {
            get => _val;
            set
            {
                if (value >= 0 && value < Max)
                {
                    _val = value;

                    if (Max != 0)
                    {
                        ChangedProgressPanel.Left = value * ProgressBarPanel.Width / Max;
                    }
                }
            }
        }

        private void ChangedProgressPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                IsMouseDown = true;
                _mousePosition = new Point(e.X, e.Y);
            }
        }

        private void ChangedProgressPanel_MouseUp(object sender, MouseEventArgs e)
        {
            IsMouseDown = false;
        }

        private void ChangedProgressPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDown)
            {
                var newPosition = new Point(ChangedProgressPanel.Left + (e.X - _mousePosition.X),
                    ChangedProgressPanel.Top);

                if (newPosition.X >= ProgressBarPanel.Location.X &&
                    newPosition.X <= ProgressBarPanel.Width - ChangedProgressPanel.Width)
                {
                    ChangedProgressPanel.Location = newPosition;
                }
            }
        }

        private void PlaybackBarControl_Resize(object sender, EventArgs e)
        {
            ChangedProgressPanel.Height = Height;
            ProgressBarPanel.Width = Width;
            ConfigPlaybackBarControlColor();
        }

        private void ChangedProgressPanel_LocationChanged(object sender, EventArgs e)
        {
            if (ProgressBarPanel.Width != 0)
            {
                _val = ChangedProgressPanel.Location.X * Max / ProgressBarPanel.Width;
                ConfigPlaybackBarControlColor();
            }
        }

        private void ConfigPlaybackBarControlColor()
        {
            ProgressBarPanel.CreateGraphics().Clear(ProgressBarPanel.BackColor);
            ProgressBarPanel.CreateGraphics().FillRectangle(Brushes.DarkSlateGray,
                new Rectangle(0, 0, ChangedProgressPanel.Left, ProgressBarPanel.Height));
        }
    }
}