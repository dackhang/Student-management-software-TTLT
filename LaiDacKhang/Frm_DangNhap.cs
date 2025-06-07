using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class Frm_DangNhap : Form
    {
        private SqlConnection conn;
        private int sai = 5;

        public Frm_DangNhap()
        {
            InitializeComponent();
        }

        private void KetNoi()
        {
            try
            {
                // Kết nối cơ sở dữ liệu
                //string strkn = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Application.StartupPath}\\qlsv.mdf;Integrated Security=True;Connect Timeout=30";
                //string strkn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database\qlsv.mdf;Integrated Security=True";
                string strkn = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={Application.StartupPath}\qlsv.mdf;Integrated Security=True;Connect Timeout=30";
                conn = new SqlConnection(strkn);
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chưa kết nối được. Kiểm tra lại tên server và tên cơ sở dữ liệu.", "Kết nối", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(ex.Message);
            }
        }

        private bool KiemTraTaiKhoan(string taiKhoan, string matKhau, string bang)
        {
            string query = $"SELECT COUNT(*) FROM {bang} WHERE tk=@tk AND mk=@mk";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@tk", taiKhoan);
                cmd.Parameters.AddWithValue("@mk", matKhau);
                return (int)cmd.ExecuteScalar() > 0;
            }
        }

        private void XuLyDangNhap(string taiKhoan, string matKhau)
        {
            if (KiemTraTaiKhoan(taiKhoan, matKhau, "admin"))
            {
                ShowThongBaoVaChuyenSangFrmChinh("Admin", true, false, false, false); //ban đầu 3 true 
            }
            else if (KiemTraTaiKhoan(taiKhoan, matKhau, "gv"))
            {
                ShowThongBaoVaChuyenSangFrmChinh("Giáo viên", false, true, false, false); // ban đầu 3 false 
            }
            else if (KiemTraTaiKhoan(taiKhoan, matKhau, "users"))
            {
                ShowThongBaoVaChuyenSangFrmChinh("User", false, false, true, false); //ban đầu 3 false 
            }
            else if (KiemTraTaiKhoan(taiKhoan, matKhau, "truongkhoa"))
            {
                ShowThongBaoVaChuyenSangFrmChinh("Trưởng khoa", false, false, false, true); //ban đầu 3 false 
            }
            else
            {
                sai--;
                if (sai > 0)
                {
                    MessageBox.Show($"Username hoặc Password sai! Bạn còn {sai} lần đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUsername.Clear();
                    txtPassword.Clear();
                    txtUsername.Focus();
                }
                else
                {
                    MessageBox.Show("Đã hết lượt truy cập. Mời bạn đăng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                    Frm_ChaoMung z = new Frm_ChaoMung();
                    z.Show();
                }
            }
        }

        private void ShowThongBaoVaChuyenSangFrmChinh(string loaiTaiKhoan, bool hienThiAdmin, bool hienThiGiaoVien, bool hienThiUser, bool hienThiTruongKhoa)
        {
            this.Close();
            MessageBox.Show($"Bạn đã đăng nhập vào tài khoản {loaiTaiKhoan}!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Frm_Chinh ad = new Frm_Chinh();
            ad.CapNhatThongTinDangNhap(loaiTaiKhoan, DateTime.Now); // Cập nhật thông tin đăng nhập
            ad.Show();

            if (hienThiAdmin)
            {
                // Các phần khác liên quan đến Admin
            }
            else if (hienThiGiaoVien)
            {
                ad.Ts_btn_admin.Visible = false;
                ad.Ts_Btn_dangnhap.Visible = false;
                ad.Ts_truongkhoa.Visible = false;
                ad.Ts_gv.Visible = false;
                ad.Ts_Btn_user.Visible = false;
                ad.Ts_Btn_quanly.Visible = false;
            }
            else if (hienThiUser)
            {
                ad.Ts_btn_admin.Visible = false;
                ad.Ts_Btn_dangnhap.Visible = false;
                ad.Ts_truongkhoa.Visible = false;
                ad.Ts_gv.Visible = false;
                ad.Ts_Btn_user.Visible = false;
                ad.Ts_Btn_quanly.Visible = false;
                ad.Ts_capnhatdiem.Visible = false;
            }
            else if (hienThiTruongKhoa)
            {
                ad.Ts_btn_admin.Visible = false;
                ad.Ts_Btn_dangnhap.Visible = false;
                ad.Ts_truongkhoa.Visible = false;
                ad.Ts_gv.Visible = false;
                ad.Ts_Btn_user.Visible = false;
                ad.Ts_capnhatdiem.Visible = false;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string tentk = txtUsername.Text;
            string matkhau = txtPassword.Text;

            // Kiểm tra xem tên tài khoản có được nhập hay không
            if (string.IsNullOrWhiteSpace(tentk))
            {
                MessageBox.Show("Bạn chưa Nhập Tên Tài khoản!", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
                return;
            }

            // Kiểm tra xem tên tài khoản có chứa khoảng trắng không
            if (tentk.Contains(" "))
            {
                MessageBox.Show("Tên người dùng không được chứa khoảng trắng!", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
                return;
            }

            // Kiểm tra xem mật khẩu có được nhập hay không
            if (string.IsNullOrWhiteSpace(matkhau))
            {
                MessageBox.Show("Bạn chưa Nhập Mật khẩu!", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            // Gọi hàm kết nối
            KetNoi();

            // Xử lý đăng nhập
            XuLyDangNhap(tentk, matkhau);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Frm_ChaoMung vx = new Frm_ChaoMung();
            vx.Show();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Frm_DangKy frm_DangKy = new Frm_DangKy();
            frm_DangKy.Show();
            this.Close();
        }
    }
}