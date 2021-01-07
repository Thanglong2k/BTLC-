using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOBinhGa
    {
        string maBinh;
        string tenBinh;
        string maLoai;
        string maMau;
        int maKL;
        string maNSX;
        int soLuong;
        long donGiaNhap;
        long donGiaBan;
        int thoiGianBH;
        byte[] anh;
        string ghiChu;

        public DTOBinhGa()
        {
        }

        public DTOBinhGa(string maBinh, string tenBinh, string maLoai, string maMau,
            int maKL, string maNSX, int soLuong, long donGiaNhap, long donGiaBan, 
            int thoiGianBH, byte[] anh, string ghiChu)
        {
            this.maBinh = maBinh;
            this.tenBinh = tenBinh;
            this.maLoai = maLoai;
            this.maMau = maMau;
            this.maKL = maKL;
            this.maNSX = maNSX;
            this.soLuong = soLuong;
            this.donGiaNhap = donGiaNhap;
            this.donGiaBan = donGiaBan;
            this.thoiGianBH = thoiGianBH;
            this.anh = anh;
            this.ghiChu = ghiChu;
        }

        public string MaBinh { get => maBinh; set => maBinh = value; }
        public string TenBinh { get => tenBinh; set => tenBinh = value; }
        public string MaLoai { get => maLoai; set => maLoai = value; }
        public string MaMau { get => maMau; set => maMau = value; }
        public int MaKL { get => maKL; set => maKL = value; }
        public string MaNSX { get => maNSX; set => maNSX = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public long DonGiaNhap { get => donGiaNhap; set => donGiaNhap = value; }
        public long DonGiaBan { get => donGiaBan; set => donGiaBan = value; }
        public int ThoiGianBH { get => thoiGianBH; set => thoiGianBH = value; }
        public byte[] Anh { get => anh; set => anh = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
    }
}
