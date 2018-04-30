using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDIO.GUI
{
    public partial class FrmEditCustomer : Form
    {
        string id;
        string name;
        string address;
        string phone;
        string cusid;
        string point;
        BL.BL_EditCustomer customer;

        public FrmEditCustomer()
        {
            InitializeComponent();
        }
        public FrmEditCustomer(string id, string name,string address, string phone,string cusid,string point)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.phone = phone;
            this.cusid = cusid;
            this.point = point;
            InitializeComponent();
            customer = new BL.BL_EditCustomer(this);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtAddress.Text != "" && txtPhone.Text != "" && txtPoint.Text!="")
            {
                if (txtPhone.Text.All(char.IsDigit) == true && txtPoint.Text.All(char.IsDigit) == true)
                {
                    customer.editCustomer();
                    MessageBox.Show("You have successfully edit a customer !");
                }
                else
                {
                    MessageBox.Show("Phone and point must be a number !");
                }
            }
            else
            {
                MessageBox.Show("All field must not be empty !");
            }
        }

        public void loadForm()
        {
            txtID.Text = id;
            txtName.Text = name;
            txtAddress.Text = address;
            txtPhone.Text = phone;
            cbType.Text = cusid;
            txtPoint.Text = point;
        }

        private void FrmEditCustomer_Load(object sender, EventArgs e)
        {
            customer.loadCombobox();
            this.loadForm();
        }

        private void btnCancer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmEditCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("Do you want to cancel?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                e.Cancel = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            txtPoint.Clear();
        }
    }
}
