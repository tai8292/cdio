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
    public partial class FrmEditEmployee : Form
    {
        BL.BL_EditEmployee employee;
        BL.Commen commen = new BL.Commen();
        string id;
        string name;
        string gender;
        string address;
        string phone;
        string birthday;
        string position;

        public FrmEditEmployee()
        {
            InitializeComponent();
            employee = new BL.BL_EditEmployee(this);
        }

        public FrmEditEmployee(string id, string name, string gender, string address, string phone, string birthday, string position)
        {
            InitializeComponent();
            employee = new BL.BL_EditEmployee(this);
            this.id = id;
            this.name = name;
            this.gender = gender;
            this.address = address;
            this.phone = phone;
            this.birthday = birthday;
            this.position = position;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtAddress.Text != "" && txtPhone.Text != "")
            {
                if (!commen.checkAlphaNumberic(txtName.Text) || !commen.checkAlphaNumberic(txtName.Text) || !commen.checkAlphaNumberic(txtAddress.Text))
                {
                    MessageBox.Show("Can not contain special character");
                }
                else
                {
                    if (txtPhone.Text.All(char.IsDigit) == true)
                    {
                        if (txtPhone.Text.All(char.IsDigit) == true)
                        {
                            if (txtPhone.Text.Length > 8)
                            {
                                employee.editEmployee();
                                MessageBox.Show("You have successfully edit an employee !");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Phone must be between 9-12 characters");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Phone must be a number !");
                    }
                }
            }
            else
            {
                MessageBox.Show("All field must not be empty !");
            }
        }

        private void FrmEditEmployee_Load(object sender, EventArgs e)
        {
            employee.loadCombobox();
            this.loadForm();
        }

        public void loadForm() {
            txtID.Text = id;
            txtName.Text = name;
            cbGender.Text = gender;
            txtAddress.Text = address;
            txtPhone.Text = phone;
            pickerBirthday.Text = birthday;
            cbPosition.Text = position;
        }

        private void btnCancer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
        }


    }
}
