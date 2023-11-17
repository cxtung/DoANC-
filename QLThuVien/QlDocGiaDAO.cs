using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien
{
    internal class QLDocGiaDAO
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataAdapter apt = null;
        KetNoi kn = new KetNoi();
        public QLDocGiaDAO()
        {
            conn = kn.getConnect();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

        }
        public void taodocgia(int Id_DocGia,string HoTen, string SoDienThoai,string DiaChi)
        {
            string sql = "INSERT INTO QLDocGia (Id_DocGia,  HoTen,SoDienThoai,DiaChi) VALUES (@ID_DOCGIA,@HOTEN,@SODIENTHOAI,@DIACHI)";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ID_DOCGIA", Id_DocGia);
            cmd.Parameters.AddWithValue("@HOTEN", HoTen);
            cmd.Parameters.AddWithValue("@SODIENTHOAI", SoDienThoai);
            cmd.Parameters.AddWithValue("@DIACHI", DiaChi);

            cmd.ExecuteNonQuery();
        }

        public void UpdateSV(QLDocGia dg)
        {
            string sql = "UPDATE QLDocGia SET Id_DocGia=@ID_DOCGIA,HoTen = @HOTEN, SoDienThoai = @SODIENTHOAI,DiaChi=@DIACHI ";
            sql += " WHERE Id_DocGia = @ID_DOCGIA";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ID_DOCGIA", dg.Id_DocGia);
            cmd.Parameters.AddWithValue("@HOTEN", dg.HoTen);
            cmd.Parameters.AddWithValue("@SODIENTHOAI", dg.SoDienThoai);
            cmd.Parameters.AddWithValue("@DIACHI", dg.DiaChi);
            cmd.ExecuteNonQuery();

        }
        public void DeleteSV(int Id_DocGia)
        {
            string sql = "DELETE FROM QLDocGia WHERE Id_DocGia = @ID_DOCGIA";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ID_DOCGIA", Id_DocGia);
            cmd.ExecuteNonQuery();
        }
        public DataTable getList()
        {
            string sql = "SELECT * FROM QLDocGia";
            cmd = new SqlCommand(sql, conn);
            apt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            apt.Fill(dt);
            return dt;
        }
        public DataRow getRow(string TenSach)
        {
            string sql = "SELECT QLDocGia.Id_Sach,QLDocGia.HoTen,QLDocGia.SoDienThoai,QLDocGia.DiaChi";
            cmd = new SqlCommand(sql, conn);
            apt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            apt.Fill(dt);
            DataRow row = dt.Rows[0];
            return row;
        }
    }
}
