using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTONhanVien
    {
        string maNV;
        string tenNV;
        string gioiTinh;
        DateTime ngaySinh;
        string dienThoai;
        string diaChi;
        string maCa;
        string maCV;

        public DTONhanVien()
        {
        }

        public DTONhanVien(string maNV, string tenNV, string gioiTinh, DateTime ngaySinh, string dienThoai, string diaChi, string maCa, string maCV)
        {
            this.maNV = maNV;
            this.tenNV = tenNV;
            this.gioiTinh = gioiTinh;
            this.ngaySinh = ngaySinh;
            this.dienThoai = dienThoai;
            this.diaChi = diaChi;
            this.maCa = maCa;
            this.maCV = maCV;
        }

        public string MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string DienThoai { get => dienThoai; set => dienThoai = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string MaCa { get => maCa; set => maCa = value; }
        public string MaCV { get => maCV; set => maCV = value; }
    }
}
