using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien
{
    internal class QLDocGia
    {
        public int Id_DocGia { get; set; }
        public string HoTen { get; set; }
        public string SoDienThoai { get; set; }
        public string DiaChi { get; set; }
        public QLDocGia() { }
        public QLDocGia(int id_DocGia, string hoTen, string soDienThoai, string diaChi)
        {
            this.Id_DocGia = id_DocGia;
            this.HoTen = hoTen;
            this.SoDienThoai = soDienThoai;
            this.DiaChi = diaChi;
        }
    }
}
