using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class doimatkhau : Form
    {
        private SqlConnection conn;

        public doimatkhau()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kiểm tra thông tin nhập
            if (string.IsNullOrWhiteSpace(Tbx_tendn.Text))
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Tbx_tendn.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(Tbx_mkc.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu cũ!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Tbx_mkc.Focus();
                return;
            }

            if (Tbx_matkhau.Text != Tbx_nhaplai.Text)
            {
                MessageBox.Show("Mật khẩu mới không khớp!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tentk = Tbx_tendn.Text.Trim();
            string matkhauCu = Tbx_mkc.Text.Trim();
            string matkhauMoi = Tbx_matkhau.Text.Trim();

            using (SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\qlsv.mdf;Integrated Security=True"))
            {
                try
                {
                    conn.Open();

                    // Kiểm tra và cập nhật mật khẩu
                    if (UpdatePassword(conn, "admin", tentk, matkhauCu, matkhauMoi) ||
                        UpdatePassword(conn, "gv", tentk, matkhauCu, matkhauMoi) ||
                        UpdatePassword(conn, "users", tentk, matkhauCu, matkhauMoi) ||
                        UpdatePassword(conn, "truongkhoa", tentk, matkhauCu, matkhauMoi))
                    {
                        MessageBox.Show("Bạn đã đổi mật khẩu thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Tên tài khoản hoặc mật khẩu cũ không đúng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi kết nối hoặc thực hiện đổi mật khẩu. Vui lòng thử lại!\n" + ex.Message,
                                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool UpdatePassword(SqlConnection conn, string tableName, string username, string currentPassword, string newPassword)
        {
            // Sử dụng parameterized query để tránh SQL Injection
            string query = $"UPDATE {tableName} SET mk = @newPassword WHERE tk = @username AND mk = @currentPassword";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@newPassword", newPassword);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@currentPassword", currentPassword);

                // ExecuteNonQuery trả về số dòng bị ảnh hưởng
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Đóng form
            this.Close();
        }
    }
}
