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
    public partial class monhoc : Form
    {
        private SqlConnection myconn;
        public monhoc()
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
                string strsql = "SELECT mamh AS [Mã Môn Học], tenmh AS [Tên Môn Học], sotiet AS [Số Tiết], magv AS [Mã Giáo Viên] FROM monhoc";
                DataSet dtset = new DataSet();
                SqlDataAdapter dtadapter = new SqlDataAdapter(strsql, myconn);
                dtadapter.Fill(dtset);
                Dgv_monhoc.DataSource = dtset.Tables[0];
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
        private void Dgv_monhoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Tbx_mamh.Text = Dgv_monhoc.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                Tbx_tenmh.Text = Dgv_monhoc.Rows[e.RowIndex].Cells[1].Value.ToString().Trim();
                Tbx_sotiet.Text = Dgv_monhoc.Rows[e.RowIndex].Cells[2].Value.ToString().Trim();
                Tbx_magv.Text = Dgv_monhoc.Rows[e.RowIndex].Cells[3].Value.ToString().Trim();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_in_Click(object sender, EventArgs e)
        {
            In_monhoc in_Monhoc = new In_monhoc();
            in_Monhoc.Show();
        }
    }
}
