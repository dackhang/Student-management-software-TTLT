namespace QuanLySinhVien
{
    partial class diem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(diem));
            this.Dgv_diem = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Btn_in = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Tbx_diem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Tbx_mamh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Tbx_masv = new System.Windows.Forms.TextBox();
            this.Tbx_maid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_diem)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dgv_diem
            // 
            this.Dgv_diem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_diem.Location = new System.Drawing.Point(551, 100);
            this.Dgv_diem.Name = "Dgv_diem";
            this.Dgv_diem.RowHeadersWidth = 51;
            this.Dgv_diem.RowTemplate.Height = 24;
            this.Dgv_diem.Size = new System.Drawing.Size(580, 417);
            this.Dgv_diem.TabIndex = 19;
            this.Dgv_diem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_diem_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.Btn_in);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Tbx_diem);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Tbx_mamh);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Tbx_masv);
            this.groupBox1.Controls.Add(this.Tbx_maid);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 417);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Điểm";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(294, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 33);
            this.button1.TabIndex = 25;
            this.button1.Text = "Đóng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_in
            // 
            this.Btn_in.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_in.Location = new System.Drawing.Point(128, 310);
            this.Btn_in.Name = "Btn_in";
            this.Btn_in.Size = new System.Drawing.Size(89, 33);
            this.Btn_in.TabIndex = 24;
            this.Btn_in.Text = "In";
            this.Btn_in.UseVisualStyleBackColor = true;
            this.Btn_in.Click += new System.EventHandler(this.Btn_in_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Điểm";
            // 
            // Tbx_diem
            // 
            this.Tbx_diem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_diem.Location = new System.Drawing.Point(181, 195);
            this.Tbx_diem.Name = "Tbx_diem";
            this.Tbx_diem.Size = new System.Drawing.Size(321, 27);
            this.Tbx_diem.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mã Môn Học";
            // 
            // Tbx_mamh
            // 
            this.Tbx_mamh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_mamh.Location = new System.Drawing.Point(181, 150);
            this.Tbx_mamh.Name = "Tbx_mamh";
            this.Tbx_mamh.Size = new System.Drawing.Size(321, 27);
            this.Tbx_mamh.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã Sinh Viên";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã ID";
            // 
            // Tbx_masv
            // 
            this.Tbx_masv.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_masv.Location = new System.Drawing.Point(181, 103);
            this.Tbx_masv.Name = "Tbx_masv";
            this.Tbx_masv.Size = new System.Drawing.Size(321, 27);
            this.Tbx_masv.TabIndex = 1;
            // 
            // Tbx_maid
            // 
            this.Tbx_maid.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_maid.Location = new System.Drawing.Point(181, 59);
            this.Tbx_maid.Name = "Tbx_maid";
            this.Tbx_maid.Size = new System.Drawing.Size(321, 27);
            this.Tbx_maid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(24, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1107, 65);
            this.label1.TabIndex = 17;
            this.label1.Text = "Điểm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // diem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLySinhVien.Properties.Resources.lennart_butz_japan_12;
            this.ClientSize = new System.Drawing.Size(1153, 541);
            this.Controls.Add(this.Dgv_diem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "diem";
            this.Text = "Báo Cáo Điểm";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_diem)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_diem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Tbx_diem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Tbx_mamh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tbx_masv;
        private System.Windows.Forms.TextBox Tbx_maid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Btn_in;
    }
}