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
    public partial class cn_chinhsach : Form
    {
        private SqlConnection myconn;
        public cn_chinhsach()
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
        private void Btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                OpenConnection();
                string sql = "INSERT INTO chinhsach (macs, tencs, chedo) VALUES (@macs, @tencs, @chedo)"; //, chedo ,@chedo
                SqlCommand cmd = new SqlCommand(sql, myconn);
                cmd.Parameters.AddWithValue("@macs", Tbx_macs.Text);
                cmd.Parameters.AddWithValue("@tencs", Tbx_tencs.Text);
                cmd.Parameters.AddWithValue("@chedo", txt_chedo.Text);
                cmd.ExecuteNonQuery();
                LoadData();  // Cập nhật lại DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CloseConnection();
            }
        }

        private void Btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                OpenConnection();
                string sql = "UPDATE chinhsach SET tencs = @tencs, chedo = @chedo WHERE macs = @macs"; //chedo = @chedo
                SqlCommand cmd = new SqlCommand(sql, myconn);
                cmd.Parameters.AddWithValue("@macs", Tbx_macs.Text);
                cmd.Parameters.AddWithValue("@tencs", Tbx_tencs.Text);
                cmd.Parameters.AddWithValue("@chedo", txt_chedo.Text);
                cmd.ExecuteNonQuery();
                LoadData();  // Cập nhật lại DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CloseConnection();
            }
        }

        private void Btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                OpenConnection();
                string sql = "DELETE FROM chinhsach WHERE macs = @macs";
                SqlCommand cmd = new SqlCommand(sql, myconn);
                cmd.Parameters.AddWithValue("@macs", Tbx_macs.Text);
                cmd.ExecuteNonQuery();
                LoadData();  // Cập nhật lại DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CloseConnection();
            }
        }

        private void Btn_nhaplai_Click(object sender, EventArgs e)
        {
            Tbx_macs.Clear();
            Tbx_tencs.Clear();
            txt_chedo.Clear();
        }

        private void Btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dgv_chinhsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Tbx_macs.Text = Dgv_chinhsach.Rows[e.RowIndex].Cells[0].Value.ToString();
                Tbx_tencs.Text = Dgv_chinhsach.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_chedo.Text = Dgv_chinhsach.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }
    }
}
