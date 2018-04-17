using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDIO.BL
{
    
    class Bl_CustomerType
    {
        DA.DA_Customertype ct;
        GUI.FrmCustomerType frm;
        public Bl_CustomerType(GUI.FrmCustomerType frm)
        {
            ct = new DA.DA_Customertype();
            this.frm = frm;
        }
        public void LoadForm() {
            frm.dataGridView1.DataSource = ct.GetDataTableCT();
        }
        public void clickDataGrid(int index)
        {
            frm.txtID.Text = frm.dataGridView1.Rows[index].Cells[0].Value.ToString();
            frm.txtName.Text = frm.dataGridView1.Rows[index].Cells[1].Value.ToString();
            frm.txtPoint.Text = frm.dataGridView1.Rows[index].Cells[2].Value.ToString();
        }
        public void DeleteCustomer()
        {
            ct.deleteCT(frm.txtID.Text);
            this.LoadForm();
        }
    }
}
