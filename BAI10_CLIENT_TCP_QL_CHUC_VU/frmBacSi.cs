using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace BAI10_CLIENT_TCP_QL_CHUC_VU
{
    public partial class frmBacSi : Form
    {
        public frmBacSi()
        {
            InitializeComponent();
        }
        StreamReader sr;
        StreamWriter sw;

        int chon = 0;

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            HienThiDSBacSi();
        }
    
        private void HienThiDSBacSi()
        {
            try
            {
                //tạo luồng đọc và luồng ghi dữ liệu
                //sử dụng biến static ns của form Kết Nối
                sr = new StreamReader(frmKetNoi.ns);
                sw = new StreamWriter(frmKetNoi.ns);

                chon = 16;

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
                dgvBacSi.DataSource = dt;

                //dataGridView1.Columns["macv"].HeaderText = "Mã chức vụ";
                //dataGridView1.Columns["tencv"].HeaderText = "Tên chức vụ";
                //dataGridView1.Columns["hsphucap"].HeaderText = "Hệ số phụ cấp";
                //dataGridView1.Columns["macv"].Width = 110;
                //dataGridView1.Columns["tencv"].Width = 200;
                //dataGridView1.Columns["hsphucap"].Width = 100;

                dgvBacSi.Columns["IdBacSi"].Visible = false;
                dgvBacSi.Columns["MaBacSi"].HeaderText = "Mã bác sĩ";
                dgvBacSi.Columns["HoLot"].HeaderText = "Họ lót";
                dgvBacSi.Columns["TenBS"].HeaderText = "Tên";
                dgvBacSi.Columns["GioiTinh"].HeaderText = "Giới tính";
                dgvBacSi.Columns["NgaySinh"].HeaderText = "Ngày sinh";
                dgvBacSi.Columns["NgaySinh"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvBacSi.Columns["DiaChi"].Visible = false;
                dgvBacSi.Columns["SDT"].Visible = false;
                dgvBacSi.Columns["Email"].Visible = false;
                dgvBacSi.Columns["HeSoLuong"].Visible = false;

                dgvBacSi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                //clientSock.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } 

        //chuyển dữ liệu từ dạng mảng byte sang kiểu object
        public object DeserializeData(byte[] theByteArray)
        {
            MemoryStream ms = new MemoryStream(theByteArray);
            BinaryFormatter bf1 = new BinaryFormatter();
            ms.Position = 0;
            return bf1.Deserialize(ms);

        }

        private void btnThemBS_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu có bị bỏ trống 
            if (txtHoLotBS.Text == "" || txtTenBS.Text == "" || txtsdt.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            

            chon = 12;
            string GioiTinh;
            string HoLot = txtHoLotBS.Text;
            string TenBS = txtTenBS.Text;
            if (radBsNam.Checked == true)
            {
                 GioiTinh = "Nam";
            }
            else
            {
                GioiTinh = "Nữ";
            }
            DateTime NgaySinh = DateTime.Parse(dtNgaySinh.Text);
            string DiaChi = txtDiaChi.Text;
            string SDT = txtsdt.Text;
            string Email = txtEmail.Text;
            float HeSoLuong = float.Parse(txthsluong.Text);


            sr = new StreamReader(frmKetNoi.ns);
            sw = new StreamWriter(frmKetNoi.ns);

            sw.WriteLine(chon);
            sw.WriteLine(HoLot);
            sw.WriteLine(TenBS);
            sw.WriteLine(GioiTinh);
            sw.WriteLine(NgaySinh);
            sw.WriteLine(DiaChi);
            sw.WriteLine(SDT);
            sw.WriteLine(Email);
            sw.WriteLine(HeSoLuong);
            sw.Flush();

            //tạo mảng byte để nhận dữ liệu từ máy chủ
            byte[] data = new byte[1024 * 5000];
            frmKetNoi.clientSock.Receive(data);

            //chuyển dữ liệu vừa nhận dạng mảng byte sang datatable
            DataTable dt = (DataTable)DeserializeData(data);

            //đưa datatable vào dataGridView
            dgvBacSi.DataSource = dt;
        }

        private void btnXoaBS_Click(object sender, EventArgs e)
        {
            // kiểm tra mã có tồn tại
            if (txtMaBS.Text == "")
            {
                MessageBox.Show("Vui lòng chọn mã bác sĩ!");
                return;
            }
            chon = 13;
            string mabacsi = txtMaBS.Text;

            sr = new StreamReader(frmKetNoi.ns);
            sw = new StreamWriter(frmKetNoi.ns);

            sw.WriteLine(chon);
            sw.WriteLine(mabacsi);
            sw.Flush();

            //tạo mảng byte để nhận dữ liệu từ máy chủ
            byte[] data = new byte[1024 * 5000];
            frmKetNoi.clientSock.Receive(data);

            //chuyển dữ liệu vừa nhận dạng mảng byte sang datatable
            DataTable dt = (DataTable)DeserializeData(data);

            //đưa datatable vào dataGridView
            dgvBacSi.DataSource = dt;
        }

        private void dgvBacSi_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = new DataGridViewRow();
            dr = dgvBacSi.SelectedRows[0];
            txtMaBS.Text = dr.Cells["MaBacSi"].Value.ToString();
            txtHoLotBS.Text = dr.Cells["HoLot"].Value.ToString();
            txtTenBS.Text = dr.Cells["TenBS"].Value.ToString();
            if (dr.Cells["GioiTinh"].Value.ToString() == "Nam")
            {
                radBsNam.Checked = true;
            }
            else
            {
                radBsNu.Checked = true;
            }
            dtNgaySinh.Text = dr.Cells["NgaySinh"].Value.ToString();
            txtDiaChi.Text = dr.Cells["DiaChi"].Value.ToString();
            txtsdt.Text = dr.Cells["SDT"].Value.ToString();
            txtEmail.Text = dr.Cells["Email"].Value.ToString();
            txthsluong.Text = dr.Cells["HeSoLuong"].Value.ToString();
        }

        private void btnSuaBS_Click(object sender, EventArgs e)
        {
            

            chon = 14;

            string GioiTinh;
            string HoLot = txtHoLotBS.Text;
            string TenBS = txtTenBS.Text;
            if (radBsNam.Checked == true)
            {
                GioiTinh = "Nam";
            }
            else
            {
                GioiTinh = "Nữ";
            }
            DateTime NgaySinh = DateTime.Parse(dtNgaySinh.Text);
            string DiaChi = txtDiaChi.Text;
            string SDT = txtsdt.Text;
            string Email = txtEmail.Text;
            float HeSoLuong = float.Parse(txthsluong.Text);


            sr = new StreamReader(frmKetNoi.ns);
            sw = new StreamWriter(frmKetNoi.ns);

            sw.WriteLine(chon);
            sw.WriteLine(HoLot);
            sw.WriteLine(TenBS);
            sw.WriteLine(GioiTinh);
            sw.WriteLine(NgaySinh);
            sw.WriteLine(DiaChi);
            sw.WriteLine(SDT);
            sw.WriteLine(Email);
            sw.WriteLine(HeSoLuong);
            sw.Flush();

            //tạo mảng byte để nhận dữ liệu từ máy chủ
            byte[] data = new byte[1024 * 5000];
            frmKetNoi.clientSock.Receive(data);

            //chuyển dữ liệu vừa nhận dạng mảng byte sang datatable
            DataTable dt = (DataTable)DeserializeData(data);

            //đưa datatable vào dataGridView
            dgvBacSi.DataSource = dt;
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            HienThiDSBacSi();
        }

        private void btnTimBS_Click(object sender, EventArgs e)
        {
            if (txtTimBS.Text == "")
            {
                MessageBox.Show("Vui lòng chọn nhập tên bác sĩ!");
                return;
            }

            chon = 15;
            string tenbacsitim = txtTimBS.Text;

            sr = new StreamReader(frmKetNoi.ns);
            sw = new StreamWriter(frmKetNoi.ns);

            sw.WriteLine(chon);
            sw.WriteLine(tenbacsitim);

            sw.Flush();

            //tạo mảng byte để nhận dữ liệu từ máy chủ
            byte[] data = new byte[1024 * 5000];
            frmKetNoi.clientSock.Receive(data);

            //chuyển dữ liệu vừa nhận dạng mảng byte sang datatable
            DataTable dt = (DataTable)DeserializeData(data);

            //đưa datatable vào dataGridView
            dgvBacSi.DataSource = dt;
        }
    }
}
