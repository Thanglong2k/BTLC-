using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALReport
    {
        DALGeneric dalGeneric = new DALGeneric();
        DBConnect dBConnect = new DBConnect();
        public DataSet HD_TTN_NCC(string maNCC,int thang,int nam)
        {
            SqlParameter[] sql = new SqlParameter[3];
            sql[0] = new SqlParameter("@MaNCC", maNCC);
            sql[1] = new SqlParameter("@Thang", thang);
            sql[2] = new SqlParameter("@Nam", nam);
            return dalGeneric.rpDataset("HD_TTN_NCC", sql);
        }

        public DataSet DoanhThu_Thang(int thang, int nam)
        {
            SqlParameter[] sql = new SqlParameter[2];
            sql[0] = new SqlParameter("@Thang", thang);
            sql[1] = new SqlParameter("@Nam", nam);
            return dalGeneric.rpDataset("DoanhThu_Thang", sql);
        }
        public DataSet KH_Thang(int thang, int nam)
        {
            SqlParameter[] sql = new SqlParameter[2];
            sql[0] = new SqlParameter("@Thang", thang);
            sql[1] = new SqlParameter("@Nam", nam);
            return dalGeneric.rpDataset("KH_Thang", sql);
        }
        public DataTable selectAllNam(string nameTB,string ngay)
        {

            SqlConnection Conn = dBConnect.Connection();
            SqlDataAdapter da = new SqlDataAdapter("SELECT distinct Year("+ngay+") as Nam FROM "+nameTB, Conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
