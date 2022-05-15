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
    public partial class frmThuoc : Form
    {
        public frmThuoc()
        {
            InitializeComponent();
        }          
       
        StreamReader sr;
        StreamWriter sw;   

        int chon = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            HienThiDSThuoc();
        }

        private void HienThiDSThuoc()
        {
            try
            {
                chon = 0;

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
                dgvThuoc.DataSource = dt;

                //dataGridView1.Columns["macv"].HeaderText = "Mã chức vụ";
                //dataGridView1.Columns["tencv"].HeaderText = "Tên chức vụ";
                //dataGridView1.Columns["hsphucap"].HeaderText = "Hệ số phụ cấp";
                //dataGridView1.Columns["macv"].Width = 110;
                //dataGridView1.Columns["tencv"].Width = 200;
                //dataGridView1.Columns["hsphucap"].Width = 100;

                dgvThuoc.Columns["MaThuoc"].HeaderText = "Mã thuốc";
                dgvThuoc.Columns["TenThuoc"].HeaderText = "Tên thuốc";
                dgvThuoc.Columns["DonVi"].HeaderText = "Đơn vị";
                dgvThuoc.Columns["SoLuong"].HeaderText = "Số lượng";
                dgvThuoc.Columns["NSX"].HeaderText = "Ngày sản xuất";
                dgvThuoc.Columns["NSX"].DefaultCellStyle.Format = "dd/MM//yyyy";
                dgvThuoc.Columns["HSD"].HeaderText = "Hạn sử dụng";
                dgvThuoc.Columns["HSD"].DefaultCellStyle.Format = "dd/MM//yyyy";
                dgvThuoc.Columns["GiaThuoc"].HeaderText = "Giá";

                dgvThuoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                cmbDonVi.Items.Add("Viên");
                cmbDonVi.Items.Add("Gói");
                cmbDonVi.Items.Add("Ống");
                cmbDonVi.Items.Add("Chai");


                Auto();
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

        public bool timThuocTheoMaThuoc(string mathuoctim)
        {
            chon = 5;  

            sr = new StreamReader(frmKetNoi.ns);
            sw = new StreamWriter(frmKetNoi.ns);

            sw.WriteLine(chon);
            sw.WriteLine(mathuoctim);
            sw.Flush();

            int kq = int.Parse(sr.ReadLine());
           
            if (kq == 1)
                return true;
            else
                return false;
        }
       
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            //clientSock.Close();
            //sr.Close();
           // sw.Close();
            this.Close();
        }

        private void dgvThuoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
        private void btnThemThuoc_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu có bị bỏ trống 
            if (txtMaThuoc.Text == "" || txtTenThuoc.Text == "" || txtSoLuong.Text == "" || txtGiaTien.Text == "")
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
            if (timThuocTheoMaThuoc(txtMaThuoc.Text) == true)
            {
                MessageBox.Show("Mã thuốc đã tồn tại!");
                return;
            }

            chon = 1;
            string DonVi;
            string MaThuoc = txtMaThuoc.Text;
            string TenThuoc = txtTenThuoc.Text;
            if (cmbDonVi.SelectedItem.ToString() == "Viên")
                 DonVi = "Viên";
            else if (cmbDonVi.SelectedItem.ToString() == "Gói")
                 DonVi = "Gói";
            else if (cmbDonVi.SelectedItem.ToString() == "Ống")
                 DonVi = "Ống";
            else DonVi = "Chai";
            int SoLuong = int.Parse(txtSoLuong.Text);
            string NSX = dtNSX.Text.ToString();
            string HSD = dtHSD.Text.ToString();
            int GiaThuoc = int.Parse(txtGiaTien.Text);
            

            //thêm chức vụ            
            sr = new StreamReader(frmKetNoi.ns);
            sw = new StreamWriter(frmKetNoi.ns);

            sw.WriteLine(chon);
            sw.WriteLine(MaThuoc);
            sw.WriteLine(TenThuoc);
            sw.WriteLine(DonVi);
            sw.WriteLine(SoLuong);
            sw.WriteLine(NSX);
            sw.WriteLine(HSD);
            sw.WriteLine(GiaThuoc);
            sw.Flush();

            //tạo mảng byte để nhận dữ liệu từ máy chủ
            byte[] data = new byte[1024 * 5000];
            frmKetNoi.clientSock.Receive(data);

            //chuyển dữ liệu vừa nhận dạng mảng byte sang datatable
            DataTable dt = (DataTable)DeserializeData(data);

            //đưa datatable vào dataGridView
            dgvThuoc.DataSource = dt;
        }

        private void btnTimThuoc_Click(object sender, EventArgs e)
        {

            if (txtTimThuoc.Text == "")
            {
                MessageBox.Show("Vui lòng chọn nhập tên thuốc!");
                return;
            }

            chon = 4;
            string tenthuoctim = txtTimThuoc.Text;

            sr = new StreamReader(frmKetNoi.ns);
            sw = new StreamWriter(frmKetNoi.ns);

            sw.WriteLine(chon);
            sw.WriteLine(tenthuoctim);

            sw.Flush();

            //tạo mảng byte để nhận dữ liệu từ máy chủ
            byte[] data = new byte[1024 * 5000];
            frmKetNoi.clientSock.Receive(data);

            //chuyển dữ liệu vừa nhận dạng mảng byte sang datatable
            DataTable dt = (DataTable)DeserializeData(data);

            //đưa datatable vào dataGridView
            dgvThuoc.DataSource = dt;
        }

        private void btnSuaThuoc_Click(object sender, EventArgs e)
        {
            // kiểm tra mã có tồn tại
            if (txtMaThuoc.Text == "" || txtTenThuoc.Text == "" || txtSoLuong.Text == "" || txtGiaTien.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            if (timThuocTheoMaThuoc(txtMaThuoc.Text) == false)
            {
                MessageBox.Show("Mã thuốc không tồn tại!");
                return;
            }

            chon = 3;
            string DonVi;
            string MaThuoc = txtMaThuoc.Text;
            string TenThuoc = txtTenThuoc.Text;
            if (cmbDonVi.SelectedItem.ToString() == "Viên")
                DonVi = "Viên";
            else if (cmbDonVi.SelectedItem.ToString() == "Gói")
                DonVi = "Gói";
            else if (cmbDonVi.SelectedItem.ToString() == "Ống")
                DonVi = "Ống";
            else DonVi = "Chai";
            int SoLuong = int.Parse(txtSoLuong.Text);
            string NSX = dtNSX.Text.ToString();
            string HSD = dtHSD.Text.ToString();
            int GiaThuoc = int.Parse(txtGiaTien.Text);

            //thêm chức vụ

            sr = new StreamReader(frmKetNoi.ns);
            sw = new StreamWriter(frmKetNoi.ns);

            sw.WriteLine(chon);
            sw.WriteLine(MaThuoc);
            sw.WriteLine(TenThuoc);
            sw.WriteLine(DonVi);
            sw.WriteLine(SoLuong);
            sw.WriteLine(NSX);
            sw.WriteLine(HSD);
            sw.WriteLine(GiaThuoc);
            sw.Flush();

            //tạo mảng byte để nhận dữ liệu từ máy chủ
            byte[] data = new byte[1024 * 5000];
            frmKetNoi.clientSock.Receive(data);

            //chuyển dữ liệu vừa nhận dạng mảng byte sang datatable
            DataTable dt = (DataTable)DeserializeData(data);

            //đưa datatable vào dataGridView
            dgvThuoc.DataSource = dt;
        }

        private void dgvThuoc_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = new DataGridViewRow();
            dr = dgvThuoc.SelectedRows[0];
            txtMaThuoc.Text = dr.Cells["MaThuoc"].Value.ToString();
            txtTenThuoc.Text = dr.Cells["TenThuoc"].Value.ToString();
            if (dr.Cells["DonVi"].Value.ToString() == "Viên")
                cmbDonVi.SelectedItem = "Viên";
            else if (dr.Cells["DonVi"].Value.ToString() == "Gói")
                cmbDonVi.SelectedItem = "Gói";
            else if (dr.Cells["DonVi"].Value.ToString() == "Ống")
                cmbDonVi.SelectedItem = "Ống";
            else cmbDonVi.SelectedItem = "Chai";
            //cmbDonVi.SelectedItem = dr.Cells["DonVi"].Value.ToString();
            txtSoLuong.Text = dr.Cells["SoLuong"].Value.ToString();
            dtNSX.Text = dr.Cells["NSX"].Value.ToString();
            dtHSD.Text = dr.Cells["HSD"].Value.ToString();
            txtGiaTien.Text = dr.Cells["GiaThuoc"].Value.ToString();
        }

        private void btnXoaThuoc_Click(object sender, EventArgs e)
        {
            // kiểm tra mã có tồn tại
            if (txtMaThuoc.Text == "")
            {
                MessageBox.Show("Vui lòng chọn mã thuốc!");
                return;
            }
            chon = 2;
            string macv = txtMaThuoc.Text;

            sr = new StreamReader(frmKetNoi.ns);
            sw = new StreamWriter(frmKetNoi.ns);

            sw.WriteLine(chon);
            sw.WriteLine(macv);
            sw.Flush();

            //tạo mảng byte để nhận dữ liệu từ máy chủ
            byte[] data = new byte[1024 * 5000];
            frmKetNoi.clientSock.Receive(data);

            //chuyển dữ liệu vừa nhận dạng mảng byte sang datatable
            DataTable dt = (DataTable)DeserializeData(data);

            //đưa datatable vào dataGridView
            dgvThuoc.DataSource = dt;
        }

        private void Auto()
        {
            chon = 4;
            string tenthuoctim = txtTimThuoc.Text;

            sr = new StreamReader(frmKetNoi.ns);
            sw = new StreamWriter(frmKetNoi.ns);

            sw.WriteLine(chon);
            sw.WriteLine(tenthuoctim);

            sw.Flush();

            //tạo mảng byte để nhận dữ liệu từ máy chủ
            byte[] data = new byte[1024 * 5000];
            frmKetNoi.clientSock.Receive(data);

            //chuyển dữ liệu vừa nhận dạng mảng byte sang datatable
            DataTable dt = (DataTable)DeserializeData(data);

            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //lstTenThuoc.Add(dt.Rows[i]["MaThuoc"].ToString());
                coll.Add(dt.Rows[i]["TenThuoc"].ToString());
            }
            txtTimThuoc.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtTimThuoc.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtTimThuoc.AutoCompleteCustomSource = coll;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            HienThiDSThuoc();
        }
    }
}
