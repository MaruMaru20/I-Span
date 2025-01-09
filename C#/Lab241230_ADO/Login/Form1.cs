using System;
using Day6;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;

namespace Login
{

    //登入器完成 但只有本頁面綁定連線(只能登入)
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'adventureWorksDW2022DataSet.DimCurrency' 資料表。您可以視需要進行移動或移除。

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string username = textBox1.Text;
            //string password = textBox2.Text;
            //string SQL = textBox3.Text;
            //if (username == "class" && password == "8877") 
            //{
            //    MessageBox.Show("登入成功！");

            //}

            //var mainForm = new Day6.Form1();
            //mainForm.Show();

            //this.Hide();

            string username = textBox1.Text; // 使用者輸入的 SQL 帳號
            string password = textBox2.Text; // 使用者輸入的 SQL 密碼
            string host = textBox3.Text;
            
            if (!string.IsNullOrWhiteSpace(host))
            {
                //Data Source = localhost\SQLEXPRESS; Initial Catalog = AdventureWorksDW2022; Integrated Security = True; TrustServerCertificate = True
                string connect = textBox3.Text;
                try
                {
                    // 初始化 MyDB
                    MyDB myDB = new MyDB(connect);

                    // 測試連線
                    myDB.TestConnection();

                    MessageBox.Show("連線成功！");
                    var mainForm = new Day6.Form1();
                    mainForm.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"連線失敗: {ex.Message}");
                    label1.Text = "真Ｄ是8877";
                }
            }
            else
            {

                string connect = $"Server=localhost\\SQLEXPRESS;Database=AdventureWorksDW2022;User Id={username};Password={password};";
                try
                {
                    // 初始化 MyDB
                    MyDB myDB = new MyDB(connect);

                    // 測試連線
                    myDB.TestConnection();

                    MessageBox.Show("連線成功！");
                    var mainForm = new Day6.Form1();
                    mainForm.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"連線失敗: {ex.Message}");
                    label1.Text = "真Ｄ是8877";
                }
            }


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string connectionString = "Server=localhost\\SQLEXPRESS;Database=AdventureWorksDW2022;User Id=class;Password=8877;";
            //try
            //{
            //    using (SqlConnection conn = new SqlConnection(connectionString))
            //    {
            //        conn.Open();
            //        Console.WriteLine("連線成功！");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"連線失敗: {ex.Message}");
            //}
        }
    }
    

}
