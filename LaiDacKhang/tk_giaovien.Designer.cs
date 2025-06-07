namespace QuanLySinhVien
{
    partial class tk_giaovien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tk_giaovien));
            this.Dgv_timkiem = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_nhaplai = new System.Windows.Forms.Button();
            this.Btn_dong = new System.Windows.Forms.Button();
            this.Btn_tim = new System.Windows.Forms.Button();
            this.Cbx_timtheo = new System.Windows.Forms.ComboBox();
            this.Tbx_tukhoa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_timkiem)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dgv_timkiem
            // 
            this.Dgv_timkiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_timkiem.Location = new System.Drawing.Point(580, 119);
            this.Dgv_timkiem.Name = "Dgv_timkiem";
            this.Dgv_timkiem.RowHeadersWidth = 51;
            this.Dgv_timkiem.RowTemplate.Height = 24;
            this.Dgv_timkiem.Size = new System.Drawing.Size(592, 370);
            this.Dgv_timkiem.TabIndex = 30;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.Btn_nhaplai);
            this.groupBox1.Controls.Add(this.Btn_dong);
            this.groupBox1.Controls.Add(this.Btn_tim);
            this.groupBox1.Controls.Add(this.Cbx_timtheo);
            this.groupBox1.Controls.Add(this.Tbx_tukhoa);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(547, 370);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Tìm Kiếm";
            // 
            // Btn_nhaplai
            // 
            this.Btn_nhaplai.Location = new System.Drawing.Point(229, 248);
            this.Btn_nhaplai.Name = "Btn_nhaplai";
            this.Btn_nhaplai.Size = new System.Drawing.Size(96, 41);
            this.Btn_nhaplai.TabIndex = 6;
            this.Btn_nhaplai.Text = "Load Lại";
            this.Btn_nhaplai.UseVisualStyleBackColor = true;
            this.Btn_nhaplai.Click += new System.EventHandler(this.Btn_nhaplai_Click);
            // 
            // Btn_dong
            // 
            this.Btn_dong.Location = new System.Drawing.Point(366, 248);
            this.Btn_dong.Name = "Btn_dong";
            this.Btn_dong.Size = new System.Drawing.Size(96, 41);
            this.Btn_dong.TabIndex = 5;
            this.Btn_dong.Text = "Đóng";
            this.Btn_dong.UseVisualStyleBackColor = true;
            this.Btn_dong.Click += new System.EventHandler(this.Btn_dong_Click);
            // 
            // Btn_tim
            // 
            this.Btn_tim.Location = new System.Drawing.Point(86, 248);
            this.Btn_tim.Name = "Btn_tim";
            this.Btn_tim.Size = new System.Drawing.Size(96, 41);
            this.Btn_tim.TabIndex = 4;
            this.Btn_tim.Text = "Tìm";
            this.Btn_tim.UseVisualStyleBackColor = true;
            this.Btn_tim.Click += new System.EventHandler(this.Btn_tim_Click);
            // 
            // Cbx_timtheo
            // 
            this.Cbx_timtheo.FormattingEnabled = true;
            this.Cbx_timtheo.Items.AddRange(new object[] {
            "Địa Chỉ",
            "Tên Giáo Viên"});
            this.Cbx_timtheo.Location = new System.Drawing.Point(173, 139);
            this.Cbx_timtheo.Name = "Cbx_timtheo";
            this.Cbx_timtheo.Size = new System.Drawing.Size(314, 27);
            this.Cbx_timtheo.TabIndex = 3;
            // 
            // Tbx_tukhoa
            // 
            this.Tbx_tukhoa.Location = new System.Drawing.Point(173, 59);
            this.Tbx_tukhoa.Name = "Tbx_tukhoa";
            this.Tbx_tukhoa.Size = new System.Drawing.Size(314, 27);
            this.Tbx_tukhoa.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(35, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tìm Theo";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(35, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Từ Khóa";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(8, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1164, 70);
            this.label1.TabIndex = 28;
            this.label1.Text = "Giáo Viên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tk_giaovien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLySinhVien.Properties.Resources.lennart_butz_japan_12;
            this.ClientSize = new System.Drawing.Size(1180, 507);
            this.Controls.Add(this.Dgv_timkiem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "tk_giaovien";
            this.Text = "Tìm Kiếm Giáo Viên";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_timkiem)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_timkiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_nhaplai;
        private System.Windows.Forms.Button Btn_dong;
        private System.Windows.Forms.Button Btn_tim;
        private System.Windows.Forms.ComboBox Cbx_timtheo;
        private System.Windows.Forms.TextBox Tbx_tukhoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}