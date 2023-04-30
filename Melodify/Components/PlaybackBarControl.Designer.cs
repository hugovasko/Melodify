namespace Melodify
{
    partial class PlaybackBarControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ProgressBarPanel = new System.Windows.Forms.Panel();
            this.ChangedProgressPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // ProgressBarPanel
            // 
            this.ProgressBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.ProgressBarPanel.Location = new System.Drawing.Point(1, 5);
            this.ProgressBarPanel.Name = "ProgressBarPanel";
            this.ProgressBarPanel.Size = new System.Drawing.Size(500, 10);
            this.ProgressBarPanel.TabIndex = 0;
            // 
            // ChangedProgressPanel
            // 
            this.ChangedProgressPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ChangedProgressPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangedProgressPanel.Location = new System.Drawing.Point(0, 0);
            this.ChangedProgressPanel.Name = "ChangedProgressPanel";
            this.ChangedProgressPanel.Size = new System.Drawing.Size(10, 20);
            this.ChangedProgressPanel.TabIndex = 1;
            this.ChangedProgressPanel.LocationChanged += new System.EventHandler(this.ChangedProgressPanel_LocationChanged);
            this.ChangedProgressPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ChangedProgressPanel_MouseDown);
            this.ChangedProgressPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChangedProgressPanel_MouseMove);
            this.ChangedProgressPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ChangedProgressPanel_MouseUp);
            // 
            // PlaybackBarControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.ChangedProgressPanel);
            this.Controls.Add(this.ProgressBarPanel);
            this.Name = "PlaybackBarControl";
            this.Size = new System.Drawing.Size(503, 21);
            this.Resize += new System.EventHandler(this.PlaybackBarControl_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ProgressBarPanel;
        public System.Windows.Forms.Panel ChangedProgressPanel;
    }
}
