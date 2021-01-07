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
    public class DAlCongViec
    {
        static DALGeneric dalGeneric = new DALGeneric();

        #region
        //Hiển thị tất cả sinh viên
        /*public DataTable showAll()
        {
            return dalGeneric.selectAll("CongViec");
        }
        //Thêm sinh viên
        public bool Add(DTOCongViec cv)
        {
            string insert = string.Format("insert into CongViec (MaCV,TenCV) values ('{0}','{1}')", cv.MaCV, cv.TenCV);
            return dalGeneric.ExecuteNonQuery(insert);
        }

        public bool Edit(DTOCongViec cv)
        {
            string update = string.Format("update  CongViec set  TenCV = '{0}' where MaCV = '{1}'", cv.TenCV, cv.MaCV);
            return dalGeneric.ExecuteNonQuery(update);
        }

        public bool Delete(string maCV)
        {
            string delete = string.Format("delete from  CongViec where MaCV = '{0}'", maCV);
            return dalGeneric.ExecuteNonQuery(delete);
        }*/
        #endregion
        public DataTable showAll()
        {
            return dalGeneric.selectAllProc("showAllCongViec");
        }
        //Thêm sinh viên
        public bool Add(DTOCongViec cv)
        {
            SqlParameter[] sqlP = new SqlParameter[2];
            sqlP[0] = new SqlParameter("@MaCV", cv.MaCV);
            sqlP[1] = new SqlParameter("@TenCV", cv.TenCV);

            return dalGeneric.execNonQuery("insertCongViec", sqlP);
        }

        public bool Edit(DTOCongViec cv)
        {
            SqlParameter[] sqlP = new SqlParameter[2];
            sqlP[0] = new SqlParameter("@MaCV", cv.MaCV);
            sqlP[1] = new SqlParameter("@TenCV", cv.TenCV);

            return dalGeneric.execNonQuery("updateCongViec", sqlP);
        }

        public bool Delete(string maCV)
        {
            SqlParameter[] sqlP = new SqlParameter[1];
            sqlP[0] = new SqlParameter("@MaCV", maCV);
            

            return dalGeneric.execNonQuery("deleteCongViec", sqlP);
        }
    }
}
