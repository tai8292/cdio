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
            DataTable dt = new DataTable();
            dt = dp.getDataTable(sql);
            dt.Columns["EmployeeID"].ColumnName = "Employee ID";
            dt.Columns["EmployeeName"].ColumnName = "Employee Name";
            dt.Columns["PositionID"].ColumnName = "Position";
            return dt;  
        }
        public void addEmployee(string name, string gender, string address, string phone, string birthday, string position) {
            string sql = "insert into EMPLOYEE(EmployeeName,Gender,Address,Phone,Birthday,PositionID) values (N'"+name+"','"+gender+"',N'"+address+"','"+phone+"','"+birthday+"','"+position+"');";
            dp.ExcuNonQuery(sql);
        }
        public void deleteEmployee(string id) {
            string sql = "delete from EMPLOYEE where EmployeeID='" + id + "'";
            dp.ExcuNonQuery(sql);
        }
        public void editEmployee(string id, string name, string gender, string address, string phone, string birthday, string position) {
            string sql = "update EMPLOYEE set EmployeeName=N'"+name+"',Gender='"+gender+"',Address=N'"+address+"',Phone='"+phone+"',Birthday='"+birthday+"',PositionID='"+position+"' where EmployeeID='"+id+"'; ";
            dp.ExcuNonQuery(sql);
        }
    }
}
