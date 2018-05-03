using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDIO.BL
{
    class BL_DeleteTable
    {
        DA.DA_TheTable table;
        GUI.FrmDeleteTable frm;
        public BL_DeleteTable(GUI.FrmDeleteTable frm) {
            this.frm = frm;
            table = new DA.DA_TheTable();
        }

        public void loadCB() {
            frm.cbID.DataSource = table.getDataTable();
            frm.cbID.DisplayMember = "TableID";
            frm.cbID.ValueMember = "TableID";
        }

        public int deleteTable()
        {
            return table.deleteTable(frm.cbID.Text);
        }
    }
}
