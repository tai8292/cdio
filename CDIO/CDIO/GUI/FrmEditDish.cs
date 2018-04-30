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
    public partial class FrmEditDish : Form
    {
        BL.BL_EditDish editDish;
        string id;
        private string name;
        private string selectedValue;
        private string number;
        private string price;
        private Image image;

        public FrmEditDish()
        {
            InitializeComponent();
            editDish = new BL.BL_EditDish(this);
        }



        public FrmEditDish(string Did, string text1, string selectedValue, string text2, string text3, Image image)
        {
            InitializeComponent();
            editDish = new BL.BL_EditDish(this);
            id = Did;
            this.name = text1;
            this.selectedValue = selectedValue;
            this.number = text2;
            this.price = text3;
            this.image = image;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            editDish.update();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtName.Clear();
            this.txtNumber.Clear();
            this.txtPrice.Clear();
        }

        private void btnCancer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNumber_TextChanged(object sender, EventArgs e)
        {
            onlyNumber(txtNumber);
            
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            onlyNumber(txtPrice);
        }

        public void onlyNumber(TextBox t)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(t.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                t.Text = t.Text.Remove(t.Text.Length - 1);
            }
        }

        private void FrmEditDish_Load(object sender, EventArgs e)
        {
            this.loadForm();
            editDish.loadCombobox();
        }

        public void loadForm()
        {
            txtID.Text = id;
            txtKind.Text = selectedValue;
            txtName.Text = name;
            txtNumber.Text = number;
            txtPrice.Text = price;
            picture.Image = image;

        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            open.ShowDialog();
            this.picture.Image = Image.FromFile(open.FileName);
        }

        private void txtKind_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
