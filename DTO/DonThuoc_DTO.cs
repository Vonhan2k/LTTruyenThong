using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DonThuoc_DTO
    {
        private int idDonThuoc;

        public int IdDonThuoc
        {
            get { return idDonThuoc; }
            set { idDonThuoc = value; }
        }

        private string maThuoc;

        public string MaThuoc
        {
            get { return maThuoc; }
            set { maThuoc = value; }
        }

        private string tenThuoc;

        public string TenThuoc
        {
            get { return tenThuoc; }
            set { tenThuoc = value; }
        }

        private string cachDung;

        public string CachDung
        {
            get { return cachDung; }
            set { cachDung = value; }
        }

        private int slSang;

        public int SLSang
        {
            get { return slSang; }
            set { slSang = value; }
        }

        private int slTrua;

        public int SLTrua
        {
            get { return slTrua; }
            set { slTrua = value; }
        }

        private int slChieu;

        public int SLChieu
        {
            get { return slChieu; }
            set { slChieu = value; }
        }

        private int slToi;

        public int SLToi
        {
            get { return slToi; }
            set { slToi = value; }
        }

        public int tongTien;

        public int TongTien
        {
            get { return tongTien; }
            set { tongTien = value; }
        }

    }
}
