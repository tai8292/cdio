using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDIO.DA
{
    class DA_Table
    {
        DataProvider dp = new DataProvider();

        public void SwitchTable(string tableID1,string table2)
        {
            string sql = "update TABLEBILL set TableID ='" + table2 + "' where TableID ='" + tableID1 + "'";
            dp.ExcuNonQuery(sql);
        }
    }
}
