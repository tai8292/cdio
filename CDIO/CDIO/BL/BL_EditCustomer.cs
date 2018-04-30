using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDIO.BL
{
    class BL_EditCustomer
    {
        DA.DA_Customer da;
        GUI.FrmEditCustomer frm;
        public BL_EditCustomer(GUI.FrmEditCustomer f)
        {
            frm = f;
            da = new DA.DA_Customer();
        }
        public void update()
        {
            da.editCustomer(frm.txtID.Text, frm.txtName.Text, frm.txt_Address.Text, frm.txt_Phone.Text, frm.cbType.SelectedValue.ToString(), frm.txt_Point.Text);
        }
        public void loadCombobox()
        {
            frm.cbType.DataSource = da.laybangCustomer();
            frm.cbType.ValueMember = "CusID";
            frm.cbType.DisplayMember = "Pyte";

        }
    }
}
