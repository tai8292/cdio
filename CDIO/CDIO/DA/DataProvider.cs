
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CDIO.DA
{
    class DataProvider
    {
        SqlConnection conn;
        string connectString = @"Data Source=DESKTOP-JCP96RQ\SQLEXPRESS;Initial Catalog=SQLRM;Integrated Security=True";

        public DataProvider()
        {
            conn = new SqlConnection(connectString);
        }

        public void Open()
        {
            if (conn.State != System.Data.ConnectionState.Open)
            {
                conn.Open();
            }
        }
        public void Closed()
        {
            if (conn.State != System.Data.ConnectionState.Closed)
            {
                conn.Close();
            }
        }
        public int ExcuNonQuery(string sql)
        {
            Open();
            SqlCommand comm = new SqlCommand(sql, conn);
            int ketqua = comm.ExecuteNonQuery();
            Closed();
            return ketqua;
        }

        public int ExcuNonQuery(string sql,SqlParameter param)
        {
            Open();
            SqlCommand comm = new SqlCommand(sql, conn);
            comm.Parameters.Add(param);
            int ketqua = comm.ExecuteNonQuery();
            Closed();
            return ketqua;
        }

        public DataTable getDataTable(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public int ExcuScalar(string sql)
        {
            Open();
            SqlCommand comm = new SqlCommand(sql, conn);
            int ketqua = (int)comm.ExecuteScalar();
            Closed();
            return ketqua;
        }
    }
}
