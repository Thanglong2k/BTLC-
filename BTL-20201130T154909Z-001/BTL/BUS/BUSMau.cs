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
    public class BUSMau
    {
        static DALMau dalMau = new DALMau();

        public static DataTable showAll()
        {
            return dalMau.showAll();
        }

        public static bool Add(DTOMau m)
        {
            return dalMau.Add(m);
        }
        public static bool Edit(DTOMau m)
        {
            return dalMau.Edit(m);
        }
        public static bool Delete(string maMau)
        {
            return dalMau.Delete(maMau);
        }
    }
}
