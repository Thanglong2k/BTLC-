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
    public class DALCaLam
    {
        static DALGeneric dalGeneric = new DALGeneric();
        static DBConnect dBConnect = new DBConnect();

        static SqlConnection Conn = dBConnect.Connection();
        //Hiển thị tất cả sinh viên
        public DataTable showAll()
        {
            return dalGeneric.selectAllProc("showAllCaLam");
        }
        //Thêm sinh viên
        public bool Add(DTOCaLam cl)
        {
            SqlParameter[] sqlP = new SqlParameter[2];
            sqlP[0] = new SqlParameter("@MaCa", cl.MaCa);
            sqlP[1] = new SqlParameter("@TenCa", cl.TenCa);
            return dalGeneric.execNonQuery("insertCaLam", sqlP);
        }

        public bool Edit(DTOCaLam cl)
        {
            SqlParameter[] sqlP = new SqlParameter[2];
            sqlP[0] = new SqlParameter("@MaCa", cl.MaCa);
            sqlP[1] = new SqlParameter("@TenCa", cl.TenCa);
            return dalGeneric.execNonQuery("updateCaLam", sqlP);
        }

        public bool Delete(string maCL)
        {
            SqlParameter[] sqlP = new SqlParameter[1];
            sqlP[0] = new SqlParameter("@MaCa", maCL);          
            return dalGeneric.execNonQuery("deleteCaLam", sqlP);
        }

       
    }
}
