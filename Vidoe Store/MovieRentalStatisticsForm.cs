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
    public partial class MovieRentalStatisticsForm : Form
    {
        VideoStoreDBClass videoStoreDBClass = new VideoStoreDBClass();
        public MovieRentalStatisticsForm()
        {
            InitializeComponent();
        }

        private void MovieRentalStatisticsForm_Load(object sender, EventArgs e)
        {
            txtbxTheMostPopularVideo.Text = videoStoreDBClass.ShowTheMostPopularVideo().Rows[0].ItemArray[0].ToString();
            txtbxTitle.Text = videoStoreDBClass.ShowTheMostPopularVideo().Rows[0].ItemArray[1].ToString();

            txtbxTCB.Text = videoStoreDBClass.ShowWhoBorrowedTheMostVideosVideo().Rows[0].ItemArray[0].ToString();
            txtbxFirstName.Text = videoStoreDBClass.ShowWhoBorrowedTheMostVideosVideo().Rows[0].ItemArray[1].ToString();
            txtbxLastName.Text = videoStoreDBClass.ShowWhoBorrowedTheMostVideosVideo().Rows[0].ItemArray[2].ToString();

          
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
             var mRForm = new MovieRentedForm();
            mRForm.Show();
        }
    }
}
