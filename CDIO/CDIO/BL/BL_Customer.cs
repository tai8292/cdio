using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDIO.BL
{
    class BL_Customer
    {
        DA.DA_Customer customer;
        GUI.FrmCustomer formCustomer;

        public BL_Customer(GUI.FrmCustomer f)
        {
            customer = new DA.DA_Customer();

            formCustomer = f;
        }     
        public void loadForm()
        {
            formCustomer.dataGridView1.DataSource = customer.laybangCustomer();
        }
        public void loadCombobox()
        {
            formCustomer.cbType.DataSource = customer.laybangCustomer();
            formCustomer.cbType.ValueMember = "CusID";
            formCustomer.cbType.DisplayMember = "Pyte";

        }
        public void clickDataGrid(int index)
        {
            formCustomer.txtID.Text = formCustomer.dataGridView1.Rows[index].Cells[0].Value.ToString();
            formCustomer.txtName.Text = formCustomer.dataGridView1.Rows[index].Cells[1].Value.ToString();
            formCustomer.txt_Address.Text = formCustomer.dataGridView1.Rows[index].Cells[2].Value.ToString();
            formCustomer.txt_Phone.Text = formCustomer.dataGridView1.Rows[index].Cells[3].Value.ToString();
            formCustomer.cbType.SelectedValue = formCustomer.dataGridView1.Rows[index].Cells[4].Value;
            formCustomer.txt_Point.Text = formCustomer.dataGridView1.Rows[index].Cells[5].Value.ToString();

        }
        public int ADD()
        {

            return customer.saveCustomer(formCustomer.txtName.Text,
                                         formCustomer.txt_Address.Text, formCustomer.txt_Phone.Text,
                                         formCustomer.cbType.SelectedValue.ToString(), formCustomer.txt_Point.Text);
        }
        public void deleteCostomer()
        {
            customer.deleteCustomer(formCustomer.txtID.Text);
        }
    }
}
