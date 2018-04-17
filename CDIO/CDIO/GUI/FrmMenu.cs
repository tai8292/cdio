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
    public partial class FrmMenu : Form
    {
        BL.Menu menu;
        public FrmMenu()
        {
            InitializeComponent();
            menu = new BL.Menu(this);
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            menu.loadCombobox();
            menu.loadForm();
        }

        private void btnAddDish_Click(object sender, EventArgs e)
        {
            FrmMenuAddDish f = new FrmMenuAddDish();
            f.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < this.dataGridView1.Rows.Count)
            {
                menu.clickDataGrid(e.RowIndex);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            menu.deleteDish();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FrmEditDish f = new FrmEditDish(txtID.Text,txtName.Text,txtKind.SelectedValue.ToString(),txtNumber.Text,txtPrice.Text,picture.Image);
            f.ShowDialog();
        }
    }
}
