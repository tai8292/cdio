using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CDIO.DA
{
    class DA_Employee
    {
        DataProvider dp = new DataProvider();
        public DataTable getDataTableEmployee() {
            string sql = "select * from EMPLOYEE";
            return dp.getDataTable(sql);
        }
        public void addEmployee(string name, string gender, string address, string phone, DateTime birthday, string position) {
            string sql = "insert into EMPLOYEE(EmployeeName,Gender,Address,Phone,Birthday,PositionID) values ('"+name+"','"+gender+"','"+address+"','"+phone+"','"+birthday+"','"+position+"');";
            dp.ExcuNonQuery(sql);
        }
        public void deleteEmployee(string id) {
            string sql = "delete from EMPLOYEE where EmployeeID='" + id + "'";
            dp.ExcuNonQuery(sql);
        }
        public void editEmployee(string id, string name, string gender, string address, string phone, DateTime birthday, string position) {
            string sql = "update EMPLOYEE set EmployeeName='"+name+"',Gender='"+gender+"',Address='"+address+"',Phone='"+phone+"',Birthday='"+birthday+"',PositionID='"+position+"' where EmployeeID='"+id+"'; ";
            dp.ExcuNonQuery(sql);
        }
    }
}
