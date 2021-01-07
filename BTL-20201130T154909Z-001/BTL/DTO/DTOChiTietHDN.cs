using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOChiTietHDN
    {
        string soHDN;
        string maBinh;
        int soLuong;
        long donGia;
        int giamGia;
        long thanhTien;
        private string text;
        private string v1;
        private int v2;
        private int v3;
        private long v4;

        public DTOChiTietHDN()
        {
        }

        

        public DTOChiTietHDN(string soHDN, string maBinh, int soLuong, long donGia, int giamGia, long thanhTien)
        {
            this.soHDN = soHDN;
            this.maBinh = maBinh;
            this.soLuong = soLuong;
            this.donGia = donGia;
            this.giamGia = giamGia;
            this.thanhTien = thanhTien;
        }

        public string SoHDN { get => soHDN; set => soHDN = value; }
        public string MaBinh { get => maBinh; set => maBinh = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public long DonGia { get => donGia; set => donGia = value; }
        public int GiamGia { get => giamGia; set => giamGia = value; }
        public long ThanhTien { get => thanhTien; set => thanhTien = value; }
    }
}
