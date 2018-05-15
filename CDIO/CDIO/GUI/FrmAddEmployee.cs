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
    public partial class FrmAddEmployee : Form
    {
        BL.BL_AddEmployee employee;
        BL.Commen commen = new BL.Commen();
        public FrmAddEmployee()
        {
            InitializeComponent();
            employee = new BL.BL_AddEmployee(this); 
        }



        private void FrmAddEmployee_Load(object sender, EventArgs e)
        {
            employee.loadCombobox();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtAddress.Text != "" && txtPhone.Text != "")
            {
                if (txtPhone.Text.All(char.IsDigit) == true)
                {
                    if (txtPhone.Text.All(char.IsDigit) == true)
                    {
                        if (txtPhone.Text.Length > 8)
                        {
                            employee.addEmployee();
                            MessageBox.Show("You have successfully add an new employee !");
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
            else
            {
                MessageBox.Show("All field must not be empty !");
            }
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
