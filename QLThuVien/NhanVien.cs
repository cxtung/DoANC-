using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien
{
    internal class NhanVien
    {
        public int Id_TaiKhoan { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public NhanVien() { }
        public NhanVien( string userName, string password,int id_TaiKhoan)
        {
            this.Id_TaiKhoan = id_TaiKhoan;
            this.userName = userName;
            this.password = password;
        }
    }
}
