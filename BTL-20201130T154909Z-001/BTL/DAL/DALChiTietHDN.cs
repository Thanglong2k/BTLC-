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
    public class DALChiTietHDN
    {
        static DALGeneric dalGeneric = new DALGeneric();


        //Hiển thị tất cả sinh viên
        /*public DataTable showAll()
        {
            return dalGeneric.selectAll("ChiTietHDN");
        }
        //Thêm sinh viên
        public bool Add(DTOChiTietHDN cthdn)
        {
            string insert = string.Format("insert into ChiTietHDN (SoHDN,MaBinh,SoLuong,DonGia,GiamGia,ThanhTien) values ('{0}','{1}',{2},{3},{4},{5})",
                cthdn.SoHDN, cthdn.MaBinh, cthdn.SoLuong, cthdn.DonGia, cthdn.GiamGia, cthdn.ThanhTien);
            return dalGeneric.ExecuteNonQuery(insert);
        }*/

        public DataTable showAll()
        {
            return dalGeneric.selectAllProc("showAllCTHDN");
        }
        //Thêm sinh viên
        public bool Add(DTOChiTietHDN cthdn)
        {

            SqlParameter[] sqlP = new SqlParameter[6];
            sqlP[0] = new SqlParameter("@SoHDN", cthdn.SoHDN);
            sqlP[1] = new SqlParameter("@MaBinh", cthdn.MaBinh);
            sqlP[2] = new SqlParameter("@SoLuong", cthdn.SoLuong);
            sqlP[3] = new SqlParameter("@DonGia", cthdn.DonGia);
            sqlP[4] = new SqlParameter("@GiamGia", cthdn.GiamGia);
            sqlP[5] = new SqlParameter("@ThanhTien", cthdn.ThanhTien);
            return dalGeneric.execNonQuery("insertCTHDN", sqlP);
        }
        public bool Edit(DTOChiTietHDN cthdn)
        {

            SqlParameter[] sqlP = new SqlParameter[6];
            sqlP[0] = new SqlParameter("@SoHDN", cthdn.SoHDN);
            sqlP[1] = new SqlParameter("@MaBinh", cthdn.MaBinh);
            sqlP[2] = new SqlParameter("@SoLuong", cthdn.SoLuong);
            sqlP[3] = new SqlParameter("@DonGia", cthdn.DonGia);
            sqlP[4] = new SqlParameter("@GiamGia", cthdn.GiamGia);
            sqlP[5] = new SqlParameter("@ThanhTien", cthdn.ThanhTien);
            return dalGeneric.execNonQuery("updateCTHDN", sqlP);
        }
        public bool Delete(string soHDN,string MaBinh)
        {

            SqlParameter[] sqlP = new SqlParameter[2];
            sqlP[0] = new SqlParameter("@SoHDN", soHDN);
            sqlP[1] = new SqlParameter("@MaBinh", MaBinh);
            return dalGeneric.execNonQuery("deleteCTHDN", sqlP);
        }
    }
}
