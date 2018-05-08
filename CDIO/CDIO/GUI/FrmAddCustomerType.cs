using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDIO.GUI
{
    public partial class FrmAddCustomerType : Form
    {
        BL.Bl_AddCustomerType bl;
        public FrmAddCustomerType()
        {
            InitializeComponent();
            bl = new BL.Bl_AddCustomerType(this);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text == "" || txtName.Text == "")
                {


                    MessageBox.Show("ID or Name must not null");

                }
                else

                 if (Regex.IsMatch(txtID.Text, @"[^a-zA-Z0-9 ]+"))
                {
                    if (DialogResult.Yes == MessageBox.Show(" ID or Name not has character special")) ;
                }
                else
                    if (Regex.IsMatch(txtName.Text, @"[^a-zA-Z0-9 ]+"))
                {
                    if (DialogResult.Yes == MessageBox.Show(" ID or Name not has character special")) ;
                }

                else
                {
                    bl.AddCT();
                    MessageBox.Show("add successful");
                    this.Close();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Add Customer Type failed");
            }
        }
        private void btnCancer_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Do you want close form Add?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            this.Close();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtName.Clear();
            txtPoint.Clear();
        }
        private void txtID_Validated(object sender, EventArgs e)
        {
            if (txtID.Text == "")//ID bị bỏ trống
            {
                MessageBox.Show("ID not null");
            }
            if (Regex.IsMatch(txtID.Text, @"[^a-zA-Z0-9 ]+"))//ID có các kí tự đặc biệt
            {
                MessageBox.Show("Not enter special characters ");
            }
            return;
        }

        private void txtName_Validated(object sender, EventArgs e)
        {
            if (txtName.Text == "")//Name bị bỏ trống
            {
                MessageBox.Show("Name not null");
            }
            if (Regex.IsMatch(txtName.Text, @"[^a-zA-Z0-9 ]+"))//Name có các kí tự đặc biệt
            {
                MessageBox.Show("Not enter special characters ");
            }
            return;
        }

        
    } }
