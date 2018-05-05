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
    public partial class FrmDeleteTable : Form
    {
        BL.BL_DeleteTable table;
        public FrmDeleteTable()
        {
            InitializeComponent();
            table = new BL.BL_DeleteTable(this);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (table.deleteTable() == 0)
            {
                MessageBox.Show("Table in use");
            }
            else {
                MessageBox.Show("Delete table success");
                this.Close();
            }
        }

        private void FrmDeleteTable_Load(object sender, EventArgs e)
        {
            table.loadCB();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
