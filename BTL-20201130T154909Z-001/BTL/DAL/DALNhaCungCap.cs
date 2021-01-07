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
    public class DALNhaCungCap
    {
        static DALGeneric dalGeneric = new DALGeneric();
        #region
        //Hiển thị tất cả sinh viên
        /*public DataTable showAll()
        {
            return dalGeneric.selectAll("NhaCungCap");
        }
        //Thêm sinh viên
        public bool Add(DTONhaCungCap cc)
        {
            string insert = string.Format("insert into NhaCungCap (MaNCC,TenNCC,DiaChi,DienThoai) values ('{0}','{1}','{2}','{3}')",
                cc.MaNCC, cc.TenNCC, cc.DiaChi, cc.DienThoai);
            return dalGeneric.ExecuteNonQuery(insert);
        }
        public bool Edit(DTONhaCungCap cc)
        {
            string update = string.Format("update  NhaCungCap set  TenNCC = '{0}',DiaChi = '{1}',DienThoai = '{2}' where MaNCC = '{3}'", cc.TenNCC, cc.DiaChi, cc.DienThoai, cc.MaNCC);
            return dalGeneric.ExecuteNonQuery(update);
        }

        public bool Delete(string ncc)
        {
            string delete = string.Format("delete from  NhaCungCap where MaNCC = '{0}'", ncc);
            return dalGeneric.ExecuteNonQuery(delete);
        }*/
        #endregion
        public DataTable showAll()
        {
            return dalGeneric.selectAllProc("showAllNCC");
        }
        //Thêm sinh viên
        public bool Add(DTONhaCungCap ncc)
        {
            SqlParameter[] sqlP = new SqlParameter[4];
            sqlP[0] = new SqlParameter("@MaNCC", ncc.MaNCC);
            sqlP[1] = new SqlParameter("@TenNCC", ncc.TenNCC);
            sqlP[2] = new SqlParameter("@DiaChi", ncc.DiaChi);
            sqlP[3] = new SqlParameter("@DienThoai", ncc.DienThoai);
            return dalGeneric.execNonQuery("insertNCC", sqlP);
        }
        public bool Edit(DTONhaCungCap ncc)
        {
            SqlParameter[] sqlP = new SqlParameter[4];
            sqlP[0] = new SqlParameter("@MaNCC", ncc.MaNCC);
            sqlP[1] = new SqlParameter("@TenNCC", ncc.TenNCC);
            sqlP[2] = new SqlParameter("@DiaChi", ncc.DiaChi);
            sqlP[3] = new SqlParameter("@DienThoai", ncc.DienThoai);
            return dalGeneric.execNonQuery("updateNhaCungCap", sqlP);
        }

        public bool Delete(string ncc)
        {
            SqlParameter[] sqlP = new SqlParameter[1];
            sqlP[0] = new SqlParameter("@MaNCC", ncc);
            
            return dalGeneric.execNonQuery("deleteNhaCungCap", sqlP);
        }
    }
}
