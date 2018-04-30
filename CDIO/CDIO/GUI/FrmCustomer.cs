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
        BL.BL_Customer blCustomer;
        public FrmCustomer()
        {

            InitializeComponent();
            blCustomer = new BL.BL_Customer(this);
        }
        private void btnAddPosition_Click(object sender, EventArgs e)
        {
            FrmCustomerAdd f = new FrmCustomerAdd();
                f.ShowDialog();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            blCustomer.clickDataGrid(e.RowIndex);
        }

        private void FrmCustomer_Load_1(object sender, EventArgs e)
        {
            blCustomer.loadCombobox();
            blCustomer.loadForm();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            blCustomer.clickDataGrid(e.RowIndex);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            blCustomer.loadForm();
            blCustomer.deleteCostomer();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show(blCustomer.ADD().ToString());
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FrmEditCustomer f = new FrmEditCustomer();
            f.ShowDialog();
        }
    }
}
