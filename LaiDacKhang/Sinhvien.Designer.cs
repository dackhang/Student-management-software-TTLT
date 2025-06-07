namespace QuanLySinhVien
{
    partial class Sinhvien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sinhvien));
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Tbx_tensv = new System.Windows.Forms.TextBox();
            this.Tbx_masv = new System.Windows.Forms.TextBox();
            this.Btn_dong = new System.Windows.Forms.Button();
            this.Btn_in = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_sinhvien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dgv_sinhvien
            // 
            this.Dgv_sinhvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_sinhvien.Location = new System.Drawing.Point(29, 116);
            this.Dgv_sinhvien.Name = "Dgv_sinhvien";
            this.Dgv_sinhvien.RowHeadersWidth = 51;
            this.Dgv_sinhvien.RowTemplate.Height = 24;
            this.Dgv_sinhvien.Size = new System.Drawing.Size(471, 504);
            this.Dgv_sinhvien.TabIndex = 26;
            this.Dgv_sinhvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_sinhvien_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
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
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Tbx_tensv);
            this.groupBox1.Controls.Add(this.Tbx_masv);
            this.groupBox1.Controls.Add(this.Btn_dong);
            this.groupBox1.Controls.Add(this.Btn_in);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(524, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 504);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sinh Viên";
            // 
            // rb_nu
            // 
            this.rb_nu.AutoSize = true;
            this.rb_nu.Location = new System.Drawing.Point(396, 143);
            this.rb_nu.Name = "rb_nu";
            this.rb_nu.Size = new System.Drawing.Size(48, 21);
            this.rb_nu.TabIndex = 39;
            this.rb_nu.TabStop = true;
            this.rb_nu.Text = "Nữ";
            this.rb_nu.UseVisualStyleBackColor = true;
            // 
            // rb_nam
            // 
            this.rb_nam.AutoSize = true;
            this.rb_nam.Location = new System.Drawing.Point(254, 143);
            this.rb_nam.Name = "rb_nam";
            this.rb_nam.Size = new System.Drawing.Size(58, 21);
            this.rb_nam.TabIndex = 38;
            this.rb_nam.TabStop = true;
            this.rb_nam.Text = "Nam";
            this.rb_nam.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(23, 369);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 23);
            this.label9.TabIndex = 37;
            this.label9.Text = "Mã Lớp";
            // 
            // Tbx_malop
            // 
            this.Tbx_malop.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_malop.Location = new System.Drawing.Point(191, 365);
            this.Tbx_malop.Name = "Tbx_malop";
            this.Tbx_malop.Size = new System.Drawing.Size(321, 27);
            this.Tbx_malop.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 325);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 23);
            this.label8.TabIndex = 35;
            this.label8.Text = "Mã Chính Sách";
            // 
            // Tbx_macs
            // 
            this.Tbx_macs.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_macs.Location = new System.Drawing.Point(191, 321);
            this.Tbx_macs.Name = "Tbx_macs";
            this.Tbx_macs.Size = new System.Drawing.Size(321, 27);
            this.Tbx_macs.TabIndex = 34;
            // 
            // Tbx_sdt
            // 
            this.Tbx_sdt.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_sdt.Location = new System.Drawing.Point(191, 231);
            this.Tbx_sdt.Name = "Tbx_sdt";
            this.Tbx_sdt.Size = new System.Drawing.Size(321, 27);
            this.Tbx_sdt.TabIndex = 32;
            // 
            // Tbx_ngaysinh
            // 
            this.Tbx_ngaysinh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_ngaysinh.Location = new System.Drawing.Point(191, 184);
            this.Tbx_ngaysinh.Name = "Tbx_ngaysinh";
            this.Tbx_ngaysinh.Size = new System.Drawing.Size(321, 27);
            this.Tbx_ngaysinh.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 23);
            this.label5.TabIndex = 30;
            this.label5.Text = "Địa Chỉ";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 23);
            this.label6.TabIndex = 29;
            this.label6.Text = "Số Điện Thoại";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 23);
            this.label7.TabIndex = 28;
            this.label7.Text = "Ngày Sinh";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 23);
            this.label4.TabIndex = 27;
            this.label4.Text = "Giới Tính";
            // 
            // Tbx_diachi
            // 
            this.Tbx_diachi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_diachi.Location = new System.Drawing.Point(191, 275);
            this.Tbx_diachi.Name = "Tbx_diachi";
            this.Tbx_diachi.Size = new System.Drawing.Size(321, 27);
            this.Tbx_diachi.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 23);
            this.label3.TabIndex = 25;
            this.label3.Text = "Tên Sinh Viên";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 23);
            this.label2.TabIndex = 24;
            this.label2.Text = "Mã Sinh Viên";
            // 
            // Tbx_tensv
            // 
            this.Tbx_tensv.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_tensv.Location = new System.Drawing.Point(191, 90);
            this.Tbx_tensv.Name = "Tbx_tensv";
            this.Tbx_tensv.Size = new System.Drawing.Size(321, 27);
            this.Tbx_tensv.TabIndex = 23;
            // 
            // Tbx_masv
            // 
            this.Tbx_masv.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_masv.Location = new System.Drawing.Point(191, 46);
            this.Tbx_masv.Name = "Tbx_masv";
            this.Tbx_masv.Size = new System.Drawing.Size(321, 27);
            this.Tbx_masv.TabIndex = 22;
            // 
            // Btn_dong
            // 
            this.Btn_dong.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_dong.Location = new System.Drawing.Point(328, 429);
            this.Btn_dong.Name = "Btn_dong";
            this.Btn_dong.Size = new System.Drawing.Size(91, 33);
            this.Btn_dong.TabIndex = 17;
            this.Btn_dong.Text = "Đóng";
            this.Btn_dong.UseVisualStyleBackColor = true;
            this.Btn_dong.Click += new System.EventHandler(this.Btn_dong_Click);
            // 
            // Btn_in
            // 
            this.Btn_in.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_in.Location = new System.Drawing.Point(162, 429);
            this.Btn_in.Name = "Btn_in";
            this.Btn_in.Size = new System.Drawing.Size(89, 33);
            this.Btn_in.TabIndex = 15;
            this.Btn_in.Text = "In";
            this.Btn_in.UseVisualStyleBackColor = true;
            this.Btn_in.Click += new System.EventHandler(this.Btn_in_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(29, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1046, 65);
            this.label1.TabIndex = 24;
            this.label1.Text = "Sinh Viên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Sinhvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1106, 641);
            this.Controls.Add(this.Dgv_sinhvien);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sinhvien";
            this.Text = "Báo Cáo Sinh Viên";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_sinhvien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_sinhvien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_dong;
        private System.Windows.Forms.Button Btn_in;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tbx_tensv;
        private System.Windows.Forms.TextBox Tbx_masv;
        private System.Windows.Forms.RadioButton rb_nu;
        private System.Windows.Forms.RadioButton rb_nam;
    }
}