namespace _5_11_QuanLyBanh
{
    partial class frmThongKeHoaDon
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.btnTim = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(19, 36);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 62;
			this.dataGridView1.RowTemplate.Height = 28;
			this.dataGridView1.Size = new System.Drawing.Size(1232, 339);
			this.dataGridView1.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dataGridView1);
			this.groupBox1.Location = new System.Drawing.Point(12, 298);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Size = new System.Drawing.Size(1272, 394);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "groupBox1";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(320, 715);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "Tổng tiền";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Azure;
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label2.Location = new System.Drawing.Point(446, 704);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(310, 49);
			this.label2.TabIndex = 2;
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.Dock = System.Windows.Forms.DockStyle.Top;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Purple;
			this.label3.Location = new System.Drawing.Point(0, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(1296, 105);
			this.label3.TabIndex = 2;
			this.label3.Text = "Thống Kê Hóa Đơn Bán";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker2.Location = new System.Drawing.Point(305, 222);
			this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(248, 26);
			this.dateTimePicker2.TabIndex = 4;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker1.Location = new System.Drawing.Point(305, 144);
			this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(248, 26);
			this.dateTimePicker1.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(154, 150);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(65, 20);
			this.label4.TabIndex = 5;
			this.label4.Text = "Từ ngày";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(154, 222);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(77, 20);
			this.label5.TabIndex = 5;
			this.label5.Text = "Đến ngày";
			// 
			// btnTim
			// 
			this.btnTim.Location = new System.Drawing.Point(657, 165);
			this.btnTim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnTim.Name = "btnTim";
			this.btnTim.Size = new System.Drawing.Size(130, 42);
			this.btnTim.TabIndex = 3;
			this.btnTim.Text = "Tìm";
			this.btnTim.UseVisualStyleBackColor = true;
			this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(875, 165);
			this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(129, 42);
			this.button1.TabIndex = 6;
			this.button1.Text = "Xuất file excel";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// frmThongKeHoaDon
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1296, 786);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.dateTimePicker2);
			this.Controls.Add(this.btnTim);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox1);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "frmThongKeHoaDon";
			this.Text = "frmThongKeHoaDon";
			this.Load += new System.EventHandler(this.frmThongKeHoaDon_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTim;
		private System.Windows.Forms.Button button1;
	}
}