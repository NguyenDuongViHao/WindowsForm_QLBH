using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_11_QuanLyBanh
{
	public partial class frmThongKeHoaDonNhap : Form
	{
		private SqlConnection con;
		public frmThongKeHoaDonNhap()
		{
			InitializeComponent();
			string conString = "Server=LAPTOP-89CSI2HV;Database=quanlybanBanh;Trusted_Connection=True;MultipleActiveResultSets=true";
			con = new SqlConnection(conString);
		}
		private bool isCheckboxColumnAdded = false;
		private bool isDataLoaded = false;
		CheckBox headerCheckBox = new CheckBox();
		private void HeaderCheckBox_Clicked(object sender, EventArgs e)
		{
			dataGridView1.EndEdit();

			foreach (DataGridViewRow row in dataGridView1.Rows)
			{
				DataGridViewCheckBoxCell checkBox = (row.Cells["Chon"] as DataGridViewCheckBoxCell);
				checkBox.Value = headerCheckBox.Checked;
			}
		}

		private void LoadDataToDataGridView()
		{
			if (!isCheckboxColumnAdded)
			{
				DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
				checkBoxColumn.HeaderText = "";
				checkBoxColumn.Width = 30;
				checkBoxColumn.Name = "Chon";
				dataGridView1.Columns.Insert(0, checkBoxColumn);

				Point headerCellLocation = this.dataGridView1.GetCellDisplayRectangle(0, -1, true).Location;

				headerCheckBox.Location = new Point(headerCellLocation.X + 8, headerCellLocation.Y + 2);
				headerCheckBox.BackColor = Color.White;
				headerCheckBox.Size = new Size(18, 18);

				headerCheckBox.Click += new EventHandler(HeaderCheckBox_Clicked);
				dataGridView1.Controls.Add(headerCheckBox);

				isCheckboxColumnAdded = true;
			};

			DataTable dataTable = new DataTable();
			dataTable.Columns.Add("Mã hóa đơn nhập");
			dataTable.Columns.Add("Mã nhà cung cấp");

			dataTable.Columns.Add("Mã nhân viên");
			dataTable.Columns.Add("Ngày lập hóa đơn");

			dataTable.Columns.Add("Tổng tiền");




			DateTime dateFrom = dateTimePicker1.Value.Date;
			DateTime dateTo = dateTimePicker2.Value.Date;
			if (dateFrom <= dateTo)
			{
				string sqlQuery = @"select MaHDNhap as 'Mã hóa đơn nhập', MaNCC as 'Mã nhà cung cấp',MaNV as 'Mã nhân viên', NgayNhap as 'Ngày lập hóa đơn', FORMAT(Tongtien, '#,##0.####') as 'Tổng tiền' from HoaDonNhap where NgayNhap BETWEEN  @dateFrom AND @dateTo";
				try
				{
					con.Open();
					using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
					{
						cmd.Parameters.AddWithValue("@dateFrom", dateFrom);
						cmd.Parameters.AddWithValue("@dateTo", dateTo);
						using (SqlDataAdapter adpt = new SqlDataAdapter(cmd))
						{
							adpt.Fill(dataTable);
							con.Close();
							dataGridView1.DataSource = dataTable;
						}
					}
					con.Close();
				}
				catch (Exception ex)
				{
					MessageBox.Show("Lỗi khi thực hiện tìm kiếm: " + ex.Message);
				}
			}
			else
			{
				MessageBox.Show("Ngày trước lớn hơn ngày sau");
				return;
			}

			for (int i = 1; i < dataGridView1.Columns.Count; i++)
			{
				if (dataGridView1.Columns[i].HeaderText != "Chọn")
				{
					dataGridView1.Columns[i].ReadOnly = true;
				}
			}

			isDataLoaded = true;
		}


		private void CalculateAndDisplayTotalTongtien(DateTime dateFrom, DateTime dateTo)
		{

			con.Open();
			string sqlQuery = "SELECT FORMAT(SUM(Tongtien), '#,##0.####') FROM HoaDonNhap WHERE NgayNhap BETWEEN @dateFrom AND @dateTo";
			using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
			{
				cmd.Parameters.AddWithValue("@dateFrom", dateFrom);
				cmd.Parameters.AddWithValue("@dateTo", dateTo);

				object result = cmd.ExecuteScalar();

				if (result != null && result != DBNull.Value)
				{
					label2.Text = result.ToString();
				}
				else
				{
					label2.Text = "0";
				}
			}
			con.Close();
		}

		private void btnTim_Click(object sender, EventArgs e)
		{
			LoadDataToDataGridView();
			CalculateAndDisplayTotalTongtien(dateTimePicker1.Value.Date, dateTimePicker2.Value.Date);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				if (!isDataLoaded)
				{
					MessageBox.Show("Vui lòng tải dữ liệu trước khi xuất Excel.");
					return;
				}

				if (dataGridView1.Rows.Count <= 0)
				{
					MessageBox.Show("Không có dữ liệu để xuất Excel.");
					return;
				}

				bool atLeastOneSelected = false;

				for (int i = 0; i < dataGridView1.Rows.Count; i++)
				{
					bool isChecked = Convert.ToBoolean(dataGridView1.Rows[i].Cells["Chon"].Value);

					if (isChecked)
					{
						atLeastOneSelected = true;
						break;
					}
				}

				if (!atLeastOneSelected)
				{
					MessageBox.Show("Vui lòng chọn ít nhất một hàng để xuất Excel.");
					return;
				}

				ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

				using (var package = new OfficeOpenXml.ExcelPackage())
				{
					var worksheet = package.Workbook.Worksheets.Add("Sheet1");
					for (int i = 1; i < dataGridView1.Columns.Count; i++)
					{
						if (dataGridView1.Columns[i - 1].HeaderText != "Chọn")
						{
							worksheet.Cells[1, i].Value = dataGridView1.Columns[i].HeaderText;
						}
					}
					int rowCount = 1;
					// Export data rows
					for (int i = 0; i < dataGridView1.Rows.Count; i++)
					{
						bool isChecked = Convert.ToBoolean(dataGridView1.Rows[i].Cells["Chon"].Value);

						if (isChecked)
						{
							rowCount++;
							for (int j = 1; j < dataGridView1.Columns.Count; j++)
							{
								worksheet.Cells[rowCount, j].Value = dataGridView1.Rows[i].Cells[j].Value;
							}
						}
					}

					worksheet.Cells.AutoFitColumns();

					string dateTimeString = DateTime.Now.ToString("ddMMyyyy_hhmmss");
					string fileName = $"Báo_cáo_{dateTimeString}.xlsx";

					var saveFileDialog = new SaveFileDialog
					{
						Filter = "Excel Files|*.xlsx",
						FileName = fileName
					};

					if (saveFileDialog.ShowDialog() == DialogResult.OK)
					{
						File.WriteAllBytes(saveFileDialog.FileName, package.GetAsByteArray());
						MessageBox.Show("Xuất file Excel thành công.");
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi khi thực hiện xuất excel: " + ex.Message); ;
			}
		}

		private void frmThongKeHoaDonNhap_Load(object sender, EventArgs e)
		{

		}
	}
}
