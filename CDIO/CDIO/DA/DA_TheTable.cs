using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CDIO.DA
{
    class DA_TheTable
    {
        DataProvider dp = new DataProvider();
        public int addTable(string id) {
            string sql = "select count(*) from THETABLE where TableID='"+id+"'";
            if (dp.ExcuScalar(sql) == 1)
            {
                return 0;
            }
            else
            {
                sql = "insert into THETABLE(TableID) values('" + id + "')";
                dp.ExcuNonQuery(sql);
                return 1;
            }
        }

        public DataTable getDataTable() {
            string sql = "select * from THETABLE";
            return dp.getDataTable(sql);

        }

        public int deleteTable(string id)
        {
            string sql = "select count(*) from TABLEBILL where TableID='"+id+"'";
            if (dp.ExcuScalar(sql) == 1)
            {
                return 0;
            }
            else
            {
                sql = "update BILL set TableID=null where TableID='"+id+"'";
                dp.ExcuNonQuery(sql);
                sql = "delete from THETABLE where TableID='" + id + "'";
                dp.ExcuNonQuery(sql);
                return 1;
            }
        }
        
    }
}
