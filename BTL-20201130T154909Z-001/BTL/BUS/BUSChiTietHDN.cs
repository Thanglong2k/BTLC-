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
    public class BUSChiTietHDN
    {
        static DALChiTietHDN dalChiTietHDN = new DALChiTietHDN();

        public static DataTable showAll()
        {
            return dalChiTietHDN.showAll();
        }

        public static bool Add(DTOChiTietHDN cthdn)
        {
            return dalChiTietHDN.Add(cthdn);
        }
        public static bool Edit(DTOChiTietHDN cthdn)
        {
            return dalChiTietHDN.Edit(cthdn);
        }
        public static bool Delete(string soHDN,string MaBinh)
        {
            return dalChiTietHDN.Delete(soHDN,MaBinh);
        }
    }
}
