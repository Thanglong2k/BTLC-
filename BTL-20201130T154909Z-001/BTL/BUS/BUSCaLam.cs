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
    public class BUSCaLam
    {
        static DALCaLam dalCaLam = new DALCaLam();

        public static DataTable showAll()
        {
            return dalCaLam.showAll();
        }

        public static bool Add(DTOCaLam cl)
        {
            return dalCaLam.Add(cl);
        }
        public static bool Edit(DTOCaLam cl)
        {
            return dalCaLam.Edit(cl);
        }
        public static bool Delete(string maCL)
        {
            return dalCaLam.Delete(maCL);
        }
        
    }
}
