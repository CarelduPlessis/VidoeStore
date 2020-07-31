namespace Vidoe_Store
{
    partial class CustomerForm
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
            this.CustomerdataGridView = new System.Windows.Forms.DataGridView();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnNewCustomer = new System.Windows.Forms.Button();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtbxFirstName = new System.Windows.Forms.TextBox();
            this.txtbxLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtbxAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtbxPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.NavMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerdataGridView)).BeginInit();
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
            this.NavMenu.Size = new System.Drawing.Size(800, 28);
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
            // CustomerdataGridView
            // 
            this.CustomerdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CustomerdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerdataGridView.Location = new System.Drawing.Point(12, 31);
            this.CustomerdataGridView.Name = "CustomerdataGridView";
            this.CustomerdataGridView.RowHeadersWidth = 51;
            this.CustomerdataGridView.RowTemplate.Height = 24;
            this.CustomerdataGridView.Size = new System.Drawing.Size(776, 271);
            this.CustomerdataGridView.TabIndex = 5;
            this.CustomerdataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerdataGridView_CellContentClick);
            this.CustomerdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerdataGridView_CellContentClick);
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Enabled = false;
            this.btnUpdateCustomer.Location = new System.Drawing.Point(155, 321);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(147, 53);
            this.btnUpdateCustomer.TabIndex = 6;
            this.btnUpdateCustomer.Text = "Update Customer";
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Enabled = false;
            this.btnDeleteCustomer.Location = new System.Drawing.Point(308, 321);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(143, 53);
            this.btnDeleteCustomer.TabIndex = 7;
            this.btnDeleteCustomer.Text = "Delete Customer";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.Location = new System.Drawing.Point(12, 321);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Size = new System.Drawing.Size(137, 53);
            this.btnNewCustomer.TabIndex = 8;
            this.btnNewCustomer.Text = "New Customer";
            this.btnNewCustomer.UseVisualStyleBackColor = true;
            this.btnNewCustomer.Click += new System.EventHandler(this.btnNewCustomer_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(12, 416);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(76, 17);
            this.lblFirstName.TabIndex = 9;
            this.lblFirstName.Text = "First Name";
            // 
            // txtbxFirstName
            // 
            this.txtbxFirstName.Location = new System.Drawing.Point(94, 413);
            this.txtbxFirstName.Name = "txtbxFirstName";
            this.txtbxFirstName.Size = new System.Drawing.Size(166, 22);
            this.txtbxFirstName.TabIndex = 10;
            // 
            // txtbxLastName
            // 
            this.txtbxLastName.Location = new System.Drawing.Point(94, 457);
            this.txtbxLastName.Name = "txtbxLastName";
            this.txtbxLastName.Size = new System.Drawing.Size(166, 22);
            this.txtbxLastName.TabIndex = 12;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(12, 462);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(76, 17);
            this.lblLastName.TabIndex = 11;
            this.lblLastName.Text = "Last Name";
            // 
            // txtbxAddress
            // 
            this.txtbxAddress.Location = new System.Drawing.Point(381, 413);
            this.txtbxAddress.Name = "txtbxAddress";
            this.txtbxAddress.Size = new System.Drawing.Size(166, 22);
            this.txtbxAddress.TabIndex = 14;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(315, 416);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(60, 17);
            this.lblAddress.TabIndex = 13;
            this.lblAddress.Text = "Address";
            // 
            // txtbxPhone
            // 
            this.txtbxPhone.Location = new System.Drawing.Point(367, 462);
            this.txtbxPhone.Name = "txtbxPhone";
            this.txtbxPhone.Size = new System.Drawing.Size(166, 22);
            this.txtbxPhone.TabIndex = 16;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(315, 465);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(49, 17);
            this.lblPhone.TabIndex = 15;
            this.lblPhone.Text = "Phone";
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 511);
            this.Controls.Add(this.txtbxPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtbxAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtbxLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtbxFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.btnNewCustomer);
            this.Controls.Add(this.btnDeleteCustomer);
            this.Controls.Add(this.btnUpdateCustomer);
            this.Controls.Add(this.CustomerdataGridView);
            this.Controls.Add(this.NavMenu);
            this.Name = "CustomerForm";
            this.Text = "Customer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CustomerForm_FormClosed);
            this.NavMenu.ResumeLayout(false);
            this.NavMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip NavMenu;
        private System.Windows.Forms.ToolStripMenuItem MoviesBtnTlStrpMnItm;
        private System.Windows.Forms.ToolStripMenuItem CustomerBtnTlStrpMnItm;
        private System.Windows.Forms.ToolStripMenuItem MovieRentedBtnTlStrpMnItm;
        private System.Windows.Forms.DataGridView CustomerdataGridView;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button btnNewCustomer;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtbxFirstName;
        private System.Windows.Forms.TextBox txtbxLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtbxAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtbxPhone;
        private System.Windows.Forms.Label lblPhone;
    }
}