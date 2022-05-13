
namespace BAI10_CLIENT_TCP_QL_CHUC_VU
{
    partial class frmBenhNhan
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
            this.btnKham = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.txtTimBN = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvBenhNhan = new System.Windows.Forms.DataGridView();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtMaBN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtHoLot = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtPatientSureName = new System.Windows.Forms.TextBox();
            this.txtPatientName = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.txtTenBN = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtIdBenhNhan = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSuaBN = new System.Windows.Forms.Button();
            this.btnThemBN = new System.Windows.Forms.Button();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.txtLienHe = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.radBNNam = new System.Windows.Forms.RadioButton();
            this.radNuBN = new System.Windows.Forms.RadioButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel12.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBenhNhan)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKham
            // 
            this.btnKham.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnKham.Enabled = false;
            this.btnKham.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnKham.Location = new System.Drawing.Point(953, 475);
            this.btnKham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKham.Name = "btnKham";
            this.btnKham.Size = new System.Drawing.Size(195, 54);
            this.btnKham.TabIndex = 17;
            this.btnKham.Text = "Khám bệnh";
            this.btnKham.UseVisualStyleBackColor = false;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel12.Controls.Add(this.txtTimBN);
            this.panel12.Controls.Add(this.btnSearch);
            this.panel12.Location = new System.Drawing.Point(667, 42);
            this.panel12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(591, 111);
            this.panel12.TabIndex = 19;
            // 
            // txtTimBN
            // 
            this.txtTimBN.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.txtTimBN.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimBN.Location = new System.Drawing.Point(3, 41);
            this.txtTimBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimBN.Name = "txtTimBN";
            this.txtTimBN.Size = new System.Drawing.Size(478, 32);
            this.txtTimBN.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSearch.Location = new System.Drawing.Point(487, 14);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(86, 86);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.dgvBenhNhan);
            this.panel1.Location = new System.Drawing.Point(670, 164);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(602, 307);
            this.panel1.TabIndex = 20;
            // 
            // dgvBenhNhan
            // 
            this.dgvBenhNhan.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.dgvBenhNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBenhNhan.Location = new System.Drawing.Point(6, 2);
            this.dgvBenhNhan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvBenhNhan.Name = "dgvBenhNhan";
            this.dgvBenhNhan.ReadOnly = true;
            this.dgvBenhNhan.RowHeadersWidth = 51;
            this.dgvBenhNhan.RowTemplate.Height = 24;
            this.dgvBenhNhan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBenhNhan.Size = new System.Drawing.Size(585, 284);
            this.dgvBenhNhan.TabIndex = 0;
            this.dgvBenhNhan.Click += new System.EventHandler(this.dgvBenhNhan_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Refresh.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Refresh.Location = new System.Drawing.Point(728, 475);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(195, 54);
            this.btn_Refresh.TabIndex = 21;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txtMaBN);
            this.panel4.Location = new System.Drawing.Point(3, 2);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(338, 32);
            this.panel4.TabIndex = 0;
            // 
            // txtMaBN
            // 
            this.txtMaBN.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.txtMaBN.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaBN.Location = new System.Drawing.Point(188, 5);
            this.txtMaBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaBN.Name = "txtMaBN";
            this.txtMaBN.ReadOnly = true;
            this.txtMaBN.Size = new System.Drawing.Size(162, 32);
            this.txtMaBN.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã bệnh nhân:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.txtHoLot);
            this.panel5.Location = new System.Drawing.Point(3, 41);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(336, 32);
            this.panel5.TabIndex = 1;
            // 
            // txtHoLot
            // 
            this.txtHoLot.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.txtHoLot.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtHoLot.ForeColor = System.Drawing.Color.Black;
            this.txtHoLot.Location = new System.Drawing.Point(92, 5);
            this.txtHoLot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHoLot.Name = "txtHoLot";
            this.txtHoLot.Size = new System.Drawing.Size(241, 32);
            this.txtHoLot.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ lót:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtPatientName);
            this.panel6.Controls.Add(this.txtPatientSureName);
            this.panel6.Location = new System.Drawing.Point(345, 41);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(191, 32);
            this.panel6.TabIndex = 4;
            // 
            // txtPatientSureName
            // 
            this.txtPatientSureName.Location = new System.Drawing.Point(53, 5);
            this.txtPatientSureName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPatientSureName.Name = "txtPatientSureName";
            this.txtPatientSureName.Size = new System.Drawing.Size(132, 26);
            this.txtPatientSureName.TabIndex = 1;
            // 
            // txtPatientName
            // 
            this.txtPatientName.AutoSize = true;
            this.txtPatientName.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPatientName.Location = new System.Drawing.Point(3, 6);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(55, 24);
            this.txtPatientName.TabIndex = 0;
            this.txtPatientName.Text = "Tên:";
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.label8);
            this.panel13.Controls.Add(this.txtTenBN);
            this.panel13.Location = new System.Drawing.Point(345, 41);
            this.panel13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(191, 32);
            this.panel13.TabIndex = 2;
            // 
            // txtTenBN
            // 
            this.txtTenBN.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.txtTenBN.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenBN.Location = new System.Drawing.Point(67, 5);
            this.txtTenBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenBN.Name = "txtTenBN";
            this.txtTenBN.Size = new System.Drawing.Size(132, 32);
            this.txtTenBN.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(3, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tên:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.txtIdBenhNhan);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnSuaBN);
            this.panel2.Controls.Add(this.btnThemBN);
            this.panel2.Controls.Add(this.panel11);
            this.panel2.Controls.Add(this.panel10);
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel13);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(47, 39);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(614, 457);
            this.panel2.TabIndex = 18;
            // 
            // txtIdBenhNhan
            // 
            this.txtIdBenhNhan.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.txtIdBenhNhan.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtIdBenhNhan.Location = new System.Drawing.Point(426, 8);
            this.txtIdBenhNhan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdBenhNhan.Name = "txtIdBenhNhan";
            this.txtIdBenhNhan.Size = new System.Drawing.Size(100, 32);
            this.txtIdBenhNhan.TabIndex = 12;
            this.txtIdBenhNhan.Visible = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnXoa.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.ForeColor = System.Drawing.Color.Red;
            this.btnXoa.Location = new System.Drawing.Point(352, 358);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 68);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSuaBN
            // 
            this.btnSuaBN.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSuaBN.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSuaBN.ForeColor = System.Drawing.Color.Black;
            this.btnSuaBN.Location = new System.Drawing.Point(177, 358);
            this.btnSuaBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuaBN.Name = "btnSuaBN";
            this.btnSuaBN.Size = new System.Drawing.Size(94, 68);
            this.btnSuaBN.TabIndex = 9;
            this.btnSuaBN.Text = "Sửa";
            this.btnSuaBN.UseVisualStyleBackColor = false;
            this.btnSuaBN.Click += new System.EventHandler(this.btnSuaBN_Click);
            // 
            // btnThemBN
            // 
            this.btnThemBN.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnThemBN.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemBN.ForeColor = System.Drawing.Color.Black;
            this.btnThemBN.Location = new System.Drawing.Point(36, 358);
            this.btnThemBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemBN.Name = "btnThemBN";
            this.btnThemBN.Size = new System.Drawing.Size(94, 68);
            this.btnThemBN.TabIndex = 8;
            this.btnThemBN.Text = "Thêm";
            this.btnThemBN.UseVisualStyleBackColor = false;
            this.btnThemBN.Click += new System.EventHandler(this.btnThemBN_Click);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.txtGhiChu.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtGhiChu.Location = new System.Drawing.Point(112, 29);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(435, 78);
            this.txtGhiChu.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(3, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ghi chú:";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.label7);
            this.panel11.Controls.Add(this.txtGhiChu);
            this.panel11.Location = new System.Drawing.Point(3, 246);
            this.panel11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(583, 86);
            this.panel11.TabIndex = 7;
            // 
            // txtLienHe
            // 
            this.txtLienHe.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.txtLienHe.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtLienHe.Location = new System.Drawing.Point(109, 1);
            this.txtLienHe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLienHe.Name = "txtLienHe";
            this.txtLienHe.Size = new System.Drawing.Size(435, 32);
            this.txtLienHe.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(3, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Liên hệ:";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.label6);
            this.panel10.Controls.Add(this.txtLienHe);
            this.panel10.Location = new System.Drawing.Point(3, 208);
            this.panel10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(583, 34);
            this.panel10.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(3, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Địa chỉ:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.txtDiaChi.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDiaChi.Location = new System.Drawing.Point(109, 9);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(435, 74);
            this.txtDiaChi.TabIndex = 1;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.txtDiaChi);
            this.panel9.Controls.Add(this.label5);
            this.panel9.Location = new System.Drawing.Point(3, 118);
            this.panel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(583, 85);
            this.panel9.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(21, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày sinh:";
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtNgaySinh.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgaySinh.Location = new System.Drawing.Point(165, 2);
            this.dtNgaySinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(164, 29);
            this.dtNgaySinh.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.dtNgaySinh);
            this.panel8.Controls.Add(this.label4);
            this.panel8.Location = new System.Drawing.Point(238, 79);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(351, 43);
            this.panel8.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(3, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giới tính:";
            // 
            // radBNNam
            // 
            this.radBNNam.AutoSize = true;
            this.radBNNam.Checked = true;
            this.radBNNam.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radBNNam.Location = new System.Drawing.Point(119, 6);
            this.radBNNam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radBNNam.Name = "radBNNam";
            this.radBNNam.Size = new System.Drawing.Size(70, 22);
            this.radBNNam.TabIndex = 1;
            this.radBNNam.TabStop = true;
            this.radBNNam.Text = "Nam";
            this.radBNNam.UseVisualStyleBackColor = true;
            // 
            // radNuBN
            // 
            this.radNuBN.AutoSize = true;
            this.radNuBN.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radNuBN.Location = new System.Drawing.Point(183, 6);
            this.radNuBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radNuBN.Name = "radNuBN";
            this.radNuBN.Size = new System.Drawing.Size(56, 22);
            this.radNuBN.TabIndex = 2;
            this.radNuBN.Text = "Nữ";
            this.radNuBN.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.radNuBN);
            this.panel7.Controls.Add(this.radBNNam);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Location = new System.Drawing.Point(3, 79);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(241, 41);
            this.panel7.TabIndex = 3;
            // 
            // frmBenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1308, 551);
            this.Controls.Add(this.btnKham);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmBenhNhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBenhNhan";
            this.Load += new System.EventHandler(this.frmBenhNhan_Load);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBenhNhan)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel1;
        public System.Windows.Forms.Button btnKham;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TextBox txtTimBN;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvBenhNhan;
        public System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaBN;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHoLot;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label txtPatientName;
        private System.Windows.Forms.TextBox txtPatientSureName;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTenBN;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtIdBenhNhan;
        public System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSuaBN;
        private System.Windows.Forms.Button btnThemBN;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLienHe;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DateTimePicker dtNgaySinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.RadioButton radNuBN;
        private System.Windows.Forms.RadioButton radBNNam;
        private System.Windows.Forms.Label label3;
    }
}