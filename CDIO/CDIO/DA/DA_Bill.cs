using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CDIO.DA
{
    class DA_Bill
    {
        DataProvider dp = new DataProvider();
        public DataTable getDataTableBill()
        {
            string sql = "select * from BILL";
            DataTable dt = new DataTable();
            dt = dp.getDataTable(sql);
            dt.Columns["ID"].ColumnName = "Bill ID";
            return dt;
        }
        public DataTable getDataTableBillDetail(string id)
        {
            string sql = "select d.DishName,bd.Number,bd.Price from BILLDETAIL bd,DISH d where bd.BILLID='"+id+"' and bd.DishID=d.DishID ";
            DataTable dt = new DataTable();
            dt = dp.getDataTable(sql);
            return dt;
        }
    }
}
