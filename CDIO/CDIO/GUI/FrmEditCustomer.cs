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
    public partial class FrmEditCustomer : Form
    {
        BL.BL_EditCustomer editCustomer;
        string id;
        private string Name;
        private string Address;
        private string phone;
        private string selectedValue;
        private string point;
        public FrmEditCustomer()
        {
            InitializeComponent();
            editCustomer = new BL.BL_EditCustomer(this);
        }
        public FrmEditCustomer(string Did, string text1, string text2, string text3, string selectedValue, string text4)
        {
            InitializeComponent();
            editCustomer = new BL.BL_EditCustomer(this);
            id = Did;
            this.Name = text1;
            this.Address= text2;
            this.phone = text3;
            this.selectedValue = selectedValue;
            this.point = text4;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn lưu hay không"
               , "Thông báo"
               , MessageBoxButtons.YesNo
               , MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                editCustomer.update();
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtName.Clear();
            this.txt_Address.Clear();
            this.txt_Phone.Clear();
            this.txt_Point.Clear();
        }

        private void btnCancer_Click(object sender, EventArgs e)
        {
            this.Close();
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
        private void FrmEditCustomer_Load(object sender, EventArgs e)
        {
            this.loadForm();
            editCustomer.loadCombobox();
        }

        public void loadForm()
        {
            txtID.Text = id;
            txtName.Text = Name;
            txt_Address.Text = Address;
            txt_Phone.Text = phone;
            cbType.Text = selectedValue;
            txt_Point.Text = point;


        }
    }
}
