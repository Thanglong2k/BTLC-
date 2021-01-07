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
    public class DALKhoiLuong
    {
        static DALGeneric dalGeneric = new DALGeneric();

        //Hiển thị tất cả sinh viên
        public DataTable showAll()
        {
            return dalGeneric.selectAllProc("showAllKhoiLuong");
        }
        //Thêm sinh viên
        public bool Add(DTOKhoiLuong kl)
        {
            SqlParameter[] sqlP = new SqlParameter[1];
            sqlP[0] = new SqlParameter("@MaKL", kl.MaKL);


            return dalGeneric.execNonQuery("insertKhoiLuong", sqlP);
        }


        public bool Delete(int maKL)
        {
            SqlParameter[] sqlP = new SqlParameter[1];
            sqlP[0] = new SqlParameter("@MaKL", maKL);


            return dalGeneric.execNonQuery("deleteKhoiLuong", sqlP);
        }
    }
}
