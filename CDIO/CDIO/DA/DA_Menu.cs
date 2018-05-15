using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            string sql = "insert into DISH values(N'" + text1 + "','" + v1 + "'," + text2 + "," + text3 + ",@HinhAnh)";
            return dp.ExcuNonQuery(sql,param);
        }

        public void deleteDish(string text)
        {
            string sql = "delete BILLDETAIL where DishID ='" + text + "'";
            dp.ExcuNonQuery(sql);
            sql = "delete DISH where DishID ='" + text + "'";
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

        public DataTable getListTable(string tableID)
        {
            List<Table> tableList = new List<Table>();
            DataProvider dp = new DataProvider();
            string sql = "select TableID from THETABLE where TableID not in ( select TableID from TABLEBILL )";
            DataTable dt = dp.getDataTable(sql);
            return dt;
        }

        public int getTableBill(string id)
        {
            string sql = "select count(*) from TABLEBILL where TABLEID like '" + id+"'";
            return dp.ExcuScalar(sql);
        }

        public string getBillID(string tableID)
        {
            string sql = "select ID from TABLEBILL where TableID like '" + tableID + "'";
            DataTable dt = dp.getDataTable(sql);
            string kq ="";
            foreach (DataRow item in dt.Rows)
                kq = kq + item[0];
            return kq;
        }

        public void createBill(string tableID)
        {
            DateTime d = DateTime.Today;
            string sql = "insert into BILL(CreateDate,TableID) values('" + d.ToShortDateString() + "','"+tableID+"')";
            dp.ExcuNonQuery(sql);
        }

        public string getBillID()
        {
            string sql = "select ID from BILL order by ID DESC";
            DataTable dt = dp.getDataTable(sql);
            string kq = "";
            foreach(DataRow item in dt.Rows)
            {
                kq = kq + item[0];
                break;
            }
            return kq;
        }

        public int getDishID(string dishName)
        {
            string sql = "select DishID from DISH where DishName like N'" + dishName + "'";
            DataTable dt = dp.getDataTable(sql);
            int kq = 0;
            foreach (DataRow item in dt.Rows)
                kq = (int)item["DishID"];
            return kq;
        }

        public void addBillDetail(string billID, string dishName, int soLuong, double gia,int hienco)
        {
            int id = getDishID(dishName);
            string sql ="insert into BILLDETAIL values('"+billID+"',"+id+","+soLuong+"," + gia + ")";
            dp.ExcuNonQuery(sql);
            soLuong = hienco - soLuong;
            sql = "update DISH set Number =" + soLuong + " where DishID like " + id;
            dp.ExcuNonQuery(sql);
        }

        public void updateBillDetail(string billID, string dishName, int soLuong, double gia, int hienco)
        {
            int id = getDishID(dishName);
            string sql = "update BILLDETAIL set Number = Number +"+soLuong+" where BillID = '"+billID+"' and DishID = '"+id+"'";
            dp.ExcuNonQuery(sql);
            soLuong = hienco - soLuong;
            sql = "update DISH set Number =" + soLuong + " where DishID like " + id;
            dp.ExcuNonQuery(sql);
        }

        public DataTable getBillDetail(string billID)
        {
            string sql = "select * from BILLDETAIL where BillID like '" + billID + "'";
            return dp.getDataTable(sql);
        }

        public void saveTableBill(string tableId,string billID)
        {
            string sql = "insert into TABLEBILL values('" + tableId + "','" + billID + "')";
            dp.ExcuNonQuery(sql);
        }

        public void updateBill(string billID,int cusID,int empId)
        {
            DataTable dt = dp.getDataTable("select Number,Price from BILLDETAIL where BillID like '" + billID + "'");
            double total = 0;
            foreach(DataRow r in dt.Rows)
            {
                int number = (int)r["Number"];
                double price = (double)r["Price"];
                total = total + number * price;
            }

            string sql = "update BILL set EmployeeID =" + empId + ",CustomerID =" + cusID + ",TotalMoney ='" + total + "' where ID like '" + billID + "'";
            dp.ExcuNonQuery(sql);
            decimal p =Math.Round((decimal)( total / 10000));
            sql = "update CUSTOMER set Point = Point +'" + p + "' where CustomerID =" + cusID;
            dp.ExcuNonQuery(sql);
        }

        public void deleteTableBill(string billID)
        {
            string sql = "delete TABLEBILL where ID like '" + billID + "'";
            dp.ExcuNonQuery(sql);
        }

        public void deleteBillDetail(string billID,string dishID)
        {
            string sql = "delete BILLDETAIL where BillID like '" + billID + "' and DishID like '" + dishID + "'";
            dp.ExcuNonQuery(sql);
        }
    }
}
