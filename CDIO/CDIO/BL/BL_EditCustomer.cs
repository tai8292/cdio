using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CDIO.BL
{
    class BL_EditCustomer
    {
        DA.DA_Customer customer;
        DA.DA_Customertype custype;
        GUI.FrmEditCustomer frm;
        public BL_EditCustomer(GUI.FrmEditCustomer f)
        {
            frm = f;
            customer = new DA.DA_Customer();
            custype = new DA.DA_Customertype();
        }
        public void loadCombobox()
        {
            frm.cbType.DataSource = custype.GetDataTableCT();
            frm.cbType.ValueMember = "Customer type ID";
            frm.cbType.DisplayMember = "Customer name";
        }
        public void editCustomer()
        {
            customer.editCustomer(frm.txtID.Text,frm.txtName.Text, frm.txtAddress.Text, frm.txtPhone.Text, frm.cbType.SelectedValue.ToString(), frm.txtPoint.Text);
        }
    }
}
