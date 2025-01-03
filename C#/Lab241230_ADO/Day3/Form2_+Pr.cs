using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Day3
{
    //綁定窗口 > 資料由庫讀取資料(10萬筆OK!!!) >讀取後重新加載(SetdataGridView1)
    //先禁用按鈕 在設定按鈕時設定開啟條件避免重複迴圈(好讀)

    public partial class Form2__Pr : Form
    {
        SqlConnection conn;
        SqlDataAdapter adapter;
        DataSet ds;


        //最開始使用bind綁定窗口 SetdataGridView1
        private BindingSource GOGO = new BindingSource();


        //#2 取完數量之後設定變數 需要的有  
        //頁數(起始1)!!,看幾筆資料,共幾筆(起始0)

        private int page = 1;  
        private int pageSize = 10;    
        private int total = 0; 

        public Form2__Pr()
        {
            InitializeComponent();
        }

        private void Form2__Pr_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(Day3.Properties.Settings.Default.Dw2022);
            adapter = new SqlDataAdapter();
            ds = new DataSet();
            GOGO.DataSource = ds.Tables["DimCurrency"];


            dataGridView1.DataSource = GOGO;
            button2.Enabled = false;  //預設禁用
            button3.Enabled = false;
        }

        private void SetdataGridView1(string sql)
        {
            
            adapter.SelectCommand = new SqlCommand(sql, conn);

            if (ds.Tables["DimCurrency"] != null)
            {
                ds.Tables["DimCurrency"].Clear();
            }

            adapter.Fill(ds, "DimCurrency");
            GOGO.DataSource = ds.Tables["DimCurrency"];  //綁定窗口  
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            

            //#3 變數計算與事件綁定

            //計算筆數
            int x = (page - 1) * pageSize + 1;
            int datacount = page * pageSize;
            int y = (total + pageSize - 1) / pageSize;           //當前 總數
            //double y = Math.Ceiling((double)total / pageSize); //當前 總數

            //顯示筆數不可大於總數
            if (datacount > total)
            {
                datacount = total; 
            }


            label1.Text = $"第 {x} 筆 - 第 {datacount} 筆，共 {total} 筆資料";


            //#5 按鈕設定完了 用按鈕判斷 T&F


            //用page去控制開關可以避免重複加工 先完成按鈕的if判斷式(#4)再來做這步

            button2.Enabled = page > 1;  //(由page--)去判斷      [要與if判斷式一致]
            button3.Enabled = datacount < total; // pageSize 大於等於總數時直接禁用


            textBox1.Text = $"當前{page} 總共{y}"; 
        }


        //#1 我想進資料庫取資料數量 


        //計算頁數用    
        //ExecuteScalar  <-  為obj需轉int
        //每次都進資料庫取值 取完更新介面
        //後面按鈕就可以簡單設計
        private void countpage()
        {
            string countSql = "SELECT COUNT(*) FROM DimCurrency";
            SqlCommand sqldata = new SqlCommand(countSql, conn);
            conn.Open(); //連線
            total = (int)sqldata.ExecuteScalar(); //資料庫取回是OBJ須轉INT
            conn.Close();//斷線


            //老師的offset公式  取值                                             (起 始 是 1)
            string sql = $"SELECT * FROM DimCurrency ORDER BY CurrencyKey OFFSET {(page - 1) * pageSize} ROWS FETCH NEXT {pageSize} ROWS ONLY";
            SetdataGridView1(sql);//取完值更新介面 
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

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
