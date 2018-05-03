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
    public partial class FrmAddTable : Form
    {
        BL.BL_AddTable table;
        BL.Commen com=new BL.Commen();
        public FrmAddTable()
        {
            InitializeComponent();
            table = new BL.BL_AddTable(this);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (com.CheckIsNumber(txtID.Text))
            {
                if (table.addTable() == 0)
                {
                    MessageBox.Show("Table already exist");
                }
                else
                {
                    MessageBox.Show("Add table success");
                    this.Close();
                }
            }
            else {
                MessageBox.Show("Table ID must be number!");
            }
        }
    }
}
