namespace MyMidterm
{
    partial class Form4
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView未完成 = new System.Windows.Forms.DataGridView();
            this.lbl訂單號碼 = new System.Windows.Forms.Label();
            this.dataGridView訂單明細 = new System.Windows.Forms.DataGridView();
            this.lbl訂購人 = new System.Windows.Forms.Label();
            this.lbl狀態 = new System.Windows.Forms.Label();
            this.btn修改狀態 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl訂單狀態2 = new System.Windows.Forms.Label();
            this.btn更新 = new System.Windows.Forms.Button();
            this.lbl訂單號碼2 = new System.Windows.Forms.Label();
            this.lbl訂單日期2 = new System.Windows.Forms.Label();
            this.lbl日期 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView未完成)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView訂單明細)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "訂單管理";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(27, 504);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(296, 334);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView未完成
            // 
            this.dataGridView未完成.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView未完成.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView未完成.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView未完成.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView未完成.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView未完成.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView未完成.Location = new System.Drawing.Point(26, 108);
            this.dataGridView未完成.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView未完成.Name = "dataGridView未完成";
            this.dataGridView未完成.RowHeadersWidth = 62;
            this.dataGridView未完成.RowTemplate.Height = 24;
            this.dataGridView未完成.Size = new System.Drawing.Size(296, 334);
            this.dataGridView未完成.TabIndex = 4;
            this.dataGridView未完成.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView未完成_CellClick);
            // 
            // lbl訂單號碼
            // 
            this.lbl訂單號碼.AutoSize = true;
            this.lbl訂單號碼.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl訂單號碼.Location = new System.Drawing.Point(420, 80);
            this.lbl訂單號碼.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl訂單號碼.Name = "lbl訂單號碼";
            this.lbl訂單號碼.Size = new System.Drawing.Size(108, 25);
            this.lbl訂單號碼.TabIndex = 5;
            this.lbl訂單號碼.Text = "00000000";
            // 
            // dataGridView訂單明細
            // 
            this.dataGridView訂單明細.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView訂單明細.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView訂單明細.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView訂單明細.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView訂單明細.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView訂單明細.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView訂單明細.Location = new System.Drawing.Point(321, 108);
            this.dataGridView訂單明細.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView訂單明細.Name = "dataGridView訂單明細";
            this.dataGridView訂單明細.RowHeadersWidth = 62;
            this.dataGridView訂單明細.RowTemplate.Height = 24;
            this.dataGridView訂單明細.Size = new System.Drawing.Size(797, 729);
            this.dataGridView訂單明細.TabIndex = 6;
            // 
            // lbl訂購人
            // 
            this.lbl訂購人.AutoSize = true;
            this.lbl訂購人.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl訂購人.Location = new System.Drawing.Point(323, 55);
            this.lbl訂購人.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl訂購人.Name = "lbl訂購人";
            this.lbl訂購人.Size = new System.Drawing.Size(72, 25);
            this.lbl訂購人.TabIndex = 7;
            this.lbl訂購人.Text = "訂購人";
            // 
            // lbl狀態
            // 
            this.lbl狀態.AutoSize = true;
            this.lbl狀態.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl狀態.Location = new System.Drawing.Point(692, 28);
            this.lbl狀態.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl狀態.Name = "lbl狀態";
            this.lbl狀態.Size = new System.Drawing.Size(52, 25);
            this.lbl狀態.TabIndex = 8;
            this.lbl狀態.Text = "狀態";
            // 
            // btn修改狀態
            // 
            this.btn修改狀態.BackColor = System.Drawing.Color.Thistle;
            this.btn修改狀態.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn修改狀態.Location = new System.Drawing.Point(979, 25);
            this.btn修改狀態.Name = "btn修改狀態";
            this.btn修改狀態.Size = new System.Drawing.Size(139, 48);
            this.btn修改狀態.TabIndex = 9;
            this.btn修改狀態.Text = "訂單已完成";
            this.btn修改狀態.UseVisualStyleBackColor = false;
            this.btn修改狀態.Click += new System.EventHandler(this.btn修改狀態_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(23, 475);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 28);
            this.label2.TabIndex = 10;
            this.label2.Text = "已完成訂單";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.Firebrick;
            this.label3.Location = new System.Drawing.Point(24, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 28);
            this.label3.TabIndex = 11;
            this.label3.Text = "未完成訂單";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl訂單狀態2
            // 
            this.lbl訂單狀態2.AutoSize = true;
            this.lbl訂單狀態2.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl訂單狀態2.Location = new System.Drawing.Point(596, 28);
            this.lbl訂單狀態2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl訂單狀態2.Name = "lbl訂單狀態2";
            this.lbl訂單狀態2.Size = new System.Drawing.Size(97, 25);
            this.lbl訂單狀態2.TabIndex = 12;
            this.lbl訂單狀態2.Text = "訂單狀態:";
            // 
            // btn更新
            // 
            this.btn更新.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn更新.Location = new System.Drawing.Point(163, 15);
            this.btn更新.Name = "btn更新";
            this.btn更新.Size = new System.Drawing.Size(69, 33);
            this.btn更新.TabIndex = 13;
            this.btn更新.Text = "更新";
            this.btn更新.UseVisualStyleBackColor = true;
            this.btn更新.Click += new System.EventHandler(this.btn更新_Click);
            // 
            // lbl訂單號碼2
            // 
            this.lbl訂單號碼2.AutoSize = true;
            this.lbl訂單號碼2.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl訂單號碼2.Location = new System.Drawing.Point(323, 80);
            this.lbl訂單號碼2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl訂單號碼2.Name = "lbl訂單號碼2";
            this.lbl訂單號碼2.Size = new System.Drawing.Size(97, 25);
            this.lbl訂單號碼2.TabIndex = 14;
            this.lbl訂單號碼2.Text = "訂單號碼:";
            // 
            // lbl訂單日期2
            // 
            this.lbl訂單日期2.AutoSize = true;
            this.lbl訂單日期2.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl訂單日期2.Location = new System.Drawing.Point(755, 79);
            this.lbl訂單日期2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl訂單日期2.Name = "lbl訂單日期2";
            this.lbl訂單日期2.Size = new System.Drawing.Size(97, 25);
            this.lbl訂單日期2.TabIndex = 16;
            this.lbl訂單日期2.Text = "訂單日期:";
            // 
            // lbl日期
            // 
            this.lbl日期.AutoSize = true;
            this.lbl日期.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl日期.Location = new System.Drawing.Point(857, 79);
            this.lbl日期.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl日期.Name = "lbl日期";
            this.lbl日期.Size = new System.Drawing.Size(92, 25);
            this.lbl日期.TabIndex = 15;
            this.lbl日期.Text = "訂單日期";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1131, 872);
            this.Controls.Add(this.lbl訂單日期2);
            this.Controls.Add(this.lbl日期);
            this.Controls.Add(this.lbl訂單號碼2);
            this.Controls.Add(this.btn更新);
            this.Controls.Add(this.lbl訂單狀態2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn修改狀態);
            this.Controls.Add(this.lbl狀態);
            this.Controls.Add(this.lbl訂購人);
            this.Controls.Add(this.dataGridView訂單明細);
            this.Controls.Add(this.lbl訂單號碼);
            this.Controls.Add(this.dataGridView未完成);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView未完成)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView訂單明細)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView未完成;
        private System.Windows.Forms.Label lbl訂單號碼;
        private System.Windows.Forms.DataGridView dataGridView訂單明細;
        private System.Windows.Forms.Label lbl訂購人;
        private System.Windows.Forms.Label lbl狀態;
        private System.Windows.Forms.Button btn修改狀態;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl訂單狀態2;
        private System.Windows.Forms.Button btn更新;
        private System.Windows.Forms.Label lbl訂單號碼2;
        private System.Windows.Forms.Label lbl訂單日期2;
        private System.Windows.Forms.Label lbl日期;
    }
}