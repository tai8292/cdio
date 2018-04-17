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
        }

        private void FrmUser_Load(object sender, EventArgs e)
        {
            user.loadForm();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            user.clickDataGrid(e.RowIndex);
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            FrmAddUser f = new FrmAddUser();
            f.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Do you want to Delete this User? ", "Noted", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                user.deleteUser();
                user.loadForm();
                MessageBox.Show("You deleted successfully!");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Do you want to Reset this User? ", "Noted", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                user.resetUser();
                user.loadForm();
                MessageBox.Show("You have successfully reset the password, the default password is :123456!");
            }
        }
    }
}
