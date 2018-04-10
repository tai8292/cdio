using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDIO.DA
{
    class DA_Menu
    {
        DataProvider dp = new DataProvider();

        public DataTable getDataTableMenu()
        {
            string sql = "select * from Food";
            return dp.getDataTable(sql);
        }
    }
}
