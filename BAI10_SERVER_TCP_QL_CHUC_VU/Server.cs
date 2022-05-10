using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Data;
using System.Data.SqlClient;//Man abc

namespace BAI10_SERVER_TCP_QL_CHUC_VU
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }
        Socket server = null;
        Socket clientSock;
        NetworkStream ns;
        StreamReader sr;
        StreamWriter sw;

        string s;
        SqlConnection KetNoi;
        int chon = 0;
        int chon_loadform = 0;
        private void Server_Load(object sender, EventArgs e)
        {

        }
        public void MoKetNoi()
        {
         //   s = @"Data Source=DESKTOP-T84NIPD\MAYAO;Initial Catalog=QLNV;Integrated Security=True; User ID=sa;password=123456";
            s = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLPM;Integrated Security=True";

            //s = @"Data Source=MAY1\SQLEXPRESS;Initial Catalog=QLNV;Integrated Security=True";

            KetNoi = new SqlConnection(s);
            KetNoi.Open();
        }

        public static void DongKetNoi(SqlConnection KetNoi)
        {
            KetNoi.Close();
        }

        private void btn_start_server_Click(object sender, EventArgs e)
        {
            btn_start_server.Text = "In process...";
            Application.DoEvents();

            // biến ipEnd sẽ chứa địa chỉ ip của tiến trình server trên mạng
            IPEndPoint ipEnd = new IPEndPoint(IPAddress.Any, 2021);


            // server sử dụng đồng thời hai socket: 
            // một socket để chờ nghe kết nối, một socket để gửi/nhận dữ liệu

            // socket thứ nhất làm nhiệm vụ chờ kết nối từ Client
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            // server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            // yêu cầu hệ điều hành cho phép chiếm dụng cổng tcp 2021
            // server sẽ nghe trên tất cả các mạng mà máy tính này kết nối tới
            // chỉ cần gói tin tcp đến cổng 2021, tiến trình server sẽ nhận được
            server.Bind(ipEnd);
            server.Listen(100);

            //while này đảm server sẵn sàng nhận nhiều kết nối từ nhiều client và server chạy liên tục
            while(true)
            {
                //có thể tạo chuyển code trong while này sang class thread
                //để thực hiện TCP song song
                
                // Socket thứ hai làm nhiệm vụ gửi/nhận dữ liệu
                // socket này được tạo ra bởi lệnh Accept
                clientSock = server.Accept();

                //để gởi nhận dữ liệu giữa server và client có thể dùng lệnh clientSock.Send(data), clientSock.Receive(data); 
                //hoặc sử dụng luồng stream bằng lệnh NetworkStream ns = new NetworkStream(clientSock);
                
                //tạo các luồng truyền dữ liệu
                ns = new NetworkStream(clientSock);
                //tạo luồng đọc dữ liệu
                sr = new StreamReader(ns);
                //tạo luồng ghi dữ liệu
                sw = new StreamWriter(ns);

                //mở kết nối csdl sql server
                MoKetNoi();

                //while này duy trì liên tục phục vụ các yêu cầu liên tục
                //của 1 client như đăng nhập, thêm, cập nhật, xóa, tìm kiếm,....
                while (true)
                {
                    //nhận biến chọn từ client để xử lý các sự kiện như load dữ liệu, thêm, xóa, cập nhật 
                    chon = int.Parse(sr.ReadLine());
                  
                    //chọn = 1 là sự kiện khi client nhấn nút thêm
                    if (chon == 0)
                    {
                        //tạo datatable lấy dữ liệu từ sql server
                        DataTable table = getdataThuoc();

                        //chuyển datatable sang dạng mảng byte --> rồi gởi sang client
                        clientSock.Send(SerializeData(table));
                    }

                    //chọn = 1 là sự kiện khi client nhấn nút thêm
                    if (chon == 1)
                    {
                        //nhận macv, tencv, hspc từ client
                        string MaThuoc = sr.ReadLine();
                        string TenThuoc = sr.ReadLine();
                        string DonVi = sr.ReadLine();
                        int SoLuong = int.Parse(sr.ReadLine());
                        DateTime NSX = DateTime.Parse(sr.ReadLine());
                        DateTime HSD = DateTime.Parse(sr.ReadLine());
                        int GiaThuoc = int.Parse(sr.ReadLine());

                        DataTable table1 = themthuocdata(MaThuoc, TenThuoc, DonVi, SoLuong, NSX, HSD, GiaThuoc);

                        //chuyển datatable sang dạng mảng byte --> rồi gởi sang client
                        clientSock.Send(SerializeData(table1));
                    }

                    //chọn = 2 là sự kiện khi client nhấn nút xóa
                    if (chon == 2)
                    {
                        string MaThuoc = sr.ReadLine();

                        DataTable table2 = xoathuocdata(MaThuoc);

                        //chuyển datatable sang dạng mảng byte --> rồi gởi sang client
                        clientSock.Send(SerializeData(table2));

                    }

                    //chọn = 3 là sự kiện khi client nhấn nút cập nhật
                    if (chon == 3)
                    {
                        string MaThuoc = sr.ReadLine();
                        string TenThuoc = sr.ReadLine();
                        string DonVi = sr.ReadLine();
                        int SoLuong = int.Parse(sr.ReadLine());
                        DateTime NSX = DateTime.Parse(sr.ReadLine());
                        DateTime HSD = DateTime.Parse(sr.ReadLine());
                        int GiaThuoc = int.Parse(sr.ReadLine());

                        DataTable table3 = capnhatthuocdata(MaThuoc, TenThuoc, DonVi, SoLuong, NSX, HSD, GiaThuoc);

                        //chuyển datatable sang dạng mảng byte --> rồi gởi sang client
                        clientSock.Send(SerializeData(table3));
                    }

                    //chọn = 4 là sự kiện khi client nhấn nút tìm
                    if (chon == 4)
                    {
                        string TenThuoc = sr.ReadLine();

                        DataTable table1 = timtenthuocdata(TenThuoc);

                        //chuyển datatable sang dạng mảng byte --> rồi gởi sang client
                        clientSock.Send(SerializeData(table1));
                    }

                    //chọn = 5 tìm chức vụ theo macv
                    if (chon == 5)
                    {
                        string mathuoctim = sr.ReadLine();
                        int kq = timmathuocdata(mathuoctim);

                        sw.WriteLine(kq);
                        sw.Flush();
                    }


                    //chọn = 6 lấy danh sách chức vụ
                    if (chon == 6)
                    {
                        ////tạo datatable lấy dữ liệu table chức vụ từ sql server
                        //DataTable table6 = getdataThuoc();

                        ////chuyển datatable sang dạng mảng byte --> rồi gởi sang client
                        //clientSock.Send(SerializeData(table6));

                        //tạo datatable lấy dữ liệu table nhân viên từ sql server
                        DataTable table7 = getdataBenhNhan();

                        //chuyển datatable sang dạng mảng byte --> rồi gởi sang client
                        clientSock.Send(SerializeData(table7));

                    }

                    //chọn = 7 lấy danh sách nhân viên, kiểm tra đăng nhập
                    if (chon == 7)
                    {
                       
                        string tendangnhap = sr.ReadLine();
                        string matkhau = sr.ReadLine();
                      
                        int kq = kiemtradangnhap(tendangnhap, matkhau);

                        sw.WriteLine(kq);
                        sw.WriteLine(tendangnhap);
                        sw.Flush();

                    }
                }
            }    
            
            DongKetNoi(KetNoi);
            server.Close();
            clientSock.Close();
            btn_start_server.Text = "&Start Server";
            Application.DoEvents();
        }

        //chuyển datatable sang dạng mảng byte
        public byte[] SerializeData(Object o)
        {
            MemoryStream ms = new MemoryStream();
            BinaryFormatter bf1 = new BinaryFormatter();
            bf1.Serialize(ms, o);
            return ms.ToArray();
        }

        private DataTable getdataThuoc()
        {    
            string sTruyVan = "select * from Thuoc";  

            SqlDataAdapter da = new SqlDataAdapter(sTruyVan, KetNoi);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        private DataTable getdataBenhNhan()
        {
            string sTruyVan = "select * from BenhNhan";

            SqlDataAdapter da = new SqlDataAdapter(sTruyVan, KetNoi);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
        private DataTable themthuocdata(string MaThuoc, string TenThuoc, string DonVi, int SoLuong, DateTime NSX, DateTime HSD, int GiaThuoc)
        {
            bool kt = false;
            DataTable dt = new DataTable();
            string sTruyVan = string.Format(@"insert into Thuoc values(N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}')", MaThuoc, TenThuoc, DonVi, SoLuong, NSX, HSD, GiaThuoc);
            try
            {
                SqlCommand cm = new SqlCommand(sTruyVan, KetNoi);
                cm.ExecuteNonQuery();
                kt = true;
            }
            catch (Exception ex)
            {
                kt = false;
            }
            if(kt == true)
            {
                string sTruyVan2 = "select * from Thuoc";
                SqlDataAdapter da = new SqlDataAdapter(sTruyVan2, KetNoi);
                da.Fill(dt);               
            }            
            return dt;    
        }

        private DataTable xoathuocdata(string MaThuoc)
        {
            bool kt = false;
            DataTable dt2 = new DataTable();
            string sTruyVan1 = string.Format(@"delete from Thuoc where MaThuoc='{0}'", MaThuoc);
            //MessageBox.Show(sTruyVan1.ToString());
            try
            {
                SqlCommand cm = new SqlCommand(sTruyVan1, KetNoi);
                cm.ExecuteNonQuery();
                kt = true;
            }
            catch (Exception ex)
            {
                kt = false;
            }
            if (kt == true)
            {
                string sTruyVan2 = "select * from Thuoc";
                SqlDataAdapter da = new SqlDataAdapter(sTruyVan2, KetNoi);
                da.Fill(dt2);
            }
            return dt2;

        }

        private DataTable capnhatthuocdata(string MaThuoc, string TenThuoc, string DonVi, int SoLuong, DateTime NSX, DateTime HSD, int GiaThuoc)
        {
            bool kt = false;
            DataTable dt = new DataTable();
            string sTruyVan = string.Format(@"update Thuoc set TenThuoc=N'{0}',DonVi='{1}'',SoLuong='{2}'',NSX='{3}'',HSD='{4}'',GiaThuoc='{5}' where MaThuoc='{6}'", TenThuoc, DonVi, SoLuong, NSX, HSD, GiaThuoc, MaThuoc);  
            try
            {
                SqlCommand cm = new SqlCommand(sTruyVan, KetNoi);
                cm.ExecuteNonQuery();
                kt = true;
            }
            catch (Exception ex)
            {
                kt = false;
            }
            if (kt == true)
            {
                string sTruyVan2 = "select * from Thuoc";
                SqlDataAdapter da = new SqlDataAdapter(sTruyVan2, KetNoi);
                da.Fill(dt);
            }
            return dt;

        }
        private DataTable timtenthuocdata(string tenthuoctim)
        {
            bool kt = false;
            DataTable dt = new DataTable();
            string sTruyVan = string.Format(@"select * from Thuoc where TenThuoc like '%{0}%'", tenthuoctim);
            //MessageBox.Show("sql: "+sTruyVan);
            SqlDataAdapter da = new SqlDataAdapter(sTruyVan, KetNoi);
            da.Fill(dt);
            
            return dt;

        }

        private int timmathuocdata(string mathuoctim)
        {
            int kq = 1;
            DataTable dt = new DataTable();
            string sTruyVan = string.Format(@"select * from Thuoc where MaThuoc = '{0}'", mathuoctim);          
            SqlDataAdapter da = new SqlDataAdapter(sTruyVan, KetNoi);
            da.Fill(dt);
            
            int dem = dt.Rows.Count;
           // MessageBox.Show("so dong = "+dem);
            if (dem > 0)
                return 1;
            else
                return 0;
        }

        private int kiemtradangnhap(string tendangnhap, string matkhau)
        {
            int kq = 1;
            DataTable dt = new DataTable();
            string sTruyVan = string.Format(@"select * from Account where TenDangNhap = '{0}' and MatKhau = '{1}'", tendangnhap, matkhau);
            SqlDataAdapter da = new SqlDataAdapter(sTruyVan, KetNoi);
            da.Fill(dt);

            int dem = dt.Rows.Count;

            if (dem > 0)
                return 1;
            else
                return 0;
        }
        
    }
}
