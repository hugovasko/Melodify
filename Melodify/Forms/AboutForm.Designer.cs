namespace Melodify.Forms
{
    partial class AboutForm
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
            LabelTitle = new System.Windows.Forms.Label();
            LabelDescription = new System.Windows.Forms.Label();
            PictureBoxLogo = new System.Windows.Forms.PictureBox();
            LinkLabelAppCreatorName = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)PictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // LabelTitle
            // 
            LabelTitle.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            LabelTitle.ForeColor = System.Drawing.Color.Teal;
            LabelTitle.Location = new System.Drawing.Point(14, 133);
            LabelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LabelTitle.Name = "LabelTitle";
            LabelTitle.Size = new System.Drawing.Size(327, 63);
            LabelTitle.TabIndex = 1;
            LabelTitle.Text = "Melodify";
            LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelDescription
            // 
            LabelDescription.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            LabelDescription.Location = new System.Drawing.Point(59, 196);
            LabelDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LabelDescription.Name = "LabelDescription";
            LabelDescription.Size = new System.Drawing.Size(145, 21);
            LabelDescription.TabIndex = 1;
            LabelDescription.Text = "Created with love by";
            LabelDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PictureBoxLogo
            // 
            PictureBoxLogo.Image = Properties.Resources.Melodify;
            PictureBoxLogo.InitialImage = null;
            PictureBoxLogo.Location = new System.Drawing.Point(119, 14);
            PictureBoxLogo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            PictureBoxLogo.Name = "PictureBoxLogo";
            PictureBoxLogo.Size = new System.Drawing.Size(117, 115);
            PictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            PictureBoxLogo.TabIndex = 0;
            PictureBoxLogo.TabStop = false;
            // 
            // LinkLabelAppCreatorName
            // 
            LinkLabelAppCreatorName.AutoSize = true;
            LinkLabelAppCreatorName.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            LinkLabelAppCreatorName.LinkColor = System.Drawing.Color.Green;
            LinkLabelAppCreatorName.Location = new System.Drawing.Point(186, 197);
            LinkLabelAppCreatorName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LinkLabelAppCreatorName.Name = "LinkLabelAppCreatorName";
            LinkLabelAppCreatorName.Size = new System.Drawing.Size(97, 19);
            LinkLabelAppCreatorName.TabIndex = 2;
            LinkLabelAppCreatorName.TabStop = true;
            LinkLabelAppCreatorName.Text = "Vasko Nikolov";
            LinkLabelAppCreatorName.LinkClicked += LinkLabelAppCreatorName_LinkClicked;
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(360, 258);
            Controls.Add(LinkLabelAppCreatorName);
            Controls.Add(LabelDescription);
            Controls.Add(LabelTitle);
            Controls.Add(PictureBoxLogo);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AboutForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "About Melodify";
            ((System.ComponentModel.ISupportInitialize)PictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBoxLogo;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Label LabelDescription;
        private System.Windows.Forms.LinkLabel LinkLabelAppCreatorName;
    }
}