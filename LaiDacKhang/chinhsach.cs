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
    public partial class chinhsach : Form
    {
        private SqlConnection myconn;
        public chinhsach()
        {
            InitializeComponent();
            myconn = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Application.StartupPath}\\qlsv.mdf;Integrated Security=True;Connect Timeout=30");
            LoadData();  // Tải dữ liệu khi form mở
        }
        private void OpenConnection()
        {
            if (myconn.State == ConnectionState.Closed)
            {
                myconn.Open();
            }
        }

        // Đóng kết nối với cơ sở dữ liệu
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
                string strsql = "SELECT macs AS [Mã Chính Sách], tencs AS [Tên Chính Sách], chedo AS [Chế Độ] FROM chinhsach"; //, chedo AS [Chế Độ]
                DataSet dtset = new DataSet();
                SqlDataAdapter dtadapter = new SqlDataAdapter(strsql, myconn);
                dtadapter.Fill(dtset);
                if (dtset.Tables[0].Rows.Count > 0)
                {
                    Dgv_chinhsach.DataSource = dtset.Tables[0];
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
        //private void chinhsach_Load_Click(object sender, EventArgs e)
        //{
        //    String strsql;
        //    strsql = "select macs[Mã Chính Sách], tencs[Tên Chính Sách], chedo[Chế Độ] from chinhsach";
        //    DataSet dtset = new DataSet();
        //    SqlDataAdapter dtadapter = new SqlDataAdapter(strsql, myconn);
        //    dtadapter.Fill(dtset);
        //    this.Dgv_chinhsach.DataSource = dtset.Tables(0);
        //}
        private void Btn_xoa_Click(object sender, EventArgs e)
        {
            //Btn_Dong not xoa
            this.Close();
        }

        private void chinhsach_Load(object sender, EventArgs e)
        {

        }

        private void chinhsach_Click(object sender, EventArgs e)
        {

        }

        private void Dgv_chinhsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Tbx_macs.Text = Dgv_chinhsach.Rows[e.RowIndex].Cells[0].Value.ToString();
                Tbx_tencs.Text = Dgv_chinhsach.Rows[e.RowIndex].Cells[1].Value.ToString();
                Tbx_chedo.Text = Dgv_chinhsach.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void Btn_in_Click(object sender, EventArgs e)
        {
            In_cs in_Cs = new In_cs();
            in_Cs.Show();
        }
    }
}