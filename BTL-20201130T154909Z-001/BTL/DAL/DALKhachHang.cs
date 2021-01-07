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
    public class DALKhachHang
    {
        static DALGeneric dalGeneric = new DALGeneric();
        #region
        //Hiển thị tất cả sinh viên
        /*public DataTable showAll()
        {
            return dalGeneric.selectAll("KhachHang");
        }
        //Thêm sinh viên
        public bool Add(DTOKhachHang kh)
        {
            string insert = string.Format("insert into KhachHang (MaKH,TenKH,DiaChi,DienThoai) values ('{0}','{1}','{2}','{3}')",
                kh.MaKH, kh.TenKH,kh.DiaChi,kh.DienThoai);
            return dalGeneric.ExecuteNonQuery(insert);
        }
        public bool Edit(DTOKhachHang kh)
        {
            string update = string.Format("update  KhachHang set  TenKH = '{0}', DiaChi = '{1}', DienThoai = '{2}' where MaKH = '{3}'", 
                kh.TenKH,kh.DiaChi,kh.DienThoai,kh.MaKH);
            return dalGeneric.ExecuteNonQuery(update);
        }

        public bool Delete(string kh)
        {
            string delete = string.Format("delete from  KhachHang where MaKH = '{0}'", kh);
            return dalGeneric.ExecuteNonQuery(delete);
        }*/
        #endregion
        public DataTable showAll()
        {
            return dalGeneric.selectAllProc("showAllKhachHang");
        }
 

        public bool Add(DTOKhachHang kh)
        {
            SqlParameter[] sqlP = new SqlParameter[4];
            sqlP[0] = new SqlParameter("@MaKH", kh.MaKH);
            sqlP[1] = new SqlParameter("@TenKH", kh.TenKH);
            sqlP[2] = new SqlParameter("@DiaChi", kh.DiaChi);
            sqlP[3] = new SqlParameter("@DienThoai", kh.DienThoai);
            return dalGeneric.execNonQuery("insertKH", sqlP);
        }
        public bool Edit(DTOKhachHang kh)
        {
            SqlParameter[] sqlP = new SqlParameter[4];
            sqlP[0] = new SqlParameter("@MaKH", kh.MaKH);
            sqlP[1] = new SqlParameter("@TenKH", kh.TenKH);
            sqlP[2] = new SqlParameter("@DiaChi", kh.DiaChi);
            sqlP[3] = new SqlParameter("@DienThoai", kh.DienThoai);
            return dalGeneric.execNonQuery("updateKhachHang", sqlP);
        }

        public bool Delete(string kh)
        {
            SqlParameter[] sqlP = new SqlParameter[1];
            sqlP[0] = new SqlParameter("@MaKH", kh);
           
            return dalGeneric.execNonQuery("deleteKhachHang", sqlP);
        }


    }
}
