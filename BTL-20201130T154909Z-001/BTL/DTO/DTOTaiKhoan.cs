using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOTaiKhoan
    {
        string tenND;
        string taiKhoan;
        string matkhau;
        int status;
        string quyen;
        string email;

        public DTOTaiKhoan()
        {
        }

        public DTOTaiKhoan(string tenND, string taiKhoan, string matkhau, int status, string quyen, string email)
        {
            this.tenND = tenND;
            this.taiKhoan = taiKhoan;
            this.matkhau = matkhau;
            this.status = status;
            this.quyen = quyen;
            this.email = email;
        }

        public string TenNguoiDung { get => tenND; set => tenND = value; }
        public string TaiKhoan { get => taiKhoan; set => taiKhoan = value; }
        public string MatKhau { get => matkhau; set => matkhau = value; }
        public int Status { get => status; set => status = value; }
        public string Quyen { get => quyen; set => quyen = value; }
        public string Email { get => email; set => email = value; }
    }
}
