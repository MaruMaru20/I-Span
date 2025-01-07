using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{

    internal class MyDB
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
        public void InsertDataTable(string sql, string[] Key, string[] Values)
        {
             //string sql = @"INSERT INTO DimCurrency
             //           (CurrencyAlternateKey,CurrencyName)
             //           VALUES
             //           (@p1,@p2)";
        }
    }
}

