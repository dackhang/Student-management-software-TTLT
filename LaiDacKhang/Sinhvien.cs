using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class Sinhvien : Form
    {
        private SqlConnection myconn;

        public Sinhvien()
        {
            InitializeComponent();
            myconn = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Application.StartupPath}\\qlsv.mdf;Integrated Security=True;Connect Timeout=30");
            LoadData();
        }

        private void OpenConnection()
        {
            if (myconn.State == ConnectionState.Closed)
            {
                myconn.Open();
            }
        }

        private void CloseConnection()
        {
            if (myconn.State == ConnectionState.Open)
            {
                myconn.Close();
            }
        }

        private void LoadData()
        {
            try
            {
                OpenConnection();
                string query = "SELECT * FROM sinhvien"; // Điều chỉnh query theo cấu trúc bảng
                SqlDataAdapter adapter = new SqlDataAdapter(query, myconn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                Dgv_sinhvien.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        private void Dgv_sinhvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Tbx_masv.Text = Dgv_sinhvien.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                Tbx_tensv.Text = Dgv_sinhvien.Rows[e.RowIndex].Cells[1].Value.ToString().Trim();
                Tbx_ngaysinh.Text = Dgv_sinhvien.Rows[e.RowIndex].Cells[3].Value.ToString().Trim();
                Tbx_sdt.Text = Dgv_sinhvien.Rows[e.RowIndex].Cells[4].Value.ToString().Trim();
                Tbx_diachi.Text = Dgv_sinhvien.Rows[e.RowIndex].Cells[5].Value.ToString().Trim();
                Tbx_macs.Text = Dgv_sinhvien.Rows[e.RowIndex].Cells[6].Value.ToString().Trim();
                Tbx_malop.Text = Dgv_sinhvien.Rows[e.RowIndex].Cells[7].Value.ToString().Trim();

                // Xác định giới tính
                string gioitinh = Dgv_sinhvien.Rows[e.RowIndex].Cells[2].Value.ToString().Trim();
                if (gioitinh == "Nam")
                {
                    rb_nam.Checked = true;
                    rb_nu.Checked = false;
                }
                else if (gioitinh == "Nữ")
                {
                    rb_nam.Checked = false;
                    rb_nu.Checked = true;
                }
            }
        }

        private void Btn_in_Click(object sender, EventArgs e)
        {
            In_sv in_Sv = new In_sv();
            in_Sv.Show();
        }

        private void Btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
