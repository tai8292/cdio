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
    public partial class FrmEmployee : Form
    {
        BL.Employee employee;
        public FrmEmployee()
        {
            InitializeComponent();
            employee = new BL.Employee(this);
            this.dataGridView1.AllowUserToAddRows = false;
        }

        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            employee.loadCombobox();
            employee.loadForm();
        }


        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            FrmAddEmployee frm = new FrmAddEmployee();
            frm.ShowDialog();
            employee.loadForm();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FrmEditEmployee frm = new FrmEditEmployee(txtID.Text, txtName.Text, cbGender.SelectedValue.ToString(),txtAddress.Text,txtPhone.Text,pickerBirthday.Value.ToString(),cbPosition.SelectedValue.ToString());
            frm.ShowDialog();
            employee.loadForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Do you want to Delete this employee? ", "Noted", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                employee.deleteEmployee();
                employee.loadForm();
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
                MessageBox.Show("You have successfully delete an employee !");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0 && e.RowIndex < this.dataGridView1.Rows.Count) {
                employee.clickDataGrid(e.RowIndex);
                btnDelete.Enabled = true;
                btnEdit.Enabled = true;
            }            
        }
    }
}
