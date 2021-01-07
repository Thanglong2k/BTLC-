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
    public class BUSChiTIetHDB
    {
        static DALChiTietHDB dalChiTietHDB = new DALChiTietHDB();

        public static DataTable showAll()
        {
            return dalChiTietHDB.showAll();
        }
        public static DataTable showAllBySHD()
        {
            return dalChiTietHDB.showAllBySHD();
        }
        public static bool Add(DTOChiTietHDB cthdb)
        {
            return dalChiTietHDB.Add(cthdb);
        }
        public static bool Edit(DTOChiTietHDB cthdb)
        {
            return dalChiTietHDB.Edit(cthdb);
        }
        public static bool Delete(string soHDB,string MaBinh)
        {
            return dalChiTietHDB.Delete(soHDB, MaBinh);
        }

    }
}
