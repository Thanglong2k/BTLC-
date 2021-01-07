using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOChiTietHDB
    {
        string soHDB;
        string maBinh;
        int soLuong;
        int giamGia;
        long thanhTien;

        public DTOChiTietHDB()
        {
        }

        public DTOChiTietHDB(string soHDB, string maBinh, int soLuong, int giamGia, long thanhTien)
        {
            this.soHDB = soHDB;
            this.maBinh = maBinh;
            this.soLuong = soLuong;
            this.giamGia = giamGia;
            this.thanhTien = thanhTien;
        }

        public string SoHDB { get => soHDB; set => soHDB = value; }
        public string MaBinh { get => maBinh; set => maBinh = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int GiamGia { get => giamGia; set => giamGia = value; }
        public long ThanhTien { get => thanhTien; set => thanhTien = value; }
    }
}
