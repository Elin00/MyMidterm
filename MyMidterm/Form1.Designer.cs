namespace MyMidterm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLoginInfo = new System.Windows.Forms.Label();
            this.groupBoxCustomer = new System.Windows.Forms.GroupBox();
            this.btn會員管理 = new System.Windows.Forms.Button();
            this.btn訂單查詢 = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.panel顧客 = new System.Windows.Forms.Panel();
            this.groupBoxManager = new System.Windows.Forms.GroupBox();
            this.btn後台會員 = new System.Windows.Forms.Button();
            this.btn後台商品 = new System.Windows.Forms.Button();
            this.btn後台訂單 = new System.Windows.Forms.Button();
            this.panel管理 = new System.Windows.Forms.Panel();
            this.groupBoxCustomer.SuspendLayout();
            this.groupBoxManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLoginInfo
            // 
            this.lblLoginInfo.AutoSize = true;
            this.lblLoginInfo.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblLoginInfo.Location = new System.Drawing.Point(30, 10);
            this.lblLoginInfo.Name = "lblLoginInfo";
            this.lblLoginInfo.Size = new System.Drawing.Size(89, 29);
            this.lblLoginInfo.TabIndex = 0;
            this.lblLoginInfo.Text = "Hi,會員";
            // 
            // groupBoxCustomer
            // 
            this.groupBoxCustomer.BackColor = System.Drawing.Color.Beige;
            this.groupBoxCustomer.Controls.Add(this.btn會員管理);
            this.groupBoxCustomer.Controls.Add(this.btn訂單查詢);
            this.groupBoxCustomer.Controls.Add(this.btnOrder);
            this.groupBoxCustomer.Controls.Add(this.panel顧客);
            this.groupBoxCustomer.Location = new System.Drawing.Point(27, 43);
            this.groupBoxCustomer.Name = "groupBoxCustomer";
            this.groupBoxCustomer.Size = new System.Drawing.Size(1350, 960);
            this.groupBoxCustomer.TabIndex = 1;
            this.groupBoxCustomer.TabStop = false;
            // 
            // btn會員管理
            // 
            this.btn會員管理.BackColor = System.Drawing.SystemColors.Control;
            this.btn會員管理.FlatAppearance.BorderColor = System.Drawing.Color.Beige;
            this.btn會員管理.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn會員管理.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn會員管理.ForeColor = System.Drawing.Color.Black;
            this.btn會員管理.Location = new System.Drawing.Point(0, 147);
            this.btn會員管理.Name = "btn會員管理";
            this.btn會員管理.Size = new System.Drawing.Size(168, 63);
            this.btn會員管理.TabIndex = 3;
            this.btn會員管理.Text = "會員管理";
            this.btn會員管理.UseVisualStyleBackColor = false;
            this.btn會員管理.Click += new System.EventHandler(this.btn會員管理_Click);
            // 
            // btn訂單查詢
            // 
            this.btn訂單查詢.BackColor = System.Drawing.SystemColors.Control;
            this.btn訂單查詢.FlatAppearance.BorderColor = System.Drawing.Color.Beige;
            this.btn訂單查詢.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn訂單查詢.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn訂單查詢.ForeColor = System.Drawing.Color.Black;
            this.btn訂單查詢.Location = new System.Drawing.Point(0, 86);
            this.btn訂單查詢.Name = "btn訂單查詢";
            this.btn訂單查詢.Size = new System.Drawing.Size(168, 63);
            this.btn訂單查詢.TabIndex = 2;
            this.btn訂單查詢.Text = "訂單查詢";
            this.btn訂單查詢.UseVisualStyleBackColor = false;
            this.btn訂單查詢.Click += new System.EventHandler(this.btn訂單查詢_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.SystemColors.Control;
            this.btnOrder.FlatAppearance.BorderColor = System.Drawing.Color.Beige;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOrder.ForeColor = System.Drawing.Color.Black;
            this.btnOrder.Location = new System.Drawing.Point(0, 24);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(168, 63);
            this.btnOrder.TabIndex = 1;
            this.btnOrder.Text = "我要點餐";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // panel顧客
            // 
            this.panel顧客.Location = new System.Drawing.Point(168, 21);
            this.panel顧客.Name = "panel顧客";
            this.panel顧客.Size = new System.Drawing.Size(1155, 930);
            this.panel顧客.TabIndex = 0;
            this.panel顧客.Paint += new System.Windows.Forms.PaintEventHandler(this.panel顧客_Paint);
            // 
            // groupBoxManager
            // 
            this.groupBoxManager.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBoxManager.Controls.Add(this.btn後台會員);
            this.groupBoxManager.Controls.Add(this.btn後台商品);
            this.groupBoxManager.Controls.Add(this.btn後台訂單);
            this.groupBoxManager.Controls.Add(this.panel管理);
            this.groupBoxManager.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBoxManager.Location = new System.Drawing.Point(27, 45);
            this.groupBoxManager.Name = "groupBoxManager";
            this.groupBoxManager.Size = new System.Drawing.Size(1350, 960);
            this.groupBoxManager.TabIndex = 2;
            this.groupBoxManager.TabStop = false;
            // 
            // btn後台會員
            // 
            this.btn後台會員.BackColor = System.Drawing.SystemColors.Control;
            this.btn後台會員.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btn後台會員.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn後台會員.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn後台會員.ForeColor = System.Drawing.Color.Black;
            this.btn後台會員.Location = new System.Drawing.Point(14, 154);
            this.btn後台會員.Name = "btn後台會員";
            this.btn後台會員.Size = new System.Drawing.Size(168, 63);
            this.btn後台會員.TabIndex = 7;
            this.btn後台會員.Text = "會員管理";
            this.btn後台會員.UseVisualStyleBackColor = false;
            this.btn後台會員.Click += new System.EventHandler(this.btn後台會員_Click);
            // 
            // btn後台商品
            // 
            this.btn後台商品.BackColor = System.Drawing.SystemColors.Control;
            this.btn後台商品.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btn後台商品.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn後台商品.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn後台商品.ForeColor = System.Drawing.Color.Black;
            this.btn後台商品.Location = new System.Drawing.Point(14, 93);
            this.btn後台商品.Name = "btn後台商品";
            this.btn後台商品.Size = new System.Drawing.Size(168, 63);
            this.btn後台商品.TabIndex = 6;
            this.btn後台商品.Text = "商品管理";
            this.btn後台商品.UseVisualStyleBackColor = false;
            this.btn後台商品.Click += new System.EventHandler(this.btn後台商品_Click);
            // 
            // btn後台訂單
            // 
            this.btn後台訂單.BackColor = System.Drawing.SystemColors.Control;
            this.btn後台訂單.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btn後台訂單.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn後台訂單.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn後台訂單.ForeColor = System.Drawing.Color.Black;
            this.btn後台訂單.Location = new System.Drawing.Point(14, 32);
            this.btn後台訂單.Name = "btn後台訂單";
            this.btn後台訂單.Size = new System.Drawing.Size(168, 63);
            this.btn後台訂單.TabIndex = 5;
            this.btn後台訂單.Text = "訂單管理";
            this.btn後台訂單.UseVisualStyleBackColor = false;
            this.btn後台訂單.Click += new System.EventHandler(this.btn後台訂單_Click);
            // 
            // panel管理
            // 
            this.panel管理.Location = new System.Drawing.Point(182, 28);
            this.panel管理.Name = "panel管理";
            this.panel管理.Size = new System.Drawing.Size(1155, 930);
            this.panel管理.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1416, 992);
            this.Controls.Add(this.groupBoxCustomer);
            this.Controls.Add(this.groupBoxManager);
            this.Controls.Add(this.lblLoginInfo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxCustomer.ResumeLayout(false);
            this.groupBoxManager.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoginInfo;
        private System.Windows.Forms.GroupBox groupBoxCustomer;
        private System.Windows.Forms.GroupBox groupBoxManager;
        private System.Windows.Forms.Panel panel顧客;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btn會員管理;
        private System.Windows.Forms.Button btn訂單查詢;
        private System.Windows.Forms.Button btn後台會員;
        private System.Windows.Forms.Button btn後台商品;
        private System.Windows.Forms.Button btn後台訂單;
        private System.Windows.Forms.Panel panel管理;
    }
}