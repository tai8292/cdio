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
            bl.AddCT();
            MessageBox.Show("add sucessfull");
            this.Close();
        }
    }
}
