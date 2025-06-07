using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class cn_monhoc : Form
    {
        private SqlConnection myconn;

        public cn_monhoc()
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
                string strsql = "SELECT mamh AS [Mã Môn Học], tenmh AS [Tên Môn Học], sotiet AS [Số Tiết], magv AS [Mã Giáo Viên] FROM monhoc";
                DataSet dtset = new DataSet();
                SqlDataAdapter dtadapter = new SqlDataAdapter(strsql, myconn);
                dtadapter.Fill(dtset);
                Dgv_monhoc.DataSource = dtset.Tables[0];
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
                OpenConnection();
                string strsql = "INSERT INTO monhoc (mamh, tenmh, sotiet, magv) VALUES (@mamh, @tenmh, @sotiet, @magv)";
                SqlCommand com = new SqlCommand(strsql, myconn);
                com.Parameters.AddWithValue("@mamh", Tbx_mamh.Text);
                com.Parameters.AddWithValue("@tenmh", Tbx_tenmh.Text);
                com.Parameters.AddWithValue("@sotiet", Tbx_sotiet.Text);
                com.Parameters.AddWithValue("@magv", Tbx_magv.Text);
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
                OpenConnection();
                string strsql = "UPDATE monhoc SET tenmh = @tenmh, sotiet = @sotiet, magv = @magv WHERE mamh = @mamh";
                SqlCommand com = new SqlCommand(strsql, myconn);
                com.Parameters.AddWithValue("@mamh", Tbx_mamh.Text);
                com.Parameters.AddWithValue("@tenmh", Tbx_tenmh.Text);
                com.Parameters.AddWithValue("@sotiet", Tbx_sotiet.Text);
                com.Parameters.AddWithValue("@magv", Tbx_magv.Text);
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
                string strsql = "DELETE FROM monhoc WHERE mamh = @mamh";
                SqlCommand com = new SqlCommand(strsql, myconn);
                com.Parameters.AddWithValue("@mamh", Tbx_mamh.Text);
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
            Tbx_mamh.Clear();
            Tbx_tenmh.Clear();
            Tbx_sotiet.Clear();
            Tbx_magv.Clear();
        }

        private void Btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dgv_monhoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Tbx_mamh.Text = Dgv_monhoc.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                Tbx_tenmh.Text = Dgv_monhoc.Rows[e.RowIndex].Cells[1].Value.ToString().Trim();
                Tbx_sotiet.Text = Dgv_monhoc.Rows[e.RowIndex].Cells[2].Value.ToString().Trim();
                Tbx_magv.Text = Dgv_monhoc.Rows[e.RowIndex].Cells[3].Value.ToString().Trim();
            }
        }
    }
}
