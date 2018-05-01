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
    public partial class FrmBillManagement : Form
    {
        BL.BL_BillManagement bill;
        public FrmBillManagement()
        {
            InitializeComponent();
            bill = new BL.BL_BillManagement(this);
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToAddRows = false;
        }

        private void FrmBillManagement_Load(object sender, EventArgs e)
        {
            bill.loadForm();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < this.dataGridView1.Rows.Count)
            {
                bill.clickDataGrid(e.RowIndex);
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < this.dataGridView1.Rows.Count)
            {
                bill.clickDataGridDetail(e.RowIndex);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Do you want to Delete this ? ", "Noted", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                bill.delete();
                bill.loadForm();
                btnDelete.Enabled = false;
                MessageBox.Show("Delete successfully !");
            }
        }
    }
}
