using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day3
{
    public partial class Form1 : Form
    {
        //1.
        SqlConnection conn;
        SqlDataAdapter adapter;
        DataSet ds;
        public Form1()
        {
            InitializeComponent();
        }

        private void SetdataGridView1(string sql)
        {
            adapter.SelectCommand = new SqlCommand(sql, conn);

            //4
            if (ds.Tables["DimCurrency"] != null && ds.Tables["DimCurrency"].Rows.Count > 0)
            {
                ds.Tables["DimCurrency"].Clear();
            }

            adapter.Fill(ds, "DimCurrency");
            dataGridView1.DataSource = ds.Tables["DimCurrency"];




            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //2.
            conn = new SqlConnection(Day3.Properties.Settings.Default.Dw2022);
            adapter = new SqlDataAdapter();
            ds = new DataSet();






            button1.Text = "查詢全部";
            button2.Text = "條件查詢";
            button3.Text = "實驗";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //3.
            string sql = "select * from DimCurrency ";
            SetdataGridView1 (sql);
            adapter.SelectCommand = new SqlCommand(sql, conn);

            //4
            if (ds.Tables["DimCurrency"] != null && ds.Tables["DimCurrency"].Rows.Count > 0)
            {
                ds.Tables["DimCurrency"].Clear();
            }

            adapter.Fill(ds, "DimCurrency");
            dataGridView1.DataSource = ds.Tables["DimCurrency"];





            dataGridView1.Columns[0].HeaderText = "ban";
            dataGridView1.Columns[1].HeaderText = "縮";
            dataGridView1.Columns[2].HeaderText = "念~~";

            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.IndexOf("=") > 0 )
            {
                MessageBox.Show("Error!");
                
            }

            //如果直接串字串會引發 SQL注入
            //嘗試輸入 1 or 1=1 會被取得所有資料
            //若輸入 1 or 1=1 ; Drop table DimCurrency.......>>>GG
            string sql = "select * from DimCurrency where CurrencyKey = " + textBox1.Text;
            SetdataGridView1(sql);

            dataGridView1.Columns[0].HeaderText = "號";
            dataGridView1.Columns[1].HeaderText = "國家";
            dataGridView1.Columns[2].HeaderText = "念~~";


        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "select * from DimCurrency where CurrencyKey = @apple";
            adapter.SelectCommand = new SqlCommand(sql, conn);

            //跟著技術文件走>>失敗
            
            adapter.SelectCommand.Parameters.AddWithValue("@apple", textBox1.Text);

            
            adapter.Fill(ds,"DimCurrency");
            dataGridView1.DataSource = ds.Tables["DimCurrency"];
        }
    }
}
