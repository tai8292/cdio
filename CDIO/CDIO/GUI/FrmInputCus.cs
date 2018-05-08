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
    public partial class FrmInputCus : Form
    {
        DA.DataProvider dp = new DA.DataProvider();
        public string cusID ="1";
        public FrmInputCus()
        {
            InitializeComponent();
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            string sql = "select count(*) from CUSTOMER where CustomerID like '" + txtInput.Text + "'";
            if (dp.ExcuScalar(sql) == 1)
            {
                cusID = txtInput.Text;
                this.Close();
            }
            else
            {
                MessageBox.Show("Customer ID not correct");
            }
        }

        private void FrmInputCus_Load(object sender, EventArgs e)
        {
            this.txtInput.Focus();
        }
    }
}
