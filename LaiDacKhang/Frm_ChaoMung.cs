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
    public partial class Frm_ChaoMung : Form
    {
        public Frm_ChaoMung()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThongTin_Click(object sender, EventArgs e)
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

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            Frm_DangKy t = new Frm_DangKy();
            t.Show();
            this.Hide();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            Frm_DangNhap t = new Frm_DangNhap();
            t.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label2.Left < this.Width)
            {
                label2.Left = label2.Left + 10;
            } else
            {
                label2.Left = -label2.Width;
            }
        }

        private void label1_Click(object sender, EventArgs e)
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

        private void Frm_ChaoMung_Load(object sender, EventArgs e)
        {

        }
    }
}
