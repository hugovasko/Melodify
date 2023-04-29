namespace Melodify
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
            this.EditPanel = new System.Windows.Forms.Panel();
            this.ButtonAuto = new System.Windows.Forms.Button();
            this.RadioButtonLTR = new System.Windows.Forms.RadioButton();
            this.RadioButtonRTL = new System.Windows.Forms.RadioButton();
            this.hr = new System.Windows.Forms.Panel();
            this.ButtonPrevieus = new System.Windows.Forms.Button();
            this.ButtonNext = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.RichTextBoxLyrics = new System.Windows.Forms.RichTextBox();
            this.TextBoxTrackCount = new System.Windows.Forms.TextBox();
            this.LabelTrackOf = new System.Windows.Forms.Label();
            this.LabelLyrics = new System.Windows.Forms.Label();
            this.TextBoxGenre = new System.Windows.Forms.TextBox();
            this.LabelGenre = new System.Windows.Forms.Label();
            this.TextBoxTrack = new System.Windows.Forms.TextBox();
            this.LabelTrack = new System.Windows.Forms.Label();
            this.TextBoxYear = new System.Windows.Forms.TextBox();
            this.LabelYear = new System.Windows.Forms.Label();
            this.TextBoxAlbum = new System.Windows.Forms.TextBox();
            this.LabelAlbum = new System.Windows.Forms.Label();
            this.TextBoxArtists = new System.Windows.Forms.TextBox();
            this.LabelArtists = new System.Windows.Forms.Label();
            this.TextBoxTitle = new System.Windows.Forms.TextBox();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.ButtonChooseCover = new System.Windows.Forms.Button();
            this.PictureBoxCover = new System.Windows.Forms.PictureBox();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.FlowLayoutPanelSong = new System.Windows.Forms.FlowLayoutPanel();
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.EditPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxCover)).BeginInit();
            this.SearchPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // EditPanel
            // 
            this.EditPanel.Controls.Add(this.ButtonAuto);
            this.EditPanel.Controls.Add(this.RadioButtonLTR);
            this.EditPanel.Controls.Add(this.RadioButtonRTL);
            this.EditPanel.Controls.Add(this.hr);
            this.EditPanel.Controls.Add(this.ButtonPrevieus);
            this.EditPanel.Controls.Add(this.ButtonNext);
            this.EditPanel.Controls.Add(this.ButtonClose);
            this.EditPanel.Controls.Add(this.ButtonSave);
            this.EditPanel.Controls.Add(this.RichTextBoxLyrics);
            this.EditPanel.Controls.Add(this.TextBoxTrackCount);
            this.EditPanel.Controls.Add(this.LabelTrackOf);
            this.EditPanel.Controls.Add(this.LabelLyrics);
            this.EditPanel.Controls.Add(this.TextBoxGenre);
            this.EditPanel.Controls.Add(this.LabelGenre);
            this.EditPanel.Controls.Add(this.TextBoxTrack);
            this.EditPanel.Controls.Add(this.LabelTrack);
            this.EditPanel.Controls.Add(this.TextBoxYear);
            this.EditPanel.Controls.Add(this.LabelYear);
            this.EditPanel.Controls.Add(this.TextBoxAlbum);
            this.EditPanel.Controls.Add(this.LabelAlbum);
            this.EditPanel.Controls.Add(this.TextBoxArtists);
            this.EditPanel.Controls.Add(this.LabelArtists);
            this.EditPanel.Controls.Add(this.TextBoxTitle);
            this.EditPanel.Controls.Add(this.LabelTitle);
            this.EditPanel.Controls.Add(this.ButtonChooseCover);
            this.EditPanel.Controls.Add(this.PictureBoxCover);
            this.EditPanel.Location = new System.Drawing.Point(6, 8);
            this.EditPanel.Name = "EditPanel";
            this.EditPanel.Size = new System.Drawing.Size(582, 481);
            this.EditPanel.TabIndex = 35;
            this.EditPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.EditPanel_Paint);
            // 
            // ButtonAuto
            // 
            this.ButtonAuto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ButtonAuto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAuto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.ButtonAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAuto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.ButtonAuto.Location = new System.Drawing.Point(342, 455);
            this.ButtonAuto.Name = "ButtonAuto";
            this.ButtonAuto.Size = new System.Drawing.Size(75, 23);
            this.ButtonAuto.TabIndex = 70;
            this.ButtonAuto.Text = "Auto";
            this.ButtonAuto.UseVisualStyleBackColor = false;
            this.ButtonAuto.Click += new System.EventHandler(this.ButtonAuto_Click);
            // 
            // RadioButtonLTR
            // 
            this.RadioButtonLTR.AutoSize = true;
            this.RadioButtonLTR.Checked = true;
            this.RadioButtonLTR.Location = new System.Drawing.Point(236, 166);
            this.RadioButtonLTR.Name = "RadioButtonLTR";
            this.RadioButtonLTR.Size = new System.Drawing.Size(87, 17);
            this.RadioButtonLTR.TabIndex = 69;
            this.RadioButtonLTR.TabStop = true;
            this.RadioButtonLTR.Text = "Left To Right";
            this.RadioButtonLTR.UseVisualStyleBackColor = true;
            this.RadioButtonLTR.Click += new System.EventHandler(this.RadioButtonLTR_CheckedChanged);
            // 
            // RadioButtonRTL
            // 
            this.RadioButtonRTL.AutoSize = true;
            this.RadioButtonRTL.Location = new System.Drawing.Point(236, 189);
            this.RadioButtonRTL.Name = "RadioButtonRTL";
            this.RadioButtonRTL.Size = new System.Drawing.Size(87, 17);
            this.RadioButtonRTL.TabIndex = 68;
            this.RadioButtonRTL.Text = "Right To Left";
            this.RadioButtonRTL.UseVisualStyleBackColor = true;
            this.RadioButtonRTL.Click += new System.EventHandler(this.RadioButtonRTL_CheckedChanged);
            // 
            // hr
            // 
            this.hr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.hr.Location = new System.Drawing.Point(23, 447);
            this.hr.Name = "hr";
            this.hr.Size = new System.Drawing.Size(539, 2);
            this.hr.TabIndex = 67;
            // 
            // ButtonPrevieus
            // 
            this.ButtonPrevieus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ButtonPrevieus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonPrevieus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.ButtonPrevieus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPrevieus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.ButtonPrevieus.Location = new System.Drawing.Point(3, 455);
            this.ButtonPrevieus.Name = "ButtonPrevieus";
            this.ButtonPrevieus.Size = new System.Drawing.Size(51, 23);
            this.ButtonPrevieus.TabIndex = 65;
            this.ButtonPrevieus.Text = "<=";
            this.ButtonPrevieus.UseVisualStyleBackColor = false;
            this.ButtonPrevieus.Click += new System.EventHandler(this.ButtonPrevieus_Click);
            // 
            // ButtonNext
            // 
            this.ButtonNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ButtonNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonNext.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.ButtonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.ButtonNext.Location = new System.Drawing.Point(60, 455);
            this.ButtonNext.Name = "ButtonNext";
            this.ButtonNext.Size = new System.Drawing.Size(51, 23);
            this.ButtonNext.TabIndex = 64;
            this.ButtonNext.Text = "=>";
            this.ButtonNext.UseVisualStyleBackColor = false;
            this.ButtonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // ButtonClose
            // 
            this.ButtonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ButtonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.ButtonClose.Location = new System.Drawing.Point(423, 455);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(75, 23);
            this.ButtonClose.TabIndex = 63;
            this.ButtonClose.Text = "Close";
            this.ButtonClose.UseVisualStyleBackColor = false;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ButtonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.ButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.ButtonSave.Location = new System.Drawing.Point(504, 455);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(75, 23);
            this.ButtonSave.TabIndex = 66;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = false;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // RichTextBoxLyrics
            // 
            this.RichTextBoxLyrics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.RichTextBoxLyrics.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RichTextBoxLyrics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.RichTextBoxLyrics.Location = new System.Drawing.Point(329, 134);
            this.RichTextBoxLyrics.Name = "RichTextBoxLyrics";
            this.RichTextBoxLyrics.Size = new System.Drawing.Size(250, 270);
            this.RichTextBoxLyrics.TabIndex = 62;
            this.RichTextBoxLyrics.Text = "";
            // 
            // TextBoxTrackCount
            // 
            this.TextBoxTrackCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.TextBoxTrackCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxTrackCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxTrackCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.TextBoxTrackCount.Location = new System.Drawing.Point(158, 294);
            this.TextBoxTrackCount.Name = "TextBoxTrackCount";
            this.TextBoxTrackCount.Size = new System.Drawing.Size(45, 23);
            this.TextBoxTrackCount.TabIndex = 57;
            this.TextBoxTrackCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxTrackCount.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // LabelTrackOf
            // 
            this.LabelTrackOf.AutoSize = true;
            this.LabelTrackOf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTrackOf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.LabelTrackOf.Location = new System.Drawing.Point(129, 297);
            this.LabelTrackOf.Name = "LabelTrackOf";
            this.LabelTrackOf.Size = new System.Drawing.Size(23, 17);
            this.LabelTrackOf.TabIndex = 56;
            this.LabelTrackOf.Text = "Of";
            // 
            // LabelLyrics
            // 
            this.LabelLyrics.AutoSize = true;
            this.LabelLyrics.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLyrics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.LabelLyrics.Location = new System.Drawing.Point(223, 134);
            this.LabelLyrics.Name = "LabelLyrics";
            this.LabelLyrics.Size = new System.Drawing.Size(49, 17);
            this.LabelLyrics.TabIndex = 51;
            this.LabelLyrics.Text = "Lyrics:";
            // 
            // TextBoxGenre
            // 
            this.TextBoxGenre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TextBoxGenre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TextBoxGenre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.TextBoxGenre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxGenre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.TextBoxGenre.Location = new System.Drawing.Point(80, 355);
            this.TextBoxGenre.Name = "TextBoxGenre";
            this.TextBoxGenre.Size = new System.Drawing.Size(123, 23);
            this.TextBoxGenre.TabIndex = 55;
            this.TextBoxGenre.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // LabelGenre
            // 
            this.LabelGenre.AutoSize = true;
            this.LabelGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelGenre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.LabelGenre.Location = new System.Drawing.Point(3, 358);
            this.LabelGenre.Name = "LabelGenre";
            this.LabelGenre.Size = new System.Drawing.Size(59, 17);
            this.LabelGenre.TabIndex = 53;
            this.LabelGenre.Text = "Genres:";
            // 
            // TextBoxTrack
            // 
            this.TextBoxTrack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.TextBoxTrack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxTrack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxTrack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.TextBoxTrack.Location = new System.Drawing.Point(80, 294);
            this.TextBoxTrack.Name = "TextBoxTrack";
            this.TextBoxTrack.Size = new System.Drawing.Size(45, 23);
            this.TextBoxTrack.TabIndex = 49;
            this.TextBoxTrack.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxTrack.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // LabelTrack
            // 
            this.LabelTrack.AutoSize = true;
            this.LabelTrack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTrack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.LabelTrack.Location = new System.Drawing.Point(3, 297);
            this.LabelTrack.Name = "LabelTrack";
            this.LabelTrack.Size = new System.Drawing.Size(48, 17);
            this.LabelTrack.TabIndex = 46;
            this.LabelTrack.Text = "Track:";
            // 
            // TextBoxYear
            // 
            this.TextBoxYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.TextBoxYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.TextBoxYear.Location = new System.Drawing.Point(80, 326);
            this.TextBoxYear.Name = "TextBoxYear";
            this.TextBoxYear.Size = new System.Drawing.Size(123, 23);
            this.TextBoxYear.TabIndex = 50;
            this.TextBoxYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxYear.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // LabelYear
            // 
            this.LabelYear.AutoSize = true;
            this.LabelYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.LabelYear.Location = new System.Drawing.Point(3, 329);
            this.LabelYear.Name = "LabelYear";
            this.LabelYear.Size = new System.Drawing.Size(42, 17);
            this.LabelYear.TabIndex = 47;
            this.LabelYear.Text = "Year:";
            // 
            // TextBoxAlbum
            // 
            this.TextBoxAlbum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.TextBoxAlbum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxAlbum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.TextBoxAlbum.Location = new System.Drawing.Point(329, 95);
            this.TextBoxAlbum.Name = "TextBoxAlbum";
            this.TextBoxAlbum.Size = new System.Drawing.Size(250, 23);
            this.TextBoxAlbum.TabIndex = 44;
            this.TextBoxAlbum.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // LabelAlbum
            // 
            this.LabelAlbum.AutoSize = true;
            this.LabelAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAlbum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.LabelAlbum.Location = new System.Drawing.Point(223, 101);
            this.LabelAlbum.Name = "LabelAlbum";
            this.LabelAlbum.Size = new System.Drawing.Size(51, 17);
            this.LabelAlbum.TabIndex = 39;
            this.LabelAlbum.Text = "Album:";
            // 
            // TextBoxArtists
            // 
            this.TextBoxArtists.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.TextBoxArtists.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxArtists.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxArtists.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.TextBoxArtists.Location = new System.Drawing.Point(329, 63);
            this.TextBoxArtists.Name = "TextBoxArtists";
            this.TextBoxArtists.Size = new System.Drawing.Size(250, 23);
            this.TextBoxArtists.TabIndex = 42;
            this.TextBoxArtists.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // LabelArtists
            // 
            this.LabelArtists.AutoSize = true;
            this.LabelArtists.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelArtists.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.LabelArtists.Location = new System.Drawing.Point(223, 66);
            this.LabelArtists.Name = "LabelArtists";
            this.LabelArtists.Size = new System.Drawing.Size(51, 17);
            this.LabelArtists.TabIndex = 37;
            this.LabelArtists.Text = "Artists:";
            // 
            // TextBoxTitle
            // 
            this.TextBoxTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.TextBoxTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.TextBoxTitle.Location = new System.Drawing.Point(329, 34);
            this.TextBoxTitle.Name = "TextBoxTitle";
            this.TextBoxTitle.Size = new System.Drawing.Size(250, 23);
            this.TextBoxTitle.TabIndex = 41;
            this.TextBoxTitle.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.LabelTitle.Location = new System.Drawing.Point(223, 37);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(39, 17);
            this.LabelTitle.TabIndex = 40;
            this.LabelTitle.Text = "Title:";
            // 
            // ButtonChooseCover
            // 
            this.ButtonChooseCover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ButtonChooseCover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonChooseCover.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.ButtonChooseCover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonChooseCover.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.ButtonChooseCover.Location = new System.Drawing.Point(3, 243);
            this.ButtonChooseCover.Name = "ButtonChooseCover";
            this.ButtonChooseCover.Size = new System.Drawing.Size(200, 30);
            this.ButtonChooseCover.TabIndex = 36;
            this.ButtonChooseCover.Text = "Choose Picture";
            this.ButtonChooseCover.UseVisualStyleBackColor = false;
            this.ButtonChooseCover.Click += new System.EventHandler(this.ButtonChooseCover_Click);
            // 
            // PictureBoxCover
            // 
            this.PictureBoxCover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PictureBoxCover.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PictureBoxCover.Location = new System.Drawing.Point(3, 37);
            this.PictureBoxCover.Name = "PictureBoxCover";
            this.PictureBoxCover.Size = new System.Drawing.Size(200, 200);
            this.PictureBoxCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxCover.TabIndex = 35;
            this.PictureBoxCover.TabStop = false;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.SearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.SearchTextBox.Location = new System.Drawing.Point(3, 426);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(400, 23);
            this.SearchTextBox.TabIndex = 37;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.SearchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.SearchButton.Location = new System.Drawing.Point(3, 455);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(190, 23);
            this.SearchButton.TabIndex = 39;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.CancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.CancelButton.Location = new System.Drawing.Point(213, 455);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(190, 23);
            this.CancelButton.TabIndex = 38;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // FlowLayoutPanelSong
            // 
            this.FlowLayoutPanelSong.Location = new System.Drawing.Point(3, 3);
            this.FlowLayoutPanelSong.Name = "FlowLayoutPanelSong";
            this.FlowLayoutPanelSong.Size = new System.Drawing.Size(400, 415);
            this.FlowLayoutPanelSong.TabIndex = 40;
            // 
            // SearchPanel
            // 
            this.SearchPanel.Controls.Add(this.FlowLayoutPanelSong);
            this.SearchPanel.Controls.Add(this.CancelButton);
            this.SearchPanel.Controls.Add(this.SearchButton);
            this.SearchPanel.Controls.Add(this.SearchTextBox);
            this.SearchPanel.Location = new System.Drawing.Point(594, 8);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(409, 481);
            this.SearchPanel.TabIndex = 0;
            // 
            // EditForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1012, 496);
            this.Controls.Add(this.EditPanel);
            this.Controls.Add(this.SearchPanel);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Form";
            this.Load += new System.EventHandler(this.EditForm_Load);
            this.EditPanel.ResumeLayout(false);
            this.EditPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxCover)).EndInit();
            this.SearchPanel.ResumeLayout(false);
            this.SearchPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel EditPanel;
        private System.Windows.Forms.Button ButtonAuto;
        private System.Windows.Forms.RadioButton RadioButtonLTR;
        private System.Windows.Forms.RadioButton RadioButtonRTL;
        private System.Windows.Forms.Panel hr;
        private System.Windows.Forms.Button ButtonPrevieus;
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
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button SearchButton;
        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanelSong;
        private System.Windows.Forms.Panel SearchPanel;
    }
}