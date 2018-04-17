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
        DataProvider dp = new DataProvider();
        public DataTable getDataTablePosition() {
            string sql = "select * from POSITION";
            return dp.getDataTable(sql);
        }
    }
}
