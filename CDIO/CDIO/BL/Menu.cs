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
        GUI.FrmMenu frmMenu;
        
        public Menu(GUI.FrmMenu f)
        {
            menu = new DA.DA_Menu();
            frmMenu = f;
        }

        public void loadForm()
        {
            frmMenu.dataGridView1.DataSource = menu.getDataTableMenu();
        }

        public void addDish()
        {
    //        menu.addDish(frmMenu.txtID.Text,frmMenu.txtName.Text,
    //            frmMenu.txtKind.SelectedValue.ToString(),frmMenu.txtNumber.Text,
    //            frmMenu.txtPrice.Text,)
        }
    }
}
