using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMidterm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            member myLoginFrom = new member();
            myLoginFrom.ShowDialog();
            lblLoginInfo.Text = $"Hi,{GlobalVar.strName}";

            if(GlobalVar.int權限 == 1)
            {
                groupBoxCustomer.Visible = true;
                groupBoxManager.Visible = false;
            }

            if(GlobalVar.int權限 == 100)
            {
                groupBoxManager.Visible = true;
                groupBoxCustomer.Visible = false;
            }
        }

        private Form activeForm = null;  //確認表單是否開啟
        private void openChildForm(Form childForm)  //開啟子表單方法
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;    //若表單未開啟,將表單名指定給變數
            childForm.TopLevel = false;  //最上層視窗通常用來做為應用程式的主要表單,故子表單不能設為最上層表單
            childForm.FormBorderStyle = FormBorderStyle.None;  //設定子表單邊框為無
            childForm.Dock = DockStyle.Fill;  //設定子表單位置
            panel顧客.Controls.Add(childForm);    //將標籤加入panel顯示
            panel顧客.Tag = childForm;  //將標籤設為子表單名
            childForm.BringToFront();  //將表單放置到前面
            childForm.Show();  //開啟表單
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            //btnOrder.BackColor = Color.White;
            openChildForm(new OnlineOrdering());
        }

        private void btn訂單查詢_Click(object sender, EventArgs e)
        {
            //btn訂單查詢.BackColor = Color.White;
            openChildForm(new CustomerOrder());
        }

        private void btn會員管理_Click(object sender, EventArgs e)
        {
            //btn會員管理.BackColor = Color.White;
            openChildForm(new CustomerMember());
        }


        private Form activeForm2 = null;  //確認表單是否開啟
        private void openChildForm2(Form childForm)  //開啟子表單方法
        {
            if (activeForm2 != null)
                activeForm2.Close();
            activeForm2 = childForm;    //若表單未開啟,將表單名指定給變數
            childForm.TopLevel = false;  //最上層視窗通常用來做為應用程式的主要表單,故子表單不能設為最上層表單
            childForm.FormBorderStyle = FormBorderStyle.None;  //設定子表單邊框為無
            childForm.Dock = DockStyle.Fill;  //設定子表單位置
            panel管理.Controls.Add(childForm);    //將標籤加入panel顯示
            panel管理.Tag = childForm;  //將標籤設為子表單名
            childForm.BringToFront();  //將表單放置到前面
            childForm.Show();  //開啟表單
        }
        private void panel顧客_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btn後台訂單_Click(object sender, EventArgs e)
        {
            openChildForm2(new Form4());
        }

        private void btn後台商品_Click(object sender, EventArgs e)
        {
            openChildForm2(new Form5());
        }

        private void btn後台會員_Click(object sender, EventArgs e)
        {
            openChildForm2(new MemberManagement());
        }

        private void btn登出_Click(object sender, EventArgs e)
        {
            //member m = new member();
            //m.ShowDialog();
            //this.Close();


        }
    }
}
