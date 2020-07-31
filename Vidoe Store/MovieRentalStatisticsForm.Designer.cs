namespace Vidoe_Store
{
    partial class MovieRentalStatisticsForm
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
            this.txtbxTheMostPopularVideo = new System.Windows.Forms.TextBox();
            this.lblTheMostPopularVideo = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtbxTitle = new System.Windows.Forms.TextBox();
            this.lblTCB = new System.Windows.Forms.Label();
            this.txtbxTCB = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtbxFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtbxLastName = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbxTheMostPopularVideo
            // 
            this.txtbxTheMostPopularVideo.Enabled = false;
            this.txtbxTheMostPopularVideo.Location = new System.Drawing.Point(154, 64);
            this.txtbxTheMostPopularVideo.Name = "txtbxTheMostPopularVideo";
            this.txtbxTheMostPopularVideo.Size = new System.Drawing.Size(127, 22);
            this.txtbxTheMostPopularVideo.TabIndex = 0;
            // 
            // lblTheMostPopularVideo
            // 
            this.lblTheMostPopularVideo.AutoSize = true;
            this.lblTheMostPopularVideo.Location = new System.Drawing.Point(12, 67);
            this.lblTheMostPopularVideo.Name = "lblTheMostPopularVideo";
            this.lblTheMostPopularVideo.Size = new System.Drawing.Size(136, 17);
            this.lblTheMostPopularVideo.TabIndex = 1;
            this.lblTheMostPopularVideo.Text = "Times Video Rented";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(305, 69);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(191, 17);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "The Most Popular Video Title";
            // 
            // txtbxTitle
            // 
            this.txtbxTitle.Enabled = false;
            this.txtbxTitle.Location = new System.Drawing.Point(502, 64);
            this.txtbxTitle.Name = "txtbxTitle";
            this.txtbxTitle.Size = new System.Drawing.Size(333, 22);
            this.txtbxTitle.TabIndex = 2;
            // 
            // lblTCB
            // 
            this.lblTCB.AutoSize = true;
            this.lblTCB.Location = new System.Drawing.Point(12, 189);
            this.lblTCB.Name = "lblTCB";
            this.lblTCB.Size = new System.Drawing.Size(178, 17);
            this.lblTCB.TabIndex = 5;
            this.lblTCB.Text = "Times Customer Borrowed ";
            // 
            // txtbxTCB
            // 
            this.txtbxTCB.Enabled = false;
            this.txtbxTCB.Location = new System.Drawing.Point(196, 184);
            this.txtbxTCB.Name = "txtbxTCB";
            this.txtbxTCB.Size = new System.Drawing.Size(127, 22);
            this.txtbxTCB.TabIndex = 4;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(352, 191);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(76, 17);
            this.lblFirstName.TabIndex = 7;
            this.lblFirstName.Text = "First Name";
            // 
            // txtbxFirstName
            // 
            this.txtbxFirstName.Enabled = false;
            this.txtbxFirstName.Location = new System.Drawing.Point(434, 186);
            this.txtbxFirstName.Name = "txtbxFirstName";
            this.txtbxFirstName.Size = new System.Drawing.Size(200, 22);
            this.txtbxFirstName.TabIndex = 6;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(647, 189);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(76, 17);
            this.lblLastName.TabIndex = 9;
            this.lblLastName.Text = "First Name";
            // 
            // txtbxLastName
            // 
            this.txtbxLastName.Enabled = false;
            this.txtbxLastName.Location = new System.Drawing.Point(729, 184);
            this.txtbxLastName.Name = "txtbxLastName";
            this.txtbxLastName.Size = new System.Drawing.Size(200, 22);
            this.txtbxLastName.TabIndex = 8;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(308, 328);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(201, 57);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // MovieRentalStatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtbxLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtbxFirstName);
            this.Controls.Add(this.lblTCB);
            this.Controls.Add(this.txtbxTCB);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtbxTitle);
            this.Controls.Add(this.lblTheMostPopularVideo);
            this.Controls.Add(this.txtbxTheMostPopularVideo);
            this.Name = "MovieRentalStatisticsForm";
            this.Text = "MovieRentalStatisticsForm";
            this.Load += new System.EventHandler(this.MovieRentalStatisticsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxTheMostPopularVideo;
        private System.Windows.Forms.Label lblTheMostPopularVideo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtbxTitle;
        private System.Windows.Forms.Label lblTCB;
        private System.Windows.Forms.TextBox txtbxTCB;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtbxFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtbxLastName;
        private System.Windows.Forms.Button btnClose;
    }
}