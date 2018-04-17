using System;
using System.Collections.Generic;
using System.Data;
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
    }
}
