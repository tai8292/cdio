using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDIO.BL
{
    
    class BL_AddPosition
    {
        GUI.FrmAddPosition frm;
        DA.DA_Position daPosition;
        public BL_AddPosition(GUI.FrmAddPosition f)
        {
            this.frm = f;
            daPosition  = new DA.DA_Position();
           
        }
        public void AddPosition()
        {
            daPosition.AddPosition(frm.txtID.Text,frm.txtName.Text);
        }
    }

}
