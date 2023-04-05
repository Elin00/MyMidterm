namespace MyMidterm
{
    partial class ProductDetial
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPID = new System.Windows.Forms.Label();
            this.txt商品名稱 = new System.Windows.Forms.TextBox();
            this.txt商品價格 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox修改 = new System.Windows.Forms.GroupBox();
            this.btn刪除 = new System.Windows.Forms.Button();
            this.btn儲存商品 = new System.Windows.Forms.Button();
            this.btn選取商品圖片 = new System.Windows.Forms.Button();
            this.groupBox新增 = new System.Windows.Forms.GroupBox();
            this.btn新增商品 = new System.Windows.Forms.Button();
            this.btn選取商品圖片2 = new System.Windows.Forms.Button();
            this.btn清空欄位 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox修改.SuspendLayout();
            this.groupBox新增.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(493, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "商品名稱";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(493, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "商品價格";
            // 
            // lblPID
            // 
            this.lblPID.AutoSize = true;
            this.lblPID.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPID.Location = new System.Drawing.Point(493, 9);
            this.lblPID.Name = "lblPID";
            this.lblPID.Size = new System.Drawing.Size(41, 36);
            this.lblPID.TabIndex = 2;
            this.lblPID.Text = "id";
            // 
            // txt商品名稱
            // 
            this.txt商品名稱.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt商品名稱.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt商品名稱.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt商品名稱.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt商品名稱.Location = new System.Drawing.Point(645, 48);
            this.txt商品名稱.Name = "txt商品名稱";
            this.txt商品名稱.Size = new System.Drawing.Size(281, 45);
            this.txt商品名稱.TabIndex = 3;
            // 
            // txt商品價格
            // 
            this.txt商品價格.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt商品價格.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt商品價格.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt商品價格.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt商品價格.Location = new System.Drawing.Point(645, 107);
            this.txt商品價格.Name = "txt商品價格";
            this.txt商品價格.Size = new System.Drawing.Size(281, 45);
            this.txt商品價格.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(33, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(424, 376);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox修改
            // 
            this.groupBox修改.Controls.Add(this.btn刪除);
            this.groupBox修改.Controls.Add(this.btn儲存商品);
            this.groupBox修改.Controls.Add(this.btn選取商品圖片);
            this.groupBox修改.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox修改.Location = new System.Drawing.Point(592, 196);
            this.groupBox修改.Name = "groupBox修改";
            this.groupBox修改.Size = new System.Drawing.Size(334, 219);
            this.groupBox修改.TabIndex = 6;
            this.groupBox修改.TabStop = false;
            this.groupBox修改.Text = "修改.刪除商品";
            // 
            // btn刪除
            // 
            this.btn刪除.BackColor = System.Drawing.SystemColors.Control;
            this.btn刪除.Location = new System.Drawing.Point(75, 158);
            this.btn刪除.Name = "btn刪除";
            this.btn刪除.Size = new System.Drawing.Size(182, 48);
            this.btn刪除.TabIndex = 2;
            this.btn刪除.Text = "刪除商品";
            this.btn刪除.UseVisualStyleBackColor = false;
            this.btn刪除.Click += new System.EventHandler(this.btn刪除_Click);
            // 
            // btn儲存商品
            // 
            this.btn儲存商品.BackColor = System.Drawing.Color.Thistle;
            this.btn儲存商品.Location = new System.Drawing.Point(75, 104);
            this.btn儲存商品.Name = "btn儲存商品";
            this.btn儲存商品.Size = new System.Drawing.Size(182, 48);
            this.btn儲存商品.TabIndex = 1;
            this.btn儲存商品.Text = "儲存商品";
            this.btn儲存商品.UseVisualStyleBackColor = false;
            this.btn儲存商品.Click += new System.EventHandler(this.btn儲存商品_Click);
            // 
            // btn選取商品圖片
            // 
            this.btn選取商品圖片.BackColor = System.Drawing.Color.Thistle;
            this.btn選取商品圖片.Location = new System.Drawing.Point(75, 50);
            this.btn選取商品圖片.Name = "btn選取商品圖片";
            this.btn選取商品圖片.Size = new System.Drawing.Size(182, 48);
            this.btn選取商品圖片.TabIndex = 0;
            this.btn選取商品圖片.Text = "選取商品圖片";
            this.btn選取商品圖片.UseVisualStyleBackColor = false;
            this.btn選取商品圖片.Click += new System.EventHandler(this.btn選取商品圖片_Click);
            // 
            // groupBox新增
            // 
            this.groupBox新增.Controls.Add(this.btn新增商品);
            this.groupBox新增.Controls.Add(this.btn選取商品圖片2);
            this.groupBox新增.Controls.Add(this.btn清空欄位);
            this.groupBox新增.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox新增.Location = new System.Drawing.Point(592, 196);
            this.groupBox新增.Name = "groupBox新增";
            this.groupBox新增.Size = new System.Drawing.Size(334, 213);
            this.groupBox新增.TabIndex = 7;
            this.groupBox新增.TabStop = false;
            this.groupBox新增.Text = "新增商品";
            // 
            // btn新增商品
            // 
            this.btn新增商品.BackColor = System.Drawing.SystemColors.Control;
            this.btn新增商品.Location = new System.Drawing.Point(75, 146);
            this.btn新增商品.Name = "btn新增商品";
            this.btn新增商品.Size = new System.Drawing.Size(182, 48);
            this.btn新增商品.TabIndex = 4;
            this.btn新增商品.Text = "確定新增";
            this.btn新增商品.UseVisualStyleBackColor = false;
            this.btn新增商品.Click += new System.EventHandler(this.btn新增商品_Click);
            // 
            // btn選取商品圖片2
            // 
            this.btn選取商品圖片2.BackColor = System.Drawing.SystemColors.Control;
            this.btn選取商品圖片2.Location = new System.Drawing.Point(75, 92);
            this.btn選取商品圖片2.Name = "btn選取商品圖片2";
            this.btn選取商品圖片2.Size = new System.Drawing.Size(182, 48);
            this.btn選取商品圖片2.TabIndex = 3;
            this.btn選取商品圖片2.Text = "選取商品圖片";
            this.btn選取商品圖片2.UseVisualStyleBackColor = false;
            this.btn選取商品圖片2.Click += new System.EventHandler(this.btn選取商品圖片_Click);
            // 
            // btn清空欄位
            // 
            this.btn清空欄位.BackColor = System.Drawing.SystemColors.Control;
            this.btn清空欄位.Location = new System.Drawing.Point(75, 38);
            this.btn清空欄位.Name = "btn清空欄位";
            this.btn清空欄位.Size = new System.Drawing.Size(182, 48);
            this.btn清空欄位.TabIndex = 2;
            this.btn清空欄位.Text = "清空欄位";
            this.btn清空欄位.UseVisualStyleBackColor = false;
            this.btn清空欄位.Click += new System.EventHandler(this.btn清空欄位_Click);
            // 
            // ProductDetial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(986, 468);
            this.Controls.Add(this.groupBox新增);
            this.Controls.Add(this.groupBox修改);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt商品價格);
            this.Controls.Add(this.txt商品名稱);
            this.Controls.Add(this.lblPID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ProductDetial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ProductDetial";
            this.Load += new System.EventHandler(this.ProductDetial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox修改.ResumeLayout(false);
            this.groupBox新增.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPID;
        private System.Windows.Forms.TextBox txt商品名稱;
        private System.Windows.Forms.TextBox txt商品價格;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox修改;
        private System.Windows.Forms.Button btn儲存商品;
        private System.Windows.Forms.Button btn選取商品圖片;
        private System.Windows.Forms.GroupBox groupBox新增;
        private System.Windows.Forms.Button btn新增商品;
        private System.Windows.Forms.Button btn選取商品圖片2;
        private System.Windows.Forms.Button btn清空欄位;
        private System.Windows.Forms.Button btn刪除;
    }
}