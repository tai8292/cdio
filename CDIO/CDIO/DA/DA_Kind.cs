using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDIO.DA
{
    class DA_Kind
    {
        DataProvider dp = new DataProvider();
        static BL.Commen commen = new BL.Commen();

        public DataTable getDataTableKind()
        {
            string sql = "select * from KIND";
            return dp.getDataTable(sql);
        }

        
    }
}
