using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vidoe_Store
{
    public partial class MoviesForm : Form
    {
        VideoStoreDBClass videoStoreDBClass = new VideoStoreDBClass();
        public MoviesForm()
        {
            InitializeComponent();

            // This is form 1
            MoviesdataGridView.DataSource = videoStoreDBClass.ShowMovies();
        }
       
        private void CustomerBtnTlStrpMnItm_Click(object sender, EventArgs e)
        {
            this.Hide();

            CustomerForm customerUI = new CustomerForm();

            customerUI.Show();
        }

        private void MovieRentedBtnTlStrpMnItm_Click(object sender, EventArgs e)
        {
            this.Hide();

            MovieRentedForm movieRentedUI = new MovieRentedForm();

            movieRentedUI.Show();
        }

        private void MoviesBtnTlStrpMnItm_Click(object sender, EventArgs e)
        {
            // do nothing as this is Movies Form
        }

        
        int movieIndex = 0; // selected index data / movie
        private void MoviesdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = MoviesdataGridView.Rows[rowIndex];
                movieIndex = Convert.ToInt32(row.Cells[0].Value);
                txtbxMovieTitle.Text = row.Cells[2].Value.ToString();
                txtbxYear.Text = row.Cells[3].Value.ToString();
                txtbxGenre.Text = row.Cells[7].Value.ToString();
                txtbxRating.Text = row.Cells[1].Value.ToString();
                txtbxRentalCost.Text = row.Cells[4].Value.ToString();
                txtbxCopies.Text = row.Cells[5].Value.ToString();
                txtbxPlot.Text = row.Cells[6].Value.ToString();

                VideoStoreDBClass.MovieID = movieIndex;
                VideoStoreDBClass.MovieTitle = txtbxMovieTitle.Text;
            } catch{
           
            }
            btnUpdateMovie.Enabled = true;
            btnDeleteMovie.Enabled = true;
        }

        private void btnNewMovie_Click(object sender, EventArgs e)
        {
            if (txtbxMovieTitle.Text != "" && txtbxRating.Text != "" && txtbxYear.Text != "" && txtbxRentalCost.Text != "" && txtbxCopies.Text != "" && txtbxPlot.Text != "" && txtbxGenre.Text != "") {
                videoStoreDBClass.NewMovie(txtbxRating.Text, txtbxMovieTitle.Text, txtbxYear.Text, txtbxRentalCost.Text, txtbxCopies.Text, txtbxPlot.Text, txtbxGenre.Text);
                MoviesdataGridView.DataSource = videoStoreDBClass.ShowMovies();
            } else {
                MessageBox.Show("There can't be empty textboxes");
            }
        }

        private void btnUpdateMovie_Click(object sender, EventArgs e)
        {
            if (txtbxMovieTitle.Text != "" && txtbxRating.Text != "" && txtbxYear.Text != "" && txtbxRentalCost.Text != "" && txtbxCopies.Text != "" && txtbxPlot.Text != "" && txtbxGenre.Text != "")
            {
                videoStoreDBClass.UpdateMovie(movieIndex, txtbxRating.Text, txtbxMovieTitle.Text, txtbxYear.Text, txtbxRentalCost.Text, txtbxCopies.Text, txtbxPlot.Text, txtbxGenre.Text);
                MoviesdataGridView.DataSource = videoStoreDBClass.ShowMovies();
            } else{
                MessageBox.Show("There can't be empty textboxes");
            }
            btnUpdateMovie.Enabled = false;
        }

        private void btnDeleteMovie_Click(object sender, EventArgs e)
        {
            videoStoreDBClass.DeleteMovie(movieIndex);
            MoviesdataGridView.DataSource = videoStoreDBClass.ShowMovies();
            btnDeleteMovie.Enabled = false;
        }

        private void MoviesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
