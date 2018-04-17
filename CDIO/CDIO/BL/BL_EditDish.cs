using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDIO.BL
{
    class BL_EditDish
    {
        GUI.FrmEditDish f;
        DA.DA_Kind daKind;
        DA.DA_Menu daMenu;

        public BL_EditDish(GUI.FrmEditDish frm)
        {
            f = frm;
            daKind = new DA.DA_Kind();
            daMenu = new DA.DA_Menu();
        }

        public void update()
        {
            daMenu.update(f.txtID.Text, f.txtName.Text, f.txtKind.SelectedValue.ToString(), f.txtNumber.Text, f.txtPrice.Text, f.picture.Image);
        }

        public void loadCombobox()
        {
            f.txtKind.DataSource = daKind.getDataTableKind();
            this.f.txtKind.DisplayMember = "KindName";
            this.f.txtKind.ValueMember = "KindID";
        }

    }
}