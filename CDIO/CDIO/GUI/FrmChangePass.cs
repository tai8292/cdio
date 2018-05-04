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
    public partial class FrmChangePass : Form
    {
        string empID;
        DA.DA_User dA_User;
        public FrmChangePass()
        {
            InitializeComponent();
        }

        public FrmChangePass(string empID)
        {
            InitializeComponent();
            this.empID = empID;
            dA_User = new DA.DA_User();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(this.txtOldPass.Text == dA_User.getPassword(this.empID))
            {
                if(txtNewPass.Text == txtComfirmPass.Text)
                {
                    dA_User.updatePassword(this.empID, txtNewPass.Text);
                    MessageBox.Show("Change password succesful");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("New password and comfirm password must be same");
                }
            }
            else
            {
                MessageBox.Show("Old password is incorrect");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtOldPass.Clear();
            this.txtNewPass.Clear();
            this.txtComfirmPass.Clear();
            this.txtOldPass.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
