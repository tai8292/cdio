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
    public partial class FrmMenuAddDish : Form
    {
        BL.BL_AddDish bl;

        public FrmMenuAddDish()
        {
            InitializeComponent();
            bl = new BL.BL_AddDish(this);
            this.picture.Image = Image.FromFile("D:/cdio4/cdio/CDIO/CDIO/food.png");
        }

        private void FrmMenuAddDish_Load(object sender, EventArgs e)
        {
            bl.loadCombobox();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            open.ShowDialog();
            this.picture.Image = Image.FromFile(open.FileName);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtNumber.Text == "" || txtPrice.Text == "")
            {
                MessageBox.Show("You must input all field");
            }
            else
            {
                bl.saveDish();
                MessageBox.Show("Add dish successful");
                this.Close();
            }
            
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
    }
}
