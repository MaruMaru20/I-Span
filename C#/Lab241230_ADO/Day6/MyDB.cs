using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{

    public class MyDB
    {
        private SqlCommandBuilder builder { get; set; }
        private SqlConnection conn;
        private SqlDataAdapter adapter;
        private DataSet ds;

        public MyDB()
        {
            conn = new SqlConnection(Day6.Properties.Settings.Default.DW2022);
            builder = new SqlCommandBuilder(adapter);
            adapter = new SqlDataAdapter();
            ds = new DataSet();
        }
        public DataTable GetDataTable(string sql, string Viwer)
        {
            ds.Clear();
            adapter.SelectCommand = new SqlCommand(sql, conn);

            adapter.Fill(ds, Viwer);
            return ds.Tables[Viwer];
        }
        public MyDB(string connect)
        {
            conn =new SqlConnection(connect);
            adapter = new SqlDataAdapter();
            builder = new SqlCommandBuilder(adapter);
            ds = new DataSet();
        }
        public void TestConnection()
        {
            using (SqlConnection conn = new SqlConnection(this.conn.ConnectionString))
            {
                conn.Open();  // 嘗試打開連線
            }
        }
        public bool InsertDataTable(string sql, string[] Key, string[] Values)
        {
            {
                adapter.InsertCommand = new SqlCommand(sql, conn);
                for (int i = 0; i < Key.Length; i++)
                {
                    adapter.InsertCommand.Parameters.AddWithValue(Key[i], Values[i]);
                }

                conn.Open();
                int xa = adapter.InsertCommand.ExecuteNonQuery();
                conn.Close();

                
                return xa > 0;
            }
        }
       
         
    }
}

