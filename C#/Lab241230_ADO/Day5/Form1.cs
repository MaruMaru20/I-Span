using System;
using System.Data;
using System.Windows.Forms;

namespace Day5
{
    public partial class Form1 : Form
    {
        private My_DB myDB;
        DataTable dt;
        public Form1()
        {
            InitializeComponent();
            myDB = new My_DB();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Read_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM DimCurrency";

            DataTable dt = myDB.GetDataTable(sql, "DimCurrency");

            dataGridView1.DataSource = dt;

            dataGridView1.Columns[0].HeaderText = "Currency Key";
            dataGridView1.Columns[1].HeaderText = "Currency Alternate Key";
            dataGridView1.Columns[2].HeaderText = "Currency Name";
        }

        private void EXPT_Click(object sender, EventArgs e)
        {
            //string con = "Data Source=DESKTOP-AVM54SB\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True;TrustServerCertificate=True";
        }



        private void UPDATE_Click(object sender, EventArgs e)
        {
            My_DB newyourself = new My_DB();

            DataRow row = dt.NewRow(); 
            row["CurrencyKey"] = 106;
            row["CurrencyAlternateKey"] = "ZZZ";
            row["CurrencyName"] = "newyourself";
            dt.Rows.Add(row);

            newyourself.InsertDataTable(dt);
        }
        private void UPself_Click(object sender, EventArgs e)
        {


        }
    }
}
