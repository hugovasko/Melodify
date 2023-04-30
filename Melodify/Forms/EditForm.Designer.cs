namespace Melodify.Forms
{
    partial class EditForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            EditPanel = new System.Windows.Forms.Panel();
            hr = new System.Windows.Forms.Panel();
            ButtonPrevious = new System.Windows.Forms.Button();
            ButtonNext = new System.Windows.Forms.Button();
            ButtonClose = new System.Windows.Forms.Button();
            ButtonSave = new System.Windows.Forms.Button();
            RichTextBoxLyrics = new System.Windows.Forms.RichTextBox();
            TextBoxTrackCount = new System.Windows.Forms.TextBox();
            LabelTrackOf = new System.Windows.Forms.Label();
            LabelLyrics = new System.Windows.Forms.Label();
            TextBoxGenre = new System.Windows.Forms.TextBox();
            LabelGenre = new System.Windows.Forms.Label();
            TextBoxTrack = new System.Windows.Forms.TextBox();
            LabelTrack = new System.Windows.Forms.Label();
            TextBoxYear = new System.Windows.Forms.TextBox();
            LabelYear = new System.Windows.Forms.Label();
            TextBoxAlbum = new System.Windows.Forms.TextBox();
            LabelAlbum = new System.Windows.Forms.Label();
            TextBoxArtists = new System.Windows.Forms.TextBox();
            LabelArtists = new System.Windows.Forms.Label();
            TextBoxTitle = new System.Windows.Forms.TextBox();
            LabelTitle = new System.Windows.Forms.Label();
            ButtonChooseCover = new System.Windows.Forms.Button();
            PictureBoxCover = new System.Windows.Forms.PictureBox();
            FlowLayoutPanelSong = new System.Windows.Forms.FlowLayoutPanel();
            EditPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBoxCover).BeginInit();
            SuspendLayout();
            // 
            // EditPanel
            // 
            EditPanel.Controls.Add(hr);
            EditPanel.Controls.Add(ButtonPrevious);
            EditPanel.Controls.Add(ButtonNext);
            EditPanel.Controls.Add(ButtonClose);
            EditPanel.Controls.Add(ButtonSave);
            EditPanel.Controls.Add(RichTextBoxLyrics);
            EditPanel.Controls.Add(TextBoxTrackCount);
            EditPanel.Controls.Add(LabelTrackOf);
            EditPanel.Controls.Add(LabelLyrics);
            EditPanel.Controls.Add(TextBoxGenre);
            EditPanel.Controls.Add(LabelGenre);
            EditPanel.Controls.Add(TextBoxTrack);
            EditPanel.Controls.Add(LabelTrack);
            EditPanel.Controls.Add(TextBoxYear);
            EditPanel.Controls.Add(LabelYear);
            EditPanel.Controls.Add(TextBoxAlbum);
            EditPanel.Controls.Add(LabelAlbum);
            EditPanel.Controls.Add(TextBoxArtists);
            EditPanel.Controls.Add(LabelArtists);
            EditPanel.Controls.Add(TextBoxTitle);
            EditPanel.Controls.Add(LabelTitle);
            EditPanel.Controls.Add(ButtonChooseCover);
            EditPanel.Controls.Add(PictureBoxCover);
            EditPanel.Location = new System.Drawing.Point(6, 8);
            EditPanel.Name = "EditPanel";
            EditPanel.Size = new System.Drawing.Size(582, 481);
            EditPanel.TabIndex = 35;
            EditPanel.Paint += EditPanel_Paint;
            // 
            // hr
            // 
            hr.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            hr.Location = new System.Drawing.Point(23, 447);
            hr.Name = "hr";
            hr.Size = new System.Drawing.Size(539, 2);
            hr.TabIndex = 67;
            // 
            // ButtonPrevious
            // 
            ButtonPrevious.BackColor = System.Drawing.Color.FromArgb(5, 18, 18);
            ButtonPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            ButtonPrevious.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(176, 176, 176);
            ButtonPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            ButtonPrevious.ForeColor = System.Drawing.Color.FromArgb(176, 176, 176);
            ButtonPrevious.Location = new System.Drawing.Point(3, 455);
            ButtonPrevious.Name = "ButtonPrevious";
            ButtonPrevious.Size = new System.Drawing.Size(51, 23);
            ButtonPrevious.TabIndex = 65;
            ButtonPrevious.Text = "<=";
            ButtonPrevious.UseVisualStyleBackColor = false;
            ButtonPrevious.Click += ButtonPrevious_Click;
            // 
            // ButtonNext
            // 
            ButtonNext.BackColor = System.Drawing.Color.FromArgb(5, 18, 18);
            ButtonNext.Cursor = System.Windows.Forms.Cursors.Hand;
            ButtonNext.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(176, 176, 176);
            ButtonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            ButtonNext.ForeColor = System.Drawing.Color.FromArgb(176, 176, 176);
            ButtonNext.Location = new System.Drawing.Point(60, 455);
            ButtonNext.Name = "ButtonNext";
            ButtonNext.Size = new System.Drawing.Size(51, 23);
            ButtonNext.TabIndex = 64;
            ButtonNext.Text = "=>";
            ButtonNext.UseVisualStyleBackColor = false;
            ButtonNext.Click += ButtonNext_Click;
            // 
            // ButtonClose
            // 
            ButtonClose.BackColor = System.Drawing.Color.FromArgb(5, 18, 18);
            ButtonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            ButtonClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(176, 176, 176);
            ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            ButtonClose.ForeColor = System.Drawing.Color.FromArgb(176, 176, 176);
            ButtonClose.Location = new System.Drawing.Point(423, 455);
            ButtonClose.Name = "ButtonClose";
            ButtonClose.Size = new System.Drawing.Size(75, 23);
            ButtonClose.TabIndex = 63;
            ButtonClose.Text = "Close";
            ButtonClose.UseVisualStyleBackColor = false;
            ButtonClose.Click += ButtonClose_Click;
            // 
            // ButtonSave
            // 
            ButtonSave.BackColor = System.Drawing.Color.FromArgb(5, 18, 18);
            ButtonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            ButtonSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(176, 176, 176);
            ButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            ButtonSave.ForeColor = System.Drawing.Color.FromArgb(176, 176, 176);
            ButtonSave.Location = new System.Drawing.Point(504, 455);
            ButtonSave.Name = "ButtonSave";
            ButtonSave.Size = new System.Drawing.Size(75, 23);
            ButtonSave.TabIndex = 66;
            ButtonSave.Text = "Save";
            ButtonSave.UseVisualStyleBackColor = false;
            ButtonSave.Click += ButtonSave_Click;
            // 
            // RichTextBoxLyrics
            // 
            RichTextBoxLyrics.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            RichTextBoxLyrics.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            RichTextBoxLyrics.ForeColor = System.Drawing.Color.FromArgb(176, 176, 176);
            RichTextBoxLyrics.Location = new System.Drawing.Point(329, 134);
            RichTextBoxLyrics.Name = "RichTextBoxLyrics";
            RichTextBoxLyrics.Size = new System.Drawing.Size(250, 270);
            RichTextBoxLyrics.TabIndex = 62;
            RichTextBoxLyrics.Text = "";
            RichTextBoxLyrics.TextChanged += RichTextBoxLyrics_TextChanged;
            // 
            // TextBoxTrackCount
            // 
            TextBoxTrackCount.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            TextBoxTrackCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            TextBoxTrackCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            TextBoxTrackCount.ForeColor = System.Drawing.Color.FromArgb(176, 176, 176);
            TextBoxTrackCount.Location = new System.Drawing.Point(158, 294);
            TextBoxTrackCount.Name = "TextBoxTrackCount";
            TextBoxTrackCount.Size = new System.Drawing.Size(45, 23);
            TextBoxTrackCount.TabIndex = 57;
            TextBoxTrackCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            TextBoxTrackCount.TextChanged += TextBox_TextChanged;
            // 
            // LabelTrackOf
            // 
            LabelTrackOf.AutoSize = true;
            LabelTrackOf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            LabelTrackOf.ForeColor = System.Drawing.Color.FromArgb(176, 176, 176);
            LabelTrackOf.Location = new System.Drawing.Point(129, 297);
            LabelTrackOf.Name = "LabelTrackOf";
            LabelTrackOf.Size = new System.Drawing.Size(23, 17);
            LabelTrackOf.TabIndex = 56;
            LabelTrackOf.Text = "Of";
            // 
            // LabelLyrics
            // 
            LabelLyrics.AutoSize = true;
            LabelLyrics.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            LabelLyrics.ForeColor = System.Drawing.Color.FromArgb(176, 176, 176);
            LabelLyrics.Location = new System.Drawing.Point(223, 134);
            LabelLyrics.Name = "LabelLyrics";
            LabelLyrics.Size = new System.Drawing.Size(49, 17);
            LabelLyrics.TabIndex = 51;
            LabelLyrics.Text = "Lyrics:";
            // 
            // TextBoxGenre
            // 
            TextBoxGenre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            TextBoxGenre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            TextBoxGenre.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            TextBoxGenre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            TextBoxGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            TextBoxGenre.ForeColor = System.Drawing.Color.FromArgb(176, 176, 176);
            TextBoxGenre.Location = new System.Drawing.Point(80, 355);
            TextBoxGenre.Name = "TextBoxGenre";
            TextBoxGenre.Size = new System.Drawing.Size(123, 23);
            TextBoxGenre.TabIndex = 55;
            TextBoxGenre.TextChanged += TextBox_TextChanged;
            // 
            // LabelGenre
            // 
            LabelGenre.AutoSize = true;
            LabelGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            LabelGenre.ForeColor = System.Drawing.Color.FromArgb(176, 176, 176);
            LabelGenre.Location = new System.Drawing.Point(3, 358);
            LabelGenre.Name = "LabelGenre";
            LabelGenre.Size = new System.Drawing.Size(59, 17);
            LabelGenre.TabIndex = 53;
            LabelGenre.Text = "Genres:";
            // 
            // TextBoxTrack
            // 
            TextBoxTrack.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            TextBoxTrack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            TextBoxTrack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            TextBoxTrack.ForeColor = System.Drawing.Color.FromArgb(176, 176, 176);
            TextBoxTrack.Location = new System.Drawing.Point(80, 294);
            TextBoxTrack.Name = "TextBoxTrack";
            TextBoxTrack.Size = new System.Drawing.Size(45, 23);
            TextBoxTrack.TabIndex = 49;
            TextBoxTrack.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            TextBoxTrack.TextChanged += TextBox_TextChanged;
            // 
            // LabelTrack
            // 
            LabelTrack.AutoSize = true;
            LabelTrack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            LabelTrack.ForeColor = System.Drawing.Color.FromArgb(176, 176, 176);
            LabelTrack.Location = new System.Drawing.Point(3, 297);
            LabelTrack.Name = "LabelTrack";
            LabelTrack.Size = new System.Drawing.Size(48, 17);
            LabelTrack.TabIndex = 46;
            LabelTrack.Text = "Track:";
            // 
            // TextBoxYear
            // 
            TextBoxYear.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            TextBoxYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            TextBoxYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            TextBoxYear.ForeColor = System.Drawing.Color.FromArgb(176, 176, 176);
            TextBoxYear.Location = new System.Drawing.Point(80, 326);
            TextBoxYear.Name = "TextBoxYear";
            TextBoxYear.Size = new System.Drawing.Size(123, 23);
            TextBoxYear.TabIndex = 50;
            TextBoxYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            TextBoxYear.TextChanged += TextBox_TextChanged;
            // 
            // LabelYear
            // 
            LabelYear.AutoSize = true;
            LabelYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            LabelYear.ForeColor = System.Drawing.Color.FromArgb(176, 176, 176);
            LabelYear.Location = new System.Drawing.Point(3, 329);
            LabelYear.Name = "LabelYear";
            LabelYear.Size = new System.Drawing.Size(42, 17);
            LabelYear.TabIndex = 47;
            LabelYear.Text = "Year:";
            // 
            // TextBoxAlbum
            // 
            TextBoxAlbum.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            TextBoxAlbum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            TextBoxAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            TextBoxAlbum.ForeColor = System.Drawing.Color.FromArgb(176, 176, 176);
            TextBoxAlbum.Location = new System.Drawing.Point(329, 95);
            TextBoxAlbum.Name = "TextBoxAlbum";
            TextBoxAlbum.Size = new System.Drawing.Size(250, 23);
            TextBoxAlbum.TabIndex = 44;
            TextBoxAlbum.TextChanged += TextBox_TextChanged;
            // 
            // LabelAlbum
            // 
            LabelAlbum.AutoSize = true;
            LabelAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            LabelAlbum.ForeColor = System.Drawing.Color.FromArgb(176, 176, 176);
            LabelAlbum.Location = new System.Drawing.Point(223, 101);
            LabelAlbum.Name = "LabelAlbum";
            LabelAlbum.Size = new System.Drawing.Size(51, 17);
            LabelAlbum.TabIndex = 39;
            LabelAlbum.Text = "Album:";
            // 
            // TextBoxArtists
            // 
            TextBoxArtists.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            TextBoxArtists.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            TextBoxArtists.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            TextBoxArtists.ForeColor = System.Drawing.Color.FromArgb(176, 176, 176);
            TextBoxArtists.Location = new System.Drawing.Point(329, 63);
            TextBoxArtists.Name = "TextBoxArtists";
            TextBoxArtists.Size = new System.Drawing.Size(250, 23);
            TextBoxArtists.TabIndex = 42;
            TextBoxArtists.TextChanged += TextBox_TextChanged;
            // 
            // LabelArtists
            // 
            LabelArtists.AutoSize = true;
            LabelArtists.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            LabelArtists.ForeColor = System.Drawing.Color.FromArgb(176, 176, 176);
            LabelArtists.Location = new System.Drawing.Point(223, 66);
            LabelArtists.Name = "LabelArtists";
            LabelArtists.Size = new System.Drawing.Size(51, 17);
            LabelArtists.TabIndex = 37;
            LabelArtists.Text = "Artists:";
            // 
            // TextBoxTitle
            // 
            TextBoxTitle.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            TextBoxTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            TextBoxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            TextBoxTitle.ForeColor = System.Drawing.Color.FromArgb(176, 176, 176);
            TextBoxTitle.Location = new System.Drawing.Point(329, 34);
            TextBoxTitle.Name = "TextBoxTitle";
            TextBoxTitle.Size = new System.Drawing.Size(250, 23);
            TextBoxTitle.TabIndex = 41;
            TextBoxTitle.TextChanged += TextBox_TextChanged;
            // 
            // LabelTitle
            // 
            LabelTitle.AutoSize = true;
            LabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            LabelTitle.ForeColor = System.Drawing.Color.FromArgb(176, 176, 176);
            LabelTitle.Location = new System.Drawing.Point(223, 37);
            LabelTitle.Name = "LabelTitle";
            LabelTitle.Size = new System.Drawing.Size(39, 17);
            LabelTitle.TabIndex = 40;
            LabelTitle.Text = "Title:";
            // 
            // ButtonChooseCover
            // 
            ButtonChooseCover.BackColor = System.Drawing.Color.FromArgb(5, 18, 18);
            ButtonChooseCover.Cursor = System.Windows.Forms.Cursors.Hand;
            ButtonChooseCover.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(176, 176, 176);
            ButtonChooseCover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            ButtonChooseCover.ForeColor = System.Drawing.Color.FromArgb(176, 176, 176);
            ButtonChooseCover.Location = new System.Drawing.Point(3, 243);
            ButtonChooseCover.Name = "ButtonChooseCover";
            ButtonChooseCover.Size = new System.Drawing.Size(200, 30);
            ButtonChooseCover.TabIndex = 36;
            ButtonChooseCover.Text = "Choose Picture";
            ButtonChooseCover.UseVisualStyleBackColor = false;
            ButtonChooseCover.Click += ButtonChooseCover_Click;
            // 
            // PictureBoxCover
            // 
            PictureBoxCover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            PictureBoxCover.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            PictureBoxCover.Location = new System.Drawing.Point(3, 37);
            PictureBoxCover.Name = "PictureBoxCover";
            PictureBoxCover.Size = new System.Drawing.Size(200, 200);
            PictureBoxCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            PictureBoxCover.TabIndex = 35;
            PictureBoxCover.TabStop = false;
            // 
            // FlowLayoutPanelSong
            // 
            FlowLayoutPanelSong.Location = new System.Drawing.Point(3, 3);
            FlowLayoutPanelSong.Name = "FlowLayoutPanelSong";
            FlowLayoutPanelSong.Size = new System.Drawing.Size(400, 415);
            FlowLayoutPanelSong.TabIndex = 40;
            // 
            // EditForm
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            ClientSize = new System.Drawing.Size(600, 496);
            Controls.Add(EditPanel);
            ForeColor = System.Drawing.Color.White;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Edit Form";
            Load += EditForm_Load;
            EditPanel.ResumeLayout(false);
            EditPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBoxCover).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel EditPanel;
        private System.Windows.Forms.Panel hr;
        private System.Windows.Forms.Button ButtonPrevious;
        private System.Windows.Forms.Button ButtonNext;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.RichTextBox RichTextBoxLyrics;
        private System.Windows.Forms.TextBox TextBoxTrackCount;
        private System.Windows.Forms.Label LabelTrackOf;
        private System.Windows.Forms.Label LabelLyrics;
        private System.Windows.Forms.TextBox TextBoxGenre;
        private System.Windows.Forms.Label LabelGenre;
        private System.Windows.Forms.TextBox TextBoxTrack;
        private System.Windows.Forms.Label LabelTrack;
        private System.Windows.Forms.TextBox TextBoxYear;
        private System.Windows.Forms.Label LabelYear;
        private System.Windows.Forms.TextBox TextBoxAlbum;
        private System.Windows.Forms.Label LabelAlbum;
        private System.Windows.Forms.TextBox TextBoxArtists;
        private System.Windows.Forms.Label LabelArtists;
        private System.Windows.Forms.TextBox TextBoxTitle;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Button ButtonChooseCover;
        private System.Windows.Forms.PictureBox PictureBoxCover;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanelSong;
    }
}