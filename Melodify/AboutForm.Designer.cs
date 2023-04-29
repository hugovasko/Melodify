namespace Melodify
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
            this.LabelTitle = new System.Windows.Forms.Label();
            this.LabelDescription = new System.Windows.Forms.Label();
            this.PictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.LinkLabelAppGodName = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelTitle
            // 
            this.LabelTitle.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.ForeColor = System.Drawing.Color.Teal;
            this.LabelTitle.Location = new System.Drawing.Point(12, 115);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(280, 55);
            this.LabelTitle.TabIndex = 1;
            this.LabelTitle.Text = "Melodify";
            this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelDescription
            // 
            this.LabelDescription.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDescription.Location = new System.Drawing.Point(47, 170);
            this.LabelDescription.Name = "LabelDescription";
            this.LabelDescription.Size = new System.Drawing.Size(124, 18);
            this.LabelDescription.TabIndex = 1;
            this.LabelDescription.Text = "Created with love by";
            this.LabelDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PictureBoxLogo
            // 
            this.PictureBoxLogo.Image = global::Melodify.Properties.Resources.Logo;
            this.PictureBoxLogo.Location = new System.Drawing.Point(102, 12);
            this.PictureBoxLogo.Name = "PictureBoxLogo";
            this.PictureBoxLogo.Size = new System.Drawing.Size(100, 100);
            this.PictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxLogo.TabIndex = 0;
            this.PictureBoxLogo.TabStop = false;
            // 
            // LinkLabelAppGodName
            // 
            this.LinkLabelAppGodName.AutoSize = true;
            this.LinkLabelAppGodName.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLabelAppGodName.LinkColor = System.Drawing.Color.Green;
            this.LinkLabelAppGodName.Location = new System.Drawing.Point(164, 170);
            this.LinkLabelAppGodName.Name = "LinkLabelAppGodName";
            this.LinkLabelAppGodName.Size = new System.Drawing.Size(97, 19);
            this.LinkLabelAppGodName.TabIndex = 2;
            this.LinkLabelAppGodName.TabStop = true;
            this.LinkLabelAppGodName.Text = "Vasko Nikolov";
            this.LinkLabelAppGodName.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelAppGodName_LinkClicked);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 224);
            this.Controls.Add(this.LinkLabelAppGodName);
            this.Controls.Add(this.LabelDescription);
            this.Controls.Add(this.LabelTitle);
            this.Controls.Add(this.PictureBoxLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About Melodify";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBoxLogo;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Label LabelDescription;
        private System.Windows.Forms.LinkLabel LinkLabelAppGodName;
    }
}