using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

namespace QuanLySinhVien
{
    public partial class In_cs : Form
    {
        public In_cs()
        {
            InitializeComponent();
        }

        private void In_cs_Load(object sender, EventArgs e)
        {
            try
            {
                // Cấu hình ReportViewer
                reportViewer1.ProcessingMode = ProcessingMode.Local;
                reportViewer1.ZoomMode = ZoomMode.PageWidth;

                // Xóa các DataSource cũ
                reportViewer1.LocalReport.DataSources.Clear();

                // Sử dụng đường dẫn tương đối
                string reportPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "chinhsachReport.rdlc");
                reportViewer1.LocalReport.ReportPath = reportPath;

                // Tạo DataTable và fill dữ liệu
                DataTable dt = new DataTable();
                using (SqlConnection conn = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Application.StartupPath}\\qlsv.mdf;Integrated Security=True;Connect Timeout=30"))
                {
                    conn.Open();
                    string query = "SELECT macs, tencs, chedo FROM chinhsach";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.Fill(dt);
                }

                // Tạo và thêm ReportDataSource
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "DataSetChinhSach"; // Phải trùng với tên Dataset trong RDLC
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

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            // Có thể để trống nếu không cần xử lý gì thêm
        }
    }
}
