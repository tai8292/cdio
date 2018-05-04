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
    public partial class FrmUser : Form
    {
        BL.User user;
        public FrmUser()
        {
            InitializeComponent();
            user = new BL.User(this);
            this.dataGridView1.AllowUserToAddRows = false;
        }

        private void FrmUser_Load(object sender, EventArgs e)
        {
            user.loadForm();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < this.dataGridView1.Rows.Count)
            {
                user.clickDataGrid(e.RowIndex);
                btnDelete.Enabled = true;
                btnReset.Enabled = true;
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            FrmAddUser f = new FrmAddUser();
            f.ShowDialog();
            txtID.Clear();
            txtName.Clear();
            user.loadForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Do you want to Delete this User? ", "Noted", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                user.deleteUser();
                user.loadForm();
                txtID.Clear();
                txtName.Clear();
                btnDelete.Enabled = false;
                btnReset.Enabled = false;
                MessageBox.Show("You deleted successfully!");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Do you want to Reset this User? ", "Noted", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                user.resetUser();
                user.loadForm();
                btnDelete.Enabled = false;
                btnReset.Enabled = false;
                MessageBox.Show("You have successfully reset the password, the default password is :123456!");
            }
        }
    }
}
