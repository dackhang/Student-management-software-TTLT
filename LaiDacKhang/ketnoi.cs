using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    internal class ketnoi
    {
        private SqlConnection conn;

        public ketnoi()
        {
            string strConnection = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Application.StartupPath}\\qlsv.mdf;Integrated Security=True;Connect Timeout=30";
            conn = new SqlConnection(strConnection);
        }

        public void MoKetNoi()
        {
            try
            {
                if (conn.State == ConnectionState.Closed) // Kiểm tra trạng thái kết nối
                {
                    conn.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chưa kết nối được. Bạn kiểm tra lại tên server và tên cơ sở dữ liệu.", "Kết nối", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(ex.Message);
            }
        }

        public void DongKetNoi()
        {
            if (conn.State == ConnectionState.Open) // Kiểm tra xem kết nối có đang mở không
            {
                conn.Close();
            }
        }

        public SqlConnection GetConnection() // Trả về đối tượng kết nối
        {
            return conn;
        }
    }
}