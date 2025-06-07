namespace QuanLySinhVien
{
    partial class cn_sinhvien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cn_sinhvien));
            this.Dgv_sinhvien = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_nu = new System.Windows.Forms.RadioButton();
            this.rb_nam = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.Tbx_malop = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Tbx_macs = new System.Windows.Forms.TextBox();
            this.Tbx_sdt = new System.Windows.Forms.TextBox();
            this.Tbx_ngaysinh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Tbx_diachi = new System.Windows.Forms.TextBox();
            this.Btn_dong = new System.Windows.Forms.Button();
            this.Btn_nhaplai = new System.Windows.Forms.Button();
            this.Btn_xoa = new System.Windows.Forms.Button();
            this.Btn_sua = new System.Windows.Forms.Button();
            this.Btn_them = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Tbx_tensv = new System.Windows.Forms.TextBox();
            this.Tbx_masv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_sinhvien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dgv_sinhvien
            // 
            this.Dgv_sinhvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_sinhvien.Location = new System.Drawing.Point(692, 105);
            this.Dgv_sinhvien.Name = "Dgv_sinhvien";
            this.Dgv_sinhvien.RowHeadersWidth = 51;
            this.Dgv_sinhvien.RowTemplate.Height = 24;
            this.Dgv_sinhvien.Size = new System.Drawing.Size(565, 569);
            this.Dgv_sinhvien.TabIndex = 22;
            this.Dgv_sinhvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_sinhvien_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rb_nu);
            this.groupBox1.Controls.Add(this.rb_nam);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.Tbx_malop);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.Tbx_macs);
            this.groupBox1.Controls.Add(this.Tbx_sdt);
            this.groupBox1.Controls.Add(this.Tbx_ngaysinh);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Tbx_diachi);
            this.groupBox1.Controls.Add(this.Btn_dong);
            this.groupBox1.Controls.Add(this.Btn_nhaplai);
            this.groupBox1.Controls.Add(this.Btn_xoa);
            this.groupBox1.Controls.Add(this.Btn_sua);
            this.groupBox1.Controls.Add(this.Btn_them);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Tbx_tensv);
            this.groupBox1.Controls.Add(this.Tbx_masv);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(648, 569);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sinh Viên";
            // 
            // rb_nu
            // 
            this.rb_nu.AutoSize = true;
            this.rb_nu.Location = new System.Drawing.Point(427, 150);
            this.rb_nu.Name = "rb_nu";
            this.rb_nu.Size = new System.Drawing.Size(48, 21);
            this.rb_nu.TabIndex = 23;
            this.rb_nu.TabStop = true;
            this.rb_nu.Text = "Nữ";
            this.rb_nu.UseVisualStyleBackColor = true;
            // 
            // rb_nam
            // 
            this.rb_nam.AutoSize = true;
            this.rb_nam.Location = new System.Drawing.Point(285, 150);
            this.rb_nam.Name = "rb_nam";
            this.rb_nam.Size = new System.Drawing.Size(58, 21);
            this.rb_nam.TabIndex = 22;
            this.rb_nam.TabStop = true;
            this.rb_nam.Text = "Nam";
            this.rb_nam.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(68, 376);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 23);
            this.label9.TabIndex = 21;
            this.label9.Text = "Mã Lớp";
            // 
            // Tbx_malop
            // 
            this.Tbx_malop.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_malop.Location = new System.Drawing.Point(236, 372);
            this.Tbx_malop.Name = "Tbx_malop";
            this.Tbx_malop.Size = new System.Drawing.Size(321, 27);
            this.Tbx_malop.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(68, 332);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 23);
            this.label8.TabIndex = 19;
            this.label8.Text = "Mã Chính Sách";
            // 
            // Tbx_macs
            // 
            this.Tbx_macs.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_macs.Location = new System.Drawing.Point(236, 328);
            this.Tbx_macs.Name = "Tbx_macs";
            this.Tbx_macs.Size = new System.Drawing.Size(321, 27);
            this.Tbx_macs.TabIndex = 18;
            // 
            // Tbx_sdt
            // 
            this.Tbx_sdt.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_sdt.Location = new System.Drawing.Point(236, 238);
            this.Tbx_sdt.Name = "Tbx_sdt";
            this.Tbx_sdt.Size = new System.Drawing.Size(321, 27);
            this.Tbx_sdt.TabIndex = 15;
            // 
            // Tbx_ngaysinh
            // 
            this.Tbx_ngaysinh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_ngaysinh.Location = new System.Drawing.Point(236, 191);
            this.Tbx_ngaysinh.Name = "Tbx_ngaysinh";
            this.Tbx_ngaysinh.Size = new System.Drawing.Size(321, 27);
            this.Tbx_ngaysinh.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(68, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "Địa Chỉ";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(68, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Số Điện Thoại";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(68, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 23);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ngày Sinh";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(68, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Giới Tính";
            // 
            // Tbx_diachi
            // 
            this.Tbx_diachi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_diachi.Location = new System.Drawing.Point(236, 282);
            this.Tbx_diachi.Name = "Tbx_diachi";
            this.Tbx_diachi.Size = new System.Drawing.Size(321, 27);
            this.Tbx_diachi.TabIndex = 9;
            // 
            // Btn_dong
            // 
            this.Btn_dong.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_dong.Location = new System.Drawing.Point(343, 505);
            this.Btn_dong.Name = "Btn_dong";
            this.Btn_dong.Size = new System.Drawing.Size(95, 33);
            this.Btn_dong.TabIndex = 8;
            this.Btn_dong.Text = "Đóng";
            this.Btn_dong.UseVisualStyleBackColor = true;
            this.Btn_dong.Click += new System.EventHandler(this.Btn_dong_Click);
            // 
            // Btn_nhaplai
            // 
            this.Btn_nhaplai.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_nhaplai.Location = new System.Drawing.Point(192, 505);
            this.Btn_nhaplai.Name = "Btn_nhaplai";
            this.Btn_nhaplai.Size = new System.Drawing.Size(105, 33);
            this.Btn_nhaplai.TabIndex = 7;
            this.Btn_nhaplai.Text = "Nhập Lại";
            this.Btn_nhaplai.UseVisualStyleBackColor = true;
            this.Btn_nhaplai.Click += new System.EventHandler(this.Btn_nhaplai_Click);
            // 
            // Btn_xoa
            // 
            this.Btn_xoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_xoa.Location = new System.Drawing.Point(382, 444);
            this.Btn_xoa.Name = "Btn_xoa";
            this.Btn_xoa.Size = new System.Drawing.Size(91, 33);
            this.Btn_xoa.TabIndex = 6;
            this.Btn_xoa.Text = "Xóa";
            this.Btn_xoa.UseVisualStyleBackColor = true;
            this.Btn_xoa.Click += new System.EventHandler(this.Btn_xoa_Click);
            // 
            // Btn_sua
            // 
            this.Btn_sua.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_sua.Location = new System.Drawing.Point(265, 444);
            this.Btn_sua.Name = "Btn_sua";
            this.Btn_sua.Size = new System.Drawing.Size(90, 33);
            this.Btn_sua.TabIndex = 5;
            this.Btn_sua.Text = "Sửa";
            this.Btn_sua.UseVisualStyleBackColor = true;
            this.Btn_sua.Click += new System.EventHandler(this.Btn_sua_Click);
            // 
            // Btn_them
            // 
            this.Btn_them.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_them.Location = new System.Drawing.Point(151, 444);
            this.Btn_them.Name = "Btn_them";
            this.Btn_them.Size = new System.Drawing.Size(89, 33);
            this.Btn_them.TabIndex = 4;
            this.Btn_them.Text = "Thêm";
            this.Btn_them.UseVisualStyleBackColor = true;
            this.Btn_them.Click += new System.EventHandler(this.Btn_them_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên Sinh Viên";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Sinh Viên";
            // 
            // Tbx_tensv
            // 
            this.Tbx_tensv.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_tensv.Location = new System.Drawing.Point(236, 97);
            this.Tbx_tensv.Name = "Tbx_tensv";
            this.Tbx_tensv.Size = new System.Drawing.Size(321, 27);
            this.Tbx_tensv.TabIndex = 1;
            // 
            // Tbx_masv
            // 
            this.Tbx_masv.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_masv.Location = new System.Drawing.Point(236, 53);
            this.Tbx_masv.Name = "Tbx_masv";
            this.Tbx_masv.Size = new System.Drawing.Size(321, 27);
            this.Tbx_masv.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1237, 65);
            this.label1.TabIndex = 20;
            this.label1.Text = "Sinh Viên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cn_sinhvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLySinhVien.Properties.Resources.lennart_butz_japan_12;
            this.ClientSize = new System.Drawing.Size(1269, 686);
            this.Controls.Add(this.Dgv_sinhvien);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cn_sinhvien";
            this.Text = "Cập Nhật Sinh Viên";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_sinhvien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_sinhvien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Tbx_malop;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Tbx_macs;
        private System.Windows.Forms.TextBox Tbx_sdt;
        private System.Windows.Forms.TextBox Tbx_ngaysinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Tbx_diachi;
        private System.Windows.Forms.Button Btn_dong;
        private System.Windows.Forms.Button Btn_nhaplai;
        private System.Windows.Forms.Button Btn_xoa;
        private System.Windows.Forms.Button Btn_sua;
        private System.Windows.Forms.Button Btn_them;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tbx_tensv;
        private System.Windows.Forms.TextBox Tbx_masv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rb_nu;
        private System.Windows.Forms.RadioButton rb_nam;
    }
}