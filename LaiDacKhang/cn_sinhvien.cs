using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class cn_sinhvien : Form
    {
        private SqlConnection myconn;

        public cn_sinhvien()
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

                string gioitinh = Dgv_sinhvien.Rows[e.RowIndex].Cells[2].Value.ToString().Trim();
                if (gioitinh == "Nam")
                    rb_nam.Checked = true;
                else if (gioitinh == "Nữ")
                    rb_nu.Checked = true;
            }
        }

        private void Btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                OpenConnection();
                string gioitinh = rb_nam.Checked ? "Nam" : "Nữ";
                string query = "INSERT INTO sinhvien (masv, tensv, gioitinh, ngaysinh, sdt, diachi, macs, malop) " +
                               "VALUES (@masv, @tensv, @gioitinh, @ngaysinh, @sdt, @diachi, @macs, @malop)";

                SqlCommand cmd = new SqlCommand(query, myconn);
                cmd.Parameters.AddWithValue("@masv", Tbx_masv.Text.Trim());
                cmd.Parameters.AddWithValue("@tensv", Tbx_tensv.Text.Trim());
                cmd.Parameters.AddWithValue("@gioitinh", gioitinh);
                cmd.Parameters.AddWithValue("@ngaysinh", Tbx_ngaysinh.Text.Trim());
                cmd.Parameters.AddWithValue("@sdt", Tbx_sdt.Text.Trim());
                cmd.Parameters.AddWithValue("@diachi", Tbx_diachi.Text.Trim());
                cmd.Parameters.AddWithValue("@macs", Tbx_macs.Text.Trim());
                cmd.Parameters.AddWithValue("@malop", Tbx_malop.Text.Trim());

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Thêm sinh viên thành công!");
                    LoadData(); // Refresh dữ liệu
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm sinh viên: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        private void Btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                OpenConnection();
                string gioitinh = rb_nam.Checked ? "Nam" : "Nữ";
                string query = "UPDATE sinhvien SET tensv = @tensv, gioitinh = @gioitinh, ngaysinh = @ngaysinh, " +
                               "sdt = @sdt, diachi = @diachi, macs = @macs, malop = @malop WHERE masv = @masv";

                SqlCommand cmd = new SqlCommand(query, myconn);
                cmd.Parameters.AddWithValue("@masv", Tbx_masv.Text.Trim());
                cmd.Parameters.AddWithValue("@tensv", Tbx_tensv.Text.Trim());
                cmd.Parameters.AddWithValue("@gioitinh", gioitinh);
                cmd.Parameters.AddWithValue("@ngaysinh", Tbx_ngaysinh.Text.Trim());
                cmd.Parameters.AddWithValue("@sdt", Tbx_sdt.Text.Trim());
                cmd.Parameters.AddWithValue("@diachi", Tbx_diachi.Text.Trim());
                cmd.Parameters.AddWithValue("@macs", Tbx_macs.Text.Trim());
                cmd.Parameters.AddWithValue("@malop", Tbx_malop.Text.Trim());

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Sửa thông tin sinh viên thành công!");
                    LoadData(); // Refresh dữ liệu
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa sinh viên: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        private void Btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                OpenConnection();
                string query = "DELETE FROM sinhvien WHERE masv = @masv";

                SqlCommand cmd = new SqlCommand(query, myconn);
                cmd.Parameters.AddWithValue("@masv", Tbx_masv.Text.Trim());

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Xóa sinh viên thành công!");
                    LoadData(); // Refresh dữ liệu
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa sinh viên: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        private void Btn_nhaplai_Click(object sender, EventArgs e)
        {
            Tbx_masv.Clear();
            Tbx_tensv.Clear();
            Tbx_ngaysinh.Clear();
            Tbx_sdt.Clear();
            Tbx_diachi.Clear();
            Tbx_macs.Clear();
            Tbx_malop.Clear();
            rb_nam.Checked = false;
            rb_nu.Checked = false;
        }

        private void Btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
