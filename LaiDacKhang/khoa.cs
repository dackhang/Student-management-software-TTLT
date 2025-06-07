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
    public partial class khoa : Form
    {
        private SqlConnection myconn;

        public khoa()
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

        private void Btn_in_Click(object sender, EventArgs e)
        {
            In_khoa in_Khoa = new In_khoa();
            in_Khoa.Show();
        }

        private void Dgv_khoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Tbx_makhoa.Text = Dgv_khoa.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                Tbx_tenkhoa.Text = Dgv_khoa.Rows[e.RowIndex].Cells[1].Value.ToString().Trim();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}