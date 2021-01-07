using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Handling
{
    public class HandlingDateTime
    {
        public static string chuyendinhdang24h(string gio)
        {
            string h = "";
            switch (gio)
            {
                case "1":
                    h = "13";
                    break;
                case "2":
                    h = "14";
                    break;
                case "3":
                    h = "15";
                    break;
                case "4":
                    h = "16";
                    break;
                case "5":
                    h = "17";
                    break;
                case "6":
                    h = "18";
                    break;
                case "7":
                    h = "19";
                    break;
                case "8":
                    h = "20";
                    break;
                case "9":
                    h = "21";
                    break;
                case "10":
                    h = "22";
                    break;
                case "11":
                    h = "23";
                    break;
                case "12":
                    h = "0";
                    break;
            }
            return h;
        }
        public static string taochuoiDateTime(string tiento)
        {
            string chuoi = tiento;
            string[] Date;
            Date = DateTime.Now.ToShortDateString().Split('/');
            //Ví dụ 07/08/2009
            string day = String.Format("{0}{1}{2}", Date[1], Date[0], Date[2]);
            chuoi = chuoi + day;
            string[] Time;
            Time = DateTime.Now.ToLongTimeString().Split(':');
            //Ví dụ 7:08:03 PM hoặc 7:08:03 AM
            if (Time[2].Substring(3, 2) == "PM")
                Time[0] = chuyendinhdang24h(Time[0]);
            if (Time[2].Substring(3, 2) == "AM")
                if (Time[0].Length == 1)
                    Time[0] = "0" + Time[0];
            //Xóa ký tự trắng và PM hoặc AM
            Time[2] = Time[2].Remove(2, 3);
            string a;
            a = String.Format("_{0}{1}{2}", Time[0], Time[1], Time[2]);
            chuoi = chuoi + a;
            return chuoi;
        }
        public static string createCode(DataTable dt,string tiento)
        {
            int dem = tiento.Length;
            string s = tiento;
            int so;
            if (dt.Rows.Count==0)
            {
                s += "0";
            }
            else
            {

                DataRow dr = dt.Rows[dt.Rows.Count - 1];//hàng cuối của datatable    
                so = int.Parse(dr[0].ToString().Substring(dem));
                s += (so + 1).ToString();
            }
            return s;
        }
    }
}
