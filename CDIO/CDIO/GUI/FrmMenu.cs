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
            loadForm();
        }

        public void loadForm()
        {
            menu.loadCombobox();
            menu.loadForm();
        }

        private void btnAddDish_Click(object sender, EventArgs e)
        {
            FrmMenuAddDish f = new FrmMenuAddDish();
            f.ShowDialog();
            loadForm();
            clearComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < this.dataGridView1.Rows.Count)
            {
                this.btnEdit.Enabled = true;
                this.btnDelete.Enabled = true;
                menu.clickDataGrid(e.RowIndex);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Do you want to delete this dish?", "Notice", MessageBoxButtons.YesNo))
            {
                menu.deleteDish();
                MessageBox.Show("Delete dish successfully");
                loadForm();
                clearComponent();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FrmEditDish f = new FrmEditDish(txtID.Text,txtName.Text,txtKind.SelectedValue.ToString(),txtNumber.Text,txtPrice.Text,picture.Image);
            f.ShowDialog();
            loadForm();
            clearComponent();
        }

        public void clearComponent()
        {
            this.txtID.Clear();
            this.txtName.Clear();
            this.txtNumber.Clear();
            this.txtPrice.Clear();
            this.picture.Image = Image.FromFile("D:/projectCDIO/projectCDIO/cdio/CDIO/CDIO/food.png");
        }
    }
}
