using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTONuocSX
    {
        string maNSX;
        string tenNSX;

        public DTONuocSX(string maNSX, string tenNSX)
        {
            this.maNSX = maNSX;
            this.tenNSX = tenNSX;
        }

        public string MaNSX { get => maNSX; set => maNSX = value; }
        public string TenNSX { get => tenNSX; set => tenNSX = value; }
    }
}
