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
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FrmEditEmployee frm = new FrmEditEmployee(txtID.Text, txtName.Text, cbGender.SelectedValue.ToString(),txtAddress.Text,txtPhone.Text,pickerBirthday.Value.ToString(),cbPosition.SelectedValue.ToString());
            frm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            employee.deleteEmployee();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            employee.clickDataGrid(e.RowIndex);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            employee.clickDataGrid(e.RowIndex);
        }


    }
}
