using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MyMidterm
{
    public partial class CustomerOrder : Form
    {
        SqlConnectionStringBuilder scsb;
        string strDBConnectString = "";

        
        public CustomerOrder()
        {
            InitializeComponent();
        }

        private void CustomerOrder_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "MyMidtermDB";
            scsb.IntegratedSecurity = true;
            strDBConnectString = scsb.ToString();

            lbl訂單號碼.Visible=false;
            lbl日期.Visible=false;
            lbl狀態.Visible = false;
            lbl訂單日期2.Visible = false;
            lbl訂單狀態2.Visible = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView2.RowHeadersVisible = false;
            產生訂單列表();
            產生訂單明細();
        }

        void 產生訂單列表()
        {
            SqlConnection con = new SqlConnection(strDBConnectString);
            con.Open(); 
            string strSQL = "select 訂單號碼 from Olist where pid = @NewPID group by 訂單號碼 ;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@NewPID", GlobalVar.memberID);
            SqlDataReader reader = cmd.ExecuteReader();
           


            if (reader.HasRows)
            {
                DataTable dt = new DataTable();  //DataTable變數型態
                dt.Load(reader);
                dataGridView1.DataSource = dt;
            }
            reader.Close();
            con.Close();
        }
        void 產生訂單明細()
        {
            SqlConnection con = new SqlConnection(strDBConnectString);
            con.Open();
            string strSQL = "select 訂購商品名稱,數量,總金額,飲料,配料,炸物 from Olist where 訂單號碼=@New訂單號碼;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@New訂單號碼", lbl訂單號碼.Text);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                DataTable dt = new DataTable();  //DataTable變數型態
                dt.Load(reader);
                dataGridView2.DataSource = dt;
            }
            reader.Close();
            con.Close();
        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string value = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

                lbl訂單號碼.Text = value;
                lbl日期.Visible = true;
                lbl狀態.Visible = true;
                lbl訂單號碼.Visible = true;
                lbl訂單日期2.Visible = true;
                lbl訂單狀態2.Visible = true;
                產生訂單明細();

                string str訂單號碼 = lbl訂單號碼.Text;
                SqlConnection con = new SqlConnection(strDBConnectString);
                con.Open();
                string strSQL = "select * from Olist where 訂單號碼 = @New訂單號碼;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@New訂單號碼", str訂單號碼);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read() == true)
                {
                    lbl狀態.Text = reader["訂單狀態"].ToString();
                    lbl訂單號碼.Text = reader["訂單號碼"].ToString();
                    lbl日期.Text = reader["訂單日期"].ToString();
                    lbl日期.Visible = true;
                    lbl狀態.Visible = true;
                    lbl訂單號碼.Visible = true;
                    lbl訂單日期2.Visible = true;
                    lbl訂單狀態2.Visible = true;
                    產生訂單明細();

                }

                reader.Close();
                con.Close();
            }
        }
        
    }
}
