using System.Data;
using System.Data.SqlClient;

namespace Day5
{
    public class My_DB
    {
        private SqlCommandBuilder builder {  get; set; }
        private SqlConnection conn;
        private SqlDataAdapter adapter;
        private DataSet ds;

        public My_DB()
        {
            conn = new SqlConnection(Day5.Properties.Settings.Default.DW2022);
            adapter = new SqlDataAdapter();
            ds = new DataSet();
        }
        public My_DB(string connstring)
        {
            conn = new SqlConnection(connstring);
            adapter = new SqlDataAdapter();
            builder = new SqlCommandBuilder();
            ds = new DataSet();
        }


        public DataTable GetDataTable(string sql, string tableName)
        {
            ds.Clear(); 
            adapter.SelectCommand = new SqlCommand(sql, conn);

            adapter.Fill(ds, tableName);

            return ds.Tables[tableName];
        }
        public void InsertDataTable(DataTable dt)
        {
            SqlCommand xa = builder.GetInsertCommand();
            adapter.SelectCommand = xa;
            adapter.Update(dt);
            int temp = adapter.Update(dt);
                return temp;
        }
    }
}
