using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

namespace QuanLySinhVien
{
    public partial class In_gv : Form
    {
        public In_gv()
        {
            InitializeComponent();
        }

        private void In_gv_Load(object sender, EventArgs e)
        {
            try
            {
                // Cấu hình ReportViewer
                reportViewer1.ProcessingMode = ProcessingMode.Local;
                reportViewer1.ZoomMode = ZoomMode.PageWidth;

                // Xóa các DataSource cũ
                reportViewer1.LocalReport.DataSources.Clear();
                string reportPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "giaovienReport.rdlc");
                reportViewer1.LocalReport.ReportPath = reportPath;

                // Tạo DataTable và fill dữ liệu
                DataTable dt = new DataTable();
                using (SqlConnection conn = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Application.StartupPath}\\qlsv.mdf;Integrated Security=True;Connect Timeout=30"))
                {
                    conn.Open();
                    string query = "SELECT magv, tengv, gioitinh, ngaysinh, sdt, diachi FROM giaovien";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.Fill(dt);
                }

                // Tạo và thêm ReportDataSource
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "DataSetGiaoVien"; // Phải trùng với tên Dataset trong RDLC
                rds.Value = dt;

                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.PageWidth; // Đặt ZoomMode thành Page Width
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}