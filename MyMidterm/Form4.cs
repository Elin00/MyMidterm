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

namespace MyMidterm
{
    public partial class Form4 : Form
    {
        SqlConnectionStringBuilder scsb;
        string strDBConnectString = "";

        string str狀態完成 = "已完成";
        string str狀態未完成 = "未完成";


        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "MyMidtermDB";
            scsb.IntegratedSecurity = true;
            strDBConnectString = scsb.ToString();

            lbl訂單號碼.Visible = false;
            lbl訂單號碼2.Visible = false;
            lbl狀態.Visible = false;
            lbl訂購人.Visible=false;
            btn修改狀態.Visible = false;
            lbl訂單狀態2.Visible= false;
            lbl日期.Visible = false;
            lbl訂單日期2.Visible = false;

            dataGridView未完成.RowHeadersVisible = false;
            dataGridView訂單明細.RowHeadersVisible = false;
            dataGridView1.RowHeadersVisible = false;

            產生訂單已完成列表();
            產生訂單未完成列表();
        }
        void 產生訂單已完成列表()
        {
            SqlConnection con = new SqlConnection(strDBConnectString);
            con.Open();
            string strSQL = "select 訂單號碼 from Olist where 訂單狀態=@New狀態完成 group by 訂單號碼 ;";
           // string strSQL = "select id, 訂單號碼 from Olist where 訂單狀態=@New狀態完成; "; 
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@New狀態完成", str狀態完成);
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

        void 產生訂單未完成列表()
        {
            SqlConnection con = new SqlConnection(strDBConnectString);
            con.Open();
            string strSQL = "select 訂單號碼 from Olist where 訂單狀態=@New狀態未完成 group by 訂單號碼; ";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@New狀態未完成", str狀態未完成);
            SqlDataReader reader = cmd.ExecuteReader();



            if (reader.HasRows)
            {
                DataTable dt = new DataTable();  //DataTable變數型態
                dt.Load(reader);
                dataGridView未完成.DataSource = dt;
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
                dataGridView訂單明細.DataSource = dt;
            }
            reader.Close();
            con.Close();
        }

        private void dataGridView未完成_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string value = dataGridView未完成.Rows[e.RowIndex].Cells[0].Value.ToString();
                lbl訂單號碼.Text = value;

                lbl訂單號碼.Visible = true;
                lbl訂單號碼2.Visible = true;
                //lbl狀態.Visible = true;
                lbl訂購人.Visible = true;
                btn修改狀態.Visible = true;
                //lbl訂單狀態2.Visible = true;
                btn修改狀態.Visible = true;
                lbl日期.Visible = true;
                lbl訂單日期2.Visible = true;
                產生訂單明細();

                    SqlConnection con = new SqlConnection(strDBConnectString);
                    con.Open();
                    string strSQL = "select * from Olist where 訂單號碼 = @New訂單號碼;";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@New訂單號碼", lbl訂單號碼.Text);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read() == true)
                    {

                        lbl訂單號碼.Visible = true;
                        lbl訂單號碼2.Visible = true;
                        //lbl狀態.Visible = true;
                        lbl訂購人.Visible = true;
                        btn修改狀態.Visible = true;
                        //lbl訂單狀態2.Visible = true;
                        lbl日期.Visible = true;
                        lbl訂單日期2.Visible = true;

                    lbl日期.Text = reader["訂單日期"].ToString();
                         lbl狀態.Text = reader["訂單狀態"].ToString();
                        lbl訂購人.Text = reader["訂購人"].ToString();
                        lbl訂單號碼.Text = reader["訂單號碼"].ToString();
                        btn修改狀態.Visible = true;
                        產生訂單明細();
                    }
                    else
                    {
                        //清空欄位();
                    }
                    reader.Close();
                    con.Close();
                }
            
             
        }

        private void btn修改狀態_Click(object sender, EventArgs e)
        {
                    SqlConnection con = new SqlConnection(strDBConnectString);
                    con.Open();
                    string strSQL = "update Olist set 訂單狀態=@New狀態完成 where 訂單號碼=@New訂單號碼";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                     cmd.Parameters.AddWithValue("@New狀態完成", str狀態完成);
                    cmd.Parameters.AddWithValue("@New訂單號碼", lbl訂單號碼.Text);

                    int rows = cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("資料修改成功");
                
            }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
               
                string value = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                lbl訂單號碼.Text = value;

                lbl訂單號碼.Visible = true;
                lbl訂單號碼2.Visible = true;
                lbl訂購人.Visible = true;
                btn修改狀態.Visible = true;
                //lbl狀態.Visible = true;
                //lbl訂單狀態2.Visible = true;
                btn修改狀態.Visible = false;
                lbl日期.Visible = true;
                lbl訂單日期2.Visible = true;
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
                        lbl訂單號碼.Visible = true;
                        lbl訂單號碼2.Visible = true; 
                        lbl訂購人.Visible = true;
                        btn修改狀態.Visible = false ;
                        //lbl訂單狀態2.Visible = true;
                        //lbl狀態.Visible = true;
                        lbl日期.Visible = true;
                        lbl訂單日期2.Visible = true;
                        lbl日期.Text = reader["訂單日期"].ToString();
                        lbl狀態.Text = reader["訂單狀態"].ToString();
                        lbl訂購人.Text = reader["訂購人"].ToString();
                        lbl訂單號碼.Text = reader["訂單號碼"].ToString();


                        btn修改狀態.Visible = false;
                        產生訂單明細();
                    }
                    
                    reader.Close();
                    con.Close();
                
            }
            }

        private void btn更新_Click(object sender, EventArgs e)
        {
            產生訂單已完成列表();
            產生訂單未完成列表();

            lbl訂單號碼.Visible = false;
            lbl訂單號碼2.Visible = false;
            lbl狀態.Visible = false;
            lbl訂購人.Visible = false;
            btn修改狀態.Visible = false;
            dataGridView訂單明細.DataSource = null;
            lbl訂單狀態2.Visible = false;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
