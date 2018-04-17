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
    class DA_Menu
    {
        DataProvider dp = new DataProvider();
        BL.Commen commen = new BL.Commen();

        public DataTable getDataTableMenu()
        {
            string sql = "select * from DISH";
            return dp.getDataTable(sql);
        }

        public int saveDish(string text1, string v1, string text2, string text3, byte[] v2)
        {
            SqlParameter param = new SqlParameter();
            param.ParameterName = "@HinhAnh";
            param.Value = v2;
            string sql = "insert into DISH values('10',N'" + text1 + "','" + v1 + "'," + text2 + "," + text3 + ",@HinhAnh)";
            return dp.ExcuNonQuery(sql,param);
        }

        public void deleteDish(string text)
        {
            string sql = "delete from DISH where DishID ='" + text + "'";
            dp.ExcuNonQuery(sql);
        }

        public void update(string text1, string text2, string v, string text3, string text4, Image image)
        {
            SqlParameter param = new SqlParameter();
            param.ParameterName = "@HinhAnh";
            param.Value = commen.ImageToByte(image);   
            string sql = "update DISH set DishName=N'" + text2 + "',KindID='" + v + "',Number=" + text3 + ",Price=" + text4 + ",Picture= @HinhAnh where DishID like'"+text1+"'";
            dp.ExcuNonQuery(sql,param);
        }

        public List<Dish> getListDish()
        {
            List<Dish> dishList = new List<Dish>();
            DataProvider dp = new DataProvider();
            string sql = "select DishID,DishName,KindID,Number,Price as p from DISH" ;
            DataTable dt = dp.getDataTable(sql);
            foreach (DataRow item in dt.Rows)
            {
                Dish drinks = new Dish(item);
                dishList.Add(drinks);
            }

            return dishList;
        }

        public List<Table> getListTable()
        {
            List<Table> tableList = new List<Table>();
            DataProvider dp = new DataProvider();
            string sql = "select TableID from THETABLE";
            DataTable dt = dp.getDataTable(sql);
            foreach (DataRow item in dt.Rows)
            {
                Table table = new Table(item);
                tableList.Add(table);
            }

            return tableList;
        }

        public int getTableBill(string id)
        {
            string sql = "select count(*) from TABLEBILL where TABLEID like '" + id+"'";
            return dp.ExcuScalar(sql);
        }
    }
}
