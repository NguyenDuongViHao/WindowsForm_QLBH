namespace _5_11_QuanLyBanh
{
    partial class frmTimKiemNhanVien
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
			this.dgvDanhSach = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.cboHienThiTimTheo = new System.Windows.Forms.ComboBox();
			this.cboTimTheo = new System.Windows.Forms.ComboBox();
			this.btnHuy = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnThoat = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvDanhSach
			// 
			this.dgvDanhSach.AllowUserToAddRows = false;
			this.dgvDanhSach.AllowUserToDeleteRows = false;
			this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDanhSach.Location = new System.Drawing.Point(21, 25);
			this.dgvDanhSach.Name = "dgvDanhSach";
			this.dgvDanhSach.ReadOnly = true;
			this.dgvDanhSach.RowHeadersWidth = 62;
			this.dgvDanhSach.RowTemplate.Height = 28;
			this.dgvDanhSach.Size = new System.Drawing.Size(1133, 272);
			this.dgvDanhSach.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(1190, 88);
			this.label1.TabIndex = 3;
			this.label1.Text = "Tìm Kiếm Nhân Viên";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.cboHienThiTimTheo);
			this.groupBox2.Controls.Add(this.cboTimTheo);
			this.groupBox2.Controls.Add(this.btnHuy);
			this.groupBox2.Location = new System.Drawing.Point(390, 132);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(496, 227);
			this.groupBox2.TabIndex = 8;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Tìm kiếm";
			// 
			// cboHienThiTimTheo
			// 
			this.cboHienThiTimTheo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboHienThiTimTheo.FormattingEnabled = true;
			this.cboHienThiTimTheo.Location = new System.Drawing.Point(153, 111);
			this.cboHienThiTimTheo.Name = "cboHienThiTimTheo";
			this.cboHienThiTimTheo.Size = new System.Drawing.Size(312, 28);
			this.cboHienThiTimTheo.TabIndex = 0;
			this.cboHienThiTimTheo.SelectedIndexChanged += new System.EventHandler(this.cboHienThiTimTheo_SelectedIndexChanged);
			// 
			// cboTimTheo
			// 
			this.cboTimTheo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboTimTheo.FormattingEnabled = true;
			this.cboTimTheo.Items.AddRange(new object[] {
            "Mã Nhân Viên",
            "Tên Nhân Viên"});
			this.cboTimTheo.Location = new System.Drawing.Point(153, 50);
			this.cboTimTheo.Name = "cboTimTheo";
			this.cboTimTheo.Size = new System.Drawing.Size(312, 28);
			this.cboTimTheo.TabIndex = 0;
			this.cboTimTheo.SelectedIndexChanged += new System.EventHandler(this.cboTimTheo_SelectedIndexChanged);
			// 
			// btnHuy
			// 
			this.btnHuy.Location = new System.Drawing.Point(356, 163);
			this.btnHuy.Name = "btnHuy";
			this.btnHuy.Size = new System.Drawing.Size(109, 36);
			this.btnHuy.TabIndex = 7;
			this.btnHuy.Text = "Hủy";
			this.btnHuy.UseVisualStyleBackColor = true;
			this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dgvDanhSach);
			this.groupBox1.Location = new System.Drawing.Point(12, 387);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1172, 321);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Danh sách nhân viên";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::_5_11_QuanLyBanh.Properties.Resources.hinh4;
			this.pictureBox1.Location = new System.Drawing.Point(33, 120);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(212, 248);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 11;
			this.pictureBox1.TabStop = false;
			// 
			// btnThoat
			// 
			this.btnThoat.Location = new System.Drawing.Point(971, 714);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(195, 40);
			this.btnThoat.TabIndex = 12;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// frmTimKiemNhanVien
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1190, 778);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.label1);
			this.Name = "frmTimKiemNhanVien";
			this.Text = "frmTimKiemNhanVien";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTimKiemNhanVien_FormClosing);
			this.Load += new System.EventHandler(this.frmTimKiemNhanVien_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboTimTheo;
        private System.Windows.Forms.ComboBox cboHienThiTimTheo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnThoat;
    }
}