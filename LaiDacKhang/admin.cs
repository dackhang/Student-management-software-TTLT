using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class admin : Form
    {
        private SqlConnection myconn;

        public admin()
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

        private void admin_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                OpenConnection();
                string strsql = "select tk as [Tên Tài Khoản], mk as [Mật Khẩu] from admin";
                DataSet dtset = new DataSet();
                SqlDataAdapter dtadapter = new SqlDataAdapter(strsql, myconn);
                dtadapter.Fill(dtset);

                if (dtset.Tables[0].Rows.Count > 0)
                {
                    Dgv_admin.DataSource = dtset.Tables[0];
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

        private void Btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                OpenConnection();
                string s = "insert into admin (tk, mk) values(@username, @password)";
                SqlCommand com = new SqlCommand(s, myconn);
                com.Parameters.AddWithValue("@username", Tbx_ten.Text);
                com.Parameters.AddWithValue("@password", Tbx_mk.Text);
                com.ExecuteNonQuery();
                com.Dispose();

                // Cập nhật lại DataGridView sau khi thêm mới
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dữ liệu Đã Tồn Tại! Bạn Vui Lòng Nhập Lại!", "Báo lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
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
                string strsql = "update admin set mk = @password where tk = @username";
                SqlCommand cmd = new SqlCommand(strsql, myconn);
                cmd.Parameters.AddWithValue("@username", Tbx_ten.Text);
                cmd.Parameters.AddWithValue("@password", Tbx_mk.Text);
                cmd.ExecuteNonQuery();

                // Cập nhật lại DataGridView sau khi chỉnh sửa
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
                string strsql = "delete from admin where tk = @username";
                SqlCommand cmd = new SqlCommand(strsql, myconn);
                cmd.Parameters.AddWithValue("@username", Tbx_ten.Text);
                cmd.ExecuteNonQuery();

                // Cập nhật lại DataGridView sau khi xóa
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
            Tbx_ten.Clear();
            Tbx_mk.Clear();
        }

        private void Btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dgv_admin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    Tbx_ten.Text = Dgv_admin.Rows[e.RowIndex].Cells[0].Value.ToString();
                    Tbx_mk.Text = Dgv_admin.Rows[e.RowIndex].Cells[1].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi chọn dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}