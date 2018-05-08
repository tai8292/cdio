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
    public partial class FrmCustomerType : Form

    {
        BL.Bl_CustomerType ct;
        public FrmCustomerType()
        {
            InitializeComponent();
            ct = new BL.Bl_CustomerType(this);
        }

        private void btnAddCustomerType_Click(object sender, EventArgs e)
        {
            FrmAddCustomerType frm = new FrmAddCustomerType();
            frm.ShowDialog();
            LoadForm();

        }

        private void FrmCustomerType_Load(object sender, EventArgs e)
        {
            this.LoadForm();
        }
        public void LoadForm()
        {
            ct.LoadForm();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ct.clickDataGrid(e.RowIndex);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want delete " + txtID.Text + "? if want click Yes, if not click No ", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ct.DeleteCustomer();
                this.txtID.Clear();
                this.txtName.Clear();
                this.txtPoint.Clear();
                LoadForm();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FrmEditCustomerType frm = new FrmEditCustomerType(txtID.Text,txtName.Text,txtPoint.Text);
            frm.ShowDialog();
            LoadForm();
        }
    }
}
