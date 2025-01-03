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

namespace Day4
{
    public partial class Form1_pages : Form
    {
        SqlConnection conn;
        SqlDataAdapter adapter;
        DataSet ds;

        private BindingSource GOGO = new BindingSource();


        //#2 取完數量之後設定變數 需要的有  
        //頁數(起始1)!!,看幾筆資料,共幾筆(起始0)

        private int page = 1;
        private int pageSize = 10;
        private int total = 0;
        public Form1_pages()
        {
            InitializeComponent();
        }



        private void Form1_pages_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(Day4.Properties.Settings.Default.DW2022);
            adapter = new SqlDataAdapter();
            ds = new DataSet();
            GOGO.DataSource = ds.Tables["MyViewer"];


            dataGridView1.DataSource = GOGO;
            button2.Enabled = false;  //預設禁用
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            textBox1.Enabled = false;
            
            textBox3.Enabled = false;
            
            
            


        }

        private void SetdataGridView1(string sql)
        {


            adapter.SelectCommand = new SqlCommand(sql, conn);


            if (ds.Tables["MyViewer"] != null)
            {
                ds.Tables["MyViewer"].Clear();
            }

            adapter.Fill(ds, "MyViewer");
            GOGO.DataSource = ds.Tables["MyViewer"];  //綁定窗口  
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            
            textBox3.Enabled = true;
            button5.Enabled = true;


            //#3 變數計算與事件綁定

            //計算筆數
            int x = (page - 1) * pageSize + 1;
            int datacount = page * pageSize;
            int totalpage = (total + pageSize - 1) / pageSize;           //當前 總數
            
            //double y = Math.Ceiling((double)total / pageSize); //當前 總數

            //顯示筆數不可大於總數
            if (datacount > total)
            {
                datacount = total;
            }

            
            textBox3.Text = pageSize.ToString();

            label1.Text = $"第 {x} 筆 - 第 {datacount} 筆，共 {total} 筆資料";

            

            //#5 按鈕設定完了 用按鈕判斷 T&F


            //用page去控制開關可以避免重複加工 先完成按鈕的if判斷式(#4)再來做這步
            
            button2.Enabled = page > 1;  //(由page--)去判斷      [要與if判斷式一致]
            button3.Enabled = datacount < total; // pageSize 大於等於總數時直接禁用

            if (totalpage <= 1)
            {
                textBox1.Text = $"當前:{totalpage} 總共:{totalpage}";
                
            }
            else 
            {
                textBox1.Text = $"當前:{page} 總共:{totalpage}";
            }

            


        }


        //#1 我想進資料庫取資料數量 


            //計算頁數用    
            //ExecuteScalar  <-  為obj需轉int
            //每次都進資料庫取值 取完更新介面
            //後面按鈕就可以簡單設計


        private void countpage()
        {

            //新增  DimDate , DateKey    |  DimCurrency , CurrencyKey
            string selectfrom = "DimDate"; //SQL資料表選擇區
            string keyzone = "DateKey";    //選擇資料表候選KEY


            string countSql = $"SELECT COUNT(*) FROM {selectfrom}";
            SqlCommand sqldata = new SqlCommand(countSql, conn);
            conn.Open(); //連線
            total = (int)sqldata.ExecuteScalar(); //資料庫取回是OBJ須轉INT
            conn.Close();//斷線


            //老師的offset公式  取值                                             (起 始 是 1)
            string sql = $"SELECT * FROM {selectfrom} ORDER BY {keyzone} OFFSET {(page - 1) * pageSize } ROWS FETCH NEXT {pageSize} ROWS ONLY";
            SetdataGridView1(sql);//取完值更新介面 



            label4.Text = $"{selectfrom}";
            

            
            
        }

        //#4 設定按鈕 

        //READ button 
        private void button1_Click(object sender, EventArgs e)
        {
            
            page = 1;  //如果按完按鈕就禁用可以免+這個
            countpage();
        }
        //PG-UP button
        private void button2_Click(object sender, EventArgs e)
        {
            if (page > 1)
            {
                page--;
                countpage();
            }
        }
        //PG-DN button
        private void button3_Click(object sender, EventArgs e)
        {
            if (page * pageSize < total)
            {
                page++;
                countpage();

            }

        }
        //keykeypress 數字
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // 阻止輸入
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (page > total) {
                MessageBox.Show("！");
            }

            if (int.TryParse(textBox3.Text, out int newPageSize) && newPageSize > 0 )
            {
                pageSize = newPageSize; // 更新 pageSize
                countpage();

            }
            else if (!string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("！");
            }
        }
        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.button5_Click(sender, e);

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
