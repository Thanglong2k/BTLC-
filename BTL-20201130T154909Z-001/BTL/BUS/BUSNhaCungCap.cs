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
    public class BUSNhaCungCap
    {
        static DALNhaCungCap dalNhaCungCap = new DALNhaCungCap();

        public static DataTable showAll()
        {
            return dalNhaCungCap.showAll();
        }

        public static bool Add(DTONhaCungCap ncc)
        {
            return dalNhaCungCap.Add(ncc);
        }
        public static bool Edit(DTONhaCungCap ncc)
        {
            return dalNhaCungCap.Edit(ncc);
        }
        public static bool Delete(string ncc)
        {
            return dalNhaCungCap.Delete(ncc);
        }
    }
}
