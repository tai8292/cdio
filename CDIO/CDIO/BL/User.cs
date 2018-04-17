using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDIO.BL
{
    class User
    {
        DA.DA_User user;
        GUI.FrmUser frmUser;
        public User(GUI.FrmUser f)
        {
            user = new DA.DA_User();
            frmUser = f;
        }
        public void loadForm()
        {
            frmUser.dataGridView1.DataSource = user.getDataTableUser();
        }
        public void clickDataGrid(int index)
        {
            frmUser.txtName.Text = frmUser.dataGridView1.Rows[index].Cells[0].Value.ToString();
            frmUser.txtID.Text = frmUser.dataGridView1.Rows[index].Cells[1].Value.ToString();
        }

        public void deleteUser()
        {
            user.deleteUser(frmUser.txtName.Text);
        }
        public void resetUser()
        {
            user.resetUser(frmUser.txtName.Text);
        }
    }
}
