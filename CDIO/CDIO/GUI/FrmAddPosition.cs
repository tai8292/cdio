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
    public partial class FrmAddPosition : Form
    {
        BL.BL_AddPosition Position;
        public FrmAddPosition()
        {
            InitializeComponent();
            Position = new BL.BL_AddPosition(this);
        }
        

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtName.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            Position.AddPosition();
            MessageBox.Show("Add Position Successfull");
            this.Close();
        }

      

        private void btnCancer_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Do you want to Cancel this Form Add Position? ", "Noted", MessageBoxButtons.YesNo, MessageBoxIcon.Question))// câu lệnh để hiển thị câu bạn có chắc chắn muốn bỏ qua hoặc rời khỏi hoặc xóa

                this.Close();
        }

       
    }
}
