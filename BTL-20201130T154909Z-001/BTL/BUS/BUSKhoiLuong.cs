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
    public class BUSKhoiLuong
    {
        static DALKhoiLuong dalKhoiLuong = new DALKhoiLuong();

        public static DataTable showAll()
        {
            return dalKhoiLuong.showAll();
        }

        public static bool Add(DTOKhoiLuong kl)
        {
            return dalKhoiLuong.Add(kl);
        }
        public static bool Delete(int maKL)
        {
            return dalKhoiLuong.Delete(maKL);
        }
    }
}
