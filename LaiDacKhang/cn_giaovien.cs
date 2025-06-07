using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class cn_giaovien : Form
    {
        private SqlConnection myconn;

        public cn_giaovien()
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
                string strsql = "SELECT magv AS [Mã Giáo Viên], tengv AS [Tên Giáo Viên], ngaysinh AS [Ngày Sinh], sdt AS [SĐT], diachi AS [Địa Chỉ], gioitinh AS [Giới Tính] FROM giaovien";
                DataSet dtset = new DataSet();
                SqlDataAdapter dtadapter = new SqlDataAdapter(strsql, myconn);
                dtadapter.Fill(dtset);
                Dgv_giaovien.DataSource = dtset.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CloseConnection();
            }
        }

        private void Btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                string gioitinh = rb_nam.Checked ? "Nam" : rb_nu.Checked ? "Nữ" : string.Empty;

                if (string.IsNullOrEmpty(gioitinh))
                {
                    MessageBox.Show("Vui lòng chọn giới tính.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                OpenConnection();
                string strsql = "INSERT INTO giaovien (magv, tengv, ngaysinh, sdt, diachi, gioitinh) VALUES (@magv, @tengv, @ngaysinh, @sdt, @diachi, @gioitinh)";
                SqlCommand com = new SqlCommand(strsql, myconn);
                com.Parameters.AddWithValue("@magv", Tbx_magv.Text);
                com.Parameters.AddWithValue("@tengv", Tbx_tengv.Text);
                com.Parameters.AddWithValue("@ngaysinh", Tbx_ngaysinh.Text);
                com.Parameters.AddWithValue("@sdt", Tbx_sdt.Text);
                com.Parameters.AddWithValue("@diachi", Tbx_diachi.Text);
                com.Parameters.AddWithValue("@gioitinh", gioitinh);
                com.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                string gioitinh = rb_nam.Checked ? "Nam" : rb_nu.Checked ? "Nữ" : string.Empty;

                if (string.IsNullOrEmpty(gioitinh))
                {
                    MessageBox.Show("Vui lòng chọn giới tính.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                OpenConnection();
                string strsql = "UPDATE giaovien SET tengv = @tengv, ngaysinh = @ngaysinh, sdt = @sdt, diachi = @diachi, gioitinh = @gioitinh WHERE magv = @magv";
                SqlCommand com = new SqlCommand(strsql, myconn);
                com.Parameters.AddWithValue("@magv", Tbx_magv.Text);
                com.Parameters.AddWithValue("@tengv", Tbx_tengv.Text);
                com.Parameters.AddWithValue("@ngaysinh", Tbx_ngaysinh.Text);
                com.Parameters.AddWithValue("@sdt", Tbx_sdt.Text);
                com.Parameters.AddWithValue("@diachi", Tbx_diachi.Text);
                com.Parameters.AddWithValue("@gioitinh", gioitinh);
                com.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                string strsql = "DELETE FROM giaovien WHERE magv = @magv";
                SqlCommand com = new SqlCommand(strsql, myconn);
                com.Parameters.AddWithValue("@magv", Tbx_magv.Text);
                com.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CloseConnection();
            }
        }

        private void Btn_nhaplai_Click(object sender, EventArgs e)
        {
            Tbx_magv.Clear();
            Tbx_tengv.Clear();
            Tbx_ngaysinh.Clear();
            Tbx_sdt.Clear();
            Tbx_diachi.Clear();
            rb_nam.Checked = false;
            rb_nu.Checked = false;
        }

        private void Btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dgv_giaovien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Tbx_magv.Text = Dgv_giaovien.Rows[e.RowIndex].Cells[0].Value.ToString();
                Tbx_tengv.Text = Dgv_giaovien.Rows[e.RowIndex].Cells[1].Value.ToString();
                Tbx_ngaysinh.Text = Dgv_giaovien.Rows[e.RowIndex].Cells[2].Value.ToString();
                Tbx_sdt.Text = Dgv_giaovien.Rows[e.RowIndex].Cells[3].Value.ToString();
                Tbx_diachi.Text = Dgv_giaovien.Rows[e.RowIndex].Cells[4].Value.ToString();

                string gioitinh = Dgv_giaovien.Rows[e.RowIndex].Cells[5].Value.ToString();
                if (gioitinh == "Nam")
                {
                    rb_nam.Checked = true;
                    rb_nu.Checked = false;
                }
                else if (gioitinh == "Nữ")
                {
                    rb_nu.Checked = true;
                    rb_nam.Checked = false;
                }
            }
        }
    }
}
