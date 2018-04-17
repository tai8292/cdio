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
    public partial class FrmAddUser : Form
    {
        BL.BL_AddUser bl;
        public FrmAddUser()
        {
            InitializeComponent();
            bl = new BL.BL_AddUser(this);
        }

        private void FrmAddUser_Load(object sender, EventArgs e)
        {
            bl.loadCombobox();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bl.saveDish();
            MessageBox.Show("You have successfully added the account with the default password is :123456!");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtName.Clear();
        }

        private void btnCancer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAddUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("Do you want to cancer?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                e.Cancel = true;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
