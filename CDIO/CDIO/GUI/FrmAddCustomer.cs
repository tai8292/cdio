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
    public partial class FrmAddCustomer : Form
    {
        BL.BL_AddCustomer customer;
        public FrmAddCustomer()
        {
            InitializeComponent();
            customer = new BL.BL_AddCustomer(this);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtAddress.Text != "" && txtPhone.Text != "" && txtPoint.Text != "")
            {
                if (txtPhone.Text.All(char.IsDigit) == true && txtPoint.Text.All(char.IsDigit) == true)
                {
                    customer.addCustomer();
                    MessageBox.Show("You have successfully add a new customer !");
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            txtPoint.Clear();
        }

        private void FrmAddCustomer_Load(object sender, EventArgs e)
        {
            customer.loadCombobox();
        }

        private void btnCancer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAddCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("Do you want to cancel?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                e.Cancel = true;
        }
    }
}
