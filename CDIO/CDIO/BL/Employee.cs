using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDIO.BL
{
    class Employee
    {
        DA.DA_Employee employee;
        DA.DA_Position postion;
        GUI.FrmEmployee frmEmployee;

        public Employee(GUI.FrmEmployee f) {
            employee = new DA.DA_Employee();
            postion = new DA.DA_Position();
            frmEmployee = f;
        }

        public void loadForm() {
            frmEmployee.dataGridView1.DataSource = employee.getDataTableEmployee();
        }
        public class gender
        {
            public string gname { get; set; }
            public int gvalue { get; set; }
        }
        
        public void loadCombobox()
        {
            List<gender> listGender;
            listGender = new List<gender>(){
                new gender() { gname = "Male", gvalue = 1},
                new gender() { gname = "Female", gvalue = 0},
            };
            frmEmployee.cbGender.DataSource = listGender;
            frmEmployee.cbGender.DisplayMember = "gname";
            frmEmployee.cbGender.ValueMember = "gvalue";
            frmEmployee.cbPosition.DataSource = postion.getDataTablePosition();
            frmEmployee.cbPosition.ValueMember = "PositionID";
            frmEmployee.cbPosition.DisplayMember = "PositionName";
        }

        public void clickDataGrid(int index)
        {
            frmEmployee.txtID.Text = frmEmployee.dataGridView1.Rows[index].Cells[0].Value.ToString();
            frmEmployee.txtName.Text = frmEmployee.dataGridView1.Rows[index].Cells[1].Value.ToString();         
            frmEmployee.txtAddress.Text = frmEmployee.dataGridView1.Rows[index].Cells[3].Value.ToString();
            frmEmployee.txtPhone.Text = frmEmployee.dataGridView1.Rows[index].Cells[4].Value.ToString();
            frmEmployee.pickerBirthday.Text = frmEmployee.dataGridView1.Rows[index].Cells[5].Value.ToString();
            frmEmployee.cbPosition.SelectedValue = frmEmployee.dataGridView1.Rows[index].Cells[6].Value;
         
            if (frmEmployee.dataGridView1.Rows[index].Cells[2].Value.ToString() == "True")
                frmEmployee.cbGender.SelectedValue = 1;
            else
                frmEmployee.cbGender.SelectedValue = 0;
        }
        public void deleteEmployee()
        {
            employee.deleteEmployee(frmEmployee.txtID.Text);
            this.loadForm();

        }
    }
}
