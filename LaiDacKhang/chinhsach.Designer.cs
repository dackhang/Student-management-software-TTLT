namespace QuanLySinhVien
{
    partial class chinhsach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(chinhsach));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Tbx_chedo = new System.Windows.Forms.TextBox();
            this.Btn_xoa = new System.Windows.Forms.Button();
            this.Btn_in = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Tbx_tencs = new System.Windows.Forms.TextBox();
            this.Tbx_macs = new System.Windows.Forms.TextBox();
            this.Dgv_chinhsach = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_chinhsach)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1046, 65);
            this.label1.TabIndex = 21;
            this.label1.Text = "Chính Sách";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Tbx_chedo);
            this.groupBox1.Controls.Add(this.Btn_xoa);
            this.groupBox1.Controls.Add(this.Btn_in);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Tbx_tencs);
            this.groupBox1.Controls.Add(this.Tbx_macs);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(507, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 265);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Báo Cáo Chính Sách";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 23);
            this.label4.TabIndex = 21;
            this.label4.Text = "Chế Độ";
            // 
            // Tbx_chedo
            // 
            this.Tbx_chedo.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_chedo.Location = new System.Drawing.Point(201, 138);
            this.Tbx_chedo.Name = "Tbx_chedo";
            this.Tbx_chedo.Size = new System.Drawing.Size(321, 27);
            this.Tbx_chedo.TabIndex = 20;
            // 
            // Btn_xoa
            // 
            this.Btn_xoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_xoa.Location = new System.Drawing.Point(324, 186);
            this.Btn_xoa.Name = "Btn_xoa";
            this.Btn_xoa.Size = new System.Drawing.Size(91, 33);
            this.Btn_xoa.TabIndex = 17;
            this.Btn_xoa.Text = "Đóng";
            this.Btn_xoa.UseVisualStyleBackColor = true;
            this.Btn_xoa.Click += new System.EventHandler(this.Btn_xoa_Click);
            // 
            // Btn_in
            // 
            this.Btn_in.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_in.Location = new System.Drawing.Point(158, 186);
            this.Btn_in.Name = "Btn_in";
            this.Btn_in.Size = new System.Drawing.Size(89, 33);
            this.Btn_in.TabIndex = 15;
            this.Btn_in.Text = "In";
            this.Btn_in.UseVisualStyleBackColor = true;
            this.Btn_in.Click += new System.EventHandler(this.Btn_in_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tên Chính Sách";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mã Chính Sách";
            // 
            // Tbx_tencs
            // 
            this.Tbx_tencs.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_tencs.Location = new System.Drawing.Point(201, 91);
            this.Tbx_tencs.Name = "Tbx_tencs";
            this.Tbx_tencs.Size = new System.Drawing.Size(321, 27);
            this.Tbx_tencs.TabIndex = 12;
            // 
            // Tbx_macs
            // 
            this.Tbx_macs.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_macs.Location = new System.Drawing.Point(201, 47);
            this.Tbx_macs.Name = "Tbx_macs";
            this.Tbx_macs.Size = new System.Drawing.Size(321, 27);
            this.Tbx_macs.TabIndex = 11;
            // 
            // Dgv_chinhsach
            // 
            this.Dgv_chinhsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_chinhsach.Location = new System.Drawing.Point(12, 90);
            this.Dgv_chinhsach.Name = "Dgv_chinhsach";
            this.Dgv_chinhsach.RowHeadersWidth = 51;
            this.Dgv_chinhsach.RowTemplate.Height = 24;
            this.Dgv_chinhsach.Size = new System.Drawing.Size(471, 258);
            this.Dgv_chinhsach.TabIndex = 23;
            this.Dgv_chinhsach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_chinhsach_CellClick);
            // 
            // chinhsach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLySinhVien.Properties.Resources.lennart_butz_japan_12;
            this.ClientSize = new System.Drawing.Size(1070, 368);
            this.Controls.Add(this.Dgv_chinhsach);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "chinhsach";
            this.Text = "Báo Cáo Chính Sách";
            this.Load += new System.EventHandler(this.chinhsach_Load);
            this.Click += new System.EventHandler(this.chinhsach_Click);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_chinhsach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView Dgv_chinhsach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Tbx_chedo;
        private System.Windows.Forms.Button Btn_xoa;
        private System.Windows.Forms.Button Btn_in;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tbx_tencs;
        private System.Windows.Forms.TextBox Tbx_macs;
    }
}