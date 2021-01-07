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
    public class BUSKhachHang
    {
        static DALKhachHang dalKhachHang = new DALKhachHang();

        public static DataTable showAll()
        {
            return dalKhachHang.showAll();
        }

        public static bool Add(DTOKhachHang kh)
        {
            return dalKhachHang.Add(kh);
        }
        public static bool Edit(DTOKhachHang kh)
        {
            return dalKhachHang.Edit(kh);
        }
        public static bool Delete(string kh)
        {
            return dalKhachHang.Delete(kh);
        }
    }
}
