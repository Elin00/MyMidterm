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
    public partial class Form5 : Form
    {
        SqlConnectionStringBuilder scsb;
        string strMyDBConnectionString = "";

        List<string> listPname = new List<string>();    
        List<int> listPrice = new List<int>();
        List<int> listPID = new List<int>();
        private void Form5_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "MyMidtermDB";
            scsb.IntegratedSecurity = true;
            strMyDBConnectionString = scsb.ToString();

            讀取資料庫();
            展示listView商品圖片模式();
        }
        void 讀取資料庫()
        {
            SqlConnection con = new SqlConnection(strMyDBConnectionString);
            con.Open();
            string strSQL = "select * from products;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader =cmd.ExecuteReader();

            string image_dir = @"images\";
            string image_name = "";  
            int i = 0;

            while (reader.Read())
            {
                listPID.Add((int)reader["id"]);
                listPname.Add(reader["pname"].ToString());
                listPrice.Add((int)reader["price"]);
                image_name = reader["pimage"].ToString();
                Image myProductImage = Image.FromFile(image_dir + image_name);
                imageList產品圖檔.Images.Add(myProductImage);
                i += 1;
            }
            reader.Close();
            con.Close();

        }

        void 展示listView商品圖片模式()
        {
            listView1.Clear();
            listView1.View = View.LargeIcon;   //LargeIcon, SmallIcon, List, Tile
            imageList產品圖檔.ImageSize = new Size(180, 120);
            listView1.LargeImageList = imageList產品圖檔;  //LargeIcon, Tile
            listView1.SmallImageList = imageList產品圖檔;  //SmallIcon, List

            for (int i = 0; i < imageList產品圖檔.Images.Count; i += 1)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                item.Font = new Font("微軟正黑體", 10, FontStyle.Regular);
                item.Text = listPname[i] + "  " + listPrice[i] + "元";
                item.Tag = listPID[i];      //藏資訊用
                listView1.Items.Add(item);
            }

        }

        public Form5()
        {
            InitializeComponent();
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            ProductDetial PDF = new ProductDetial();
            PDF.PID = (int)listView1.SelectedItems[0].Tag;
            PDF.ShowDialog();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn新增商品_Click(object sender, EventArgs e)
        {
            ProductDetial PDF = new ProductDetial();
            PDF.ShowDialog();
        }

        private void btn重新載入_Click(object sender, EventArgs e)
        {
            listPID.Clear();
            listPname.Clear();
            listPrice.Clear();
            imageList產品圖檔.Images.Clear();
            讀取資料庫();
            展示listView商品圖片模式();
        }
    }
}
