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
    public class DALNuocSX
    {
        static DALGeneric dalGeneric = new DALGeneric();

        //Hiển thị tất cả sinh viên
        public DataTable showAll()
        {
            return dalGeneric.selectAllProc("showAllNSX");
        }
        //Thêm sinh viên
        public bool Add(DTONuocSX nsx)
        {
            SqlParameter[] sqlP = new SqlParameter[2];
            sqlP[0] = new SqlParameter("@MaNSX", nsx.MaNSX);
            sqlP[1] = new SqlParameter("@TenNSX", nsx.TenNSX);

            return dalGeneric.execNonQuery("insertNSX", sqlP);
        }

        public bool Edit(DTONuocSX nsx)
        {
            SqlParameter[] sqlP = new SqlParameter[2];
            sqlP[0] = new SqlParameter("@MaNSX", nsx.MaNSX);
            sqlP[1] = new SqlParameter("@TenNSX", nsx.TenNSX);

            return dalGeneric.execNonQuery("updateNuocSX", sqlP);
        }

        public bool Delete(string maNSX)
        {
            SqlParameter[] sqlP = new SqlParameter[1];
            sqlP[0] = new SqlParameter("@MaNSX", maNSX);
            

            return dalGeneric.execNonQuery("deleteNuocSX", sqlP);
        }
    }
}
