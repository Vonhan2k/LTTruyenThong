
namespace BAI10_CLIENT_TCP_QL_CHUC_VU
{
    partial class frmThuoc
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.dgvThuoc = new System.Windows.Forms.DataGridView();
            this.btnTimThuoc = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTimThuoc = new System.Windows.Forms.TextBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnXoaThuoc = new System.Windows.Forms.Button();
            this.btnSuaThuoc = new System.Windows.Forms.Button();
            this.btnThemThuoc = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenThuoc = new System.Windows.Forms.TextBox();
            this.cmbDonVi = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dtNSX = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dtHSD = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtGiaTien = new System.Windows.Forms.TextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txtMaThuoc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuoc)).BeginInit();
            this.panel11.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRefresh.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnRefresh.Location = new System.Drawing.Point(1066, 115);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(110, 63);
            this.btnRefresh.TabIndex = 31;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số lượng:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtSoLuong);
            this.panel1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel1.Location = new System.Drawing.Point(99, 206);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 32);
            this.panel1.TabIndex = 22;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.txtSoLuong.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSoLuong.Location = new System.Drawing.Point(196, 3);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(54, 32);
            this.txtSoLuong.TabIndex = 1;
            // 
            // dgvThuoc
            // 
            this.dgvThuoc.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.dgvThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThuoc.Location = new System.Drawing.Point(519, 184);
            this.dgvThuoc.Name = "dgvThuoc";
            this.dgvThuoc.ReadOnly = true;
            this.dgvThuoc.RowHeadersWidth = 51;
            this.dgvThuoc.RowTemplate.Height = 24;
            this.dgvThuoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThuoc.Size = new System.Drawing.Size(705, 382);
            this.dgvThuoc.TabIndex = 30;
            this.dgvThuoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThuoc_CellContentClick);
            // 
            // btnTimThuoc
            // 
            this.btnTimThuoc.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTimThuoc.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimThuoc.Location = new System.Drawing.Point(926, 115);
            this.btnTimThuoc.Name = "btnTimThuoc";
            this.btnTimThuoc.Size = new System.Drawing.Size(110, 63);
            this.btnTimThuoc.TabIndex = 29;
            this.btnTimThuoc.Text = "Tìm";
            this.btnTimThuoc.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(3, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 25);
            this.label11.TabIndex = 0;
            this.label11.Text = "Tìm kiếm:";
            // 
            // txtTimThuoc
            // 
            this.txtTimThuoc.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.txtTimThuoc.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimThuoc.Location = new System.Drawing.Point(130, 3);
            this.txtTimThuoc.Name = "txtTimThuoc";
            this.txtTimThuoc.Size = new System.Drawing.Size(218, 32);
            this.txtTimThuoc.TabIndex = 1;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.label11);
            this.panel11.Controls.Add(this.txtTimThuoc);
            this.panel11.Location = new System.Drawing.Point(547, 133);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(364, 32);
            this.panel11.TabIndex = 28;
            // 
            // btnXoaThuoc
            // 
            this.btnXoaThuoc.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnXoaThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoaThuoc.ForeColor = System.Drawing.Color.Red;
            this.btnXoaThuoc.Location = new System.Drawing.Point(119, 480);
            this.btnXoaThuoc.Name = "btnXoaThuoc";
            this.btnXoaThuoc.Size = new System.Drawing.Size(110, 63);
            this.btnXoaThuoc.TabIndex = 27;
            this.btnXoaThuoc.Text = "Xóa";
            this.btnXoaThuoc.UseVisualStyleBackColor = false;
            // 
            // btnSuaThuoc
            // 
            this.btnSuaThuoc.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSuaThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSuaThuoc.Location = new System.Drawing.Point(304, 401);
            this.btnSuaThuoc.Name = "btnSuaThuoc";
            this.btnSuaThuoc.Size = new System.Drawing.Size(110, 63);
            this.btnSuaThuoc.TabIndex = 26;
            this.btnSuaThuoc.Text = "Sửa";
            this.btnSuaThuoc.UseVisualStyleBackColor = false;
            // 
            // btnThemThuoc
            // 
            this.btnThemThuoc.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnThemThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemThuoc.Location = new System.Drawing.Point(119, 401);
            this.btnThemThuoc.Name = "btnThemThuoc";
            this.btnThemThuoc.Size = new System.Drawing.Size(110, 63);
            this.btnThemThuoc.TabIndex = 25;
            this.btnThemThuoc.Text = "Thêm";
            this.btnThemThuoc.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên thuốc:";
            // 
            // txtTenThuoc
            // 
            this.txtTenThuoc.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.txtTenThuoc.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenThuoc.Location = new System.Drawing.Point(196, 3);
            this.txtTenThuoc.Name = "txtTenThuoc";
            this.txtTenThuoc.Size = new System.Drawing.Size(181, 32);
            this.txtTenThuoc.TabIndex = 1;
            // 
            // cmbDonVi
            // 
            this.cmbDonVi.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.cmbDonVi.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbDonVi.FormattingEnabled = true;
            this.cmbDonVi.Location = new System.Drawing.Point(196, 3);
            this.cmbDonVi.Name = "cmbDonVi";
            this.cmbDonVi.Size = new System.Drawing.Size(181, 33);
            this.cmbDonVi.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.txtTenThuoc);
            this.panel6.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel6.Location = new System.Drawing.Point(99, 130);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(380, 32);
            this.panel6.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Đơn vị:";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.cmbDonVi);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel7.Location = new System.Drawing.Point(99, 168);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(380, 32);
            this.panel7.TabIndex = 21;
            // 
            // dtNSX
            // 
            this.dtNSX.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtNSX.CustomFormat = "dd/MM/yyyy";
            this.dtNSX.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtNSX.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNSX.Location = new System.Drawing.Point(196, 0);
            this.dtNSX.Name = "dtNSX";
            this.dtNSX.Size = new System.Drawing.Size(181, 32);
            this.dtNSX.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ngày sản xuất:";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.dtNSX);
            this.panel8.Controls.Add(this.label8);
            this.panel8.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel8.Location = new System.Drawing.Point(99, 244);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(380, 32);
            this.panel8.TabIndex = 20;
            // 
            // dtHSD
            // 
            this.dtHSD.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtHSD.CustomFormat = "dd/MM/yyyy";
            this.dtHSD.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtHSD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtHSD.Location = new System.Drawing.Point(196, 6);
            this.dtHSD.Name = "dtHSD";
            this.dtHSD.Size = new System.Drawing.Size(181, 32);
            this.dtHSD.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(3, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(168, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Hạn sử dụng:";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.dtHSD);
            this.panel9.Controls.Add(this.label9);
            this.panel9.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel9.Location = new System.Drawing.Point(99, 283);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(380, 32);
            this.panel9.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(3, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "Giá tiền:";
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.txtGiaTien.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtGiaTien.Location = new System.Drawing.Point(196, 3);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(181, 32);
            this.txtGiaTien.TabIndex = 1;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.label10);
            this.panel10.Controls.Add(this.txtGiaTien);
            this.panel10.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel10.Location = new System.Drawing.Point(99, 321);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(380, 32);
            this.panel10.TabIndex = 24;
            // 
            // txtMaThuoc
            // 
            this.txtMaThuoc.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.txtMaThuoc.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaThuoc.Location = new System.Drawing.Point(196, 3);
            this.txtMaThuoc.Name = "txtMaThuoc";
            this.txtMaThuoc.Size = new System.Drawing.Size(181, 32);
            this.txtMaThuoc.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã thuốc:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtMaThuoc);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel5.Location = new System.Drawing.Point(99, 92);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(380, 32);
            this.panel5.TabIndex = 18;
            // 
            // frmChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1323, 658);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvThuoc);
            this.Controls.Add(this.btnTimThuoc);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.btnXoaThuoc);
            this.Controls.Add(this.btnSuaThuoc);
            this.Controls.Add(this.btnThemThuoc);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel5);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmChucVu";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuoc)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.DataGridView dgvThuoc;
        private System.Windows.Forms.Button btnTimThuoc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTimThuoc;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button btnXoaThuoc;
        private System.Windows.Forms.Button btnSuaThuoc;
        private System.Windows.Forms.Button btnThemThuoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTenThuoc;
        private System.Windows.Forms.ComboBox cmbDonVi;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DateTimePicker dtNSX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DateTimePicker dtHSD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtGiaTien;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox txtMaThuoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
    }
}

