using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDIO.BL
{
    class BL_AddDish
    {
        GUI.FrmMenuAddDish frm;
        DA.DA_Kind daKind;
        DA.DA_Menu daMenu;
        static BL.Commen commen = new BL.Commen();

        public BL_AddDish(GUI.FrmMenuAddDish f)
        {
            frm = f;
            daKind = new DA.DA_Kind();
            daMenu = new DA.DA_Menu();
        }

        public void loadCombobox()
        {
            this.frm.txtKind.DataSource = daKind.getDataTableKind();
            this.frm.txtKind.DisplayMember = "KindName";
            this.frm.txtKind.ValueMember = "KindID";
        }

        public int saveDish()
        {
            return daMenu.saveDish(frm.txtName.Text, frm.txtKind.SelectedValue.ToString(),
                frm.txtNumber.Text, frm.txtPrice.Text, commen.ImageToByte(frm.picture.Image));
        }
    }
}
