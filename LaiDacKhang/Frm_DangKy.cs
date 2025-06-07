using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class Frm_DangKy : Form
    {
        public Frm_DangKy()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        public void ketnoi()
        {
            try
            {
                //B1: ket noi
                string strkn;
                //strkn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database\qlsv.mdf;Integrated Security=True";
                strkn = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={Application.StartupPath}\qlsv.mdf;Integrated Security=True;Connect Timeout=30";
                conn = new SqlConnection();
                conn.ConnectionString = strkn;
                //B2: Mo ket noi
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chưa kết nối được, Bạn Kiểm tra lại tên server và tên cơ sở dữ liệu", "Kết nối", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(ex.Message);
            }
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                ketnoi();
                String a = txtPassword.Text;
                String b = txtPasswordCheck.Text;
                if ( a == b)
                {
                    String str = "select count(*) from users where tk ='" + txtUsername.Text + "'";
                    if (txtUsername.Text.Trim() == "")
                    {
                        MessageBox.Show("Bạn chưa nhập tên người dùng !", "Đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    //else if (!IsValidEmail(txtUsername.Text))
                    //{
                    //    MessageBox.Show("Tên người dùng phải có định dạng email hợp lệ!", "Đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //    return;
                    //}
                    //}
                    else if (txtUsername.Text.Contains(" "))
                    {
                        MessageBox.Show("Tên người dùng không được chứa khoảng trắng!", "Đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    else if (txtPassword.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập mật khẩu !", "Đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand(str, conn);
                        int i = (int)cmd.ExecuteScalar();
                        cmd.Dispose();
                        if (i > 0)
                        {
                            MessageBox.Show("Tài Khoản Đã Được Đăng Ký. Vui lòng sử dụng tên khác !", "Đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtUsername.Focus();
                            //txtPassword.Text = "";
                            //txtUsername.Text = "";
                            txtPassword.Clear();
                            txtUsername.Clear();
                            txtPasswordCheck.Clear();
                            return;
                        }
                        else
                        {
                            String s = "insert into users values('" + txtUsername.Text + "','" + txtPassword.Text + "')";
                            SqlCommand com = new SqlCommand(s, conn);
                            com.ExecuteNonQuery();
                            com.Dispose();
                            if (MessageBox.Show("Đăng ký thành công. Bạn có muốn đăng nhập không ?", "Đăng nhập", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                Frm_DangNhap frmDangNhap = new Frm_DangNhap(); // Đảm bảo tạo một thể hiện mới của Frm_DangNhap
                                frmDangNhap.Show();
                            }
                            else
                            {
                                this.Close();
                            }
                        }
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu bạn nhập không khớp ! Xin vui lòng nhập lại ", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Clear();
                    txtPasswordCheck.Clear();
                }
            }
            catch ( Exception ex ) 
            {
                MessageBox.Show("Thao tác không thực hiện được. Vui lòng kiểm tra lại !", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool IsValidEmail(string email)
        {
            // Regex để kiểm tra định dạng email
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Frm_ChaoMung f = new Frm_ChaoMung();
            f.Show();
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Frm_DangNhap f = new Frm_DangNhap();
            f.Show();
            this.Close();
        }
    }
}
