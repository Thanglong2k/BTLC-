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
    public class BUSNhanVien
    {
        static DALNhanVien dalNhanVien = new DALNhanVien();

        public static DataTable showAll()
        {
            return dalNhanVien.showAll();
        }

        public static bool Add(DTONhanVien nv)
        {
            return dalNhanVien.Add(nv);
        }
        public static bool Edit(DTONhanVien nv)
        {
            return dalNhanVien.Edit(nv);
        }
        public static bool Delete(string maNV)
        {
            return dalNhanVien.Delete(maNV);
        }
        public static DataSet NVBanItNhat(string maNV)
        {
            return dalNhanVien.NVBanItNhat(maNV);
        }
    }
}
