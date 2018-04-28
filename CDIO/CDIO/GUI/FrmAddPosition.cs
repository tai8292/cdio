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
        BL.Commen commen =new BL.Commen();
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
            try
            {
                if (txtID.Text == "" || txtName.Text == "")
                {
                    MessageBox.Show("ID or NAME must not null");

                }
                else
                if (!commen.checkAlphaNumberic(txtID.Text) || !commen.checkAlphaNumberic(txtName.Text))
                {
                    MessageBox.Show("ID or NAME can not contain special character");
                }
                else
                {
                    Position.AddPosition();
                    MessageBox.Show("Add Position Successfull");
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Add Position Failed");
            }

        }

   

        private void btnCancer_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Do you want to Cancel this Form Add Position? ", "Noted", MessageBoxButtons.YesNo, MessageBoxIcon.Question))// câu lệnh để hiển thị câu bạn có chắc chắn muốn bỏ qua hoặc rời khỏi hoặc xóa

                this.Close();
        }


      /*  private void txtID_Validated(object sender, EventArgs e)
        {
            if (txtID.Text == "" )
            {
                this.btnSave.Enabled = false;
            }
            else
                this.btnSave.Enabled = true;
        }

        private void FrmAddPosition_Load(object sender, EventArgs e)
        {
            this.btnSave.Enabled = false;
        }

      private void txtName_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text) || string.IsNullOrEmpty(txtName.Text))
            {
                this.btnSave.Enabled = false;
            }
            else
                this.btnSave.Enabled = true;
        }

      private void txtID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text) || string.IsNullOrEmpty(txtName.Text))
            {
                this.btnSave.Enabled = false;
            }
            else
                this.btnSave.Enabled = true;
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text) || string.IsNullOrEmpty(txtName.Text))
            {
                this.btnSave.Enabled = false;
            }
            else
                this.btnSave.Enabled = true;

        }*/
    }
}
