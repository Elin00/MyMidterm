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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace MyMidterm
{
    
    public partial class MemberManagement : Form
    {
        SqlConnectionStringBuilder scsb;
        string strDBConnectString = "";
        

        public MemberManagement()
        {
            InitializeComponent();
        }

        private void MemberManagement_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "MyMidtermDB";
            scsb.IntegratedSecurity = true;
            strDBConnectString = scsb.ToString();
            dataGridView1.RowHeadersVisible = false;

            lblID.Visible = false;
            產生會員資料列表();

        }
        void 產生會員資料列表()
        {
            SqlConnection con = new SqlConnection(strDBConnectString);
            con.Open();
            string strSQL = "select id,name as 姓名,phone as 電話,email as 帳號,password as 密碼 from member;";
            SqlCommand cmd = new SqlCommand(strSQL,con);
            SqlDataReader reader = cmd.ExecuteReader();

            if(reader.HasRows)
            {
                DataTable dt = new DataTable();  //DataTable變數型態
                dt.Load(reader);
                dataGridView1.DataSource = dt;
            }
            reader.Close();
            con.Close();
        }
        void 清空欄位()
        {
            txtEmail.Clear();
            txt密碼.Clear();
            txt姓名.Clear();
            txt電話.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string strSelectID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                int intSelectedID = 0;
                bool isID = Int32.TryParse(strSelectID, out intSelectedID);

                if (isID == true)
                {
                    SqlConnection con = new SqlConnection(strDBConnectString);
                    con.Open();
                    string strSQL = "select * from member where id = @SearchID;";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@SearchID", intSelectedID);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read() == true)
                    {
                        lblID.Text = reader["id"].ToString();
                        txtEmail.Text = reader["email"].ToString();
                        txt密碼.Text = reader["password"].ToString();
                        txt姓名.Text = reader["name"].ToString();
                        txt電話.Text = reader["phone"].ToString();
                    }
                    else
                    {
                        清空欄位();
                    }
                    reader.Close();
                    con.Close();
                }
            }
        }

        private void btn修改資料_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(lblID.Text, out intID);

            if((intID>0) && (txtEmail.Text !="") && (txt密碼.Text != "") && (txt姓名.Text != "") && (txt電話.Text != ""))
            {
                SqlConnection con = new SqlConnection(strDBConnectString);
                con.Open();
                string strSQL = "update member set email=@NewMail,password=@NewPassword,name=@NewName,phone=@NewPhone where id=@SearchID";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewMail", txtEmail.Text);
                cmd.Parameters.AddWithValue("@NewPassword", txt密碼.Text);
                cmd.Parameters.AddWithValue("@NewName",txt姓名.Text);
                cmd.Parameters.AddWithValue("@NewPhone", txt電話.Text);
                cmd.Parameters.AddWithValue("@SearchID", intID);
               
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("資料修改成功");
            }
        }
      

        private void btn清空欄位_Click(object sender, EventArgs e)
        {
            清空欄位();        }

        private void btn新增資料_Click(object sender, EventArgs e)
        {
            if ((txtEmail.Text != "") && (txt密碼.Text != "") && (txt姓名.Text != "") && (txt電話.Text != ""))
            {
                SqlConnection con = new SqlConnection(strDBConnectString);
                con.Open();
                string strSQL = "insert into member values(@NewName,@NewPhone,@NewMail,@NewPassword,1);";
                SqlCommand cmd = new SqlCommand(strSQL, con); 
                cmd.Parameters.AddWithValue("@NewMail", txtEmail.Text);
                cmd.Parameters.AddWithValue("@NewPassword", txt密碼.Text);
                cmd.Parameters.AddWithValue("@NewName", txt姓名.Text);
                cmd.Parameters.AddWithValue("@NewPhone", txt電話.Text);
                

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("資料新增成功");
            }
        }

        private void btn刪除資料_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(lblID.Text, out intID);

            if (intID > 0)
            {
                DialogResult R = MessageBox.Show("是否確認刪除此筆資料", "確認框", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (R == DialogResult.OK)
                {
                    SqlConnection con = new SqlConnection(strDBConnectString);
                    con.Open();
                    string strSQL = "delete from member where id = @DeleteID;";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@DeleteID", intID);

                    int rows = cmd.ExecuteNonQuery();
                    con.Close();
                    清空欄位();
                    MessageBox.Show("資料刪除成功");

                }
            }
        }

        private void btn重新整理_Click(object sender, EventArgs e)
        {
            產生會員資料列表();
        }
    }
}
