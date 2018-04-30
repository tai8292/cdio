using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDIO.DA
{
    class DA_User
    {
        DataProvider dp = new DataProvider();
        public DataTable getDataTableUser()
        {
            string sql = "select Username, EmployeeID from USERNAME";
            return dp.getDataTable(sql);
        }
        public DataTable getDataTableEmployee()
        {
            string sql = "select * from EMPLOYEE";
            return dp.getDataTable(sql);
        }
        public int saveDish(string text1, string v1)
        {
            string sql = "insert into USERNAME values('" + text1 + "','"+"123456"+"','" + v1 + "')";
            return dp.ExcuNonQuery(sql);
        }
        public void deleteUser(string text)
        {
            string sql = "delete from USERNAME where Username ='" + text + "'";
            dp.ExcuNonQuery(sql);
        }
        public void resetUser(string text)
        {
            string sql = "update USERNAME set Password ='" + 123456 + "' where Username ='" + text + "'";
            dp.ExcuNonQuery(sql);
        }

        public bool checkUser(string username,string pass)
        {
            string sql = "select count (*) from USERNAME where Username ='" + username + "' AND Password =@pass";
            SqlParameter param = new SqlParameter();
            param.ParameterName = "@pass";
            param.Value = pass;
            int kq = dp.ExcuScalar(sql, param);
            if (kq == 1)
                return true;
            return false;
        }

        public string getEmployeeID(string username)
        {
            string sql = "select EmployeeID from USERNAME where Username ='" + username + "'";
            DataTable dt = dp.getDataTable(sql);
            foreach(DataRow r in dt.Rows)
            {
                return "" + (int)r["EmployeeID"];
            }
            return "";
        }
    }
}
