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
    public partial class FrmCustomer : Form
    {
        BL.BL_Customer customer;
        public FrmCustomer()
        {
            InitializeComponent();
            customer = new BL.BL_Customer(this);
            this.dataGridView1.AllowUserToAddRows = false;
        }

        private void btnAddPosition_Click(object sender, EventArgs e)
        {
            FrmAddCustomer frm = new FrmAddCustomer();
            frm.ShowDialog();
            customer.loadForm();
        }

        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            customer.loadCombobox();
            customer.loadForm();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < this.dataGridView1.Rows.Count)
            {
                customer.clickDataGrid(e.RowIndex);
                btnDelete.Enabled = true;
                btnEdit.Enabled = true;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FrmEditCustomer frm = new FrmEditCustomer(txtID.Text, txtName.Text,txtAddress.Text,txtPhone.Text,cbType.SelectedValue.ToString(),txtPoint.Text);
            frm.ShowDialog();
            customer.loadForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Do you want to Delete this employee? ", "Noted", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                customer.deleteCustomer();
                customer.loadForm();
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
                MessageBox.Show("You have successfully delete a customer !");
            }        
        }
    }
}
