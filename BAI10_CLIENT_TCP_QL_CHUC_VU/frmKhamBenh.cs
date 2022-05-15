using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAI10_CLIENT_TCP_QL_CHUC_VU
{
    public partial class frmKhamBenh : Form
    {
        public frmKhamBenh()
        {
            InitializeComponent();
        }
        StreamReader sr;
        StreamWriter sw;

        int chon = 0;

       

        private void frmKhamBenh_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            txtBacSi.Text = frmMain.tennguoidung;
            frmBenhNhan f1 = new frmBenhNhan();
            HienThiDSPhieuKham();
            
        }

        private void HienThiDSPhieuKham()
        {
            //try
            //{
            //    chon = 6;

            //    //tạo luồng đọc và luồng ghi dữ liệu
            //    //sử dụng biến static ns của form Kết Nối
            //    sr = new StreamReader(frmKetNoi.ns);
            //    sw = new StreamWriter(frmKetNoi.ns);

            //    sw.WriteLine(chon);
            //    sw.Flush();


            //    //tạo mảng byte để nhận dữ liệu từ máy chủ
            //    byte[] data = new byte[1024 * 5000];

            //    //sử dụng biến static clientSockt của form Kết Nối
            //    frmKetNoi.clientSock.Receive(data);

            //    //chuyển dữ liệu vừa nhận dạng mảng byte sang kiểu object rồi ép kiểu sang datatable
            //    DataTable dt = (DataTable)DeserializeData(data);

            //    //đưa datatable vào dataGridView
            //    dgvBenhNhan.DataSource = dt;

            //    //dataGridView1.Columns["macv"].HeaderText = "Mã chức vụ";
            //    //dataGridView1.Columns["tencv"].HeaderText = "Tên chức vụ";
            //    //dataGridView1.Columns["hsphucap"].HeaderText = "Hệ số phụ cấp";
            //    //dataGridView1.Columns["macv"].Width = 110;
            //    //dataGridView1.Columns["tencv"].Width = 200;
            //    //dataGridView1.Columns["hsphucap"].Width = 100;

            //    dgvBenhNhan.Columns["MaBenhNhan"].HeaderText = "Mã bệnh nhân";
            //    dgvBenhNhan.Columns["HoLot"].HeaderText = "Họ lót";
            //    dgvBenhNhan.Columns["TenBN"].HeaderText = "Tên";
            //    dgvBenhNhan.Columns["GioiTinh"].HeaderText = "Giới tính";
            //    dgvBenhNhan.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            //    dgvBenhNhan.Columns["NgaySinh"].DefaultCellStyle.Format = "dd/MM/yyyy";
            //    dgvBenhNhan.Columns["IdBenhNhan"].Visible = false;
            //    dgvBenhNhan.Columns["DiaChi"].Visible = false;
            //    dgvBenhNhan.Columns["DiaChi"].Visible = false;
            //    dgvBenhNhan.Columns["GhiChu"].Visible = false;

            //    dgvBenhNhan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
    }
}
