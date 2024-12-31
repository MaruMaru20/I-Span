using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day2
{
    public partial class Form4_where : Form
    {
        SqlConnection connect;
        SqlDataAdapter adapter;
        DataSet ds;
        public Form4_where()
        {
            InitializeComponent();
        }





        private void Form4_where_Load_1(object sender, EventArgs e)
        {
            connect = new SqlConnection(Day2.Properties.Settings.Default.AdventureWorksDW2022ConnectionString);
            adapter = new SqlDataAdapter();
            ds = new DataSet();
           





            button1.Text = "查詢全部";
            button2.Text = "條件查詢";
            button3.Text = "實驗";

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "select * from DimCurrency ";
            SqlCommand _sqlCommand = new SqlCommand(sql, connect);
            adapter.SelectCommand = _sqlCommand;
            adapter.Fill(ds, "MSIT62");
            dataGridView1.DataSource = ds.Tables["MSIT62"];


            dataGridView1.Columns[0].HeaderText = "ban";
            dataGridView1.Columns[1].HeaderText = "縮";
            dataGridView1.Columns[2].HeaderText = "念";

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string sql = "select * from DimCurrency where CurrencyKey =102";
            SqlCommand sqlCommand = new SqlCommand(sql, connect);
            adapter.SelectCommand = sqlCommand;
            //ds.Tables["MSIT62"] != null
            //ds.Tables["MSIT62"].Rows.Count > 0
            if (ds.Tables["MSIT62"] != null)
            {
                ds.Tables["MSIT62"].Clear();
            }
            
            adapter.Fill(ds, "MSIT62");
            dataGridView1.DataSource = ds.Tables["MSIT62"];
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
