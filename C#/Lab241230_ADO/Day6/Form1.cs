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
        private int pageSize = 5;
        //private int total = 0;
        public Form1()
        {
            InitializeComponent();
        }
        MyDB myDB = new MyDB();
        DataTable dt;

        private void Form1_Load(object sender, EventArgs e)
        {
            CurrencyKey.Enabled = false;
        }

        private void Read_Click(object sender, EventArgs e)
        {
            //string sql = "SELECT * FROM DimCurrency";
            //dataGridView1.DataSource = MyDB.GetDataTable(sql);
            //added
            string selectfrom = "DimPromotion";
            string keyzone = "PromotionKey";
            string sql = $"SELECT * FROM {selectfrom} ORDER BY {keyzone} OFFSET {(page - 1) * pageSize} ROWS FETCH NEXT {pageSize} ROWS ONLY";
            dataGridView1.DataSource = myDB.GetDataTable(sql, "Viewer");
            


            //Read.DataBindings.Clear();
            //Insert.DataBindings.Clear();
            //UPDATE.DataBindings.Clear();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            //string sql = "select CurrencyKey from DimCurrency where CurrencyAlternateKey = 'ZZZ'";
            //DataTable dt = myDB.GetDataTable(sql, "Viewer");
            //Ans.Text = dt.Rows[0].ItemArray[0].ToString();
            string Key = "";
            string sql = $"SELECT * FROM DimCurrency WHERE CurrencyAlternateKey = 'ZZA'";
            DataTable dt = myDB.GetDataTable(sql, "DimCurrency");
            if (dt != null )
            {
                MessageBox.Show($"新增中");
            }
            else
            {
                Ans.Text = dt.Rows[0]["CurrencyAlternateKey"].ToString();
            }


            if (Ans.Text == null)
            {
                
            }
            else
            {
                
                MessageBox.Show($"已存在名稱:{Ans.Text}");
                

            }
        

        }

        private void EXPT_Click(object sender, EventArgs e)
        {

        }


    }
}
