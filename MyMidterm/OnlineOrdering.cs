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

namespace MyMidterm
{
    public partial class OnlineOrdering : Form
    {
        SqlConnectionStringBuilder scsb;
        string strDBConnectString = "";

        List<string> list商品名稱 = new List<string>();
        List<int> list套餐價格 = new List<int>();
        List<string> list套餐數量 = new List<string>();
        List<string> list配料 = new List<string>();
        List<string> list炸物 = new List<string>();

        string 訂購人姓名電話 = "";
        string 訂單號碼 = "";
        string 所選套餐數量 = "";
        string 所選套餐單價 = "";
        int 所選套餐總價 = 0;
        string 所選商品名稱 = "";
        bool is飲品 = false;

        string image_dir = @"images\";
        string image_name = "";



        public OnlineOrdering()
        {
            InitializeComponent();
        }
        private void OnlineOrdering_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "MyMidtermDB";
            scsb.IntegratedSecurity = true;
            strDBConnectString = scsb.ToString();

            lbl日期.Text = DateTime.Now.ToString();
            lbl價格.Visible = false;
            lbl小計.Visible = false;
            lbl總金額.Visible = false;
            lbl日期.Visible = false; ;
            dataGridView1.RowHeadersVisible = false;
            dataGridView已選餐點.RowHeadersVisible = false;

            顯示商品列表();

            list套餐數量.Add("1");
            list套餐數量.Add("2");
            list套餐數量.Add("3");
            list套餐數量.Add("4");
            list套餐數量.Add("5");


            foreach (string item in list套餐數量)
            {
                cBox數量.Items.Add(item);
            }


            cBox數量.SelectedIndex = 0;
            所選套餐數量 = cBox數量.SelectedItem.ToString();
            radioButton紅茶.Checked = true;
        }

        void 計算小計金額()
        {

            int INT所選套餐單價 = 0;
            Int32.TryParse(lbl價格.Text, out INT所選套餐單價);

            int INT所選套餐數量 = 0;
            Int32.TryParse(所選套餐數量, out INT所選套餐數量);
            所選套餐總價 = INT所選套餐單價 * INT所選套餐數量;

            if (list配料.Count > 0)
            {
                所選套餐總價 = 所選套餐總價 + list配料.Count * 10;
            }
            if (list炸物.Count > 0)
            {
                if (chk美式脆薯.Checked == true)
                {
                    所選套餐總價 = 所選套餐總價 + 39;
                }
                if (chk雙色地瓜球.Checked == true)
                {

                    所選套餐總價 = 所選套餐總價 + 49;
                }
                if (chk辣味雞米花.Checked == true)
                {

                    所選套餐總價 = 所選套餐總價 + 59;
                }
                if (chk雞塊.Checked == true)
                {

                    所選套餐總價 = 所選套餐總價 + 59;
                }
            }
            lbl小計.Text = $"{所選套餐總價}";

        }

        void 顯示商品列表()
        {
            SqlConnection con = new SqlConnection(strDBConnectString);
            con.Open();
            string strSQL = "select id,pname as 套餐名稱,price as 價格 from products;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
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


        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            ////dataGridView1.AutoResizeColumn();
            //dataGridView1.AutoResizeRows();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                lbl價格.Visible = true;
                lbl小計.Visible = true;
                lbl餐點名稱.Visible = true;

                string strSelectID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                int intSelectedID = 0;
                bool isID = Int32.TryParse(strSelectID, out intSelectedID);

                if (isID == true)
                {
                    SqlConnection con = new SqlConnection(strDBConnectString);
                    con.Open();
                    string strSQL = "select * from products where id = @SearchID;";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@SearchID", intSelectedID);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read() == true)
                    {
                        lbl餐點名稱.Text = reader["pname"].ToString();
                        lbl價格.Text = reader["price"].ToString();
                        image_name = reader["pimage"].ToString();
                        pictureBox商品.Image = Image.FromFile(image_dir + image_name);

                        計算小計金額();
                    }
                    else
                    {
                        lbl餐點名稱.Visible = false;
                        lbl價格.Visible = false;
                        lbl餐點名稱.Visible = false;
                        pictureBox商品.Image = null;
                    }
                    reader.Close();
                    con.Close();
                }
            }
        }

        private void radioButton紅茶_CheckedChanged(object sender, EventArgs e)
        {
            is飲品 = true;
        }

        private void radioButton綠茶_CheckedChanged(object sender, EventArgs e)
        {
            is飲品 = false;
        }

        private void chk鮮奶油_CheckedChanged(object sender, EventArgs e)
        {
            if (chk鮮奶油.Checked == true)
            {
                list配料.Add("鮮奶油");
            }
            else
            {
                list配料.Remove("鮮奶油");
            }
            計算小計金額();
        }

        private void chk起司_CheckedChanged(object sender, EventArgs e)
        {
            if (chk起司.Checked == true)
            {
                list配料.Add("起司");
            }
            else
            {
                list配料.Remove("起司");
            }
            計算小計金額();
        }

        private void chk花生_CheckedChanged(object sender, EventArgs e)
        {
            if (chk花生.Checked == true)
            {
                list配料.Add("花生");
            }
            else
            {
                list配料.Remove("花生");
            }
            計算小計金額();
        }

        private void chk藍莓_CheckedChanged(object sender, EventArgs e)
        {
            if (chk藍莓.Checked == true)
            {
                list配料.Add("藍莓");
            }
            else
            {
                list配料.Remove("藍莓");
            }
            計算小計金額();
        }

        private void chk巧克力_CheckedChanged(object sender, EventArgs e)
        {
            if (chk巧克力.Checked == true)
            {
                list配料.Add("巧克力");
            }
            else
            {
                list配料.Remove("巧克力");
            }
            計算小計金額();
        }

        private void chk香蕉_CheckedChanged(object sender, EventArgs e)
        {
            if (chk香蕉.Checked == true)
            {
                list配料.Add("香蕉");
            }
            else
            {
                list配料.Remove("香蕉");
            }
            計算小計金額();
        }

        private void chk紅豆_CheckedChanged(object sender, EventArgs e)
        {
            if (chk紅豆.Checked == true)
            {
                list配料.Add("紅豆");
            }
            else
            {
                list配料.Remove("紅豆");
            }
            計算小計金額();
        }

        private void chk抹茶_CheckedChanged(object sender, EventArgs e)
        {
            if (chk抹茶.Checked == true)
            {
                list配料.Add("抹茶");
            }
            else
            {
                list配料.Remove("抹茶");
            }
            計算小計金額();
        }

        private void chk美式脆薯_CheckedChanged(object sender, EventArgs e)
        {
            if (chk美式脆薯.Checked == true)
            {
                list炸物.Add("美式脆薯");
            }
            else
            {
                list炸物.Remove("美式脆薯");
            }
            計算小計金額();
        }

        private void chk雙色地瓜球_CheckedChanged(object sender, EventArgs e)
        {
            if (chk雙色地瓜球.Checked == true)
            {
                list炸物.Add("雙色地瓜球");
            }
            else
            {
                list炸物.Remove("雙色地瓜球");
            }
            計算小計金額();
        }

        private void chk辣味雞米花_CheckedChanged(object sender, EventArgs e)
        {
            if (chk辣味雞米花.Checked == true)
            {
                list炸物.Add("辣味雞米花");
            }
            else
            {
                list炸物.Remove("辣味雞米花");
            }
            計算小計金額();
        }

        private void chk雞塊_CheckedChanged(object sender, EventArgs e)
        {
            if (chk雞塊.Checked == true)
            {
                list炸物.Add("雞塊");
            }
            else
            {
                list炸物.Remove("雞塊");
            }
            計算小計金額();
        }

        private void cBox數量_SelectedIndexChanged(object sender, EventArgs e)
        {
            所選套餐數量 = cBox數量.SelectedItem.ToString();
            計算小計金額();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbl總金額.Visible = true;

            string str配料集合 = "";
            foreach (string item in list配料)
            {
                if (list配料 != null)
                {
                    str配料集合 = str配料集合 + "," + item;
                }
                str配料集合 = str配料集合.TrimStart(',');
            }

            string str炸物集合 = "";
            foreach (string item in list炸物)
            {
                if (list炸物 != null)
                {
                    str炸物集合 = str炸物集合 + "," + item;

                }
                str炸物集合 = str炸物集合.TrimStart(',');
            }





            string str飲品 = "";
            if (is飲品 == true)
            {
                str飲品 = "紅茶";
            }
            else
            {
                str飲品 = "綠茶";
            }

            計算小計金額();
            dataGridView已選餐點.Rows.Add(new object[] { lbl餐點名稱.Text, lbl小計.Text, 所選套餐數量, str飲品, str配料集合, str炸物集合 });
            計算總金額();
        }

        void 計算總金額()
        {

            decimal total = 0;
            for (int i = 0; i < dataGridView已選餐點.Rows.Count; i++)
            {
                DataGridViewRow row = dataGridView已選餐點.Rows[i];
                if (row.Cells[i].Value != null)
                {
                    total += Convert.ToDecimal(row.Cells["Column價格"].Value.ToString());
                }
            }
            lbl總金額.Text = total.ToString();
        }

        private void btn下訂_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strDBConnectString);
            con.Open();
            Random myRand = new Random();
            訂單號碼 = DateTime.Now.ToString("yyyyMMddHHmmss") + myRand.Next(1000, 10000).ToString();
            訂購人姓名電話 = GlobalVar.strName +" ("+ GlobalVar.strPhone +")";
            for (int i = 0; i < dataGridView已選餐點.Rows.Count; i++)
            {
                
                    if (dataGridView已選餐點.Rows[i].Cells[0].Value != null)

                    {

                    string strSQL = "insert into Olist values(@New套餐名稱,@New數量,@New價格,@New飲品,@New配料,@New炸物,@New訂購人,@New訂購日期,@New訂購狀態,@New訂購號碼,@Newpid)";
                        SqlCommand cmd = new SqlCommand(strSQL, con);
                        cmd.Parameters.AddWithValue("@New套餐名稱", dataGridView已選餐點.Rows[i].Cells[0].Value.ToString());
                        cmd.Parameters.AddWithValue("@New價格", dataGridView已選餐點.Rows[i].Cells[1].Value.ToString());
                        cmd.Parameters.AddWithValue("@New數量", dataGridView已選餐點.Rows[i].Cells[2].Value.ToString());
                        cmd.Parameters.AddWithValue("@New飲品", dataGridView已選餐點.Rows[i].Cells[3].Value.ToString());
                        cmd.Parameters.AddWithValue("@New配料", dataGridView已選餐點.Rows[i].Cells[4].Value.ToString());
                        cmd.Parameters.AddWithValue("@New炸物", dataGridView已選餐點.Rows[i].Cells[5].Value.ToString());
                        cmd.Parameters.AddWithValue("@New訂購人", 訂購人姓名電話);
                        cmd.Parameters.AddWithValue("@New訂購日期", lbl日期.Text);
                        cmd.Parameters.AddWithValue("@New訂購狀態", "未完成");
                        cmd.Parameters.AddWithValue("@New訂購號碼", 訂單號碼);
                        cmd.Parameters.AddWithValue("@Newpid", GlobalVar.memberID);

                        int rows = cmd.ExecuteNonQuery();   //只執行不查詢,會有一個回傳值(影響的資料有幾筆)
                        
                    }
                        
                        
                
            }
            con.Close();
            MessageBox.Show("訂購成功!30分鐘後可至門市取餐");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn清除重選_Click(object sender, EventArgs e)
        {
            dataGridView已選餐點.DataSource = null;
        }
    }
}
