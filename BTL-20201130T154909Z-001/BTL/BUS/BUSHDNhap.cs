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
    public class BUSHDNhap
    {
        static DALHDNhap dalHDNhap = new DALHDNhap();

        public static DataTable showAll()
        {
            return dalHDNhap.showAll();
        }
        public static DataTable showAllHDN_CTHDN()
        {
            return dalHDNhap.showAllHDN_CTHDN();
        }
        public static bool Add(DTOHDNhap hdn)
        {
            return dalHDNhap.Add(hdn);
        }
        public static bool Edit(DTOHDNhap hdn)
        {
            return dalHDNhap.Edit(hdn);
        }
        public static bool Delete(string soHDN)
        {
            return dalHDNhap.Delete(soHDN);
        }

    }
}
