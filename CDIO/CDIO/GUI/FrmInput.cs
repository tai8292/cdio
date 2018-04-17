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
    public partial class FrmInput : Form
    {
        public int soluong;
        public FrmInput()
        {
            InitializeComponent();


        }

        //kiểm tra số lượng nhập vào và chuyển qua form Main

        private void btnOkay_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("abc");
            BL.Commen g = new BL.Commen();
            if (txtInput.Text == "")
            {
                this.soluong = 0;
            }
            else
            {
                if (txtInput.Text.Length < 10)
                {
                    if (g.CheckIsNumber(txtInput.Text) == true)
                    {
                        this.soluong = int.Parse(txtInput.Text.ToString());
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Giá trị nhập vào không hợp lệ,vui lòng nhập lại", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Giá trị nhập vào quá lớn,vui lòng nhập lại", "Thông báo");
                }
            }
            this.Close();
        }
    }
}