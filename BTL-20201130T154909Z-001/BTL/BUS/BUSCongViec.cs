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
    public class BUSCongViec
    {
        static DAlCongViec dalCongViec = new DAlCongViec();

        public static DataTable showAll()
        {
            return dalCongViec.showAll();
        }

        public static bool Add(DTOCongViec cv)
        {
            return dalCongViec.Add(cv);
        }
        public static bool Edit(DTOCongViec cv)
        {
            return dalCongViec.Edit(cv);
        }
        public static bool Delete(string maCV)
        {
            return dalCongViec.Delete(maCV);
        }
    }
}
