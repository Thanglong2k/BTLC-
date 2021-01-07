using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOCongViec
    {
        string maCV;
        string tenCV;

        public DTOCongViec(string maCV, string tenCV)
        {
            this.maCV = maCV;
            this.tenCV = tenCV;
        }

        public string MaCV { get => maCV; set => maCV = value; }
        public string TenCV { get => tenCV; set => tenCV = value; }
    }
}
