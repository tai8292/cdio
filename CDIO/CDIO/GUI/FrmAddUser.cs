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
        BL.Commen commen = new BL.Commen();
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
            try
            {
                if (txtName.Text == "")
                {
                    MessageBox.Show("NAME must not null");
                }
                else
                if (!commen.checkAlphaNumberic(txtName.Text))
                {
                    MessageBox.Show("NAME can not contain special character");
                }
                else
                if (txtName.Text.Length < 6)
                {
                    MessageBox.Show("Name must be at least 6 characters long.");
                }
                else
                {
                    bl.saveDish();
                    MessageBox.Show("You have successfully added the account with the default password is :123456!");
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Add User Failed");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtName.Clear();
        }

        private void btnCancer_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Do you want to Cancel this Form Add Position? ", "Noted", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                this.Close();
        }
        
        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text.Length < 6)
                MessageBox.Show("Name must be at least 6 characters long.");
        }
        
    }
}
