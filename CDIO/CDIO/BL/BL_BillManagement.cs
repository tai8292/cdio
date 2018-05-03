using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CDIO.BL
{
    class BL_BillManagement
    {
        GUI.FrmBillManagement frm;
        DA.DA_BillManagement bill;
        public BL_BillManagement(GUI.FrmBillManagement frm)
        {
            this.frm = frm;
            bill = new DA.DA_BillManagement();
        }


        public void clickDataGrid(int index)
        {
            frm.txtID.Text = frm.dataGridView1.Rows[index].Cells[0].Value.ToString();
            frm.txtEmployee.Text = frm.dataGridView1.Rows[index].Cells[1].Value.ToString();
            frm.txtDate.Text = frm.dataGridView1.Rows[index].Cells[3].Value.ToString();
            frm.txtTotal.Text = frm.dataGridView1.Rows[index].Cells[4].Value.ToString();
            frm.dataGridView2.DataSource = bill.getDataTableBillDetail(frm.txtID.Text);
        }


        public void loadForm()
        {
            frm.dataGridView1.DataSource = bill.getDataTableBill();
            frm.dataGridView1.Columns["EmployeeID"].Visible = false;
            frm.dataGridView1.Columns["CustomerID"].Visible = false;
            //frm.dataGridView1.Columns["CreateDate"].Visible = false;
            frm.dataGridView1.Columns["TotalMoney"].Visible = false;
            frm.dataGridView1.Columns["TableID"].Visible = false;
        }


    }
}
