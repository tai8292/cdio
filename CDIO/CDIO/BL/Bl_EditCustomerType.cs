using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDIO.BL
{
    class Bl_EditCustomerType
    {
        GUI.FrmEditCustomerType frm;
        DA.DA_Customertype ct;
        
    
        public Bl_EditCustomerType(GUI.FrmEditCustomerType frm)
        {
            this.frm = frm;
            ct = new DA.DA_Customertype();

        }
        public void EditCT()
        {
            ct.editCT(frm.txtID.Text, frm.txtName.Text, frm.txtPoint.Text);
            
        }
    }
}
