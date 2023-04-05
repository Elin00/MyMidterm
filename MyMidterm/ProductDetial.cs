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
using System.Security.Cryptography;

namespace MyMidterm
{
    public partial class ProductDetial : Form
    {
        public int PID = 0;
        SqlConnectionStringBuilder scsb;
        string strMyDBConnectionString = "";
        string image_dir = @"images\";
        string image_name = "";
        bool is已修改圖檔 = false;
        

        private void ProductDetial_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "MyMidtermDB";
            scsb.IntegratedSecurity = true;
            strMyDBConnectionString = scsb.ToString();

            lblPID.Visible = false;
           

            if (PID > 0)
            {
                //修改模式
                groupBox新增.Visible = false;
                groupBox修改.Visible = true;
                顯示商品詳細資訊();
            }
            else
            {
                //新增模式
                groupBox新增.Visible = true;
                groupBox修改.Visible = false;
            }
        }
        
        void 顯示商品詳細資訊()
        {
            SqlConnection con = new SqlConnection(strMyDBConnectionString);
            con.Open();
            string strSQL = "select * from products where id = @SearchID;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchID", PID);
            SqlDataReader reader = cmd.ExecuteReader();

            int i = 0;
            while (reader.Read())
            {
                lblPID.Text = reader["id"].ToString();
                txt商品名稱.Text = reader["pname"].ToString();
                txt商品價格.Text = reader["price"].ToString();
                image_name = reader["pimage"].ToString();
                pictureBox1.Image = Image.FromFile(image_dir + image_name);
                i += 1;
            }
        }
        public ProductDetial()
        {
            InitializeComponent();
        }

        private void btn選取商品圖片_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "檔案類型 (*.jpg, *.jpeg, *.png)|*.jpeg;*.jpg;*.png";   //  |=>or  左邊描述可隨意寫
            DialogResult R = f.ShowDialog();

            if (R == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(f.FileName);
                string fileExtension = System.IO.Path.GetExtension(f.SafeFileName);  //取得副檔名(SafeFileName:不包含目錄)
                Random myRand = new Random();
                image_name = DateTime.Now.ToString("yyyyMMddHHmmss") + myRand.Next(1000, 10000).ToString() + fileExtension;
                //產生系統化名稱,防止名稱重複
                is已修改圖檔 = true;
            }
        }

        private void btn儲存商品_Click(object sender, EventArgs e)
        {
            if ((txt商品名稱.Text != "") && (txt商品價格.Text != "") && (pictureBox1.Image != null))
            {

                int intID = 0;
                Int32.TryParse(lblPID.Text, out intID);

                if (is已修改圖檔 == true)
                {
                    pictureBox1.Image.Save(image_dir + image_name);
                    is已修改圖檔 = false;
                }
                SqlConnection con = new SqlConnection(strMyDBConnectionString);
                con.Open();
                string strSQL = "update products set pname=@NewPname,price=@NewPrice,pimage=@NewPimage where id=@SearchID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewPname", txt商品名稱.Text);
                int intPrice = 0;
                Int32.TryParse(txt商品價格.Text, out intPrice);
                cmd.Parameters.AddWithValue("@NewPrice", intPrice);
                cmd.Parameters.AddWithValue("@NewPimage", image_name);
                cmd.Parameters.AddWithValue("@SearchID", intID);
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("資料儲存成功");
            }

            else
            {
                MessageBox.Show("所有欄位必填!!");
            }
        }
        void 清空欄位()
        {
            lblPID.Text = "";
            txt商品名稱.Clear();
            txt商品價格.Clear();
            pictureBox1.Image = null;
        }
        private void btn清空欄位_Click(object sender, EventArgs e)
        {
            清空欄位();
        }

        private void btn新增商品_Click(object sender, EventArgs e)
        {
            if ((txt商品名稱.Text != "") && (txt商品價格.Text != "") && (pictureBox1.Image != null))
            {
                if (is已修改圖檔 == true)
                {
                    pictureBox1.Image.Save(image_dir + image_name);
                    is已修改圖檔 = false;
                }
                SqlConnection con = new SqlConnection(strMyDBConnectionString);
                con.Open();
                string strSQL = "Insert into products values(@NewPname,@NewPrice,@NewPimage);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewPname", txt商品名稱.Text);
                int intPrice = 0;
                Int32.TryParse(txt商品價格.Text, out intPrice);
                cmd.Parameters.AddWithValue("@NewPrice", intPrice);
                cmd.Parameters.AddWithValue("@NewPimage", image_name);
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("資料新增成功");
            }

            else
            {
                MessageBox.Show("所有欄位必填!!");
            }
        }

        private void btn刪除_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(lblPID.Text, out intID);

            ProductDetial f = new ProductDetial();
            
            if (intID > 0)
            {
                DialogResult R = MessageBox.Show("是否確認刪除此筆資料","確認框",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                if (R == DialogResult.OK)
                {
                    SqlConnection con = new SqlConnection(strMyDBConnectionString);
                    con.Open();
                    string strSQL = "delete from products where id = @DeleteID;";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@DeleteID", intID);

                    int rows = cmd.ExecuteNonQuery();
                    con.Close();
                    清空欄位();
                    MessageBox.Show("資料刪除成功");

                }
            }
        }
    }

        
    
}
