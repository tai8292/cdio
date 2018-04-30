using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDIO.BL
{
    class BL_Customer
    {
        DA.DA_Customer customer;
        DA.DA_Customertype custype;
        GUI.FrmCustomer frm;
        public BL_Customer(GUI.FrmCustomer f)
        {
            frm = f;
            customer = new DA.DA_Customer();
            custype = new DA.DA_Customertype();
        }
        public void loadForm() {
            frm.dataGridView1.DataSource = customer.getDataTableCustomer();
        }
        public void loadCombobox()
        {
            frm.cbType.DataSource = custype.GetDataTableCT();
            frm.cbType.ValueMember = "Customer type ID";
            frm.cbType.DisplayMember = "Customer name";
        }
        public void clickDataGrid(int index)
        {
            frm.txtID.Text = frm.dataGridView1.Rows[index].Cells[0].Value.ToString();
            frm.txtName.Text = frm.dataGridView1.Rows[index].Cells[1].Value.ToString();
            frm.txtAddress.Text = frm.dataGridView1.Rows[index].Cells[2].Value.ToString();
            frm.txtPhone.Text = frm.dataGridView1.Rows[index].Cells[3].Value.ToString();
            frm.cbType.Text = frm.dataGridView1.Rows[index].Cells[4].Value.ToString();
            frm.txtPoint.Text = frm.dataGridView1.Rows[index].Cells[5].Value.ToString();
        }
        public void deleteCustomer()
        {
            customer.deleteCustomer(frm.txtID.Text);
            this.loadForm();
        }
    }  
}
