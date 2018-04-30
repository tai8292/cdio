using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CDIO.DA
{
    class DA_Customer
    {
        DataProvider dp = new DataProvider();
        public DataTable getDataTableCustomer()
        {
            string sql = "select * from Customer";
            return dp.getDataTable(sql);
        }
        public void addCustomer(string name, string address, string phone, string cusid, string point)
        {
            string sql = "insert into CUSTOMER(CustomerName,Address,Phone,CusID,Point) values (N'" + name + "',N'" + address + "','" + phone + "','" + cusid + "','" + point + "');";
            dp.ExcuNonQuery(sql);
        }
        public void deleteCustomer(string id)
        {
            string sql = "delete from CUSTOMER where CustomerID='" + id + "'";
            dp.ExcuNonQuery(sql);
        }
        public void editCustomer(string id,string name, string address, string phone, string cusid, string point)
        {
            string sql = "update CUSTOMER set CustomerName=N'" + name + "',Address=N'" + address + "',Phone='" + phone + "',CusID='" + cusid + "',Point='"+point+"' where CustomerID='" + id + "'; ";
            dp.ExcuNonQuery(sql);
        }
    }
}
