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
    public class BUSLoaiGa
    {
        static DALLoaiGa dalLoaiGa = new DALLoaiGa();

        public static DataTable showAll()
        {
            return dalLoaiGa.showAll();
        }

        public static bool Add(DTOLoaiGa lg)
        {
            return dalLoaiGa.Add(lg);
        }
        public static bool Edit(DTOLoaiGa lg)
        {
            return dalLoaiGa.Edit(lg);
        }
        public static bool Delete(string maLoai)
        {
            return dalLoaiGa.Delete(maLoai);
        }
    }
}
