using DevExpress.Data.Filtering.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_11_QuanLyBanh
{
    public partial class frmTimKiemNhanVien : Form
    {
        public frmTimKiemNhanVien()
        {
            InitializeComponent();
        }


        quanlybanBanh q = new quanlybanBanh();
        DataSet dsNhanVien = new DataSet();
       
        Boolean f = false;

        void danhsach_datagridview(DataGridView d, string sql)
        {
            dsNhanVien = q.layDuLieu(sql);
            d.DataSource = dsNhanVien.Tables[0];
        }

      
        private void frmTimKiemNhanVien_Load(object sender, EventArgs e)
        {
            danhsach_datagridview(dgvDanhSach, "select * from NhanVien where trangthai=0");
           
            cboHienThiTimTheo.Enabled= false;
			cboHienThiTimTheo.Text = "";
            cboTimTheo.Text = "";
;			f = true;
        }

        void hienThiComboBox(ComboBox cbo, DataSet ds, string ten, string ma)
        {
            cbo.DataSource = ds.Tables[0];
            cbo.DisplayMember = ten;
            cbo.ValueMember = ma;
            cbo.SelectedIndex = -1;
        }

        private void cboTimTheo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (f)
            {
                if(cboTimTheo.SelectedIndex == 0) 
                {
                    dsNhanVien = q.layDuLieu("select * from NhanVien ");
                    hienThiComboBox(cboHienThiTimTheo, dsNhanVien, "MaNV", "MaNV");
                }
                if(cboTimTheo.SelectedIndex == 1)
                {
                    dsNhanVien = q.layDuLieu("select * from NhanVien ");
                    hienThiComboBox(cboHienThiTimTheo, dsNhanVien, "HoTen", "MaNV");
                }
            }
            cboHienThiTimTheo.Enabled = true;
           
        }

        private void cboHienThiTimTheo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ma = "";
            string sql = "";
            if (f)
            {
                if(cboTimTheo.SelectedIndex == 0)
                {
                    if (cboHienThiTimTheo.SelectedIndex != -1)
                    {
                        ma = cboHienThiTimTheo.SelectedValue.ToString();
                        sql = "select * from NhanVien where MaNV = '" + ma + "'";
                        dsNhanVien = q.layDuLieu(sql);
                        
                    }
                }
                if (cboTimTheo.SelectedIndex == 1)
                {
                    if (cboHienThiTimTheo.SelectedIndex != -1)
                    {
                        ma = cboHienThiTimTheo.SelectedValue.ToString();
                        sql = "select * from NhanVien where MaNV = '" + ma + "'";
                        dsNhanVien = q.layDuLieu(sql);
                        
                    }
                }

            }
            dgvDanhSach.DataSource = dsNhanVien.Tables[0];
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmTimKiemNhanVien_Load(sender, e);
          
            cboHienThiTimTheo.Text = "";
            cboTimTheo.Text = "";
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTimKiemNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult thoat;
            thoat = MessageBox.Show("Bạn chắc chắn muốn thoát", "Thông Báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (thoat == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

    }
}
