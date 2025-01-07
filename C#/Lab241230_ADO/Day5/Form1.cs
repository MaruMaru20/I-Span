using System;
using System.Data;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Day5
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            

        }
        My_DB myDB = new My_DB();
        DataTable dt;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Read_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM DimCurrency";

            DataTable dt = myDB.GetDataTable(sql, "DimCurrency");

            dataGridView1.DataSource = dt;


        }

        private void EXPT_Click(object sender, EventArgs e)
        {
            //string con = "Data Source=DESKTOP-AVM54SB\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True;TrustServerCertificate=True";
        }



        private void UPDATE_Click(object sender, EventArgs e)
        {
            string sql = "select * from DimCurrency";
            dt = myDB.GetDataTable(sql, "DimCurrency");

            DataRow row = dt.NewRow();
            row["CurrencyKey"] = 106;
            row["CurrencyAlternateKey"] = "XGY";
            row["CurrencyName"] = "SharkJ";
            dt.Rows.Add(row);

            myDB.InsertDataTable(dt);
        }
        private void UPself_Click(object sender, EventArgs e)
        {


        }

        private void Ans_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
