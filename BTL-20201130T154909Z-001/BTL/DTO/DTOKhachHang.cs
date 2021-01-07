using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOKhachHang
    {
        string maKH;
        string tenKH;
        string diaChi;
        string dienThoai;

        public DTOKhachHang()
        {
        }

        public DTOKhachHang(string maKH, string tenKH, string diaChi, string dienThoai)
        {
            this.maKH = maKH;
            this.tenKH = tenKH;
            this.diaChi = diaChi;
            this.dienThoai = dienThoai;
        }

        public string MaKH { get => maKH; set => maKH = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string DienThoai { get => dienThoai; set => dienThoai = value; }
    }
}
