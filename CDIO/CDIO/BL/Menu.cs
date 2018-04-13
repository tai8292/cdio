using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDIO.BL
{
    class Menu
    {
        DA.DA_Menu menu;
        DA.DA_Kind kind;
        GUI.FrmMenu frmMenu;
        Commen commen = new Commen();
        
        public Menu(GUI.FrmMenu f)
        {
            menu = new DA.DA_Menu();
            kind = new DA.DA_Kind();
            frmMenu = f;
        }

        public void loadForm()
        {
            frmMenu.dataGridView1.DataSource = menu.getDataTableMenu();
        }

        public void loadCombobox()
        {
            frmMenu.txtKind.DataSource = kind.getDataTableKind();
            frmMenu.txtKind.ValueMember = "KindID";
            frmMenu.txtKind.DisplayMember = "KindName";
        }

        public void addDish()
        {
    //        menu.addDish(frmMenu.txtID.Text,frmMenu.txtName.Text,
    //            frmMenu.txtKind.SelectedValue.ToString(),frmMenu.txtNumber.Text,
    //            frmMenu.txtPrice.Text,)
        }

        public void clickDataGrid(int index)
        {
            frmMenu.txtID.Text = frmMenu.dataGridView1.Rows[index].Cells[0].Value.ToString();
            frmMenu.txtName.Text = frmMenu.dataGridView1.Rows[index].Cells[1].Value.ToString();
            frmMenu.txtNumber.Text = frmMenu.dataGridView1.Rows[index].Cells[3].Value.ToString();
            frmMenu.txtPrice.Text = frmMenu.dataGridView1.Rows[index].Cells[4].Value.ToString();
            frmMenu.txtKind.SelectedValue = frmMenu.dataGridView1.Rows[index].Cells[2].Value;
            frmMenu.picture.Image = commen.byteToImage((byte[])frmMenu.dataGridView1.Rows[index].Cells[5].Value);
        }

        public void deleteDish()
        {
            menu.deleteDish(frmMenu.txtID.Text);
        }

    }
}
