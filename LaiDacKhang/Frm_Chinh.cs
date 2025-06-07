using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class Frm_Chinh : Form
    {
        public Frm_Chinh()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Lbl_qlsv.Text = "Hà Nội, " + DateTime.Now.ToString("dd MMMM yyyy, HH:mm:ss", new System.Globalization.CultureInfo("vi-VN"));
            if (Lbl_qlsv.Left <= this.Width)
            {
                Lbl_qlsv.Left = Lbl_qlsv.Left + 10;
            } 
            else 
                Lbl_qlsv.Left = -Lbl_qlsv.Width;
        }

        private void Lbl_qlsv_Click(object sender, EventArgs e)
        {
            string tt;
            tt = "Phần mềm: Quản Lý Sinh Viên\n";
            tt += "\n";
            tt += "Version: 1.0";
            tt += "\n";
            tt += "Thực tập lập trình .Net \n";
            tt += "\n";
            tt += "Copy right @năm 2024 \n";
            tt += "Designer by: Lại Đắc Khang \n";
            tt += "Email: ld.khang@gmail.com";
            MessageBox.Show((tt), "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Ts_btn_admin_Click(object sender, EventArgs e)
        {
            admin f = new admin();
            f.Show();
        }

        private void Ts_Btn_user_Click(object sender, EventArgs e)
        {
            user user = new user();
            user.Show();
        }

        private void Ts_Btn_dangxuat_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại xác nhận
            if (MessageBox.Show("Bạn có chắc muốn đăng xuất ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Nếu người dùng chọn "Yes"
                MessageBox.Show("Bạn đã đăng xuất thành công!", "Thông báo!",  MessageBoxButtons.OK,MessageBoxIcon.Information);

                // Tạo mới form đăng nhập (hoặc form bắt đầu)
                Frm_ChaoMung f = new Frm_ChaoMung();
                f.Show();  // Hiển thị form
                this.Hide();  // Ẩn form hiện tại (Form chính)
            }
            else
            {
                // Nếu người dùng chọn "No", giữ nguyên form hiện tại
                this.Show();
            }
        }

        private void Ts_Btn_tt_sinhvien_Click(object sender, EventArgs e)
        {
            Sinhvien sinhvien = new Sinhvien();
            sinhvien.Show();
        }

        private void Ts_Btn_tt_giaovien_Click(object sender, EventArgs e)
        {
            Giaovien giaovien = new Giaovien();
            giaovien.Show();
        }

        private void Ts_Btn_tt_lop_Click(object sender, EventArgs e)
        {
            lop lop = new lop();
            lop.Show();
        }

        private void Ts_Btn_tt_khoa_Click(object sender, EventArgs e)
        {
            khoa khoa = new khoa();
            khoa.Show();
        }

        private void Ts_Btn_tt_monhoc_Click(object sender, EventArgs e)
        {
            monhoc khoa = new monhoc();
            khoa.Show();
        }

        private void Ts_Btn_tt_chinhsach_Click(object sender, EventArgs e)
        {
            chinhsach ch = new chinhsach();
            ch.Show();
        }

        private void Ts_Btn_tt_diem_Click(object sender, EventArgs e)
        {
            diem f = new diem();
            f.Show();
        }

        private void Ts_Btn_tk_sinhvien_Click(object sender, EventArgs e)
        {
            tk_sinhvien t = new tk_sinhvien();
            t.Show();
        }

        private void Ts_Btn_tk_giaovien_Click(object sender, EventArgs e)
        {
            tk_giaovien t = new tk_giaovien();
            t.Show();
        }

        private void Ts_Btn_tk_lop_Click(object sender, EventArgs e)
        {
            tk_lop t = new tk_lop();
            t.Show();
        }

        private void Ts_Btn_tk_khoa_Click(object sender, EventArgs e)
        {
            tk_khoa t = new tk_khoa();
            t.Show();
        }

        private void Ts_Btn_tk_monhoc_Click(object sender, EventArgs e)
        {
            tk_monhoc t = new tk_monhoc();
            t.Show();
        }

        private void Ts_Btn_tk_chinhsach_Click(object sender, EventArgs e)
        {
            tk_chinhsach tk_Chinhsach = new tk_chinhsach();
            tk_Chinhsach.Show();
        }

        private void Ts_Btn_ql_giaovien_Click(object sender, EventArgs e)
        {
            cn_giaovien f = new cn_giaovien();
            f.Show();
        }

        private void Ts_Btn_ql_lop_Click(object sender, EventArgs e)
        {
            cn_lop f = new cn_lop();
            f.Show();
        }

        private void Ts_Btn_ql_sinhvien_Click(object sender, EventArgs e)
        {
            cn_sinhvien f  = new cn_sinhvien();
            f.Show();
        }

        private void Ts_Btn_ql_monhoc_Click(object sender, EventArgs e)
        {
            cn_monhoc f = new cn_monhoc();
            f.Show();
        }

        private void Ts_Btn_ql_chinhsach_Click(object sender, EventArgs e)
        {
            cn_chinhsach f = new cn_chinhsach();
            f.Show();
        }

        private void Ts_Btn_ql_diem_Click(object sender, EventArgs e)
        {
            cn_diem f = new cn_diem();
            f.Show();
        }

        private void Ts_Btn_ql_khoa_Click(object sender, EventArgs e)
        {
            cn_khoa f = new cn_khoa();
            f.Show();
        }

        private void paintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var paintPath = @"C:\Windows\system32\mspaint.exe";
            var processInfo = new System.Diagnostics.ProcessStartInfo
            {
                FileName = paintPath,
                UseShellExecute = true // Sử dụng Shell để xử lý đường dẫn hợp lệ
            };
            System.Diagnostics.Process.Start(processInfo);
        }

        private void cmdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cmd");

        }

        private void notpadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad");

        }

        private void máyTínhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");

        }

        private void microsoftWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string wordPath = @"C:\Program Files\Microsoft Office\root\Office16\WINWORD.EXE";
            System.Diagnostics.Process.Start(wordPath);
        }

        private void Frm_Chinh_Load(object sender, EventArgs e)
        {

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ts_Btn_khoa_Click(object sender, EventArgs e)
        {
            Ts_Btn_dangnhap.Visible = true;
            Ts_btn_admin.Visible = false;
            Ts_Btn_user.Visible = false;
            Ts_Btn_dangxuat.Visible = false;
            Ts_Btn_khoa.Visible = false;
            Ts_Btn_thongtin.Enabled = false;
            Ts_Btn_timkiem.Enabled = false;
            Ts_Btn_quanly.Enabled = false;
            Ts_Btn_hienthi.Enabled = false;
            Ts_Btn_tienich.Enabled = false;
            Ts_Btn_ht_capnhat.Visible = false;
            Ts_capnhatdiem.Visible = false;
            Ts_gv.Visible = false;
            Ts_truongkhoa.Visible = false;
            Ts_Btn_doimatkhau.Visible = false;
            toolStripSeparator2.Visible = false;
            khoamay f = new khoamay();
            f.Show();


        }

        private void Ts_Btn_dangnhap_Click(object sender, EventArgs e)
        {
            khoamay k = new khoamay();
            k.Show();
        }

        private void Ts_Btn_ht_lienhe_Click(object sender, EventArgs e)
        {
            string tt;
            tt = "Phần mềm: Quản Lý Sinh Viên\n";
            tt += "\n";
            tt += "Version: 1.0";
            tt += "\n";
            tt += "Thực tập lập trình .Net \n";
            tt += "\n";
            tt += "Copy right @năm 2024 \n";
            tt += "Designer by: Lại Đắc Khang \n";
            tt += "SDT: 095124554441 \n";
            tt += "Email: ld.khang@gmail.com";
            MessageBox.Show((tt), "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Ts_Btn_ht_thongtin_Click(object sender, EventArgs e)
        {
            FormThongTin formThongTin = new FormThongTin();
            formThongTin.Show();
        }

        private void Ts_Btn_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Bạn đã đăng xuất thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void Ts_Btn_doimatkhau_Click(object sender, EventArgs e)
        {
            doimatkhau f = new doimatkhau();
            f.Show();
        }

        private void Ts_gv_Click(object sender, EventArgs e)
        {
            tk_gv f = new tk_gv();
            f.Show();
        }

        private void Ts_truongkhoa_Click(object sender, EventArgs e)
        {
            truongkhoa f = new truongkhoa();
            f.Show();
        }

        private void Ts_capnhatdiem_Click(object sender, EventArgs e)
        {
            cn_diemsv f = new cn_diemsv();
            f.Show();
        }

        private void btnkieuxem_Click(object sender, EventArgs e)
        {
            string tt;
            tt = "Comming Soon...\n";
            MessageBox.Show((tt), "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnngonngu_Click(object sender, EventArgs e)
        {
            string tt;
            tt = "Comming Soon...\n";
            MessageBox.Show((tt), "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Ts_Btn_ht_capnhat_Click(object sender, EventArgs e)
        {
            string tt;
            tt = "Đây là phiên bản mới nhất !";
            MessageBox.Show((tt), "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void CapNhatThongTinDangNhap(string loaiTaiKhoan, DateTime thoiGianDangNhap)
        {
            lblThongTinDangNhap.Text = $"Tài khoản Loại: {loaiTaiKhoan} - Thời gian: {thoiGianDangNhap}";
        }
    }
}
