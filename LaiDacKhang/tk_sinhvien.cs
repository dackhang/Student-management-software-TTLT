using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class tk_sinhvien : Form
    {
        private SqlConnection myconn;

        public tk_sinhvien()
        {
            InitializeComponent();
            myconn = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Application.StartupPath}\\qlsv.mdf;Integrated Security=True;Connect Timeout=30");
            LoadData(); // Tải dữ liệu ban đầu
        }

        private void tk_sinhvien_Load(object sender, EventArgs e)
        {
            // Thêm tùy chọn vào ComboBox
            Cbx_timtheo.Items.Add("Tên Sinh Viên");
            Cbx_timtheo.Items.Add("Giới Tính");
            Cbx_timtheo.Items.Add("Địa Chỉ");
            Cbx_timtheo.Items.Add("Mã Lớp");
            Cbx_timtheo.Items.Add("Mã Chính Sách");

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
                    masv AS [Mã Sinh Viên], 
                    tensv AS [Tên Sinh Viên], 
                    gioitinh AS [Giới Tính], 
                    ngaysinh AS [Ngày Sinh], 
                    sdt AS [Số Điện Thoại], 
                    diachi AS [Địa Chỉ], 
                    macs AS [Mã Chính Sách], 
                    malop AS [Mã Lớp]
                FROM 
                    sinhvien";

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
            if (Cbx_timtheo.SelectedItem.ToString() == "Tên Sinh Viên")
            {
                filterColumn = "tensv";
            }
            else if (Cbx_timtheo.SelectedItem.ToString() == "Giới Tính")
            {
                filterColumn = "gioitinh";
            }
            else if (Cbx_timtheo.SelectedItem.ToString() == "Địa Chỉ")
            {
                filterColumn = "diachi";
            }
            else if (Cbx_timtheo.SelectedItem.ToString() == "Mã Lớp")
            {
                filterColumn = "malop";
            }
            else if (Cbx_timtheo.SelectedItem.ToString() == "Mã Chính Sách")
            {
                filterColumn = "macs";
            }

            // Chuỗi truy vấn SQL
            string strsql = $@"
                SELECT 
                    masv AS [Mã Sinh Viên], 
                    tensv AS [Tên Sinh Viên], 
                    gioitinh AS [Giới Tính], 
                    ngaysinh AS [Ngày Sinh], 
                    sdt AS [Số Điện Thoại], 
                    diachi AS [Địa Chỉ], 
                    macs AS [Mã Chính Sách], 
                    malop AS [Mã Lớp]
                FROM 
                    sinhvien
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
