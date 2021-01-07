using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOMau
    {
        string maMau;
        string tenMau;

        public DTOMau(string maMau, string tenMau)
        {
            this.maMau = maMau;
            this.tenMau = tenMau;
        }

        public string MaMau { get => maMau; set => maMau = value; }
        public string TenMau { get => tenMau; set => tenMau = value; }
    }
}
