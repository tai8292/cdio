using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CDIO.DA
{
    class DA_Customer
    {
        DataProvider lopchung = new DataProvider();
        public DataTable laybangCustomer()
        {
            string sql = "select * from CUSTOMER";
            return lopchung.getDataTable(sql);
        }

        public int saveCustomer( string name, string address , string phone, string type, string point)
        {
            string sql = "insert into CUSTOMER values(N'" + name + "','" + address + "','" + phone +"','"+ type +"'," +point+ ")";
            return lopchung.ExcuNonQuery(sql);
        }
        public int editCustomer(string id, string name, string address, string phone, string type,string point)
        {
            string sql = " update CUSTOMER set CustomerName=N'"+name+ "', Address= '" +address + "',Phone ='" +phone+ "', CusID = '" +type+ "', Point = '"+point+ "' where CustomerID = '" + id+"'";
            return lopchung.ExcuNonQuery(sql);
        }
        public int deleteCustomer(string id)
        {
            string sql = "Delete CUSTOMER where CustomerID = '" + id + "'";
            return lopchung.ExcuNonQuery(sql);
        } 
    }
}

