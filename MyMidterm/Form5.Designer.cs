namespace MyMidterm
{
    partial class Form5
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.imageList產品圖檔 = new System.Windows.Forms.ImageList(this.components);
            this.btn新增商品 = new System.Windows.Forms.Button();
            this.btn重新載入 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "商品管理";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(10, 58);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1032, 724);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.ItemActivate += new System.EventHandler(this.listView1_ItemActivate);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // imageList產品圖檔
            // 
            this.imageList產品圖檔.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList產品圖檔.ImageSize = new System.Drawing.Size(256, 256);
            this.imageList產品圖檔.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btn新增商品
            // 
            this.btn新增商品.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn新增商品.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn新增商品.Location = new System.Drawing.Point(757, 6);
            this.btn新增商品.Name = "btn新增商品";
            this.btn新增商品.Size = new System.Drawing.Size(134, 44);
            this.btn新增商品.TabIndex = 3;
            this.btn新增商品.Text = "新增商品";
            this.btn新增商品.UseVisualStyleBackColor = false;
            this.btn新增商品.Click += new System.EventHandler(this.btn新增商品_Click);
            // 
            // btn重新載入
            // 
            this.btn重新載入.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn重新載入.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn重新載入.Location = new System.Drawing.Point(907, 6);
            this.btn重新載入.Name = "btn重新載入";
            this.btn重新載入.Size = new System.Drawing.Size(134, 44);
            this.btn重新載入.TabIndex = 4;
            this.btn重新載入.Text = "重新載入";
            this.btn重新載入.UseVisualStyleBackColor = false;
            this.btn重新載入.Click += new System.EventHandler(this.btn重新載入_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(168, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "雙擊圖片編輯";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1131, 872);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn重新載入);
            this.Controls.Add(this.btn新增商品);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList imageList產品圖檔;
        private System.Windows.Forms.Button btn新增商品;
        private System.Windows.Forms.Button btn重新載入;
        private System.Windows.Forms.Label label2;
    }
}