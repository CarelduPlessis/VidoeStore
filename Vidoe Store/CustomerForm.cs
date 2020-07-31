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
    public partial class CustomerForm : Form
    {
        VideoStoreDBClass videoStoreDBClass = new VideoStoreDBClass();
        public CustomerForm()
        {
            InitializeComponent();
            CustomerdataGridView.DataSource = videoStoreDBClass.ShowCustomer();
        }

        private void MovieRentedBtnTlStrpMnItm_Click(object sender, EventArgs e)
        {
            this.Hide();

            MovieRentedForm movieRentedUI = new MovieRentedForm();

            movieRentedUI.Show();
        }

        private void CustomerBtnTlStrpMnItm_Click(object sender, EventArgs e)
        {
            // do nothing as this is Customer Form
        }

        private void MoviesBtnTlStrpMnItm_Click(object sender, EventArgs e)
        {
            this.Hide();

            MoviesForm movieUI = new MoviesForm();

            movieUI.Show();
        }

        
        int customerIndex = 0; // selected index data / CustomerIndex
        private void CustomerdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = CustomerdataGridView.Rows[rowIndex];
                customerIndex = Convert.ToInt32(row.Cells[0].Value);
                txtbxFirstName.Text = row.Cells[1].Value.ToString();
                txtbxLastName.Text = row.Cells[2].Value.ToString();
                txtbxAddress.Text = row.Cells[3].Value.ToString();
                txtbxPhone.Text = row.Cells[4].Value.ToString();

                VideoStoreDBClass.CustomerID = customerIndex;
                VideoStoreDBClass.FirstName = txtbxFirstName.Text;
                VideoStoreDBClass.LastName = txtbxLastName.Text;
            }
            catch
            {

            }
            btnUpdateCustomer.Enabled = true;
            btnDeleteCustomer.Enabled = true;
        }
        private void btnNewCustomer_Click(object sender, EventArgs e)
        {

            if (txtbxFirstName.Text != "" && txtbxLastName.Text != "" && txtbxAddress.Text != "" && txtbxPhone.Text != "") {
                videoStoreDBClass.NewCustomer(txtbxFirstName.Text, txtbxLastName.Text, txtbxAddress.Text, txtbxPhone.Text);
                CustomerdataGridView.DataSource = videoStoreDBClass.ShowCustomer();
            } else {
                MessageBox.Show("There can't be empty textboxes");
            }
        }
        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (txtbxFirstName.Text != "" && txtbxLastName.Text != "" && txtbxAddress.Text != "" && txtbxPhone.Text != "")
            {
                videoStoreDBClass.UpdateCustomer(customerIndex, txtbxFirstName.Text, txtbxLastName.Text, txtbxAddress.Text, txtbxPhone.Text);
                CustomerdataGridView.DataSource = videoStoreDBClass.ShowCustomer();
            } else {
                MessageBox.Show("There can't be empty textboxes");
            }
            btnUpdateCustomer.Enabled = false;
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            videoStoreDBClass.DeleteCustomer(customerIndex);
            CustomerdataGridView.DataSource = videoStoreDBClass.ShowCustomer();
            btnDeleteCustomer.Enabled = false;
        }

        private void CustomerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }
    }
}
