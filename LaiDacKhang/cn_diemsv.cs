using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class cn_diemsv : Form
    {
        private SqlConnection myconn;

        public cn_diemsv()
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
                string strsql = "SELECT id AS [Mã Điểm], masv AS [Mã Sinh Viên], mamh AS [Mã Môn Học], diem AS [Điểm], is_locked AS [Đã Khóa] FROM diem";
                DataSet dtset = new DataSet();
                SqlDataAdapter dtadapter = new SqlDataAdapter(strsql, myconn);
                dtadapter.Fill(dtset);
                if (dtset.Tables[0].Rows.Count > 0)
                {
                    Dgv_diem.DataSource = dtset.Tables[0];
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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

        // Thêm mới điểm
        private void Btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                OpenConnection();
                string sql = "INSERT INTO diem (id, masv, mamh, diem) VALUES (@maid, @masv, @mamh, @diem)";
                SqlCommand cmd = new SqlCommand(sql, myconn);
                cmd.Parameters.AddWithValue("@maid", Tbx_maid.Text);
                cmd.Parameters.AddWithValue("@masv", Tbx_masv.Text);
                cmd.Parameters.AddWithValue("@mamh", Tbx_mamh.Text);
                cmd.Parameters.AddWithValue("@diem", Tbx_diem.Text);
                cmd.ExecuteNonQuery();
                LoadData();  // Cập nhật lại DataGridView
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

        // Sửa điểm
        private void Btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                OpenConnection();
                string checkQuery = "SELECT is_locked FROM diem WHERE id = @maid";
                SqlCommand checkCmd = new SqlCommand(checkQuery, myconn);
                checkCmd.Parameters.AddWithValue("@maid", Tbx_maid.Text);
                bool isLocked = Convert.ToBoolean(checkCmd.ExecuteScalar());

                if (isLocked)
                {
                    MessageBox.Show("Dữ liệu này đã bị khóa và không thể chỉnh sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string sql = "UPDATE diem SET masv = @masv, mamh = @mamh, diem = @diem WHERE id = @maid";
                SqlCommand cmd = new SqlCommand(sql, myconn);
                cmd.Parameters.AddWithValue("@maid", Tbx_maid.Text);
                cmd.Parameters.AddWithValue("@masv", Tbx_masv.Text);
                cmd.Parameters.AddWithValue("@mamh", Tbx_mamh.Text);
                cmd.Parameters.AddWithValue("@diem", Tbx_diem.Text);
                cmd.ExecuteNonQuery();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CloseConnection();
            }
        }

        // Xóa điểm
        private void Btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                OpenConnection();
                string checkQuery = "SELECT is_locked FROM diem WHERE id = @maid";
                SqlCommand checkCmd = new SqlCommand(checkQuery, myconn);
                checkCmd.Parameters.AddWithValue("@maid", Tbx_maid.Text);
                bool isLocked = Convert.ToBoolean(checkCmd.ExecuteScalar());

                if (isLocked)
                {
                    MessageBox.Show("Dữ liệu này đã bị khóa và không thể xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string sql = "DELETE FROM diem WHERE id = @maid";
                SqlCommand cmd = new SqlCommand(sql, myconn);
                cmd.Parameters.AddWithValue("@maid", Tbx_maid.Text);
                cmd.ExecuteNonQuery();
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

        // Khóa dữ liệu
        private void Btn_chuyendiem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenConnection();
                string sql = "UPDATE diem SET is_locked = 1 WHERE id = @maid";
                SqlCommand cmd = new SqlCommand(sql, myconn);
                cmd.Parameters.AddWithValue("@maid", Tbx_maid.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Dữ liệu đã được khóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi khóa dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CloseConnection();
            }
        }

        // Làm mới các TextBox
        private void Btn_nhaplai_Click(object sender, EventArgs e)
        {
            Tbx_maid.Clear();
            Tbx_masv.Clear();
            Tbx_mamh.Clear();
            Tbx_diem.Clear();
        }

        // Đóng form
        private void Btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Xử lý khi người dùng chọn dòng trong DataGridView
        private void Dgv_diem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Tbx_maid.Text = Dgv_diem.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                Tbx_masv.Text = Dgv_diem.Rows[e.RowIndex].Cells[1].Value.ToString().Trim();
                Tbx_mamh.Text = Dgv_diem.Rows[e.RowIndex].Cells[2].Value.ToString().Trim();
                Tbx_diem.Text = Dgv_diem.Rows[e.RowIndex].Cells[3].Value.ToString().Trim();
            }
        }
    }
}
