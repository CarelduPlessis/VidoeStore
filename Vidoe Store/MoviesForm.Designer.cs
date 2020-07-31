namespace Vidoe_Store
{
    partial class MoviesForm
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
            this.NavMenu = new System.Windows.Forms.MenuStrip();
            this.MoviesBtnTlStrpMnItm = new System.Windows.Forms.ToolStripMenuItem();
            this.CustomerBtnTlStrpMnItm = new System.Windows.Forms.ToolStripMenuItem();
            this.MovieRentedBtnTlStrpMnItm = new System.Windows.Forms.ToolStripMenuItem();
            this.MoviesdataGridView = new System.Windows.Forms.DataGridView();
            this.btnNewMovie = new System.Windows.Forms.Button();
            this.btnDeleteMovie = new System.Windows.Forms.Button();
            this.btnUpdateMovie = new System.Windows.Forms.Button();
            this.lblMovieTitle = new System.Windows.Forms.Label();
            this.txtbxMovieTitle = new System.Windows.Forms.TextBox();
            this.txtbxYear = new System.Windows.Forms.TextBox();
            this.lblMovieYear = new System.Windows.Forms.Label();
            this.txtbxGenre = new System.Windows.Forms.TextBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.txtbxRating = new System.Windows.Forms.TextBox();
            this.lblRating = new System.Windows.Forms.Label();
            this.txtbxRentalCost = new System.Windows.Forms.TextBox();
            this.lblRentalCost = new System.Windows.Forms.Label();
            this.txtbxCopies = new System.Windows.Forms.TextBox();
            this.lblCopies = new System.Windows.Forms.Label();
            this.txtbxPlot = new System.Windows.Forms.TextBox();
            this.lblPlot = new System.Windows.Forms.Label();
            this.NavMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoviesdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // NavMenu
            // 
            this.NavMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.NavMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MoviesBtnTlStrpMnItm,
            this.CustomerBtnTlStrpMnItm,
            this.MovieRentedBtnTlStrpMnItm});
            this.NavMenu.Location = new System.Drawing.Point(0, 0);
            this.NavMenu.Name = "NavMenu";
            this.NavMenu.Size = new System.Drawing.Size(1108, 30);
            this.NavMenu.TabIndex = 2;
            this.NavMenu.Text = "Navigation Menu";
            // 
            // MoviesBtnTlStrpMnItm
            // 
            this.MoviesBtnTlStrpMnItm.Name = "MoviesBtnTlStrpMnItm";
            this.MoviesBtnTlStrpMnItm.Size = new System.Drawing.Size(70, 24);
            this.MoviesBtnTlStrpMnItm.Text = "Movies";
            this.MoviesBtnTlStrpMnItm.Click += new System.EventHandler(this.MoviesBtnTlStrpMnItm_Click);
            // 
            // CustomerBtnTlStrpMnItm
            // 
            this.CustomerBtnTlStrpMnItm.Name = "CustomerBtnTlStrpMnItm";
            this.CustomerBtnTlStrpMnItm.Size = new System.Drawing.Size(86, 24);
            this.CustomerBtnTlStrpMnItm.Text = "Customer";
            this.CustomerBtnTlStrpMnItm.Click += new System.EventHandler(this.CustomerBtnTlStrpMnItm_Click);
            // 
            // MovieRentedBtnTlStrpMnItm
            // 
            this.MovieRentedBtnTlStrpMnItm.Name = "MovieRentedBtnTlStrpMnItm";
            this.MovieRentedBtnTlStrpMnItm.Size = new System.Drawing.Size(115, 24);
            this.MovieRentedBtnTlStrpMnItm.Text = "Movie Rented";
            this.MovieRentedBtnTlStrpMnItm.Click += new System.EventHandler(this.MovieRentedBtnTlStrpMnItm_Click);
            // 
            // MoviesdataGridView
            // 
            this.MoviesdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MoviesdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MoviesdataGridView.Location = new System.Drawing.Point(12, 31);
            this.MoviesdataGridView.Name = "MoviesdataGridView";
            this.MoviesdataGridView.RowHeadersWidth = 51;
            this.MoviesdataGridView.RowTemplate.Height = 24;
            this.MoviesdataGridView.Size = new System.Drawing.Size(1084, 271);
            this.MoviesdataGridView.TabIndex = 3;
            this.MoviesdataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MoviesdataGridView_CellContentClick);
            this.MoviesdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MoviesdataGridView_CellContentClick);
            // 
            // btnNewMovie
            // 
            this.btnNewMovie.Location = new System.Drawing.Point(12, 325);
            this.btnNewMovie.Name = "btnNewMovie";
            this.btnNewMovie.Size = new System.Drawing.Size(137, 53);
            this.btnNewMovie.TabIndex = 11;
            this.btnNewMovie.Text = "New Movie";
            this.btnNewMovie.UseVisualStyleBackColor = true;
            this.btnNewMovie.Click += new System.EventHandler(this.btnNewMovie_Click);
            // 
            // btnDeleteMovie
            // 
            this.btnDeleteMovie.Enabled = false;
            this.btnDeleteMovie.Location = new System.Drawing.Point(308, 325);
            this.btnDeleteMovie.Name = "btnDeleteMovie";
            this.btnDeleteMovie.Size = new System.Drawing.Size(143, 53);
            this.btnDeleteMovie.TabIndex = 10;
            this.btnDeleteMovie.Text = "Delete Movie";
            this.btnDeleteMovie.UseVisualStyleBackColor = true;
            this.btnDeleteMovie.Click += new System.EventHandler(this.btnDeleteMovie_Click);
            // 
            // btnUpdateMovie
            // 
            this.btnUpdateMovie.Enabled = false;
            this.btnUpdateMovie.Location = new System.Drawing.Point(155, 325);
            this.btnUpdateMovie.Name = "btnUpdateMovie";
            this.btnUpdateMovie.Size = new System.Drawing.Size(147, 53);
            this.btnUpdateMovie.TabIndex = 9;
            this.btnUpdateMovie.Text = "Update Movie";
            this.btnUpdateMovie.UseVisualStyleBackColor = true;
            this.btnUpdateMovie.Click += new System.EventHandler(this.btnUpdateMovie_Click);
            // 
            // lblMovieTitle
            // 
            this.lblMovieTitle.AutoSize = true;
            this.lblMovieTitle.Location = new System.Drawing.Point(12, 394);
            this.lblMovieTitle.Name = "lblMovieTitle";
            this.lblMovieTitle.Size = new System.Drawing.Size(35, 17);
            this.lblMovieTitle.TabIndex = 12;
            this.lblMovieTitle.Text = "Title";
            // 
            // txtbxMovieTitle
            // 
            this.txtbxMovieTitle.Location = new System.Drawing.Point(64, 391);
            this.txtbxMovieTitle.Name = "txtbxMovieTitle";
            this.txtbxMovieTitle.Size = new System.Drawing.Size(347, 22);
            this.txtbxMovieTitle.TabIndex = 13;
            // 
            // txtbxYear
            // 
            this.txtbxYear.Location = new System.Drawing.Point(481, 391);
            this.txtbxYear.Name = "txtbxYear";
            this.txtbxYear.Size = new System.Drawing.Size(100, 22);
            this.txtbxYear.TabIndex = 15;
            // 
            // lblMovieYear
            // 
            this.lblMovieYear.AutoSize = true;
            this.lblMovieYear.Location = new System.Drawing.Point(429, 394);
            this.lblMovieYear.Name = "lblMovieYear";
            this.lblMovieYear.Size = new System.Drawing.Size(38, 17);
            this.lblMovieYear.TabIndex = 14;
            this.lblMovieYear.Text = "Year";
            // 
            // txtbxGenre
            // 
            this.txtbxGenre.Location = new System.Drawing.Point(657, 393);
            this.txtbxGenre.Name = "txtbxGenre";
            this.txtbxGenre.Size = new System.Drawing.Size(273, 22);
            this.txtbxGenre.TabIndex = 17;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(603, 394);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(48, 17);
            this.lblGenre.TabIndex = 16;
            this.lblGenre.Text = "Genre";
            // 
            // txtbxRating
            // 
            this.txtbxRating.Location = new System.Drawing.Point(64, 450);
            this.txtbxRating.Name = "txtbxRating";
            this.txtbxRating.Size = new System.Drawing.Size(164, 22);
            this.txtbxRating.TabIndex = 19;
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Location = new System.Drawing.Point(12, 452);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(49, 17);
            this.lblRating.TabIndex = 18;
            this.lblRating.Text = "Rating";
            // 
            // txtbxRentalCost
            // 
            this.txtbxRentalCost.Location = new System.Drawing.Point(321, 452);
            this.txtbxRentalCost.Name = "txtbxRentalCost";
            this.txtbxRentalCost.Size = new System.Drawing.Size(146, 22);
            this.txtbxRentalCost.TabIndex = 21;
            // 
            // lblRentalCost
            // 
            this.lblRentalCost.AutoSize = true;
            this.lblRentalCost.Location = new System.Drawing.Point(234, 452);
            this.lblRentalCost.Name = "lblRentalCost";
            this.lblRentalCost.Size = new System.Drawing.Size(81, 17);
            this.lblRentalCost.TabIndex = 20;
            this.lblRentalCost.Text = "Rental Cost";
            // 
            // txtbxCopies
            // 
            this.txtbxCopies.Location = new System.Drawing.Point(535, 453);
            this.txtbxCopies.Name = "txtbxCopies";
            this.txtbxCopies.Size = new System.Drawing.Size(134, 22);
            this.txtbxCopies.TabIndex = 23;
            // 
            // lblCopies
            // 
            this.lblCopies.AutoSize = true;
            this.lblCopies.Location = new System.Drawing.Point(478, 453);
            this.lblCopies.Name = "lblCopies";
            this.lblCopies.Size = new System.Drawing.Size(51, 17);
            this.lblCopies.TabIndex = 22;
            this.lblCopies.Text = "Copies";
            // 
            // txtbxPlot
            // 
            this.txtbxPlot.Location = new System.Drawing.Point(713, 455);
            this.txtbxPlot.Name = "txtbxPlot";
            this.txtbxPlot.Size = new System.Drawing.Size(383, 22);
            this.txtbxPlot.TabIndex = 25;
            // 
            // lblPlot
            // 
            this.lblPlot.AutoSize = true;
            this.lblPlot.Location = new System.Drawing.Point(675, 455);
            this.lblPlot.Name = "lblPlot";
            this.lblPlot.Size = new System.Drawing.Size(32, 17);
            this.lblPlot.TabIndex = 24;
            this.lblPlot.Text = "Plot";
            // 
            // MoviesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 523);
            this.Controls.Add(this.txtbxPlot);
            this.Controls.Add(this.lblPlot);
            this.Controls.Add(this.txtbxCopies);
            this.Controls.Add(this.lblCopies);
            this.Controls.Add(this.txtbxRentalCost);
            this.Controls.Add(this.lblRentalCost);
            this.Controls.Add(this.txtbxRating);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.txtbxGenre);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.txtbxYear);
            this.Controls.Add(this.lblMovieYear);
            this.Controls.Add(this.txtbxMovieTitle);
            this.Controls.Add(this.lblMovieTitle);
            this.Controls.Add(this.btnNewMovie);
            this.Controls.Add(this.btnDeleteMovie);
            this.Controls.Add(this.btnUpdateMovie);
            this.Controls.Add(this.MoviesdataGridView);
            this.Controls.Add(this.NavMenu);
            this.Name = "MoviesForm";
            this.Text = "Movies";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MoviesForm_FormClosed);
            this.NavMenu.ResumeLayout(false);
            this.NavMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoviesdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip NavMenu;
        private System.Windows.Forms.ToolStripMenuItem MoviesBtnTlStrpMnItm;
        private System.Windows.Forms.ToolStripMenuItem CustomerBtnTlStrpMnItm;
        private System.Windows.Forms.ToolStripMenuItem MovieRentedBtnTlStrpMnItm;
        private System.Windows.Forms.DataGridView MoviesdataGridView;
        private System.Windows.Forms.Button btnNewMovie;
        private System.Windows.Forms.Button btnDeleteMovie;
        private System.Windows.Forms.Button btnUpdateMovie;
        private System.Windows.Forms.Label lblMovieTitle;
        private System.Windows.Forms.TextBox txtbxMovieTitle;
        private System.Windows.Forms.TextBox txtbxYear;
        private System.Windows.Forms.Label lblMovieYear;
        private System.Windows.Forms.TextBox txtbxGenre;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.TextBox txtbxRating;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.TextBox txtbxRentalCost;
        private System.Windows.Forms.Label lblRentalCost;
        private System.Windows.Forms.TextBox txtbxCopies;
        private System.Windows.Forms.Label lblCopies;
        private System.Windows.Forms.TextBox txtbxPlot;
        private System.Windows.Forms.Label lblPlot;
    }
}

