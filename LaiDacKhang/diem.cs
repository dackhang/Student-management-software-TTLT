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
    public partial class diem : Form
    {
        private SqlConnection myconn;
        public diem()
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
                string strsql = "SELECT id AS [Mã Điểm], masv AS [Mã Sinh Viên], mamh AS [Mã Môn Học], diem AS [Điểm], is_locked AS [Đã Khóa] FROM diem";
                DataSet dtset = new DataSet();
                SqlDataAdapter dtadapter = new SqlDataAdapter(strsql, myconn);
                dtadapter.Fill(dtset);
                if (dtset.Tables[0].Rows.Count > 0)
                {
                    Dgv_diem.DataSource = dtset.Tables[0];
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
        private void Dgv_diem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Tbx_maid.Text = Dgv_diem.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                Tbx_masv.Text = Dgv_diem.Rows[e.RowIndex].Cells[1].Value.ToString().Trim();
                Tbx_mamh.Text = Dgv_diem.Rows[e.RowIndex].Cells[2].Value.ToString().Trim();
                Tbx_diem.Text = Dgv_diem.Rows[e.RowIndex].Cells[3].Value.ToString().Trim();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_in_Click(object sender, EventArgs e)
        {
            In_diem in_Diem = new In_diem();
            in_Diem.Show();
        }
    }
}
