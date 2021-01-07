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
    public class DALTaiKhoan
    {
        static DALGeneric dalGeneric = new DALGeneric();
        static DBConnect dBConnect = new DBConnect();
        SqlConnection conn = dBConnect.Connection();
        //Hiển thị tất cả sinh viên
        public DataTable showAll()
        {

            return dalGeneric.selectAll("TaiKhoan");
        }


        public bool Add(DTOTaiKhoan tk)
        {
            string insert = string.Format("insert into TaiKhoan (TaiKhoan,MatKhau,Status,Quyen,TenNguoiDung,Email) values ('{0}','{1}',{2},'{3}','{4}','{5}')", tk.TaiKhoan, tk.MatKhau, tk.Status,tk.Quyen,tk.TenNguoiDung,tk.Email);
            return dalGeneric.ExecuteNonQuery(insert);
        }

        public bool Edit(DTOTaiKhoan tk)
        {
            string update = string.Format("update  TaiKhoan set  MatKhau = '{0}', Status = {1}, Quyen = '{2}', TenNguoiDung = '{3}', Email = '{4}' where TaiKhoan = '{5}'", tk.MatKhau, tk.Status, tk.Quyen, tk.TenNguoiDung, tk.Email, tk.TaiKhoan);
            return dalGeneric.ExecuteNonQuery(update);
        }

        public bool Delete(string taiKhoan)
        {
            string delete = string.Format("delete from  TaiKhoan where TaiKhoan = '{0}'", taiKhoan);
            return dalGeneric.ExecuteNonQuery(delete);
        }

        public DataTable TaiKhoan(string tk,string mk)
        {

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TaiKhoan where TaiKhoan = '" + tk + "' and MatKhau = '"+ mk +"' and status =" + "1", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool UpdateMK(string tk, string mk)
        {
            string update = string.Format("update  TaiKhoan set  MatKhau = '{0}' where TaiKhoan = '{1}'", mk, tk);
            return dalGeneric.ExecuteNonQuery(update);
        }
        public DataTable CheckTaiKhoan_Email(string tk, string email)
        {

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TaiKhoan where TaiKhoan = '" + tk + "' and Email = '" + email + "' and status = 1", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
