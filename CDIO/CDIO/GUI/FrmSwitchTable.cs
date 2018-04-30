using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDIO.GUI
{
    public partial class FrmSwitchTable : Form
    {
        string tableID;
        DA.DA_Menu da;
        DA.DA_Table daTable;
        public FrmSwitchTable()
        {
            InitializeComponent();
        }

        public FrmSwitchTable(string tableID)
        {
            this.tableID = tableID;
            da = new DA.DA_Menu();
            daTable = new DA.DA_Table();
            InitializeComponent();
        }

        private void FrmSwitchTable_Load(object sender, EventArgs e)
        {
            this.lbTableID.Text = tableID;
            this.cbTable.DataSource = da.getListTable(tableID);
            this.cbTable.DisplayMember = "TableID";
            this.cbTable.ValueMember = "TableID";
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            daTable.SwitchTable(tableID, cbTable.SelectedValue.ToString());
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
