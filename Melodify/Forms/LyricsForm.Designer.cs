namespace Melodify.Forms
{
    partial class LyricsForm
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
            hr = new System.Windows.Forms.Panel();
            ButtonClose = new System.Windows.Forms.Button();
            RichTextBoxLyrics = new System.Windows.Forms.RichTextBox();
            SuspendLayout();
            // 
            // hr
            // 
            hr.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            hr.Location = new System.Drawing.Point(33, 393);
            hr.Name = "hr";
            hr.Size = new System.Drawing.Size(539, 2);
            hr.TabIndex = 67;
            // 
            // ButtonClose
            // 
            ButtonClose.BackColor = System.Drawing.Color.FromArgb(5, 18, 18);
            ButtonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            ButtonClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(176, 176, 176);
            ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            ButtonClose.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ButtonClose.ForeColor = System.Drawing.Color.FromArgb(176, 176, 176);
            ButtonClose.Location = new System.Drawing.Point(514, 401);
            ButtonClose.Name = "ButtonClose";
            ButtonClose.Size = new System.Drawing.Size(75, 25);
            ButtonClose.TabIndex = 66;
            ButtonClose.Text = "Close";
            ButtonClose.UseVisualStyleBackColor = false;
            ButtonClose.Click += ButtonClose_Click;
            // 
            // RichTextBoxLyrics
            // 
            RichTextBoxLyrics.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            RichTextBoxLyrics.ForeColor = System.Drawing.Color.FromArgb(176, 176, 176);
            RichTextBoxLyrics.Location = new System.Drawing.Point(12, 12);
            RichTextBoxLyrics.Name = "RichTextBoxLyrics";
            RichTextBoxLyrics.ReadOnly = true;
            RichTextBoxLyrics.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            RichTextBoxLyrics.Size = new System.Drawing.Size(578, 369);
            RichTextBoxLyrics.TabIndex = 0;
            RichTextBoxLyrics.TabStop = false;
            RichTextBoxLyrics.Text = "";
            RichTextBoxLyrics.TextChanged += RichTextBoxLyrics_TextChanged;
            // 
            // LyricsForm
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            ClientSize = new System.Drawing.Size(602, 434);
            Controls.Add(hr);
            Controls.Add(ButtonClose);
            Controls.Add(RichTextBoxLyrics);
            Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ForeColor = System.Drawing.Color.White;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LyricsForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "LyricsForm";
            Load += LyricsForm_Load;
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel hr;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.RichTextBox RichTextBoxLyrics;
    }
}