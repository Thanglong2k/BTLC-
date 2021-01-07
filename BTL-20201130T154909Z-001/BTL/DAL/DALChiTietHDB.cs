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
    public class DALChiTietHDB
    {
        static DALGeneric dalGeneric = new DALGeneric();

        //Hiển thị tất cả sinh viên
        /*public DataTable showAll()
        {
            return dalGeneric.selectAll("ChiTietHDB");
        }*/
        //Thêm sinh viên
        /*public bool Add(DTOChiTietHDB cthdb)
        {
            string insert = string.Format("insert into ChiTietHDB (SoHDB,MaBinh,SoLuong,GiamGia,ThanhTien) values ('{0}','{1}',{2},{3},{4})",
                cthdb.SoHDB, cthdb.MaBinh, cthdb.SoLuong, cthdb.GiamGia, cthdb.ThanhTien);
            return dalGeneric.ExecuteNonQuery(insert);
        }*/

        public DataTable showAll()
        {
            return dalGeneric.selectAllProc("showAllCTHDB");
        }
        public DataTable showAllBySHD()
        {
            return dalGeneric.selectAllProc("showAllBySHDCTHDB");
        }
        //Thêm sinh viên
        public bool Add(DTOChiTietHDB cthdb)
        {

            SqlParameter[] sqlP = new SqlParameter[5];
            sqlP[0] = new SqlParameter("@SoHDB", cthdb.SoHDB);
            sqlP[1] = new SqlParameter("@MaBinh", cthdb.MaBinh);
            sqlP[2] = new SqlParameter("@SoLuong", cthdb.SoLuong);
            sqlP[3] = new SqlParameter("@GiamGia", cthdb.GiamGia);
            sqlP[4] = new SqlParameter("@ThanhTien", cthdb.ThanhTien);
            return dalGeneric.execNonQuery("insertCTHDB", sqlP);
        }
        public bool Edit(DTOChiTietHDB cthdb)
        {

            SqlParameter[] sqlP = new SqlParameter[5];
            sqlP[0] = new SqlParameter("@SoHDB", cthdb.SoHDB);
            sqlP[1] = new SqlParameter("@MaBinh", cthdb.MaBinh);
            sqlP[2] = new SqlParameter("@SoLuong", cthdb.SoLuong);
            sqlP[3] = new SqlParameter("@GiamGia", cthdb.GiamGia);
            sqlP[4] = new SqlParameter("@ThanhTien", cthdb.ThanhTien);
            return dalGeneric.execNonQuery("updateCTHDB", sqlP);
        }
        public bool Delete(string soHDB,string MaBinh)
        {

            SqlParameter[] sqlP = new SqlParameter[2];
            sqlP[0] = new SqlParameter("@SoHDB", soHDB);
            sqlP[1] = new SqlParameter("@MaBinh", MaBinh);

            return dalGeneric.execNonQuery("deleteCTHDB", sqlP);
        }
    }
}
