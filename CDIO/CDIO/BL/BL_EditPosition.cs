using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDIO.BL
{
    class BL_EditPosition
    {

        GUI.FrmEditPosition frm;
        DA.DA_Position daPosition;
        public BL_EditPosition (GUI.FrmEditPosition f)
        {
            this.frm = f;
            daPosition = new DA.DA_Position();
        }
        public void editPosition()
        {
            daPosition.EditPosition(frm.txtID.Text, frm.txtName.Text);
        }
    }
}
