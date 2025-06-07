using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class tk_monhoc : Form
    {
        private SqlConnection myconn;

        public tk_monhoc()
        {
            InitializeComponent();
            myconn = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Application.StartupPath}\\qlsv.mdf;Integrated Security=True;Connect Timeout=30");
            LoadData();
        }

        private void tk_monhoc_Load(object sender, EventArgs e)
        {
            // Thêm tùy chọn vào ComboBox
            Cbx_timtheo.Items.Add("Tên Môn Học");
            Cbx_timtheo.Items.Add("Số Tiết");

            // Tải dữ liệu ban đầu
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
            string strsql = @"
                SELECT 
                    mamh AS [Mã Môn Học], 
                    tenmh AS [Tên Môn Học], 
                    sotiet AS [Số Tiết], 
                    tengv AS [Tên Giáo Viên]
                FROM 
                    monhoc 
                JOIN 
                    giaovien ON monhoc.magv = giaovien.magv";

            try
            {
                OpenConnection();
                DataSet dtset = new DataSet();
                SqlDataAdapter dtadapter = new SqlDataAdapter(strsql, myconn);
                dtadapter.Fill(dtset);
                Dgv_timkiem.DataSource = dtset.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CloseConnection();
            }
        }

        private void Btn_tim_Click(object sender, EventArgs e)
        {
            // Kiểm tra điều kiện trước khi thực hiện tìm kiếm
            if (Cbx_timtheo.SelectedItem == null || string.IsNullOrEmpty(Tbx_tukhoa.Text))
            {
                MessageBox.Show("Vui lòng chọn mục tìm kiếm và nhập từ khóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Xác định cột tìm kiếm
            string filterColumn = "";
            if (Cbx_timtheo.SelectedItem.ToString() == "Tên Môn Học")
            {
                filterColumn = "tenmh";
            }
            else if (Cbx_timtheo.SelectedItem.ToString() == "Số Tiết")
            {
                filterColumn = "sotiet";
            }

            // Chuỗi truy vấn SQL
            string strsql = $@"
                SELECT 
                    mamh AS [Mã Môn Học], 
                    tenmh AS [Tên Môn Học], 
                    sotiet AS [Số Tiết], 
                    tengv AS [Tên Giáo Viên]
                FROM 
                    monhoc 
                JOIN 
                    giaovien ON monhoc.magv = giaovien.magv
                WHERE 
                    {filterColumn} LIKE @keyword";

            try
            {
                OpenConnection();
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(strsql, myconn);
                adapter.SelectCommand.Parameters.AddWithValue("@keyword", "%" + Tbx_tukhoa.Text.Trim() + "%");
                adapter.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    Dgv_timkiem.DataSource = ds.Tables[0];
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CloseConnection();
            }
        }

        private void Btn_nhaplai_Click(object sender, EventArgs e)
        {
            Tbx_tukhoa.Clear();
            Cbx_timtheo.SelectedIndex = -1;
            LoadData(); // Tải lại dữ liệu ban đầu
        }

        private void Btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
