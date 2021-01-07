using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOCaLam
    {
        string maCa;
        string tenCa;

        public DTOCaLam(string maCa, string tenCa)
        {
            this.maCa = maCa;
            this.tenCa = tenCa;
        }

        public string MaCa { get => maCa; set => maCa = value; }
        public string TenCa { get => tenCa; set => tenCa = value; }
    }
}
