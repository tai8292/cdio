using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDIO
{
    public partial class FrmLogin : Form
    {
        DA.DA_User daUser;
        public FrmLogin()
        {
            InitializeComponent();
            daUser = new DA.DA_User();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(DialogResult.No == MessageBox.Show("Do you want to exit?","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning))
            {
                e.Cancel = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (daUser.checkUser(txtUsername.Text, txtPassword.Text))
            {
                string id = daUser.getEmployeeID(txtUsername.Text);
                GUI.FrmMain f = new GUI.FrmMain(id);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Username or password not correct, Try againt");
            }
        }
    }
}
