using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CDIO.BL
{
    class BL_Position
    {
        GUI.FrmPosition frmPosition;
        DA.DA_Position daPosition;
        
        public BL_Position(GUI.FrmPosition f)
        {
            frmPosition = f;
            daPosition = new DA.DA_Position();
        }

        public void loadDataGridview() // load danh sách trong table
        {
            frmPosition .dataGridView1.DataSource = daPosition.getDataTablePosition();
        }
      
        public void deletePosition()
        {
            daPosition.DeletePosition(frmPosition.txtID.Text);
            this.loadDataGridview();
            frmPosition.txtID.Clear();// xóa xong sẽ tự động cập nhật lại cố edit và chỗ hiển thị của trường id
            frmPosition.txtName.Clear();// xóa xong sẽ tự động cập nhật lại cố edit và chỗ hiển thị của trường name
        }
        public void clickDataGrid(int index)
        {
            frmPosition.txtID.Text = frmPosition.dataGridView1.Rows[index].Cells[0].Value.ToString();
            frmPosition.txtName.Text = frmPosition.dataGridView1.Rows[index].Cells[1].Value.ToString();

        }

    }
}
