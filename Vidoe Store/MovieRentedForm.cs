using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vidoe_Store
{
    public partial class MovieRentedForm : Form
    {
        VideoStoreDBClass videoStoreDBClass = new VideoStoreDBClass();
        public MovieRentedForm()
        {
            InitializeComponent();
            MovieRenteddataGridView.DataSource = videoStoreDBClass.ShowRentedMovies();

            txtbxCustID.Text = VideoStoreDBClass.CustomerID.ToString();
            txtbxFirstName.Text = VideoStoreDBClass.FirstName;
            txtbxLastName.Text = VideoStoreDBClass.LastName;
            txtbxMovieID.Text = VideoStoreDBClass.MovieID.ToString();
            txtbxTitle.Text = VideoStoreDBClass.MovieTitle;

            dtTmPckrDateReturned.CustomFormat = " ";
        }

        private void MovieRentedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // do nothing as this is Movie Rented From
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            CustomerForm customerUI = new CustomerForm();

            customerUI.Show();
        }

        private void MoviesBtnTlStrpMnItm_Click(object sender, EventArgs e)
        {
            this.Hide();

            MoviesForm moviesUI = new MoviesForm();

            moviesUI.Show();
        }

        private void btnMovieStatistics_Click(object sender, EventArgs e)
        {
            this.Hide();

            MovieRentalStatisticsForm mrsUI = new MovieRentalStatisticsForm();

            mrsUI.Show();

        }

        int movieRentedIndex = 0; // selected index data / MovieRentedIndex
        private void MovieRenteddataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = MovieRenteddataGridView.Rows[rowIndex];

                movieRentedIndex = Convert.ToInt32(row.Cells[0].Value);

                txtbxFirstName.Text = row.Cells[4].Value.ToString();
                txtbxLastName.Text = row.Cells[5].Value.ToString();
                txtbxTitle.Text = row.Cells[2].Value.ToString();

                dtTmPckrDateRented.Value = Convert.ToDateTime(row.Cells[6].Value);
                dtTmPckrDateReturned.Value = Convert.ToDateTime(row.Cells[7].Value);
                txtbxCustID.Text = row.Cells[3].Value.ToString();
                txtbxMovieID.Text = row.Cells[1].Value.ToString();
            }
            catch
            {

            }
            btnDeleteRentedMovie.Enabled = true;
            btnUpdateRentedMovie.Enabled = true;
        }

        private void btnNewRentedMovie_Click(object sender, EventArgs e)
        {
            if (txtbxMovieID.Text != "0" && txtbxCustID.Text != "0") {
                videoStoreDBClass.NewMovieRented(txtbxMovieID.Text, txtbxCustID.Text, dtTmPckrDateRented.Value);
                MovieRenteddataGridView.DataSource = videoStoreDBClass.ShowRentedMovies();
            }else {
                MessageBox.Show("There can't be empty textboxes");
            }
        }

        private void btnUpdateRentedMovie_Click(object sender, EventArgs e)
        {

            if (txtbxMovieID.Text != "0" && txtbxCustID.Text != "0" && dtTmPckrDateReturned.Value != null)
            {
                videoStoreDBClass.UpdateMovieRented(movieRentedIndex, txtbxMovieID.Text, txtbxCustID.Text, dtTmPckrDateRented.Value, dtTmPckrDateReturned.Value);
                MovieRenteddataGridView.DataSource = videoStoreDBClass.ShowRentedMovies();
            }else{
                MessageBox.Show("There can't be empty textboxes");
            }
            btnUpdateRentedMovie.Enabled = false;
        }

        private void btnDeleteRentedMovie_Click(object sender, EventArgs e)
        {
           videoStoreDBClass.DeleteMovieRented(movieRentedIndex);
           MovieRenteddataGridView.DataSource = videoStoreDBClass.ShowRentedMovies();
           btnDeleteRentedMovie.Enabled = false;
        }

        private void MovieRentedForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void dtTmPckrDateReturned_ValueChanged(object sender, EventArgs e)
        {
            dtTmPckrDateReturned.CustomFormat = "dd-MM-yyyy";
            btnUpdateRentedMovie.Enabled = true;
        }

        private void btnRentedOutMovies_Click(object sender, EventArgs e)
        {
            MovieRenteddataGridView.DataSource = videoStoreDBClass.ShowRentedOutMovies();
            btnShowALLRentedMovies.Enabled = true;
            btnRentedOutMovies.Enabled = false;
        }

        private void btnShowALLRentedMovies_Click(object sender, EventArgs e)
        {
            MovieRenteddataGridView.DataSource = videoStoreDBClass.ShowRentedMovies();
            btnShowALLRentedMovies.Enabled = false;
            btnRentedOutMovies.Enabled = true;
        }
    }

}
