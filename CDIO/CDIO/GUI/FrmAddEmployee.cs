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
                    employee.addEmployee();
                    MessageBox.Show("You have successfully add a new employee !");
                }
                else {
                    MessageBox.Show("Phone must be a number !");
                }
            }
            else {
                MessageBox.Show("All field must not be empty !");
            }
        }

        private void btnCancer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAddEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("Do you want to cancel?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                e.Cancel = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
        }
    }
}
