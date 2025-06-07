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
    public partial class lop : Form
    {
        private SqlConnection myconn;
        public lop()
        {
            InitializeComponent();
            myconn = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Application.StartupPath}\\qlsv.mdf;Integrated Security=True;Connect Timeout=30");
            LoadData();
        }

        // Mở kết nối cơ sở dữ liệu
        private void OpenConnection()
        {
            if (myconn.State == ConnectionState.Closed)
            {
                myconn.Open();
            }
        }

        // Đóng kết nối cơ sở dữ liệu
        private void CloseConnection()
        {
            if (myconn.State == ConnectionState.Open)
            {
                myconn.Close();
            }
        }

        // Load dữ liệu vào DataGridView
        private void LoadData()
        {
            try
            {
                OpenConnection();
                string strsql = "SELECT malop AS [Mã Lớp], tenlop AS [Tên Lớp], makhoa AS [Mã Khoa] FROM lop";
                DataSet dtset = new DataSet();
                SqlDataAdapter dtadapter = new SqlDataAdapter(strsql, myconn);
                dtadapter.Fill(dtset);
                Dgv_lop.DataSource = dtset.Tables[0];
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
            In_lop in_Lop = new In_lop();
            in_Lop.Show();
        }

        private void Dgv_lop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Tbx_malop.Text = Dgv_lop.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                Tbx_tenlop.Text = Dgv_lop.Rows[e.RowIndex].Cells[1].Value.ToString().Trim();
                Tbx_makhoa.Text = Dgv_lop.Rows[e.RowIndex].Cells[2].Value.ToString().Trim();
            }
        }
    }
}
