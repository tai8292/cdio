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
    public partial class FrmBill : Form
    {
        BL.BL_Bill bill;
        public FrmBill()
        {
            InitializeComponent();
            bill = new BL.BL_Bill(this);
            this.dataGridView1.AllowUserToAddRows = false;
        }

        private void FrmBill_Load(object sender, EventArgs e)
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
    }
}
