using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALHDNhap
    {
        static DALGeneric dalGeneric = new DALGeneric();

        //truy vấn phía client
        //Hiển thị tất cả sinh viên
        /*public DataTable showAll()
        {
            return dalGeneric.selectAll("HoaDonNhap");
        }
        public DataTable showAllHDN_CTHDN()
        {
            return dalGeneric.selectAllHDN_CTHDN("ShowAllHDN_CTHDN");
        }
        //Thêm sinh viên
        public bool Add(DTOHDNhap hdn)
        {
            string insert = string.Format("insert into HoaDonNhap (SoHDN,MaNV,NgayNhap,MaNCC,TongTien) values ('{0}','{1}','{2}','{3}',{4})",
                hdn.SoHDN, hdn.MaNV, hdn.NgayNhap, hdn.MaNCC, hdn.TongTien);
            return dalGeneric.ExecuteNonQuery(insert);
        }*/

        //truy vấn bằng thủ tục
        public DataTable showAll()
        {
            return dalGeneric.selectAllProc("showAllHDN");
        }
        public DataTable showAllHDN_CTHDN()
        {
            return dalGeneric.selectAllProc("ShowAllHDN_CTHDN");
        }
        //Thêm sinh viên
        public bool Add(DTOHDNhap hdn)
        {
            SqlParameter[] sqlP = new SqlParameter[5];
            sqlP[0] = new SqlParameter("@SoHDN", hdn.SoHDN);
            sqlP[1] = new SqlParameter("@MaNV", hdn.MaNV);
            sqlP[2] = new SqlParameter("@NgayNhap", hdn.NgayNhap);
            sqlP[3] = new SqlParameter("@MaNCC", hdn.MaNCC);
            sqlP[4] = new SqlParameter("@TongTien", hdn.TongTien);
            return dalGeneric.execNonQuery("insertHDN",sqlP);
        }
        public bool Edit(DTOHDNhap hdn)
        {
            SqlParameter[] sqlP = new SqlParameter[5];
            sqlP[0] = new SqlParameter("@SoHDN", hdn.SoHDN);
            sqlP[1] = new SqlParameter("@MaNV", hdn.MaNV);
            sqlP[2] = new SqlParameter("@NgayNhap", hdn.NgayNhap);
            sqlP[3] = new SqlParameter("@MaNCC", hdn.MaNCC);
            sqlP[4] = new SqlParameter("@TongTien", hdn.TongTien);
            return dalGeneric.execNonQuery("updateHDN", sqlP);
        }
        public bool Delete(string soHDN)
        {
            SqlParameter[] sqlP = new SqlParameter[1];
            sqlP[0] = new SqlParameter("@SoHDN", soHDN);
            
            return dalGeneric.execNonQuery("deleteHDN", sqlP);
        }
    }
}
