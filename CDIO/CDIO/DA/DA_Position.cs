using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CDIO.DA
{
    class DA_Position
    {
        // xử lý để kết nối dữ liệu  table trong  Database 
        DataProvider dp = new DataProvider();//connect với dữu liệu trong Database
        public DataTable getDataTablePosition()
        {
            string sql = "select * from POSITION";
            DataTable dt = new DataTable();//
            dt = dp.getDataTable(sql);
            dt.Columns["PositionID"].ColumnName = "Position ID";
            dt.Columns["PositionName"].ColumnName = "Position Name";
            return dt;
        }
        
        // xóa 
        public void DeletePosition(String id)
         {
             string sql = "delete from POSITION where PositionID ='" + id + "'";//câu lệnh Sql để xóa 1 position
             dp.ExcuNonQuery(sql);
         }

        public int AddPosition(string id , string name)
        {
            string sql = "insert into POSITION values('" + id + "','" + name + "');";
            return dp.ExcuNonQuery(sql);

        }
        //chỉnh sửa
        public void EditPosition(string id, string name)
        {
            string sql = "update POSITION set PositionName='" + name + "'where PositionID ='"+id+"'; ";
            dp.ExcuNonQuery(sql);
        }
    }
}
