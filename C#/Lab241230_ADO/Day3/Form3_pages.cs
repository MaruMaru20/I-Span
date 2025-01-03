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

namespace Day3
{
    public partial class Form3_pages : Form
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
        public Form3_pages()
        {
            InitializeComponent();
        }



        private void Form3_pages_Load_1(object sender, EventArgs e)
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
    }
}

