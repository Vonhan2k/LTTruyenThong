using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace BAI10_CLIENT_TCP_QL_CHUC_VU
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        string ip_client = "";
        string ip_server = "";
        public IPEndPoint ipEnd;
        public static Socket clientSock;
        public static NetworkStream ns;
        string ipClient = "";
        string ipServer = "";
        StreamReader sr;
        StreamWriter sw;

        int chon = 0;
        
        frmThuoc fCV;
        frmBenhNhan fBN;
        frmKetNoi fKN;
        frmBacSi fBacSi;
        frmDangNhap fDN;

        public static string tennguoidung = "";
        bool kiemtradangnhap = false;
        int loaitaikhoan;
        public static bool kiemtraketnoi = false;
       

        private void FrmMain_Load(object sender, EventArgs e)
        {
            if (fKN == null || fKN.IsDisposed)
            {
                fKN = new frmKetNoi();
                fKN.MdiParent = this;
                fKN.Show();
            }
            this.WindowState = FormWindowState.Maximized;
            HienThiMenu();
        }        

        private void HienThiMenu()
        {
            if (kiemtradangnhap == true)
            {
                // Hiển thị trạng thái đăng nhập
                stt_hoten.Text = "Người dùng: " + tennguoidung;
                stt_thoigian.Text = "Thời điểm đăng nhập: " + DateTime.Now;

                i_dangnhap.Enabled = false;
                i_dangxuat.Enabled = true;

                if (loaitaikhoan == 1)
                {
                    i_Admin.Enabled = true;
                    // i_Account.Enabled = true;
                    i_BenhNhan.Enabled = true;
                    i_Thuoc.Enabled = true;
                }
                else
                {
                    i_Admin.Enabled = false;
                    // i_Account.Enabled = true;
                    i_BenhNhan.Enabled = true;
                    i_Thuoc.Enabled = true;
                }
                


                
                //i_bangluong.Enabled = true;
                //i_quatrinhluong.Enabled = true;
                
            }
            else
            {
                stt_hoten.Text = "Chưa đăng nhập";
                stt_thoigian.Text = " ";
               
                 i_dangnhap.Enabled = true;               
                i_dangxuat.Enabled = false;

                //i_dmChucVu.Enabled = false;
                //i_dmNhanVien.Enabled = false;
                //i_bangluong.Enabled = false;
                //i_quatrinhluong.Enabled = false;
            }

        }


        private void kếtNốiServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fKN == null || fKN.IsDisposed)
            {
                fKN = new frmKetNoi();
                fKN.MdiParent = this;
                fKN.Show();
            }
        }


        private void i_dangnhap_Click(object sender, EventArgs e)
        {
            if(kiemtraketnoi == true)
            {
                fDN = new frmDangNhap();
               

                if (fDN.ShowDialog() == DialogResult.OK)
                {
                  
                    string sTen = fDN.txtTen.Text;
                    MD5 md5Hash = MD5.Create();
                    string sMatKhau = GetMd5Hash(md5Hash, fDN.txtMatKhau.Text);

                    sr = new StreamReader(frmKetNoi.ns);
                    sw = new StreamWriter(frmKetNoi.ns);

                    chon = 7;
                    sw.WriteLine(chon);
                    sw.WriteLine(sTen);
                    sw.WriteLine(sMatKhau);
                    sw.Flush();
                    //lưu ý phải thêm w.Flush để đẩy dữ liệu đi

                    int kq = int.Parse(sr.ReadLine());
                    int loai = int.Parse(sr.ReadLine());
                    tennguoidung = sr.ReadLine();
                    //MessageBox.Show("KQ" + kq + " ten ND: "+ tennguoidung);
                    if (kq == 1)
                    {
                        kiemtradangnhap = true;
                        loaitaikhoan = loai;
                    }
                    else
                    {
                        kiemtradangnhap = false;
                    }
                }
                else
                {
                    kiemtradangnhap = false;
                }
                HienThiMenu();
            } 
            else
            {
                MessageBox.Show("Chưa kết nối server!");
            }    
            
        }

        static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        private void i_dangxuat_Click(object sender, EventArgs e)
        {
            // Đóng tất cả form đang mở
            foreach (Form f in this.MdiChildren)
            {
                if (!f.IsDisposed)
                    f.Close();
            }
            // Đăng xuất & thiết lập lại menu
            kiemtradangnhap = false;
            HienThiMenu();
        }


        private void i_Thuoc_Click_1(object sender, EventArgs e)
        {
            if (fCV == null || fCV.IsDisposed)
            {
                fCV = new frmThuoc();
                fCV.MdiParent = this;
                fCV.Show();
            }
        }

        private void i_BenhNhan_Click(object sender, EventArgs e)
        {
            if (fBN == null || fBN.IsDisposed)
            {
                fBN = new frmBenhNhan();
                fBN.MdiParent = this;
                fBN.Show();
            }
        }

        private void i_BacSi_Click(object sender, EventArgs e)
        {
            if (fBacSi == null || fBacSi.IsDisposed)
            {
                fBacSi = new frmBacSi();
                fBacSi.MdiParent = this;
                fBacSi.Show();
            }
        }
    }
}
