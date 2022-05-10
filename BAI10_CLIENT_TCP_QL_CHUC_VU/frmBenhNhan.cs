using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAI10_CLIENT_TCP_QL_CHUC_VU
{
    public partial class frmBenhNhan : Form
    {
        public frmBenhNhan()
        {
            InitializeComponent();
        }

        StreamReader sr;
        StreamWriter sw;

        int chon = 0;

        private void frmBenhNhan_Load(object sender, EventArgs e)
        {
            try
            {
                chon = 6;

                //tạo luồng đọc và luồng ghi dữ liệu
                //sử dụng biến static ns của form Kết Nối
                sr = new StreamReader(frmKetNoi.ns);
                sw = new StreamWriter(frmKetNoi.ns);

                sw.WriteLine(chon);
                sw.Flush();


                //tạo mảng byte để nhận dữ liệu từ máy chủ
                byte[] data = new byte[1024 * 5000];

                //sử dụng biến static clientSockt của form Kết Nối
                frmKetNoi.clientSock.Receive(data);

                //chuyển dữ liệu vừa nhận dạng mảng byte sang kiểu object rồi ép kiểu sang datatable
                DataTable dt = (DataTable)DeserializeData(data);

                //đưa datatable vào dataGridView
                dgvBenhNhan.DataSource = dt;

                //dataGridView1.Columns["macv"].HeaderText = "Mã chức vụ";
                //dataGridView1.Columns["tencv"].HeaderText = "Tên chức vụ";
                //dataGridView1.Columns["hsphucap"].HeaderText = "Hệ số phụ cấp";
                //dataGridView1.Columns["macv"].Width = 110;
                //dataGridView1.Columns["tencv"].Width = 200;
                //dataGridView1.Columns["hsphucap"].Width = 100;

                dgvBenhNhan.Columns["MaBenhNhan"].HeaderText = "Mã bệnh nhân";
                dgvBenhNhan.Columns["HoLot"].HeaderText = "Họ lót";
                dgvBenhNhan.Columns["TenBN"].HeaderText = "Tên";
                dgvBenhNhan.Columns["GioiTinh"].HeaderText = "Giới tính";
                dgvBenhNhan.Columns["NgaySinh"].HeaderText = "Ngày sinh";
                dgvBenhNhan.Columns["NgaySinh"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvBenhNhan.Columns["IdBenhNhan"].Visible = false;
                dgvBenhNhan.Columns["DiaChi"].Visible = false;
                dgvBenhNhan.Columns["DiaChi"].Visible = false;
                dgvBenhNhan.Columns["GhiChu"].Visible = false;

                dgvBenhNhan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public object DeserializeData(byte[] theByteArray)
        {
            MemoryStream ms = new MemoryStream(theByteArray);
            BinaryFormatter bf1 = new BinaryFormatter();
            ms.Position = 0;
            return bf1.Deserialize(ms);

        }

        private void btnThemBN_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu có bị bỏ trống 
            if (txtHoLot.Text == "" || txtTenBN.Text == "" || txtLienHe.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            // Kiểm tra mã nhân viên có độ dài chuỗi hợp lệ hay không
            //if (txt_macv.Text.Length > 5)
            //{
            //    MessageBox.Show("Mã chức vụ tối đa 5 ký tự!");
            //    return;
            //}

            //if (timThuocTheoMaThuoc(txtMaThuoc.Text) == true)
            //{
            //    MessageBox.Show("Mã thuốc đã tồn tại!");
            //    return;
            //}

            chon = 8; 
            string HoLot = txtHoLot.Text;
            string TenBN = txtTenBN.Text;
            string GioiTinh;
            if (radBNNam.Checked == true)
            {
                GioiTinh = "Nam";
            }
            else
            {
                GioiTinh = "Nữ";
            }
            string NgaySinh = dtNgaySinh.Text.ToString();
            string DiaChi = txtDiaChi.Text;
            string LienHe = txtLienHe.Text;
            string Ghichu = txtGhiChu.Text;

            //thêm chức vụ            
            sr = new StreamReader(frmKetNoi.ns);
            sw = new StreamWriter(frmKetNoi.ns);

            sw.WriteLine(chon);
            sw.WriteLine(HoLot);
            sw.WriteLine(TenBN);
            sw.WriteLine(GioiTinh);
            sw.WriteLine(NgaySinh);
            sw.WriteLine(DiaChi);
            sw.WriteLine(LienHe);
            sw.WriteLine(Ghichu);
            sw.Flush();

            //tạo mảng byte để nhận dữ liệu từ máy chủ
            byte[] data = new byte[1024 * 5000];
            frmKetNoi.clientSock.Receive(data);

            //chuyển dữ liệu vừa nhận dạng mảng byte sang datatable
            DataTable dt = (DataTable)DeserializeData(data);

            //đưa datatable vào dataGridView
            dgvBenhNhan.DataSource = dt;
        }

        private void dgvBenhNhan_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = new DataGridViewRow();
            dr = dgvBenhNhan.SelectedRows[0];
            txtMaBN.Text = dr.Cells["MaBenhNhan"].Value.ToString();
            txtHoLot.Text = dr.Cells["HoLot"].Value.ToString();
            txtTenBN.Text = dr.Cells["TenBN"].Value.ToString();
            if (dr.Cells["GioiTinh"].Value.ToString() == "Nam")
            {
                radBNNam.Checked = true;
            }
            else
            {
                radNuBN.Checked = true;
            }
            dtNgaySinh.Text = dr.Cells["NgaySinh"].Value.ToString();
            txtDiaChi.Text = dr.Cells["DiaChi"].Value.ToString();
            txtLienHe.Text = dr.Cells["DiaChi"].Value.ToString();
            txtGhiChu.Text = dr.Cells["GhiChu"].Value.ToString();

            //btnKham.Enabled = true;
            //btnXoa.Enabled = true;
            //var a = new WriteLog();
            //a.ButtonWrite("Xem thông tin bệnh nhân " + dr.Cells["HoLot"].Value.ToString() + " " + dr.Cells["TenBN"].Value.ToString());
        }
    }
}
