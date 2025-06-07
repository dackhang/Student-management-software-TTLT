namespace QuanLySinhVien
{
    partial class cn_chinhsach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cn_chinhsach));
            this.Dgv_chinhsach = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_chedo = new System.Windows.Forms.TextBox();
            this.Btn_dong = new System.Windows.Forms.Button();
            this.Btn_nhaplai = new System.Windows.Forms.Button();
            this.Btn_xoa = new System.Windows.Forms.Button();
            this.Btn_sua = new System.Windows.Forms.Button();
            this.Btn_them = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Tbx_tencs = new System.Windows.Forms.TextBox();
            this.Tbx_macs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_chinhsach)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dgv_chinhsach
            // 
            this.Dgv_chinhsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_chinhsach.Location = new System.Drawing.Point(552, 108);
            this.Dgv_chinhsach.Name = "Dgv_chinhsach";
            this.Dgv_chinhsach.RowHeadersWidth = 51;
            this.Dgv_chinhsach.RowTemplate.Height = 24;
            this.Dgv_chinhsach.Size = new System.Drawing.Size(407, 333);
            this.Dgv_chinhsach.TabIndex = 13;
            this.Dgv_chinhsach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_chinhsach_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_chedo);
            this.groupBox1.Controls.Add(this.Btn_dong);
            this.groupBox1.Controls.Add(this.Btn_nhaplai);
            this.groupBox1.Controls.Add(this.Btn_xoa);
            this.groupBox1.Controls.Add(this.Btn_sua);
            this.groupBox1.Controls.Add(this.Btn_them);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Tbx_tencs);
            this.groupBox1.Controls.Add(this.Tbx_macs);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(508, 342);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Chính Sách";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Chế Độ";
            // 
            // txt_chedo
            // 
            this.txt_chedo.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_chedo.Location = new System.Drawing.Point(178, 140);
            this.txt_chedo.Name = "txt_chedo";
            this.txt_chedo.Size = new System.Drawing.Size(321, 27);
            this.txt_chedo.TabIndex = 9;
            // 
            // Btn_dong
            // 
            this.Btn_dong.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_dong.Location = new System.Drawing.Point(337, 284);
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
            this.Btn_nhaplai.Location = new System.Drawing.Point(186, 284);
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
            this.Btn_xoa.Location = new System.Drawing.Point(376, 223);
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
            this.Btn_sua.Location = new System.Drawing.Point(259, 223);
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
            this.Btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_them.Location = new System.Drawing.Point(145, 223);
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
            this.label3.Location = new System.Drawing.Point(10, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên Chính Sách";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Chính Sách";
            // 
            // Tbx_tencs
            // 
            this.Tbx_tencs.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_tencs.Location = new System.Drawing.Point(178, 93);
            this.Tbx_tencs.Name = "Tbx_tencs";
            this.Tbx_tencs.Size = new System.Drawing.Size(321, 27);
            this.Tbx_tencs.TabIndex = 1;
            // 
            // Tbx_macs
            // 
            this.Tbx_macs.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_macs.Location = new System.Drawing.Point(178, 49);
            this.Tbx_macs.Name = "Tbx_macs";
            this.Tbx_macs.Size = new System.Drawing.Size(321, 27);
            this.Tbx_macs.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(25, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(934, 65);
            this.label1.TabIndex = 11;
            this.label1.Text = "Chính Sách";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cn_chinhsach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLySinhVien.Properties.Resources.lennart_butz_japan_12;
            this.ClientSize = new System.Drawing.Size(971, 465);
            this.Controls.Add(this.Dgv_chinhsach);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cn_chinhsach";
            this.Text = "Cập Nhật Chính Sách";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_chinhsach)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_chinhsach;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_dong;
        private System.Windows.Forms.Button Btn_nhaplai;
        private System.Windows.Forms.Button Btn_xoa;
        private System.Windows.Forms.Button Btn_sua;
        private System.Windows.Forms.Button Btn_them;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tbx_tencs;
        private System.Windows.Forms.TextBox Tbx_macs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_chedo;
    }
}