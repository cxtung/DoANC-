using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien
{
    internal class QLSach
    {
        public int Id_Sach { get; set; }
        public string TenSach { get; set; }
        public string TheLoai { get; set; }
        public string TacGia { get; set; }
        public float GiaSach { get; set; }
        public string ViTri { get; set; }
        public string TrangThai { get; set; }
        public QLSach() { }
        public QLSach(int id_Sach, string tenSach, string theLoai, string tacGia, float giaSach, string viTri, string trangThai)
        {
            this.Id_Sach = id_Sach;
            this.TenSach = tenSach;
            this.TheLoai = theLoai;
            this.TacGia = tacGia;
            this.GiaSach = giaSach;
            this.ViTri = viTri;
            this.TrangThai = trangThai;
        }
    }
}
