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
    public partial class FrmPosition : Form
    {
        BL.BL_Position blPosition;
       
        public FrmPosition()
        {
            InitializeComponent();
            blPosition = new BL.BL_Position(this);
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            FrmEditPosition frm = new FrmEditPosition(txtID.Text,txtName.Text);
            frm.ShowDialog();
            LoadForm();
        }

       
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if( DialogResult.Yes == MessageBox.Show("Do you want to Delete this Position? ","Noted", MessageBoxButtons.YesNo,   MessageBoxIcon.Question))
                
            blPosition.deletePosition();

        }

        private void btnAddPosition_Click(object sender, EventArgs e)
        {
            GUI.FrmAddPosition frm = new FrmAddPosition();
            frm.ShowDialog();
            LoadForm();
           
        }

        private void FrmPosition_Load(object sender, EventArgs e)
        {
            this.LoadForm();
        }
        public void LoadForm()
        {
            blPosition.loadDataGridview();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            blPosition.clickDataGrid(e.RowIndex);
        }
    }
}
