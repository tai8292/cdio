using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDIO.BL
{
    public class BL_AddCustomer
    {
        GUI.FrmCustomerAdd frmCustomer;
        DA.DA_Customer Customer;
        GUI.FrmCustomer frm;
        public BL_AddCustomer(GUI.FrmCustomerAdd f)
        {
            frmCustomer = f;
            Customer = new DA.DA_Customer();
        }
        public void loadCombobox()
        {
            frmCustomer.cbType.DataSource = Customer.laybangCustomer();
            frmCustomer.cbType.ValueMember = "CusID";
            frmCustomer.cbType.DisplayMember = "Pyte";

        }
        public int ADD()
        {
            return Customer.saveCustomer( frmCustomer.txtName.Text,
                                         frmCustomer.txt_Address.Text, frmCustomer.txt_Phone.Text,
                                         frmCustomer.cbType.SelectedValue.ToString(), frmCustomer.txt_Point.Text);
        }
    }
}
