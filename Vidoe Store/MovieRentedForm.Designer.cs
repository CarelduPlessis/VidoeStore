namespace Vidoe_Store
{
    partial class MovieRentedForm
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
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MovieRentedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MovieRenteddataGridView = new System.Windows.Forms.DataGridView();
            this.btnNewRentedMovie = new System.Windows.Forms.Button();
            this.btnDeleteRentedMovie = new System.Windows.Forms.Button();
            this.btnUpdateRentedMovie = new System.Windows.Forms.Button();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtbxFirstName = new System.Windows.Forms.TextBox();
            this.txtbxLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtbxTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDateReturned = new System.Windows.Forms.Label();
            this.lblDateRented = new System.Windows.Forms.Label();
            this.txtbxMovieID = new System.Windows.Forms.TextBox();
            this.lblMovieID = new System.Windows.Forms.Label();
            this.txtbxCustID = new System.Windows.Forms.TextBox();
            this.lblCustID = new System.Windows.Forms.Label();
            this.btnMovieStatistics = new System.Windows.Forms.Button();
            this.dtTmPckrDateRented = new System.Windows.Forms.DateTimePicker();
            this.dtTmPckrDateReturned = new System.Windows.Forms.DateTimePicker();
            this.btnRentedOutMovies = new System.Windows.Forms.Button();
            this.btnShowALLRentedMovies = new System.Windows.Forms.Button();
            this.NavMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MovieRenteddataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // NavMenu
            // 
            this.NavMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.NavMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MoviesBtnTlStrpMnItm,
            this.customerToolStripMenuItem,
            this.MovieRentedToolStripMenuItem});
            this.NavMenu.Location = new System.Drawing.Point(0, 0);
            this.NavMenu.Name = "NavMenu";
            this.NavMenu.Size = new System.Drawing.Size(1004, 28);
            this.NavMenu.TabIndex = 1;
            this.NavMenu.Text = "Navigation Menu";
            // 
            // MoviesBtnTlStrpMnItm
            // 
            this.MoviesBtnTlStrpMnItm.Name = "MoviesBtnTlStrpMnItm";
            this.MoviesBtnTlStrpMnItm.Size = new System.Drawing.Size(70, 24);
            this.MoviesBtnTlStrpMnItm.Text = "Movies";
            this.MoviesBtnTlStrpMnItm.Click += new System.EventHandler(this.MoviesBtnTlStrpMnItm_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.customerToolStripMenuItem.Text = "Customer";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // MovieRentedToolStripMenuItem
            // 
            this.MovieRentedToolStripMenuItem.Name = "MovieRentedToolStripMenuItem";
            this.MovieRentedToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.MovieRentedToolStripMenuItem.Text = "Movie Rented";
            this.MovieRentedToolStripMenuItem.Click += new System.EventHandler(this.MovieRentedToolStripMenuItem_Click);
            // 
            // MovieRenteddataGridView
            // 
            this.MovieRenteddataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MovieRenteddataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MovieRenteddataGridView.Location = new System.Drawing.Point(12, 31);
            this.MovieRenteddataGridView.Name = "MovieRenteddataGridView";
            this.MovieRenteddataGridView.RowHeadersWidth = 51;
            this.MovieRenteddataGridView.RowTemplate.Height = 24;
            this.MovieRenteddataGridView.Size = new System.Drawing.Size(980, 271);
            this.MovieRenteddataGridView.TabIndex = 4;
            this.MovieRenteddataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MovieRenteddataGridView_CellContentClick);
            this.MovieRenteddataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MovieRenteddataGridView_CellContentClick);
            // 
            // btnNewRentedMovie
            // 
            this.btnNewRentedMovie.Location = new System.Drawing.Point(12, 322);
            this.btnNewRentedMovie.Name = "btnNewRentedMovie";
            this.btnNewRentedMovie.Size = new System.Drawing.Size(137, 53);
            this.btnNewRentedMovie.TabIndex = 14;
            this.btnNewRentedMovie.Text = "New Rented Movie";
            this.btnNewRentedMovie.UseVisualStyleBackColor = true;
            this.btnNewRentedMovie.Click += new System.EventHandler(this.btnNewRentedMovie_Click);
            // 
            // btnDeleteRentedMovie
            // 
            this.btnDeleteRentedMovie.Enabled = false;
            this.btnDeleteRentedMovie.Location = new System.Drawing.Point(315, 322);
            this.btnDeleteRentedMovie.Name = "btnDeleteRentedMovie";
            this.btnDeleteRentedMovie.Size = new System.Drawing.Size(143, 53);
            this.btnDeleteRentedMovie.TabIndex = 13;
            this.btnDeleteRentedMovie.Text = "Delete Rented Movie";
            this.btnDeleteRentedMovie.UseVisualStyleBackColor = true;
            this.btnDeleteRentedMovie.Click += new System.EventHandler(this.btnDeleteRentedMovie_Click);
            // 
            // btnUpdateRentedMovie
            // 
            this.btnUpdateRentedMovie.Enabled = false;
            this.btnUpdateRentedMovie.Location = new System.Drawing.Point(155, 322);
            this.btnUpdateRentedMovie.Name = "btnUpdateRentedMovie";
            this.btnUpdateRentedMovie.Size = new System.Drawing.Size(154, 53);
            this.btnUpdateRentedMovie.TabIndex = 12;
            this.btnUpdateRentedMovie.Text = "Update Rented Movie";
            this.btnUpdateRentedMovie.UseVisualStyleBackColor = true;
            this.btnUpdateRentedMovie.Click += new System.EventHandler(this.btnUpdateRentedMovie_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(12, 405);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(76, 17);
            this.lblFirstName.TabIndex = 15;
            this.lblFirstName.Text = "First Name";
            // 
            // txtbxFirstName
            // 
            this.txtbxFirstName.Enabled = false;
            this.txtbxFirstName.Location = new System.Drawing.Point(94, 400);
            this.txtbxFirstName.Name = "txtbxFirstName";
            this.txtbxFirstName.Size = new System.Drawing.Size(190, 22);
            this.txtbxFirstName.TabIndex = 16;
            // 
            // txtbxLastName
            // 
            this.txtbxLastName.Enabled = false;
            this.txtbxLastName.Location = new System.Drawing.Point(386, 400);
            this.txtbxLastName.Name = "txtbxLastName";
            this.txtbxLastName.Size = new System.Drawing.Size(190, 22);
            this.txtbxLastName.TabIndex = 18;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(304, 405);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(76, 17);
            this.lblLastName.TabIndex = 17;
            this.lblLastName.Text = "Last Name";
            // 
            // txtbxTitle
            // 
            this.txtbxTitle.Enabled = false;
            this.txtbxTitle.Location = new System.Drawing.Point(53, 455);
            this.txtbxTitle.Name = "txtbxTitle";
            this.txtbxTitle.Size = new System.Drawing.Size(327, 22);
            this.txtbxTitle.TabIndex = 20;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 460);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(35, 17);
            this.lblTitle.TabIndex = 19;
            this.lblTitle.Text = "Title";
            // 
            // lblDateReturned
            // 
            this.lblDateReturned.AutoSize = true;
            this.lblDateReturned.Location = new System.Drawing.Point(688, 450);
            this.lblDateReturned.Name = "lblDateReturned";
            this.lblDateReturned.Size = new System.Drawing.Size(101, 17);
            this.lblDateReturned.TabIndex = 23;
            this.lblDateReturned.Text = "Date Returned";
            // 
            // lblDateRented
            // 
            this.lblDateRented.AutoSize = true;
            this.lblDateRented.Location = new System.Drawing.Point(388, 455);
            this.lblDateRented.Name = "lblDateRented";
            this.lblDateRented.Size = new System.Drawing.Size(88, 17);
            this.lblDateRented.TabIndex = 21;
            this.lblDateRented.Text = "Date Rented";
            // 
            // txtbxMovieID
            // 
            this.txtbxMovieID.Enabled = false;
            this.txtbxMovieID.Location = new System.Drawing.Point(322, 503);
            this.txtbxMovieID.Name = "txtbxMovieID";
            this.txtbxMovieID.Size = new System.Drawing.Size(159, 22);
            this.txtbxMovieID.TabIndex = 28;
            // 
            // lblMovieID
            // 
            this.lblMovieID.AutoSize = true;
            this.lblMovieID.Location = new System.Drawing.Point(250, 508);
            this.lblMovieID.Name = "lblMovieID";
            this.lblMovieID.Size = new System.Drawing.Size(66, 17);
            this.lblMovieID.TabIndex = 27;
            this.lblMovieID.Text = "Movie ID ";
            // 
            // txtbxCustID
            // 
            this.txtbxCustID.Enabled = false;
            this.txtbxCustID.Location = new System.Drawing.Point(77, 505);
            this.txtbxCustID.Name = "txtbxCustID";
            this.txtbxCustID.Size = new System.Drawing.Size(142, 22);
            this.txtbxCustID.TabIndex = 26;
            // 
            // lblCustID
            // 
            this.lblCustID.AutoSize = true;
            this.lblCustID.Location = new System.Drawing.Point(18, 510);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(53, 17);
            this.lblCustID.TabIndex = 25;
            this.lblCustID.Text = "Cust ID";
            // 
            // btnMovieStatistics
            // 
            this.btnMovieStatistics.Location = new System.Drawing.Point(602, 322);
            this.btnMovieStatistics.Name = "btnMovieStatistics";
            this.btnMovieStatistics.Size = new System.Drawing.Size(127, 53);
            this.btnMovieStatistics.TabIndex = 29;
            this.btnMovieStatistics.Text = "Movie Rental Statistics";
            this.btnMovieStatistics.UseVisualStyleBackColor = true;
            this.btnMovieStatistics.Click += new System.EventHandler(this.btnMovieStatistics_Click);
            // 
            // dtTmPckrDateRented
            // 
            this.dtTmPckrDateRented.CustomFormat = " dd-MM-yyyy";
            this.dtTmPckrDateRented.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTmPckrDateRented.Location = new System.Drawing.Point(482, 450);
            this.dtTmPckrDateRented.Name = "dtTmPckrDateRented";
            this.dtTmPckrDateRented.Size = new System.Drawing.Size(200, 22);
            this.dtTmPckrDateRented.TabIndex = 30;
            // 
            // dtTmPckrDateReturned
            // 
            this.dtTmPckrDateReturned.CustomFormat = " dd-MM-yyyy";
            this.dtTmPckrDateReturned.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTmPckrDateReturned.Location = new System.Drawing.Point(795, 445);
            this.dtTmPckrDateReturned.Name = "dtTmPckrDateReturned";
            this.dtTmPckrDateReturned.Size = new System.Drawing.Size(200, 22);
            this.dtTmPckrDateReturned.TabIndex = 31;
            this.dtTmPckrDateReturned.ValueChanged += new System.EventHandler(this.dtTmPckrDateReturned_ValueChanged);
            // 
            // btnRentedOutMovies
            // 
            this.btnRentedOutMovies.Location = new System.Drawing.Point(735, 322);
            this.btnRentedOutMovies.Name = "btnRentedOutMovies";
            this.btnRentedOutMovies.Size = new System.Drawing.Size(127, 53);
            this.btnRentedOutMovies.TabIndex = 32;
            this.btnRentedOutMovies.Text = "Rented Out Movies";
            this.btnRentedOutMovies.UseVisualStyleBackColor = true;
            this.btnRentedOutMovies.Click += new System.EventHandler(this.btnRentedOutMovies_Click);
            // 
            // btnShowALLRentedMovies
            // 
            this.btnShowALLRentedMovies.Enabled = false;
            this.btnShowALLRentedMovies.Location = new System.Drawing.Point(868, 322);
            this.btnShowALLRentedMovies.Name = "btnShowALLRentedMovies";
            this.btnShowALLRentedMovies.Size = new System.Drawing.Size(127, 53);
            this.btnShowALLRentedMovies.TabIndex = 33;
            this.btnShowALLRentedMovies.Text = "Show ALL Rented Movies";
            this.btnShowALLRentedMovies.UseVisualStyleBackColor = true;
            this.btnShowALLRentedMovies.Click += new System.EventHandler(this.btnShowALLRentedMovies_Click);
            // 
            // MovieRentedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 552);
            this.Controls.Add(this.btnShowALLRentedMovies);
            this.Controls.Add(this.btnRentedOutMovies);
            this.Controls.Add(this.dtTmPckrDateReturned);
            this.Controls.Add(this.dtTmPckrDateRented);
            this.Controls.Add(this.btnMovieStatistics);
            this.Controls.Add(this.txtbxMovieID);
            this.Controls.Add(this.lblMovieID);
            this.Controls.Add(this.txtbxCustID);
            this.Controls.Add(this.lblCustID);
            this.Controls.Add(this.lblDateReturned);
            this.Controls.Add(this.lblDateRented);
            this.Controls.Add(this.txtbxTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtbxLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtbxFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.btnNewRentedMovie);
            this.Controls.Add(this.btnDeleteRentedMovie);
            this.Controls.Add(this.btnUpdateRentedMovie);
            this.Controls.Add(this.MovieRenteddataGridView);
            this.Controls.Add(this.NavMenu);
            this.Name = "MovieRentedForm";
            this.Text = "Movie Rented";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MovieRentedForm_FormClosed);
            this.NavMenu.ResumeLayout(false);
            this.NavMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MovieRenteddataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip NavMenu;
        private System.Windows.Forms.ToolStripMenuItem MoviesBtnTlStrpMnItm;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MovieRentedToolStripMenuItem;
        private System.Windows.Forms.DataGridView MovieRenteddataGridView;
        private System.Windows.Forms.Button btnNewRentedMovie;
        private System.Windows.Forms.Button btnDeleteRentedMovie;
        private System.Windows.Forms.Button btnUpdateRentedMovie;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtbxFirstName;
        private System.Windows.Forms.TextBox txtbxLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtbxTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDateReturned;
        private System.Windows.Forms.Label lblDateRented;
        private System.Windows.Forms.TextBox txtbxMovieID;
        private System.Windows.Forms.Label lblMovieID;
        private System.Windows.Forms.TextBox txtbxCustID;
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.Button btnMovieStatistics;
        private System.Windows.Forms.DateTimePicker dtTmPckrDateRented;
        private System.Windows.Forms.DateTimePicker dtTmPckrDateReturned;
        private System.Windows.Forms.Button btnRentedOutMovies;
        private System.Windows.Forms.Button btnShowALLRentedMovies;
    }
}