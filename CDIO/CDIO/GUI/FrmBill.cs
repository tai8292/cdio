﻿using System;
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
    public partial class FrmBill : Form
    {
        private String billID, cusID, empID;
        public FrmBill()
        {
            InitializeComponent();
        }

        //lấy mã hóa đơn từ form Main
        public FrmBill(string billID, string cusID, string empID)
        {
            InitializeComponent();
            this.billID = billID;
            this.cusID = cusID;
            this.empID = empID;
        }


        private void reportBill_Load(object sender, EventArgs e)
        {
            //tạo đối tượng và đưa dữ liệu và dataBill
            DataBillTableAdapters.BILLTableAdapter bill = new DataBillTableAdapters.BILLTableAdapter();
            DataBillTableAdapters.BILLDETAILTableAdapter billDetail = new DataBillTableAdapters.BILLDETAILTableAdapter();
            DataBillTableAdapters.DISHTableAdapter dish = new DataBillTableAdapters.DISHTableAdapter();
            DataBillTableAdapters.CUSTOMERTableAdapter cus = new DataBillTableAdapters.CUSTOMERTableAdapter();
            DataBillTableAdapters.EMPLOYEETableAdapter emp = new DataBillTableAdapters.EMPLOYEETableAdapter();
            DataBill data = new DataBill();
            dish.Fill(data.DISH);
            bill.Fill(data.BILL, int.Parse(this.billID));          
            billDetail.Fill(data.BILLDETAIL, int.Parse(this.billID));        
            cus.Fill(data.CUSTOMER, int.Parse(this.cusID));
            emp.Fill(data.EMPLOYEE, int.Parse(this.empID));
            rpBill r = new rpBill();
            //đưa dữ liệu từ databill và CystalReport
            r.SetDataSource(data);
            this.reportBill.ReportSource = r;
        }

    }
}