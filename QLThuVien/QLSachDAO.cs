using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien
{
    internal class QLSachDAO
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataAdapter apt = null;
        KetNoi kn = new KetNoi();
        public QLSachDAO()
        {
            conn = kn.getConnect();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

        }
        public DataTable getList()
        {
            string sql = "SELECT * FROM QLSach";
            cmd = new SqlCommand(sql, conn);
            apt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            apt.Fill(dt);
            return dt;
        }
        public DataRow getRow(string TenSach )
        {
            string sql = "SELECT QLSach.Id_Sach,QLSach.TenSach,QLSach.TheLoai,QLSach.TrangThai,QLSach.ViTri";
            cmd = new SqlCommand(sql, conn);
            apt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            apt.Fill(dt);
            DataRow row = dt.Rows[0];
            return row;
        }
        public void UpdateSV(QLSach qls)
        {
            string sql = "UPDATE QLSach SET Id_Sach = @ID_SACH, TenSach = @TENSACH,TheLoai=@THELOAI,TacGia=@TACGIA,GiaSach=@GIASACH,ViTri=@VITRI,TrangThai=@TRANGTHAI ";
            sql += " WHERE Id_Sach = @ID_SACH";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ID_SACH", qls.Id_Sach);
            cmd.Parameters.AddWithValue("@TENSACH", qls.TenSach);
            cmd.Parameters.AddWithValue("@THELOAI", qls.TheLoai);
            cmd.Parameters.AddWithValue("@TACGIA", qls.TacGia);
            cmd.Parameters.AddWithValue("@GIASACH", qls.GiaSach);
            cmd.Parameters.AddWithValue("@VITRI", qls.ViTri);
            cmd.Parameters.AddWithValue("@TRANGTHAI", qls.TrangThai);
            cmd.ExecuteNonQuery();

        }
        public void DeleteSV(int Id_Sach)
        {
            string sql = "DELETE FROM QLSach WHERE Id_Sach = @ID_SACH";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ID_SACH", Id_Sach);
            cmd.ExecuteNonQuery();
        }
       
        public void insert(int Id_Sach, string TenSach, string TheLoai,string TacGia, float GiaSach,string ViTri,string TrangThai)
        {
            string sql = "INSERT INTO QLSach (Id_Sach, TenSach,TheLoai,TacGia,GiaSach,ViTri,TrangThai) VALUES (@ID_SACH,@TENSACH,@THELOAI,@TACGIA,@GIASACH,@VITRI,@TRANGTHAI)";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ID_SACH", Id_Sach);
            cmd.Parameters.AddWithValue("@TENSACH", TenSach);
            cmd.Parameters.AddWithValue("@THELOAI", TheLoai);
            cmd.Parameters.AddWithValue("@TACGIA", TacGia);
            cmd.Parameters.AddWithValue("@GIASACH", GiaSach);
            cmd.Parameters.AddWithValue("@VITRI", ViTri);
            cmd.Parameters.AddWithValue("@TRANGTHAI", TrangThai);
            cmd.ExecuteNonQuery();
        }
    }
}
