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
    public partial class FrmDeleteBill : Form
    {
        public FrmDeleteBill()
        {
            InitializeComponent();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Do you want to Delete this ? ", "Noted", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                DA.DA_BillManagement bill = new DA.DA_BillManagement();
                bill.deleteDetail(dtFromdate.Value.ToString(), dtTodate.Value.ToString());
                MessageBox.Show("You have successfully delete an employee !");
            }
        }

        private void FrmDeleteBill_Load(object sender, EventArgs e)
        {
            DateTime d = DateTime.Today;
            d = d.AddDays(-1);
            this.dtTodate.MaxDate = d;
            this.dtFromdate.MaxDate = d;

        }



        private void dtFromdate_ValueChanged(object sender, EventArgs e)
        {
            this.dtFromdate.MaxDate = this.dtTodate.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
