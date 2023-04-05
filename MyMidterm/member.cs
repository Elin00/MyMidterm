using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace MyMidterm
{
    public partial class member : Form
    {
        SqlConnectionStringBuilder scsb;
        string strMyDBConnectionString = "";

        List<int> listID = new List<int>();
        List<string> listName = new List<string>();
        List<string> listPhone = new List<string>();
        List<string> listEmail = new List<string>();
        List<int> list權限 = new List<int>();
 

        bool is認證成功 = false;

        public member()
        {
            InitializeComponent();
        }

        private void member_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "MyMidtermDB";
            scsb.IntegratedSecurity = true;
            strMyDBConnectionString = scsb.ToString();

            txtSignMail.Text = "請輸入電子郵件";
            txtSignPassword.Text = "請輸入密碼";

            label10.Visible = false;

        }

        private void txtSignMail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSignPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            if((txtSignMail.Text!= "") && (txtSignPassword.Text != ""))
            {
                string strSignMail = txtSignMail.Text;
                string strSignPassword = txtSignPassword.Text;

                SqlConnection con = new SqlConnection(strMyDBConnectionString);
                con.Open();
                string strSQL = string.Format("select * from member where email='{0}' and password='{1}'", strSignMail, strSignPassword);
               
                SqlCommand cmd = new SqlCommand(strSQL, con);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    is認證成功 = true;
                }

                if (is認證成功)
                {
                    MessageBox.Show("登入成功");
                    GlobalVar.memberID = (int)reader["id"];
                    GlobalVar.strName = reader["name"].ToString();
                    GlobalVar.strPhone = reader["phone"].ToString();
                    GlobalVar.int權限 = (int)reader["權限"];
                    GlobalVar.strEmail = reader["email"].ToString();
                    GlobalVar.strPassword = reader["password"].ToString();

                    Close();
                }
                else
                {
                    MessageBox.Show("登入失敗");
                }

                reader.Close();
                con.Close();

            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        void 清空註冊欄位()
        {
            txtEmail.Clear();
            txtPassword.Clear();
            txtPassword2.Clear();
            txtName.Clear();
            txtPhone.Clear();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if((txtEmail.Text != "") && (txtPassword.Text != "") && (txtPassword2.Text != "") && (txtName.Text != "") 
                && (txtPhone.Text != ""))
            {
                if((txtPassword.Text == txtPassword2.Text))
                { 
                SqlConnection con = new SqlConnection(strMyDBConnectionString);
                con.Open();
                string strSQL = "insert into member values(@NewName,@NewPhone,@NewEmail,@NewPassword,1);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewEmail", txtEmail.Text);
                cmd.Parameters.AddWithValue("@NewPassword", txtPassword.Text);
                cmd.Parameters.AddWithValue("@NewName", txtName.Text);
                cmd.Parameters.AddWithValue("@NewPhone", txtPhone.Text);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("會員註冊成功");
                清空註冊欄位();
                }
                else
                {
                    label10.Visible = true;
                    txtPassword2.Clear(); 
                }
            }
            else
            {
                MessageBox.Show("所有欄位為必填");
            }
        }

        private void member_FormClosing(object sender, FormClosingEventArgs e)
        {
           if(is認證成功)
            {
                e.Cancel = false;
            }
           else
            {
                e.Cancel = true;
            }
  
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
