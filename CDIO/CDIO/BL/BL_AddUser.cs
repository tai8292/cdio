using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDIO.BL
{
    class BL_AddUser
    {
        DA.DA_User daUser;
        GUI.FrmAddUser frm;
        public BL_AddUser(GUI.FrmAddUser f)
        {
            frm = f;
            daUser = new DA.DA_User();
        }
        public int saveDish()
        {
            return daUser.saveDish(frm.txtName.Text, frm.cbxEmployeeID.SelectedValue.ToString());
        }

        public void loadCombobox()
        {
            this.frm.cbxEmployeeID.DataSource = daUser.getDataTableEmployee();
            this.frm.cbxEmployeeID.DisplayMember = "EmployeeName";
            this.frm.cbxEmployeeID.ValueMember = "EmployeeID";
        }
    }
}
