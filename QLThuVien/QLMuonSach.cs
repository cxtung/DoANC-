using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien
{
    internal class QLMuonSach
    {
        public string Id_MuonTra { get; set; }
        public string HoTen { get; set; }
        public string SoDienThoai { get; set; }
        public string MaDocGia { get; set; }
        public string TenSach { get; set; }
        public string TheLoai { get; set; }
        public DateTime NgayMuon { get; set; }
        public QLMuonSach() { }
        public QLMuonSach(string id_MuonTra, string hoTen, string soDienThoai, string maDocGia, string tenSach, string theLoai, DateTime ngayMuon)
        {
            this.Id_MuonTra = id_MuonTra;
            this.HoTen = hoTen;
            this.SoDienThoai = soDienThoai;
            this.MaDocGia = maDocGia;
            this.TenSach = tenSach;
            this.TheLoai = theLoai;
            this.NgayMuon = ngayMuon;
        }
    }
}
