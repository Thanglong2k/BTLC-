using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOHDNhap
    {
        string soHDN;
        string maNV;
        DateTime ngayNhap;
        string maNCC;
        long tongTien;

        public DTOHDNhap(string soHDN, string maNV, DateTime ngayNhap, string maNCC, long tongTien)
        {
            this.soHDN = soHDN;
            this.maNV = maNV;
            this.ngayNhap = ngayNhap;
            this.maNCC = maNCC;
            this.tongTien = tongTien;
        }

        public string SoHDN { get => soHDN; set => soHDN = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public DateTime NgayNhap { get => ngayNhap; set => ngayNhap = value; }
        public string MaNCC { get => maNCC; set => maNCC = value; }
        public long TongTien { get => tongTien; set => tongTien = value; }
    }
}
