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
        public void loadform()
        {
            txtID.Text = ID;
            txtName.Text = name;
            txtPoint.Text = Point;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
           bl.EditCT();
            MessageBox.Show("Edit sucessfull");
            this.Close();
        }

        private void FrmEditCustomerType_Load(object sender, EventArgs e)
        {
            this.loadform();
        }
    }
}
