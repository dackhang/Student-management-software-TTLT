namespace QuanLySinhVien
{
    partial class monhoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(monhoc));
            this.Dgv_monhoc = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Btn_in = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Tbx_magv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Tbx_sotiet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Tbx_tenmh = new System.Windows.Forms.TextBox();
            this.Tbx_mamh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_monhoc)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dgv_monhoc
            // 
            this.Dgv_monhoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_monhoc.Location = new System.Drawing.Point(544, 89);
            this.Dgv_monhoc.Name = "Dgv_monhoc";
            this.Dgv_monhoc.RowHeadersWidth = 51;
            this.Dgv_monhoc.RowTemplate.Height = 24;
            this.Dgv_monhoc.Size = new System.Drawing.Size(580, 417);
            this.Dgv_monhoc.TabIndex = 25;
            this.Dgv_monhoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_monhoc_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.Btn_in);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Tbx_magv);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Tbx_sotiet);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Tbx_tenmh);
            this.groupBox1.Controls.Add(this.Tbx_mamh);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(521, 417);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Môn Học";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(309, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 33);
            this.button1.TabIndex = 23;
            this.button1.Text = "Đóng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_in
            // 
            this.Btn_in.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_in.Location = new System.Drawing.Point(143, 297);
            this.Btn_in.Name = "Btn_in";
            this.Btn_in.Size = new System.Drawing.Size(89, 33);
            this.Btn_in.TabIndex = 22;
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
            this.label5.Text = "Mã Giáo Viên";
            // 
            // Tbx_magv
            // 
            this.Tbx_magv.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_magv.Location = new System.Drawing.Point(181, 195);
            this.Tbx_magv.Name = "Tbx_magv";
            this.Tbx_magv.Size = new System.Drawing.Size(321, 27);
            this.Tbx_magv.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Số Tiết";
            // 
            // Tbx_sotiet
            // 
            this.Tbx_sotiet.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_sotiet.Location = new System.Drawing.Point(181, 150);
            this.Tbx_sotiet.Name = "Tbx_sotiet";
            this.Tbx_sotiet.Size = new System.Drawing.Size(321, 27);
            this.Tbx_sotiet.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên Môn Học";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Môn Học";
            // 
            // Tbx_tenmh
            // 
            this.Tbx_tenmh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_tenmh.Location = new System.Drawing.Point(181, 103);
            this.Tbx_tenmh.Name = "Tbx_tenmh";
            this.Tbx_tenmh.Size = new System.Drawing.Size(321, 27);
            this.Tbx_tenmh.TabIndex = 1;
            // 
            // Tbx_mamh
            // 
            this.Tbx_mamh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_mamh.Location = new System.Drawing.Point(181, 59);
            this.Tbx_mamh.Name = "Tbx_mamh";
            this.Tbx_mamh.Size = new System.Drawing.Size(321, 27);
            this.Tbx_mamh.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1107, 65);
            this.label1.TabIndex = 23;
            this.label1.Text = "Môn Học";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // monhoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 515);
            this.Controls.Add(this.Dgv_monhoc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "monhoc";
            this.Text = "Báo Cáo Môn Học";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_monhoc)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_monhoc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Tbx_magv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Tbx_sotiet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tbx_tenmh;
        private System.Windows.Forms.TextBox Tbx_mamh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Btn_in;
    }
}