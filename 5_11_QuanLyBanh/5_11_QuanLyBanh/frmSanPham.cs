using DevExpress.XtraEditors.Mask.Design;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.Skins.SolidColorHelper;

namespace _5_11_QuanLyBanh
{
    public partial class frmSanPham : Form
    {
        public frmSanPham()
        {
            InitializeComponent();
        }

        quanlybanBanh q = new quanlybanBanh();
        DataSet dsSanPham = new DataSet();
        DataSet dsLoaiSp = new DataSet();
        DataSet dsNhaCC = new DataSet();
        int vitri = 0;
        Boolean f = false;
        int flag = 0;
        void danhsach_datagridview(DataGridView dgv, string sql)
        {
            dsSanPham = q.layDuLieu(sql);
            dgv.DataSource = dsSanPham.Tables[0];
        }

        void xuLyChucNang(bool t)
        {
            btnThem.Enabled = t;
            btnSua.Enabled = t;
            btnXoa.Enabled = t;
            btnLuu.Enabled = !t;
            btnHuy.Enabled = !t;
        }

        void xuly_Visible(bool t)
        {
            btnThemSP.Visible = !t;
            btnThemSP.Enabled = t;    
        }
        void xuLyChucNang_them()
        {
            cboTenML.Text = "";
            cboTenNCC.Text = "";
            txtMaSP.Clear();
            txtTenSP.Clear();
            txtSoLuongM.Clear();
            txtSoLuongL.Clear();
            txtSoLuongXL.Clear();
            txtGiaNhap.Clear();
            txtGiaL.Clear();
            txtGiaM.Clear();
            txtGiaXL.Clear();
            rtxtMoTa.Clear();
            lbltenhinh.Text = "";
            btnLuu.Enabled = false;
            txtMaSP.ReadOnly = true;
            txtGiaM.ReadOnly = true;
            txtGiaL.ReadOnly = true;
            txtGiaXL.ReadOnly = true;
			
		}

        void xuLyChucNang_txt(bool t)
        {
            txtMaSP.ReadOnly = t;
            txtTenSP.ReadOnly = t;
            txtSoLuongM.ReadOnly = t;
            txtSoLuongL.ReadOnly = t;
            txtSoLuongXL.ReadOnly = t;
            txtGiaNhap.ReadOnly = t;
            txtGiaL.ReadOnly = t;
            txtGiaM.ReadOnly = t;
            txtGiaXL.ReadOnly = t;
           
            //cboTenNCC.Enabled = t;
            //cboTenML.Enabled = t;
            //rtxtMoTa.ReadOnly = t;
        }

        void xuly_ChucNangThem1(bool t)
        {
            txtMaSP.ReadOnly = !t;
            txtGiaM.ReadOnly = !t;
            txtGiaL.ReadOnly = !t;
            txtGiaXL.ReadOnly = !t;
        }
        void xuly_hinhanh()
        {
          // picHinhAnh.Image = Image.FromFile(@"D:\CDTH21A_WEB_C\NAM_3\WINDOWS\DoAn_QuanLyBanh\5_11_QuanLyBanh\5_11_QuanLyBanh\bin\Debug\hinhanh_SanPham\hinhanh_giaodien\hinhFrist.png");
           picHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        void hienThiComboBox(ComboBox cbo, DataSet ds, string ten, string ma)
        {
            cbo.DataSource = ds.Tables[0];
            cbo.DisplayMember = ten;
            cbo.ValueMember = ma;
            cbo.SelectedIndex = -1;
        }

        void xuly_enable(bool t)
        {
            cboTenML.Enabled = !t;
            cboTenNCC.Enabled = !t;

            rtxtMoTa.Enabled = !t;
        }

        void hienthiLenTextBox(DataSet ds, int vt)
        {
            if (ds.Tables[0].Rows.Count > vt && vt > -1)
            {
                txtMaSP.Text = ds.Tables[0].Rows[vt]["MaSP"].ToString();
                txtTenSP.Text = ds.Tables[0].Rows[vt]["TenSP"].ToString();
                txtSoLuongM.Text = ds.Tables[0].Rows[vt]["SoLuongM"].ToString();
                txtSoLuongL.Text = ds.Tables[0].Rows[vt]["SoLuongL"].ToString();
                txtSoLuongXL.Text = ds.Tables[0].Rows[vt]["SoLuongXL"].ToString();
                txtGiaNhap.Text = ds.Tables[0].Rows[vt]["GIaNhap"].ToString();
                txtGiaM.Text = ds.Tables[0].Rows[vt]["GiaSizeM"].ToString();
                txtGiaL.Text = ds.Tables[0].Rows[vt]["GiaSizeL"].ToString();
                txtGiaXL.Text = ds.Tables[0].Rows[vt]["GiaSizeXL"].ToString();

                rtxtMoTa.Text = ds.Tables[0].Rows[vt]["MoTa"].ToString();

                string mancc = ds.Tables[0].Rows[vt]["MaNCC"].ToString();
                string maloai = ds.Tables[0].Rows[vt]["MaLoai"].ToString();

                string tenhinh = ds.Tables[0].Rows[vt]["MaHinh"].ToString();
                lbltenhinh.Text = tenhinh;
                string tenfile = Path.GetFullPath("hinhanh_SanPham") + @"\" + tenhinh;
                taoAnh_tuFileAnh(picHinhAnh, tenfile);

                locDuLieuComboBox(dsLoaiSp, cboTenML, "TenLoai", "MaLoai", maloai);
                locDuLieuComboBox(dsNhaCC, cboTenNCC, "TenNCC", "MaNCC", mancc);

                if (cboTenNCC.SelectedIndex != -1)
                {
                    txtMaSP.Text = ds.Tables[0].Rows[vt]["MaSP"].ToString();
                }
            }
        }

        void locDuLieuComboBox(DataSet ds, ComboBox cbo, string ten, string ma, string giatrima)
        {
            DataView dv = new DataView();
            dv.Table = ds.Tables[0];
            dv.RowFilter = ma + "='" + giatrima + "'";
            cbo.DataSource = dv;
            cbo.DisplayMember = ten;
            cbo.ValueMember = ma;
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            xuLyChucNang(true);

			
			xuLyChucNang_txt(true);
            xuly_Visible(true);
            xuly_enable(true);
            btnLoadHinh.Enabled= false;
           
            danhsach_datagridview(dgvDanhSach, "select * from SanPham where trangthai=0");

            dsLoaiSp = q.layDuLieu("select * from LoaiSP");
            //hienThiComboBox(cboTenML, dsLoaiSp, "TenLoai", "MaLoai");

            dsNhaCC = q.layDuLieu("select * from NhaCungCap");
            //hienThiComboBox(cboTenNCC, dsNhaCC, "TenNCC", "MaNCC");

            hienthiLenTextBox(dsSanPham, vitri);

            f = true;
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {   
            if(f)
            {
                if (flag != 1)
                {
                    vitri = e.RowIndex;
                    hienthiLenTextBox(dsSanPham, vitri);
               }
            }   
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyChucNang(false);
            xuLyChucNang_txt(false);
            xuLyChucNang_them();
            xuly_Visible(false);
            xuly_enable(false);
            xuly_hinhanh();
			
			btnLoadHinh.Enabled = true;

            dsLoaiSp = q.layDuLieu("select * from LoaiSP");
            hienThiComboBox(cboTenML, dsLoaiSp, "TenLoai", "MaLoai");
            // hienThiComboBox(cboTenNCC, dsNhaCC, "TenNCC", "MaNCC");
            
            txtGiaNhap.Enabled = true;

			dgvDanhSach.DataSource = null;

            taoCotSP();

            picHinhAnh.Image = null;
            btnHuy.Focus();
            flag = 1;
        }

        void xuly_ChucNangSua(bool t)
        {
            txtMaSP.ReadOnly = t;
            txtGiaM.ReadOnly = t;
            txtGiaL.ReadOnly = t;
            txtGiaXL.ReadOnly = t;
			
            rtxtMoTa.Enabled = t;
			// cboTrangThai.Enabled = !t;
			cboTenNCC.Enabled = !t;
            cboTenML.Enabled = !t;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyChucNang(false);
            xuLyChucNang_txt(false);
            xuly_ChucNangSua(true);
            xuly_Visible(false);
            
            btnLoadHinh.Enabled = true;
            btnHuy.Focus();
            flag = 2;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            xuLyChucNang(false);

            btnHuy.Focus();
            flag = 3;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql = "";

            string tenChucNang = "";

            if (flag == 1)
            {
                int dem_capnhat = 0;

                for (int i = 0; i <= dgvDanhSach.Rows.Count-1; i++)
                {

                    string masp = dgvDanhSach.Rows[i].Cells[0].Value.ToString();
                    string tensp = dgvDanhSach.Rows[i].Cells[1].Value.ToString();
                    string mancc = dgvDanhSach.Rows[i].Cells[2].Value.ToString();
                    string soluongM = dgvDanhSach.Rows[i].Cells[3].Value.ToString();
                    string soluongL = dgvDanhSach.Rows[i].Cells[4].Value.ToString();
                    string soluongXL = dgvDanhSach.Rows[i].Cells[5].Value.ToString();
                    string gianhap = dgvDanhSach.Rows[i].Cells[6].Value.ToString();
                    string giaM = dgvDanhSach.Rows[i].Cells[7].Value.ToString();
                    string giaL = dgvDanhSach.Rows[i].Cells[8].Value.ToString();
                    string giaXL = dgvDanhSach.Rows[i].Cells[9].Value.ToString();
                    string mahinh = dgvDanhSach.Rows[i].Cells[10].Value.ToString();
                    string mota = dgvDanhSach.Rows[i].Cells[11].Value.ToString();
                    string maloai = dgvDanhSach.Rows[i].Cells[12].Value.ToString();
                    string trangthai = "0";
                    sql = "insert into SanPham values('" + masp + "',N'" + tensp + "','" + mancc + "'," + soluongM + ","  + soluongL + "," + soluongXL + "," + gianhap + "," + giaM + "," + giaL + "," + giaXL + ",'" + mahinh + "',N'" + mota + "','" + maloai + "'," + trangthai + ")";
                    if (q.capNhatDuLieu(sql) > 0)
                    {
                        dem_capnhat++;
                    }
                }
                if (dem_capnhat != 0)
                {
                    MessageBox.Show("Cập nhật thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }


            if (flag == 2)
            {      
                if(txtSoLuongXL.Text == "0" || txtSoLuongL.Text == "0" || txtSoLuongM.Text == "0" || txtGiaNhap.Text == "0")
                {
					MessageBox.Show("Số lượng và giá nhập không được bằng 0", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
				}
                sql = "update SanPham set TenSP= N'" + txtTenSP.Text + "', SoLuongM=" + txtSoLuongM.Text + ", SoLuongL=" + txtSoLuongL.Text+ ", SoLuongXL=" + txtSoLuongXL.Text+ ", GiaNhap=" + txtGiaNhap.Text + ", GiaSizeM=" + txtGiaM.Text + ", GiaSizeL=" + txtGiaL.Text + ", GiaSizeXl=" + txtGiaXL.Text + ", MaHinh='" + lbltenhinh.Text + "', MoTa=N'" + rtxtMoTa.Text  + "', trangthai=0  where MaSP = '" + txtMaSP.Text + "'"; //+ "', MaLoai='" + cboTenML.SelectedValue.ToString()   "', MaNCC= '" + cboTenNCC.SelectedValue.ToString() +

                if (q.capNhatDuLieu(sql) > 0)
                {

                    MessageBox.Show("Cập nhật thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    vitri = 0; 
				}
			}


            if (flag == 3)
            {
				DialogResult luu;
				luu = MessageBox.Show("Bạn có muốn " + tenChucNang, "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (luu == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dgvDanhSach.SelectedRows)
                    {
                        if (!row.IsNewRow)
                        {
                            string maSP = row.Cells["MaSP"].Value.ToString(); // Thay "MaSP" bằng tên cột chứa MaSP trong DataGridView

                            // Thực hiện cập nhật trạng thái trong CSDL
                            string sql1 = "update SanPham set trangthai = 1 where MaSP = '" + maSP + "'";

                            // Thực hiện câu truy vấn
                            if (q.capNhatDuLieu(sql1) > 0)
                            {
                                MessageBox.Show("Cập nhật thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                        }
                    }
                }

				}
			dgvDanhSach.Columns.Clear();
			frmSanPham_Load(sender, e);

            flag = 0;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            dgvDanhSach.Columns.Clear();
            frmSanPham_Load(sender, e);
            //rtxtMoTa.ReadOnly= true;

            flag = 0;
        }

        void taoAnh_tuFileAnh(PictureBox pic, string filename)
        {
           
            Bitmap a = new Bitmap(filename);
            pic.Image = a;
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnLoadHinh_Click(object sender, EventArgs e)
        {

            OpenFileDialog o = new OpenFileDialog();
            o.InitialDirectory = Path.GetFullPath("hinhanh_SanPham") + @"\";
           
            if (o.ShowDialog() == DialogResult.OK)
            {
                string tenfile = o.FileName;
				

				// Phân tách chuỗi thành các đường dẫn bằng dấu phân cách (ví dụ: dấu chấm phẩy)
				string[] paths = tenfile.Split(new char[] { '\\' }, StringSplitOptions.RemoveEmptyEntries);
				int pathCount = paths.Length; // Đếm số đường dẫn
				

				string[] tenhinh = tenfile.Split('\\');
				string extension = Path.GetExtension(tenfile);
				if (!string.IsNullOrEmpty(extension) && extension.ToLower() == ".jpg")
                {
                    lbltenhinh.Text = tenhinh[pathCount-2] + "\\" + tenhinh[pathCount-1];
                    taoAnh_tuFileAnh(picHinhAnh, tenfile);
					if (flag == 1)
					{
						btnThemSP.Enabled = true;
					}
				}
				else
				{
					MessageBox.Show("Tệp ảnh không đúng định dạng (.jpg). Vui lòng chọn một tệp ảnh .jpg.");
				}

			}
            else
            {
                if (string.IsNullOrEmpty(lbltenhinh.Text))
                {
                    MessageBox.Show("bạn chưa chọn ảnh");
                    return;
                }
            }
            // neu nhan nut them anh se hien thi nut themsp
            if (flag == 1)
            {
                if (!string.IsNullOrEmpty(lbltenhinh.Text))
                {
                    btnThemSP.Enabled = true;
                }
            }
        }

        private void cboTenML_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (f)
                if (cboTenML.SelectedIndex != -1)
                {
                    string ma = cboTenML.SelectedValue.ToString();
                    dsNhaCC = q.layDuLieu("select * from NhaCungCap where MaLoai = '" + ma + "'");
                    hienThiComboBox(cboTenNCC, dsNhaCC, "TenNCC", "MaNCC");
                }
        }

        private void cboTenNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            if (f)
            {
                string masp = "";
                if (cboTenNCC.SelectedIndex != -1)
                {
                    string mancc = cboTenNCC.SelectedValue.ToString();
                    string sql = "select MaSP from SanPham where ManCC='" + mancc + "'";
                    DataSet ds = q.layDuLieu(sql);

                    if (ds.Tables[0].Rows.Count < 9)
                    {
                        masp = mancc + "0" + (ds.Tables[0].Rows.Count + 1).ToString();
                    }
                    else
                    {
                        masp = mancc + (ds.Tables[0].Rows.Count + 1).ToString();
                    }

                }
                txtMaSP.Text = masp;
            }
        }

        private void txtGiaNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CultureInfo cul = new CultureInfo("vi-VN");
                float giaNhap = 0;

				giaNhap = float.Parse(txtGiaNhap.Text);
                txtGiaM.Text = (giaNhap * 2).ToString();
                txtGiaL.Text = (giaNhap * 3).ToString();
                txtGiaXL.Text = (giaNhap * 4).ToString();
            }
        }

        void taoCotSP()
        {
            dgvDanhSach.Columns.Clear();
            dgvDanhSach.Columns.Add("MaSP", "Mã sản phẩm");
            dgvDanhSach.Columns.Add("TenSP", "Tên sản phẩm");
            dgvDanhSach.Columns.Add("MaNCC", "Mã nhà cung cấp");
            dgvDanhSach.Columns.Add("SoLuongM", "Số lượng M");
            dgvDanhSach.Columns.Add("SoLuongL", "Số lượng L");
            dgvDanhSach.Columns.Add("SoLuongXL", "Số lượng XL");
            dgvDanhSach.Columns.Add("GiaNhap", "Giá nhập");
            dgvDanhSach.Columns.Add("GiaSizeM", "Giá M");
            dgvDanhSach.Columns.Add("GiaSizeL", "Giá L");
            dgvDanhSach.Columns.Add("GiaSizeXL", "Giá XL");
            dgvDanhSach.Columns.Add("MaHinh", "Mã hình");
            dgvDanhSach.Columns.Add("MoTa", "Mô tả");
            dgvDanhSach.Columns.Add("MaLoai", "Mã Loại");
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
			

			if (cboTenNCC.Text == "" || cboTenML.Text=="")
            {
                MessageBox.Show("Chưa chọn loại sản phẩm hoặc nhà cung cấp");
                return;
            }
            if(txtTenSP.Text =="" || txtSoLuongM.Text =="" || txtGiaNhap.Text =="" || rtxtMoTa.Text == "" || txtGiaM.Text == "" || txtGiaL.Text == "" || txtGiaXL.Text == "")
            {
                MessageBox.Show("Chưa nhập đầy đủ thông tin sản phẩm");
                return;
            }
            btnLuu.Enabled = true;

			
			DialogResult thoat;
			thoat = MessageBox.Show("Bạn đã chắc chắn, khi thêm chỉ sửa đc các trường:" + System.Environment.NewLine
				+ "tên, số lương, giá và mô tả trong bảng ở dưới", "Thông báo", MessageBoxButtons.OKCancel);
			if (thoat == DialogResult.Cancel)
			{
                return;
			}

			xuLyChucNang_txt(true);
			xuly_enable(true);
			btnLoadHinh.Enabled = false;
			dgvDanhSach.Columns[0].ReadOnly = true;
			dgvDanhSach.Columns[2].ReadOnly = true;
			dgvDanhSach.Columns[10].ReadOnly = true;
			dgvDanhSach.Columns[12].ReadOnly = true;


			object[] d = new object[13];
            d[0] = txtMaSP.Text + "." + cboTenML.SelectedValue.ToString();
            d[1] = txtTenSP.Text;
            d[2] = cboTenNCC.SelectedValue.ToString();
            d[3] = txtSoLuongM.Text;
            d[4] = txtSoLuongL.Text;
            d[5] = txtSoLuongXL.Text;
            d[6] = txtGiaNhap.Text;
            d[7] = txtGiaM.Text;
            d[8] = txtGiaL.Text;
            d[9] = txtGiaXL.Text;
            d[10] = lbltenhinh.Text;
            d[11] = rtxtMoTa.Text;
            d[12] = cboTenML.SelectedValue.ToString();

            dgvDanhSach.Rows.Add(d);

            btnThemSP.Enabled = false;
        }

        private void dgvDanhSach_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (f)
            {
                if (flag == 1)
                {
                    int giabandau = 0;
                    string chuoirong = "";

					if (e.ColumnIndex == 1)
					{
						for (int i = 0; i < dgvDanhSach.Rows.Count; i++)
						{
							chuoirong += dgvDanhSach.Rows[i].Cells[1].Value.ToString();
						}
						txtTenSP.Text = chuoirong.ToString();
					}
					if (e.ColumnIndex == 3)
                    {                    
                        for (int i = 0; i < dgvDanhSach.Rows.Count; i++)
                        {
							giabandau += int.Parse(dgvDanhSach.Rows[i].Cells[3].Value.ToString());
                        }
                        txtSoLuongM.Text = giabandau.ToString();
                    }
                    if (e.ColumnIndex == 4)
                    {                      
                        for (int i = 0; i < dgvDanhSach.Rows.Count; i++)
                        {
							giabandau += int.Parse(dgvDanhSach.Rows[i].Cells[4].Value.ToString());
                        }
                        txtSoLuongL.Text = giabandau.ToString();
                    }
                    if (e.ColumnIndex == 5)
                    {
                        for (int i = 0; i < dgvDanhSach.Rows.Count; i++)
                        {
							giabandau += int.Parse(dgvDanhSach.Rows[i].Cells[5].Value.ToString());
                        }
                        txtSoLuongXL.Text = giabandau.ToString();
                    }
					if (e.ColumnIndex == 6)
					{
						for (int i = 0; i < dgvDanhSach.Rows.Count; i++)
						{
							giabandau += int.Parse(dgvDanhSach.Rows[i].Cells[6].Value.ToString());
                            dgvDanhSach.Rows[i].Cells[7].Value = giabandau * 2;
							dgvDanhSach.Rows[i].Cells[8].Value = giabandau * 3;
							dgvDanhSach.Rows[i].Cells[9].Value = giabandau * 4;
						}
						txtGiaNhap.Text = giabandau.ToString();
						txtGiaM.Text = (giabandau * 2).ToString();
						txtGiaL.Text = (giabandau * 3).ToString();
						txtGiaXL.Text = (giabandau * 4).ToString();
						
					}
					if (e.ColumnIndex == 7)
					{
						for (int i = 0; i < dgvDanhSach.Rows.Count; i++)
						{
							giabandau += int.Parse(dgvDanhSach.Rows[i].Cells[7].Value.ToString());
						}
						txtGiaM.Text = giabandau.ToString();		
					}
					if (e.ColumnIndex == 8)
					{
						for (int i = 0; i < dgvDanhSach.Rows.Count; i++)
						{
							giabandau += int.Parse(dgvDanhSach.Rows[i].Cells[8].Value.ToString());
						}
						txtGiaL.Text = giabandau.ToString();
					}
					if (e.ColumnIndex == 9)
					{						
						for (int i = 0; i < dgvDanhSach.Rows.Count; i++)
						{
							giabandau += int.Parse(dgvDanhSach.Rows[i].Cells[9].Value.ToString());
						}
						txtGiaXL.Text = giabandau.ToString();				
					}

                    if(e.ColumnIndex == 11)
                    {
                        for(int i =0; i< dgvDanhSach.Rows.Count; i++)
                        {
							chuoirong += dgvDanhSach.Rows[i].Cells[11].Value.ToString();
						}
						rtxtMoTa.Text = chuoirong.ToString();
					}
				}
            }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("không được nhập kí tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtGiaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("không được nhập kí tự này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmSanPham_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult thoat;
            thoat = MessageBox.Show("Bạn chắc chắn muốn thoát", "Thông Báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (thoat == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

		private void txtSoLuongL_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && e.KeyChar != 8)
			{
				e.Handled = true;
				MessageBox.Show("không được nhập kí tự này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void txtSoLuongXL_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && e.KeyChar != 8)
			{
				e.Handled = true;
				MessageBox.Show("không được nhập kí tự này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
	}
}