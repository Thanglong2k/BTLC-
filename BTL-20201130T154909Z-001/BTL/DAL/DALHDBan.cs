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
    public class DALHDBan
    {
        static DALGeneric dalGeneric = new DALGeneric();
        //Hiển thị tất cả sinh viên
      /*  public DataTable showAll()
        {
            return dalGeneric.selectAll("HoaDonBan");
        }
        //Thêm sinh viên
        public bool Add(DTOHDBan hdb)
        {
            string insert = string.Format("insert into HoaDonBan (SoHDB,MaNV,NgayBan,MaKH,TongTien) values ('{0}','{1}','{2}','{3}',{4})",
                hdb.SoHDB, hdb.MaNV, hdb.NgayBan, hdb.MaKH, hdb.TongTien);
            return dalGeneric.ExecuteNonQuery(insert);
        }*/

        //dùng thủ tục
        public DataTable showAll()
        {          
            return dalGeneric.selectAllProc("showAllHDB");
        }
        //Thêm sinh viên
        public bool Add(DTOHDBan hdb)
        {
            SqlParameter[] sqlP = new SqlParameter[5];
            sqlP[0] = new SqlParameter("@SoHDB", hdb.SoHDB);
            sqlP[1] = new SqlParameter("@MaNV", hdb.MaNV);
            sqlP[2] = new SqlParameter("@NgayBan", hdb.NgayBan);
            sqlP[3] = new SqlParameter("@MaKH", hdb.MaKH);
            sqlP[4] = new SqlParameter("@TongTien", hdb.TongTien);
            return dalGeneric.execNonQuery("insertHDB", sqlP);
        }
        public bool Edit(DTOHDBan hdb)
        {
            SqlParameter[] sqlP = new SqlParameter[5];
            sqlP[0] = new SqlParameter("@SoHDB", hdb.SoHDB);
            sqlP[1] = new SqlParameter("@MaNV", hdb.MaNV);
            sqlP[2] = new SqlParameter("@NgayBan", hdb.NgayBan);
            sqlP[3] = new SqlParameter("@MaKH", hdb.MaKH);
            sqlP[4] = new SqlParameter("@TongTien", hdb.TongTien);
            return dalGeneric.execNonQuery("updateHDB", sqlP);
        }
        public bool Delete(string soHDB)
        {
            SqlParameter[] sqlP = new SqlParameter[1];
            sqlP[0] = new SqlParameter("@SoHDB", soHDB);

            return dalGeneric.execNonQuery("deleteHDB", sqlP);
        }
    }
}
