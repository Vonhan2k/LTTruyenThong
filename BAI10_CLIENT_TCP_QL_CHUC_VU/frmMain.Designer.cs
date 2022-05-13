
namespace BAI10_CLIENT_TCP_QL_CHUC_VU
{
    partial class frmMain
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
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.i_dangnhap = new System.Windows.Forms.ToolStripMenuItem();
            this.i_dangxuat = new System.Windows.Forms.ToolStripMenuItem();
            this.i_BenhNhan = new System.Windows.Forms.ToolStripMenuItem();
            this.i_Thuoc = new System.Windows.Forms.ToolStripMenuItem();
            this.i_Admin = new System.Windows.Forms.ToolStripMenuItem();
            this.i_ThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.i_DoanhThu = new System.Windows.Forms.ToolStripMenuItem();
            this.i_QLBacSi = new System.Windows.Forms.ToolStripMenuItem();
            this.i_LuongBacSi = new System.Windows.Forms.ToolStripMenuItem();
            this.i_QLBenhNhan = new System.Windows.Forms.ToolStripMenuItem();
            this.i_TaiKhoanQL = new System.Windows.Forms.ToolStripMenuItem();
            this.i_BacSi = new System.Windows.Forms.ToolStripMenuItem();
            this.i_XemLog = new System.Windows.Forms.ToolStripMenuItem();
            this.i_LogForm = new System.Windows.Forms.ToolStripMenuItem();
            this.i_LogButton = new System.Windows.Forms.ToolStripMenuItem();
            this.i_DuLieu = new System.Windows.Forms.ToolStripMenuItem();
            this.i_SaoLuu = new System.Windows.Forms.ToolStripMenuItem();
            this.i_PhucHoi = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stt_hoten = new System.Windows.Forms.ToolStripStatusLabel();
            this.stt_thoigian = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuMain.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.i_BenhNhan,
            this.i_Thuoc,
            this.i_Admin});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(1263, 33);
            this.menuMain.TabIndex = 2;
            this.menuMain.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.i_dangnhap,
            this.i_dangxuat});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(103, 29);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // i_dangnhap
            // 
            this.i_dangnhap.Name = "i_dangnhap";
            this.i_dangnhap.Size = new System.Drawing.Size(202, 34);
            this.i_dangnhap.Text = "Đăng nhập";
            this.i_dangnhap.Click += new System.EventHandler(this.i_dangnhap_Click);
            // 
            // i_dangxuat
            // 
            this.i_dangxuat.Enabled = false;
            this.i_dangxuat.Name = "i_dangxuat";
            this.i_dangxuat.Size = new System.Drawing.Size(202, 34);
            this.i_dangxuat.Text = "Đăng xuất";
            this.i_dangxuat.Click += new System.EventHandler(this.i_dangxuat_Click);
            // 
            // i_BenhNhan
            // 
            this.i_BenhNhan.Enabled = false;
            this.i_BenhNhan.Name = "i_BenhNhan";
            this.i_BenhNhan.Size = new System.Drawing.Size(111, 29);
            this.i_BenhNhan.Text = "Bệnh nhân";
            this.i_BenhNhan.Click += new System.EventHandler(this.i_BenhNhan_Click);
            // 
            // i_Thuoc
            // 
            this.i_Thuoc.Enabled = false;
            this.i_Thuoc.Name = "i_Thuoc";
            this.i_Thuoc.Size = new System.Drawing.Size(76, 29);
            this.i_Thuoc.Text = "Thuốc";
            this.i_Thuoc.Click += new System.EventHandler(this.i_Thuoc_Click_1);
            // 
            // i_Admin
            // 
            this.i_Admin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.i_ThongKe,
            this.i_TaiKhoanQL,
            this.i_BacSi,
            this.i_XemLog,
            this.i_DuLieu});
            this.i_Admin.Enabled = false;
            this.i_Admin.Name = "i_Admin";
            this.i_Admin.Size = new System.Drawing.Size(81, 29);
            this.i_Admin.Text = "Admin";
            // 
            // i_ThongKe
            // 
            this.i_ThongKe.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.i_DoanhThu,
            this.i_QLBacSi,
            this.i_LuongBacSi,
            this.i_QLBenhNhan});
            this.i_ThongKe.Name = "i_ThongKe";
            this.i_ThongKe.Size = new System.Drawing.Size(270, 34);
            this.i_ThongKe.Text = "Thống kê";
            // 
            // i_DoanhThu
            // 
            this.i_DoanhThu.Name = "i_DoanhThu";
            this.i_DoanhThu.Size = new System.Drawing.Size(215, 34);
            this.i_DoanhThu.Text = "Doanh thu";
            // 
            // i_QLBacSi
            // 
            this.i_QLBacSi.Name = "i_QLBacSi";
            this.i_QLBacSi.Size = new System.Drawing.Size(215, 34);
            this.i_QLBacSi.Text = "Bác sĩ";
            // 
            // i_LuongBacSi
            // 
            this.i_LuongBacSi.Name = "i_LuongBacSi";
            this.i_LuongBacSi.Size = new System.Drawing.Size(215, 34);
            this.i_LuongBacSi.Text = "Lương bác sĩ";
            // 
            // i_QLBenhNhan
            // 
            this.i_QLBenhNhan.Name = "i_QLBenhNhan";
            this.i_QLBenhNhan.Size = new System.Drawing.Size(215, 34);
            this.i_QLBenhNhan.Text = "Bệnh nhân";
            // 
            // i_TaiKhoanQL
            // 
            this.i_TaiKhoanQL.Name = "i_TaiKhoanQL";
            this.i_TaiKhoanQL.Size = new System.Drawing.Size(270, 34);
            this.i_TaiKhoanQL.Text = "Tài khoản";
            // 
            // i_BacSi
            // 
            this.i_BacSi.Name = "i_BacSi";
            this.i_BacSi.Size = new System.Drawing.Size(270, 34);
            this.i_BacSi.Text = "Bác sĩ";
            this.i_BacSi.Click += new System.EventHandler(this.i_BacSi_Click);
            // 
            // i_XemLog
            // 
            this.i_XemLog.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.i_LogForm,
            this.i_LogButton});
            this.i_XemLog.Name = "i_XemLog";
            this.i_XemLog.Size = new System.Drawing.Size(270, 34);
            this.i_XemLog.Text = "Xem log";
            // 
            // i_LogForm
            // 
            this.i_LogForm.Name = "i_LogForm";
            this.i_LogForm.Size = new System.Drawing.Size(203, 34);
            this.i_LogForm.Text = "Log form";
            // 
            // i_LogButton
            // 
            this.i_LogButton.Name = "i_LogButton";
            this.i_LogButton.Size = new System.Drawing.Size(203, 34);
            this.i_LogButton.Text = "Log button";
            // 
            // i_DuLieu
            // 
            this.i_DuLieu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.i_SaoLuu,
            this.i_PhucHoi});
            this.i_DuLieu.Name = "i_DuLieu";
            this.i_DuLieu.Size = new System.Drawing.Size(270, 34);
            this.i_DuLieu.Text = "Dữ liệu";
            // 
            // i_SaoLuu
            // 
            this.i_SaoLuu.Name = "i_SaoLuu";
            this.i_SaoLuu.Size = new System.Drawing.Size(182, 34);
            this.i_SaoLuu.Text = "Sao lưu";
            // 
            // i_PhucHoi
            // 
            this.i_PhucHoi.Name = "i_PhucHoi";
            this.i_PhucHoi.Size = new System.Drawing.Size(182, 34);
            this.i_PhucHoi.Text = "Phục hồi";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stt_hoten,
            this.stt_thoigian});
            this.statusStrip1.Location = new System.Drawing.Point(0, 691);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1263, 32);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stt_hoten
            // 
            this.stt_hoten.Name = "stt_hoten";
            this.stt_hoten.Size = new System.Drawing.Size(66, 25);
            this.stt_hoten.Text = "Họ tên";
            // 
            // stt_thoigian
            // 
            this.stt_thoigian.Name = "stt_thoigian";
            this.stt_thoigian.Size = new System.Drawing.Size(176, 25);
            this.stt_thoigian.Text = "Thời gian đăng nhập";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 723);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuMain);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.Text = "Chương trình quản lý nhân viên";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel stt_hoten;
        private System.Windows.Forms.ToolStripStatusLabel stt_thoigian;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem i_dangnhap;
        private System.Windows.Forms.ToolStripMenuItem i_dangxuat;
        private System.Windows.Forms.ToolStripMenuItem i_BenhNhan;
        private System.Windows.Forms.ToolStripMenuItem i_Thuoc;
        private System.Windows.Forms.ToolStripMenuItem i_Admin;
        private System.Windows.Forms.ToolStripMenuItem i_ThongKe;
        private System.Windows.Forms.ToolStripMenuItem i_DoanhThu;
        private System.Windows.Forms.ToolStripMenuItem i_QLBacSi;
        private System.Windows.Forms.ToolStripMenuItem i_LuongBacSi;
        private System.Windows.Forms.ToolStripMenuItem i_QLBenhNhan;
        private System.Windows.Forms.ToolStripMenuItem i_TaiKhoanQL;
        private System.Windows.Forms.ToolStripMenuItem i_BacSi;
        private System.Windows.Forms.ToolStripMenuItem i_XemLog;
        private System.Windows.Forms.ToolStripMenuItem i_LogForm;
        private System.Windows.Forms.ToolStripMenuItem i_LogButton;
        private System.Windows.Forms.ToolStripMenuItem i_DuLieu;
        private System.Windows.Forms.ToolStripMenuItem i_SaoLuu;
        private System.Windows.Forms.ToolStripMenuItem i_PhucHoi;
    }
}