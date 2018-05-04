using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDIO.BL
{
    class BL_AddTable
    {
        DA.DA_TheTable table;
        GUI.FrmAddTable frm;
        public BL_AddTable(GUI.FrmAddTable frm) {
            this.frm = frm;
            table = new DA.DA_TheTable();
        }
        public int addTable() {
            return table.addTable(frm.txtID.Text);
        }
    }
}
