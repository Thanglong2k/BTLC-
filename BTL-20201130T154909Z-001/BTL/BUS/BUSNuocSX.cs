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
    public class BUSNuocSX
    {
        static DALNuocSX dalNuocSX = new DALNuocSX();

        public static DataTable showAll()
        {
            return dalNuocSX.showAll();
        }

        public static bool Add(DTONuocSX nsx)
        {
            return dalNuocSX.Add(nsx);
        }
        public static bool Edit(DTONuocSX nsx)
        {
            return dalNuocSX.Edit(nsx);
        }
        public static bool Delete(string maNSX)
        {
            return dalNuocSX.Delete(maNSX);
        }
    }
}
