using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CDIO.DA
{
    class DA_ManyKind
    {
        DataProvider lopchung = new DataProvider();
              public DataTable getDataTableKind()
        {
            string sql = "select * from CUSTOMER";
            return lopchung.getDataTable(sql);
        }

    }
}
