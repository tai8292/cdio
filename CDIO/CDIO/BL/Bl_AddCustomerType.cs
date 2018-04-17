using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDIO.BL
{
    class Bl_AddCustomerType
    {
        GUI.FrmAddCustomerType frm;
        DA.DA_Customertype ct;
        public Bl_AddCustomerType(GUI.FrmAddCustomerType frm)
        {
            this.frm = frm;
            ct = new DA.DA_Customertype();

        }
        public void AddCT()
        {
            ct.addCT(frm.txtID.Text,frm.txtName.Text,frm.txtPoint.Text);
        }
    }
}
