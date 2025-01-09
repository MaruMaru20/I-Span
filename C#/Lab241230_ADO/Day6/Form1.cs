using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Day6
{
    public partial class Form1 : Form
    {
        //added
        MyDB MyDB;
        private int page = 1;
        private int pageSize = 200;
        //private int total = 0;
        public Form1()
        {
            InitializeComponent();
        }
        MyDB myDB = new MyDB();
        

        private void Form1_Load(object sender, EventArgs e)
        {
            CurrencyKey.Enabled = false;

        }

        private void Read_Click(object sender, EventArgs e)
        {
            //string sql = "SELECT * FROM DimCurrency";DimPromotion,PromotionKey
            //dataGridView1.DataSource = MyDB.GetDataTable(sql);
            //added
            UPDATE.Enabled = true;
            string selectfrom = "DimCurrency";
            string keyzone = "CurrencyKey";
            string sql = $"SELECT * FROM {selectfrom} ORDER BY {keyzone} OFFSET {(page - 1) * pageSize} ROWS FETCH NEXT {pageSize} ROWS ONLY ";
            DataTable dt = myDB.GetDataTable(sql, "Viewer");

            dataGridView1.DataSource = dt;


            //資料繫結
            CurrencyKey.DataBindings.Clear();
            CurrencyAlternateKey.DataBindings.Clear();
            CurrencyName.DataBindings.Clear();

            CurrencyKey.DataBindings.Add("Text", dt, "CurrencyKey");  
            CurrencyAlternateKey.DataBindings.Add("Text", dt, "CurrencyAlternateKey");
            CurrencyName.DataBindings.Add("Text", dt, "CurrencyName");



        }

        private void Insert_Click(object sender, EventArgs e)
        {
            //string sql = "select CurrencyKey from DimCurrency where CurrencyAlternateKey = 'ZZZ'";
            //DataTable dt = myDB.GetDataTable(sql, "Viewer");
            //Ans.Text = dt.Rows[0].ItemArray[0].ToString();

            UPDATE.Enabled = true;
            string Key = CurrencyAlternateKey.Text;
            string chk = $"SELECT * FROM DimCurrency WHERE CurrencyAlternateKey = '{Key}'";
            DataTable dt = myDB.GetDataTable(chk, "DimCurrency");

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show($"{Key} 不存在，可新增相關資料");


            }
            else if (dt.Rows.Count > 0)

            {
                Ans.Text = dt.Rows[0]["CurrencyAlternateKey"].ToString();
                MessageBox.Show($"已存在名稱:{Key}");
                Read_Click(sender, e);
                return;

            }

            string sql = "insert into DimCurrency(CurrencyAlternateKey,CurrencyName) values (@p1,@p2)";
            string[] keys = { "@p1", "@p2" };
            string[] sqlvalues = { CurrencyAlternateKey.Text, CurrencyName.Text };
            bool insert = myDB.InsertDataTable(sql, keys, sqlvalues);
                if (insert)
                {
                    MessageBox.Show($"OK");
                    Read_Click(sender, e);
            }
                else
                {
                    MessageBox.Show($"Faild!");
                }
            }

        private void UPDATE_Click(object sender, EventArgs e)
        {
            string Key = CurrencyAlternateKey.Text;
            string chk = $"SELECT * FROM DimCurrency WHERE CurrencyAlternateKey = '{Key}'";
            DataTable dt = myDB.GetDataTable(chk, "DimCurrency");

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show($"{Key} 不存在，請新增相關資料");
                UPDATE.Enabled = false;
                return;

            }
            else if (dt.Rows.Count == 1)

            {
                
                Ans.Text = dt.Rows[0]["CurrencyAlternateKey"].ToString();
                MessageBox.Show($"準備更新:{Key}");


            }else
            {
                MessageBox.Show($"錯誤: {Key}有多筆 您要更新哪一筆?");
            }
            string sql = "UPDATE DimCurrency " +
                         "SET CurrencyAlternateKey = @p1, CurrencyName = @p2 " +
                         "WHERE CurrencyAlternateKey = @p3;";

            string[] keys = { "@p1", "@p2", "@p3" };
            string[] sqlvalues = { CurrencyAlternateKey.Text, CurrencyName.Text, dt.Rows[0]["CurrencyAlternateKey"].ToString() };

            bool insert = myDB.InsertDataTable(sql, keys, sqlvalues);
            if (insert)
            {
                MessageBox.Show($"更新成功");
                Read_Click(sender, e);
            }
            else
            {
                MessageBox.Show($"失敗!");
            }
        }

        private void EXPT_Click(object sender, EventArgs e)
        {
            //警告      誤觸會影響資料
            //警告      誤觸會影響資料
            //警告      誤觸會影響資料
            //警告      誤觸會影響資料
            //警告      誤觸會影響資料
            //警告      誤觸會影響資料
            string Key = CurrencyAlternateKey.Text;
            string chk = $"SELECT * FROM DimCurrency WHERE CurrencyAlternateKey = '{Key}'";
            DataTable dt = myDB.GetDataTable(chk, "DimCurrency");

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show($"{Key} 不存在，請新增相關資料");
                
                return;

            }
            else if (dt.Rows.Count == 1)

            {

                Ans.Text = dt.Rows[0]["CurrencyAlternateKey"].ToString();
                DialogResult result = MessageBox.Show($"確定刪除 CurrencyAlternateKey: {Key} ？",
                                          "確認",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    string sql = "DELETE FROM DimCurrency WHERE CurrencyAlternateKey = @p1";
                    string[] keys = { "@p1" };
                    string[] sqlvalues = { CurrencyAlternateKey.Text };
                    bool insert = myDB.InsertDataTable(sql, keys, sqlvalues);
                    if (insert)
                    {
                        MessageBox.Show($"已刪除","!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Read_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show($"失敗!");
                    }
                } else
                {
                    MessageBox.Show($"已取消","!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
           
        }
        




        private void CurrencyAlternateKey_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = textBox1.Text;
            MyDB db = new MyDB(connectionString);
        }
    }
}
