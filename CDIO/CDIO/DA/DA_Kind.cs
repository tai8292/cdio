using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDIO.DA
{
    class DA_Kind
    {
        DataProvider dp = new DataProvider();

        public DataTable getDataTableKind()
        {
            string sql = "select * from KIND";
            return dp.getDataTable(sql);
        }
    }
}
