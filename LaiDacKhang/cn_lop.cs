using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class cn_lop : Form
    {
        private SqlConnection myconn;

        public cn_lop()
        {
            InitializeComponent();
            myconn = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Application.StartupPath}\\qlsv.mdf;Integrated Security=True;Connect Timeout=30");
            LoadData();
        }

        // Mở kết nối cơ sở dữ liệu
        private void OpenConnection()
        {
            if (myconn.State == ConnectionState.Closed)
            {
                myconn.Open();
            }
        }

        // Đóng kết nối cơ sở dữ liệu
        private void CloseConnection()
        {
            if (myconn.State == ConnectionState.Open)
            {
                myconn.Close();
            }
        }

        // Load dữ liệu vào DataGridView
        private void LoadData()
        {
            try
            {
                OpenConnection();
                string strsql = "SELECT malop AS [Mã Lớp], tenlop AS [Tên Lớp], makhoa AS [Mã Khoa] FROM lop";
                DataSet dtset = new DataSet();
                SqlDataAdapter dtadapter = new SqlDataAdapter(strsql, myconn);
                dtadapter.Fill(dtset);
                Dgv_lop.DataSource = dtset.Tables[0];
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

        // Thêm lớp mới
        private void Btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                OpenConnection();
                string strsql = "INSERT INTO lop (malop, tenlop, makhoa) VALUES (@malop, @tenlop, @makhoa)";
                SqlCommand com = new SqlCommand(strsql, myconn);
                com.Parameters.AddWithValue("@malop", Tbx_malop.Text);
                com.Parameters.AddWithValue("@tenlop", Tbx_tenlop.Text);
                com.Parameters.AddWithValue("@makhoa", Tbx_makhoa.Text);
                com.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        // Sửa thông tin lớp
        private void Btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                OpenConnection();
                string strsql = "UPDATE lop SET tenlop = @tenlop, makhoa = @makhoa WHERE malop = @malop";
                SqlCommand com = new SqlCommand(strsql, myconn);
                com.Parameters.AddWithValue("@malop", Tbx_malop.Text);
                com.Parameters.AddWithValue("@tenlop", Tbx_tenlop.Text);
                com.Parameters.AddWithValue("@makhoa", Tbx_makhoa.Text);
                com.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadData();  // Cập nhật lại DataGridView
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

        // Xóa lớp
        private void Btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                OpenConnection();
                string strsql = "DELETE FROM lop WHERE malop = @malop";
                SqlCommand com = new SqlCommand(strsql, myconn);
                com.Parameters.AddWithValue("@malop", Tbx_malop.Text);
                com.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadData();  // Cập nhật lại DataGridView
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

        // Làm mới các TextBox
        private void Btn_nhaplai_Click(object sender, EventArgs e)
        {
            Tbx_malop.Clear();
            Tbx_tenlop.Clear();
            Tbx_makhoa.Clear();
        }

        // Đóng form
        private void Btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Khi chọn 1 hàng trong DataGridView
        private void Dgv_lop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Tbx_malop.Text = Dgv_lop.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                Tbx_tenlop.Text = Dgv_lop.Rows[e.RowIndex].Cells[1].Value.ToString().Trim();
                Tbx_makhoa.Text = Dgv_lop.Rows[e.RowIndex].Cells[2].Value.ToString().Trim();
            }
        }
    }
}