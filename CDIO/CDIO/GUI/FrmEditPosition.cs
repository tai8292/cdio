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
    
    public partial class FrmEditPosition : Form
    {
        BL.BL_EditPosition Position;
        string PositionName;
        string PositionID;
        BL.Commen commen = new BL.Commen();

        public FrmEditPosition()
        {
            InitializeComponent();
            Position = new BL.BL_EditPosition(this);
           
        }
        public FrmEditPosition(String PositionID, string PositionName)
        {
            InitializeComponent();
            Position = new BL.BL_EditPosition(this);
            this.PositionID = PositionID;
            this.PositionName = PositionName;
        }
        private void FrmEditPosition_Load(object sender, EventArgs e)
        {
            
            this.loadForm();
        }

        public void loadForm()
        {
            txtID.Text = PositionID;
            txtName.Text = PositionName;

        }
            private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtName.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        { 
            if (txtName.Text == "")
            {
                MessageBox.Show("NAME  must not null");
            }
            else
             if (!commen.checkAlphaNumberic(txtID.Text) || !commen.checkAlphaNumberic(txtName.Text))
            {
                MessageBox.Show("not enter special character");
            }else
            {
                Position.editPosition();
                MessageBox.Show("Edit Position Successfull");
                this.Close();
            }
        }
            private void btnCancer_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Do you want to Cancel this Form Edit Position? ", "Noted", MessageBoxButtons.YesNo, MessageBoxIcon.Question))// câu lệnh để hiển thị câu bạn có chắc chắn muốn bỏ qua hoặc rời khỏi hoặc xóa

                this.Close();
        }
        private void FrmEditPosition_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("Do you want to cancel?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                e.Cancel = true;
        }

        private void FrmEditPosition_Load_1(object sender, EventArgs e)
        {
            this.loadForm();// load du lieu tu table sang menu edit
        }
    }
}
