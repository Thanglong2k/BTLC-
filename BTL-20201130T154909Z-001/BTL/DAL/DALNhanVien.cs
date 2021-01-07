using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DALNhanVien
    {
        static DALGeneric dalGeneric = new DALGeneric();
        #region
        //Hiển thị tất cả sinh viên
        /*public DataTable showAll()
        {
            return dalGeneric.selectAll("NhanVien");
        }
        //Thêm sinh viên
        public bool Add(DTONhanVien nv)
        {
            string insert = string.Format("insert into NhanVien (MaNV,TenNV,GioiTinh,NgaySinh,DienThoai,DiaChi,MaCa,MaCV) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')",
                    nv.MaNV, nv.TenNV, nv.GioiTinh, nv.NgaySinh, nv.DienThoai, nv.DiaChi, nv.MaCa, nv.MaCV);
            return dalGeneric.ExecuteNonQuery(insert);
        }

        public bool Edit(DTONhanVien nv)
        {
            
            string update = string.Format("update  NhanVien set  TenNV = '{0}', GioiTinh = '{1}', NgaySinh = '{2}', DienThoai = '{3}', DiaChi = '{4}', MaCa = {5}, MaCV = '{6}' where MaNV = '{7}'",
                   nv.TenNV, nv.GioiTinh, nv.NgaySinh, nv.DienThoai, nv.DiaChi, nv.MaCa, nv.MaCV, nv.MaNV);
               
            return dalGeneric.ExecuteNonQuery(update);
        }

        public bool Delete(string maNV)
        {             
            string delete = string.Format("delete from  NhanVien where MaNV = '{0}'", maNV);                
            return dalGeneric.ExecuteNonQuery(delete);
        }*/
        #endregion
        public DataSet NVBanItNhat(string maNV)
        {
            SqlParameter[] sql = new SqlParameter[1];
            sql[0] = new SqlParameter("@MaNV",maNV);
            return dalGeneric.rpDataset("SP_NV",sql);
        }
        public DataTable showAll()
        {
            return dalGeneric.selectAllProc("showAllNhanVien");
        }
        //Thêm sinh viên
        public bool Add(DTONhanVien nv)
        {
            SqlParameter[] sqlP = new SqlParameter[8];
            sqlP[0] = new SqlParameter("@MaNV", nv.MaNV);
            sqlP[1] = new SqlParameter("@TenNV", nv.TenNV);
            sqlP[2] = new SqlParameter("@GioiTinh", nv.GioiTinh);
            sqlP[3] = new SqlParameter("@NgaySinh", nv.NgaySinh);
            sqlP[4] = new SqlParameter("@DiaChi", nv.DiaChi);
            sqlP[5] = new SqlParameter("@DienThoai", nv.DienThoai);
            sqlP[6] = new SqlParameter("@MaCa", nv.MaCa);
            sqlP[7] = new SqlParameter("@MaCV", nv.MaCV);
            return dalGeneric.execNonQuery("insertNhanVien", sqlP);
        }

        public bool Edit(DTONhanVien nv)
        {

            SqlParameter[] sqlP = new SqlParameter[8];
            sqlP[0] = new SqlParameter("@MaNV", nv.MaNV);
            sqlP[1] = new SqlParameter("@TenNV", nv.TenNV);
            sqlP[2] = new SqlParameter("@GioiTinh", nv.GioiTinh);
            sqlP[3] = new SqlParameter("@NgaySinh", nv.NgaySinh);
            sqlP[4] = new SqlParameter("@DiaChi", nv.DiaChi);
            sqlP[5] = new SqlParameter("@DienThoai", nv.DienThoai);
            sqlP[6] = new SqlParameter("@MaCa", nv.MaCa);
            sqlP[7] = new SqlParameter("@MaCV", nv.MaCV);
            return dalGeneric.execNonQuery("updateNhanVien", sqlP);
        }

        public bool Delete(string maNV)
        {
            SqlParameter[] sqlP = new SqlParameter[1];
            sqlP[0] = new SqlParameter("@MaNV", maNV);
            
            return dalGeneric.execNonQuery("deleteNhanVien", sqlP);
        }
    }
}
