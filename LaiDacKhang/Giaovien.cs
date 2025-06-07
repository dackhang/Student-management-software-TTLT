using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class Giaovien : Form
    {
        private SqlConnection myconn;

        public Giaovien()
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
                string strsql = "SELECT magv AS [Mã Giáo Viên], tengv AS [Tên Giáo Viên], ngaysinh AS [Ngày Sinh], sdt AS [SĐT], diachi AS [Địa Chỉ], gioitinh AS [Giới Tính] FROM giaovien";
                DataSet dtset = new DataSet();
                SqlDataAdapter dtadapter = new SqlDataAdapter(strsql, myconn);
                dtadapter.Fill(dtset);
                Dgv_giaovien.DataSource = dtset.Tables[0];
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_in_Click(object sender, EventArgs e)
        {
            In_gv in_Gv = new In_gv();
            in_Gv.Show();
        }

        private void Dgv_giaovien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Tbx_magv.Text = Dgv_giaovien.Rows[e.RowIndex].Cells[0].Value.ToString();
                Tbx_tengv.Text = Dgv_giaovien.Rows[e.RowIndex].Cells[1].Value.ToString();
                Tbx_ngaysinh.Text = Dgv_giaovien.Rows[e.RowIndex].Cells[2].Value.ToString();
                Tbx_sdt.Text = Dgv_giaovien.Rows[e.RowIndex].Cells[3].Value.ToString();
                Tbx_diachi.Text = Dgv_giaovien.Rows[e.RowIndex].Cells[4].Value.ToString();

                string gioitinh = Dgv_giaovien.Rows[e.RowIndex].Cells[5].Value.ToString();

                // Chọn giới tính dựa trên dữ liệu từ cột
                if (gioitinh == "Nam")
                {
                    rb_nam.Checked = true;
                }
                else if (gioitinh == "Nữ")
                {
                    rb_nu.Checked = true;
                }
            }
        }
    }
}
