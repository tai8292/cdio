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
    public partial class FrmCustomerAdd : Form
    {
        BL.BL_AddCustomer bl;
      
        public FrmCustomerAdd()
        {
            InitializeComponent();
            bl = new BL.BL_AddCustomer(this);

        }

        private void FrmCustomerAdd_Load(object sender, EventArgs e)
        {
            bl.loadCombobox();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtID.Clear();
            this.txtName.Clear();
            this.txt_Address.Clear();
            this.txt_Phone.Clear();
            this.txt_Point.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn lưu hay không"
                  , "Thông báo"
                  , MessageBoxButtons.YesNo
                  , MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                MessageBox.Show(bl.ADD().ToString());
                bl.loadCombobox();
            }
           
        }
        private void FrmCustomerAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("Do you want to cancer?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                e.Cancel = true;
        }
        public void onlyNumber(TextBox t)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(t.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                t.Text = t.Text.Remove(t.Text.Length - 1);
            }
        }
        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            onlyNumber(txt_Phone);

        }

        private void txtPoint_TextChanged(object sender, EventArgs e)
        {
            onlyNumber(txt_Point);
        }

        private void btnCancer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      
    }
}
