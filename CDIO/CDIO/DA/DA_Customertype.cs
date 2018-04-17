using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace CDIO.DA
{
    class DA_Customertype
    {
        DataProvider dp = new DataProvider();
        public DataTable GetDataTableCT()
        {
            string sql = "select * from CUSTOMERTYPE";
            DataTable dt = new DataTable();
            dt=dp.getDataTable(sql);
            dt.Columns["ID"].ColumnName = "Customer type ID";
            dt.Columns["Name"].ColumnName = "Customer name";
            dt.Columns["Point"].ColumnName = "Customer point";
            return dt;
        }
        public void deleteCT(string text)
        {
            string sql = "delete from CUSTOMERTYPE where ID='" + text + "';";
            dp.ExcuNonQuery(sql);
        }
        public void editCT(string id, string name, string point)
        {
            string sql = "update CUSTOMERTYPE set Name = '" + name + "', Point='" + point + "' where ID='" + id + "';";
            dp.ExcuNonQuery(sql);
        }
         public void addCT(string id, string name, string point)
            {
            string sql = "insert into CUSTOMERTYPE values ('" + id + "','" + name + "','" + point + "');";
            dp.ExcuNonQuery(sql);
        }   
    }

}

    