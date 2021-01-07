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
    public class BUSHDBan
    {
        static DALHDBan dalHDBan = new DALHDBan();

        public static DataTable showAll()
        {
            return dalHDBan.showAll();
        }

        public static bool Add(DTOHDBan hdb)
        {
            return dalHDBan.Add(hdb);
        }
        public static bool Edit(DTOHDBan hdb)
        {
            return dalHDBan.Edit(hdb);
        }
        public static bool Delete(string soHDB)
        {
            return dalHDBan.Delete(soHDB);
        }

    }
}
