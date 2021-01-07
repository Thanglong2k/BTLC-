using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUSReport
    {
        static DALReport dalReport = new DALReport();
        public static DataSet HD_TTN_NCC(string maNCC, int thang, int nam)
        {
            return dalReport.HD_TTN_NCC(maNCC, thang, nam);
        }
        public static DataSet DoanhThu_Thang(int thang, int nam)
        {
            return dalReport.DoanhThu_Thang(thang, nam);
        }

        public static DataSet KH_Thang(int thang, int nam)
        {
            return dalReport.KH_Thang(thang, nam);
        }
        public static DataTable selectAllNam(string nameTB,string ngay)
        {
            return dalReport.selectAllNam(nameTB,ngay);
        }
    }
}
