using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOHDBan
    {
        string soHDB;
        string maNV;
        DateTime ngayBan;
        string maKH;
        long tongTien;

        public DTOHDBan(string soHDB, string maNV, DateTime ngayBan, string maKH, long tongTien)
        {
            this.soHDB = soHDB;
            this.maNV = maNV;
            this.ngayBan = ngayBan;
            this.maKH = maKH;
            this.tongTien = tongTien;
        }

        public string SoHDB { get => soHDB; set => soHDB = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public DateTime NgayBan { get => ngayBan; set => ngayBan = value; }
        public string MaKH { get => maKH; set => maKH = value; }
        public long TongTien { get => tongTien; set => tongTien = value; }
    }
}
