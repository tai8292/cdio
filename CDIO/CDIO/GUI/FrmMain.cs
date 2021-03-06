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
    public partial class FrmMain : Form
    {
        public string empID;
        public FrmMain()
        {
            InitializeComponent();
        }

        public FrmMain(string id)
        {
            InitializeComponent();
            empID = id;
        }

        private void nhungForm(Form f)
        {
            this.panelMain.Controls.Clear();
            f.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            f.TopLevel = false;
            f.Visible = true;

            f.Dock = System.Windows.Forms.DockStyle.None;

            this.panelMain.Controls.Add(f);
            this.panelMain.Show();
        }



        private void btnMenuDish_Click(object sender, EventArgs e)
        {
            FrmMenu f = new FrmMenu();
            nhungForm(f);
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            FrmEmployee f = new FrmEmployee();
            nhungForm(f);
        }

        private void btnPosition_Click(object sender, EventArgs e)
        {
            FrmPosition f = new FrmPosition();
            nhungForm(f);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            FrmCustomer f = new FrmCustomer();
            nhungForm(f);
        }

        private void btnCustomerType_Click(object sender, EventArgs e)
        {
            FrmCustomerType f = new FrmCustomerType();
            nhungForm(f);
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            FrmUser f = new FrmUser();
            nhungForm(f);
        }

        public void loadForm()
        {
            FrmOrder f = new FrmOrder(empID);
            nhungForm(f);
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            FrmBillManagement f = new FrmBillManagement();
            nhungForm(f);
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            FrmChangePass f = new FrmChangePass(empID);
            f.ShowDialog();
            this.loadForm();
        }

        private void btnOrder_Click_1(object sender, EventArgs e)
        {
            loadForm();
        }

        private void FrmMain_Load_1(object sender, EventArgs e)
        {
            loadForm();
        }
    }
}
