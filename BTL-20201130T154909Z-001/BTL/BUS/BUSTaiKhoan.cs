using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUSTaiKhoan
    {
        static DALTaiKhoan dalTaiKhoan = new DALTaiKhoan();

        public static DataTable showAll()
        {
            return dalTaiKhoan.showAll();
        }

        public static bool Add(DTOTaiKhoan tk)
        {
            return dalTaiKhoan.Add(tk);
        }
        public static bool Edit(DTOTaiKhoan tk)
        {
            return dalTaiKhoan.Edit(tk);
        }
        public static bool Delete(string taiKhoan)
        {
            return dalTaiKhoan.Delete(taiKhoan);
        }
        public static DataTable TaiKhoan(string tk,string mk)
        {
            return dalTaiKhoan.TaiKhoan(tk,mk);
        }
        public static bool UpdateMK(string tk, string mk)
        {
            return dalTaiKhoan.UpdateMK(tk,mk);
        }
        public static DataTable CheckTaiKhoan_Email(string tk, string email)
        {
            return dalTaiKhoan.CheckTaiKhoan_Email(tk, email);
        }
    }
}
