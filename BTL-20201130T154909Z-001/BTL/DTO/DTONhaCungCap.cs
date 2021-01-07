using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTONhaCungCap
    {
        string maNCC;
        string tenNCC;
        string diaChi;
        string dienThoai;

        public DTONhaCungCap()
        {
        }

        public DTONhaCungCap(string maNCC, string tenNCC, string diaChi, string dienThoai)
        {
            this.maNCC = maNCC;
            this.tenNCC = tenNCC;
            this.diaChi = diaChi;
            this.dienThoai = dienThoai;
        }

        public string MaNCC { get => maNCC; set => maNCC = value; }
        public string TenNCC { get => tenNCC; set => tenNCC = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string DienThoai { get => dienThoai; set => dienThoai = value; }
    }
}
