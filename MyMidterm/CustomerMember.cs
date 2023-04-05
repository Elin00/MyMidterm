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
    public partial class CustomerMember : Form
    {
        SqlConnectionStringBuilder scsb;
        string strDBConnectString = "";

        public CustomerMember()
        {
            InitializeComponent();
        }

        private void CustomerMember_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "MyMidtermDB";
            scsb.IntegratedSecurity = true;
            strDBConnectString = scsb.ToString();

            lblID.Text = $"{GlobalVar.memberID}";
            lblEail.Text = $"{GlobalVar.strEmail}";
            txt密碼.Text = GlobalVar.strPassword;
            txt確認密碼.Text = GlobalVar.strPassword;
            txt姓名.Text = GlobalVar.strName;
            txt電話.Text = GlobalVar.strPhone;

            lblID.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if ((txt姓名.Text != "") && (txt電話.Text != "") && (txt密碼.Text != "") && (txt確認密碼.Text != ""))
            {
                if ((txt密碼.Text == txt確認密碼.Text))
                {
                    SqlConnection con = new SqlConnection(strDBConnectString);
                    con.Open();
                    string strSQL = "update member set name=@NewName,phone=@NewPhone,email=@NewEmail,password=@NewPassword where id =@SearchID";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@NewName", txt姓名.Text);
                    cmd.Parameters.AddWithValue("@NewPhone", txt電話.Text);
                    cmd.Parameters.AddWithValue("@NewEmail", lblEail.Text);
                    cmd.Parameters.AddWithValue("@NewPassword", txt密碼.Text);
                    cmd.Parameters.AddWithValue("@SearchID", lblID.Text);

                    MessageBox.Show("會員資料修改成功");
                    int rows = cmd.ExecuteNonQuery();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("確認密碼不符");
                }
            }
            else
            {
                MessageBox.Show("所有欄位不可為空白");
            }
        }
    }
}

//private void btn資料修改_Click(object sender, EventArgs e)
//{
//    int intID = 0;
//    Int32.TryParse(lblID.Text, out intID);

//    if ((intID > 0) && (txt姓名.Text != "") && (txt電話.Text != ""))
//    {
//        SqlConnection con = new SqlConnection(strDBConnectString);
//        con.Open();
//        string strSQL = "update person set 姓名=@NewName,電話=@NewPhone,地址=@NewAddress,email=@NewEmail,生日=@NewBirth,婚姻狀態=@NewMarriage,點數=@NewPoints where id = @SearchID";
//        SqlCommand cmd = new SqlCommand(strSQL, con);
//        cmd.Parameters.AddWithValue("@NewName", txt姓名.Text);
//        cmd.Parameters.AddWithValue("@NewPhone", txt電話.Text);
//        cmd.Parameters.AddWithValue("@NewAddress", txt地址.Text);
//        cmd.Parameters.AddWithValue("@NewEmail", txtEmail.Text);
//        cmd.Parameters.AddWithValue("@NewBirth", dtp生日.Value);
//        cmd.Parameters.AddWithValue("@NewMarriage", chk婚姻.Checked);
//        int intPoints = 0;
//        Int32.TryParse(txt會員點數.Text, out intPoints);
//        cmd.Parameters.AddWithValue("@NewPoints", intPoints);
//        cmd.Parameters.AddWithValue("@SearchID", intID);

//        int rows = cmd.ExecuteNonQuery();   //只執行不查詢,會有一個回傳值(影響的資料有幾筆)
//        con.Close();
//        MessageBox.Show($"{rows}個資料列收到影響");

//    }
//}
//}
