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
    public partial class cn_khoa : Form
    {
        private SqlConnection myconn;

        public cn_khoa()
        {
            InitializeComponent();
            myconn = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Application.StartupPath}\\qlsv.mdf;Integrated Security=True;Connect Timeout=30");
            LoadData();
        }

        // Mở kết nối
        private void OpenConnection()
        {
            if (myconn.State == ConnectionState.Closed)
            {
                myconn.Open();
            }
        }

        // Đóng kết nối
        private void CloseConnection()
        {
            if (myconn.State == ConnectionState.Open)
            {
                myconn.Close();
            }
        }

        // Hàm Load dữ liệu vào DataGridView
        private void LoadData()
        {
            try
            {
                OpenConnection();
                string strsql = "SELECT makhoa AS [Mã Khoa], tenkhoa AS [Tên Khoa] FROM khoa";
                DataSet dtset = new DataSet();
                SqlDataAdapter dtadapter = new SqlDataAdapter(strsql, myconn);
                dtadapter.Fill(dtset);
                Dgv_khoa.DataSource = dtset.Tables[0];
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

        // Thêm mới Khoa
        private void Btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                OpenConnection();
                string strsql = "INSERT INTO khoa (makhoa, tenkhoa) VALUES (@makhoa, @tenkhoa)";
                SqlCommand com = new SqlCommand(strsql, myconn);
                com.Parameters.AddWithValue("@makhoa", Tbx_makhoa.Text);
                com.Parameters.AddWithValue("@tenkhoa", Tbx_tenkhoa.Text);
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

        // Sửa thông tin Khoa
        private void Btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                OpenConnection();
                string strsql = "UPDATE khoa SET tenkhoa = @tenkhoa WHERE makhoa = @makhoa";
                SqlCommand com = new SqlCommand(strsql, myconn);
                com.Parameters.AddWithValue("@makhoa", Tbx_makhoa.Text);
                com.Parameters.AddWithValue("@tenkhoa", Tbx_tenkhoa.Text);
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

        // Xóa Khoa
        private void Btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                OpenConnection();
                string strsql = "DELETE FROM khoa WHERE makhoa = @makhoa";
                SqlCommand com = new SqlCommand(strsql, myconn);
                com.Parameters.AddWithValue("@makhoa", Tbx_makhoa.Text);
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

        // Làm mới TextBox
        private void Btn_nhaplai_Click(object sender, EventArgs e)
        {
            Tbx_makhoa.Clear();
            Tbx_tenkhoa.Clear();
        }

        // Đóng form
        private void Btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Khi chọn 1 hàng trong DataGridView
        private void Dgv_khoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Tbx_makhoa.Text = Dgv_khoa.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                Tbx_tenkhoa.Text = Dgv_khoa.Rows[e.RowIndex].Cells[1].Value.ToString().Trim();
            }
        }
    }
}