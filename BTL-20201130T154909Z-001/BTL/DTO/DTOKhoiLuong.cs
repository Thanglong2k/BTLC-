using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOKhoiLuong
    {
        int maKL;

        public DTOKhoiLuong(int maKL)
        {
            this.maKL = maKL;
        }

        public int MaKL { get => maKL; set => maKL = value; }
    }
}
