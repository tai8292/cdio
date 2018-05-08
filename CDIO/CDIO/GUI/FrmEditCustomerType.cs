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
    public partial class FrmEditCustomerType : Form
    {
        BL.Bl_EditCustomerType bl;
        string ID;
        string name;
        string Point;
        public FrmEditCustomerType()
        {
            InitializeComponent();
            bl = new BL.Bl_EditCustomerType(this);
        }
        public FrmEditCustomerType(string id,string name,string point)
        {
            InitializeComponent();
            bl = new BL.Bl_EditCustomerType(this);
            this.ID = id;
            this.name = name;
            this.Point = point;
        }
        /*private void FrmEditCusTomerType_Load(object sender, EventArgs e)
        {

            this.loadForm();
        }*/
        public void loadform()
        {
            txtID.Text = ID;
            txtName.Text = name;
            txtPoint.Text = Point;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Name is must not null");
            }
            else

                if (Regex.IsMatch(txtName.Text, @"[^a-zA-Z0-9 ]+"))
                {
                    MessageBox.Show(" Name not has character special");
                }
            
            else
            {
                bl.EditCT();
                MessageBox.Show("Edit successful");
                this.Close();
            }
        }

        private void FrmEditCustomerType_Load(object sender, EventArgs e)
        {
            this.loadform();
        }

       

        private void btnCancer_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes==MessageBox.Show("Do you want close form Edit?","Notification",MessageBoxButtons.YesNo));
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            
            txtName.Clear();
            txtPoint.Clear();
        }
       
       
    }
}
