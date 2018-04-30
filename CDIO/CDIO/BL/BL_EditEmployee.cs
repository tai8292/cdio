using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDIO.BL
{
    class BL_EditEmployee
    {
        DA.DA_Employee employee;
        DA.DA_Position postion;
        GUI.FrmEditEmployee frm;

        public BL_EditEmployee(GUI.FrmEditEmployee f)
        {
            frm = f;
            employee = new DA.DA_Employee();
            postion = new DA.DA_Position();
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
            frm.cbGender.DataSource = listGender;
            frm.cbGender.DisplayMember = "gname";
            frm.cbGender.ValueMember = "gvalue";
            frm.cbPosition.DataSource = postion.getDataTablePosition();
            frm.cbPosition.ValueMember = "PositionID";
            frm.cbPosition.DisplayMember = "PositionName";
        }

        public void editEmployee()
        {
            employee.editEmployee(frm.txtID.Text, frm.txtName.Text, frm.cbGender.SelectedValue.ToString(), frm.txtAddress.Text, frm.txtPhone.Text, frm.pickerBirthday.Value.ToShortDateString(), frm.cbPosition.SelectedValue.ToString());
        }
    }
}
