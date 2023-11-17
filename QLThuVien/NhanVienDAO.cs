using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data.SqlClient;

namespace QLThuVien
{
     class NhanVienDAO
    {
        SqlConnection conn = null;
        SqlCommand cmd= null;
        SqlDataAdapter apt = null;
        KetNoi kn =new KetNoi();
        public NhanVienDAO()
        {
            conn = kn.getConnect();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

        }

        public void UpdateSV(NhanVien nv)
        {
            string sql = "UPDATE NhanVien SET userName = @UserName, password = @Password,Id_TaiKhoan=@ID_TAIKHOAN ";
            sql += " WHERE userName = @UserName";
            cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@UserName", nv.userName);
            cmd.Parameters.AddWithValue("@Password", nv.password);
            cmd.ExecuteNonQuery();

        }
        public void DeleteSV(int Id_TaiKhoan)
        {
            string sql = "DELETE FROM NhanVien WHERE Id_TaiKhoan = @ID_TAIKHOAN";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ID_TAIKHOAN", Id_TaiKhoan);
            cmd.ExecuteNonQuery();
        }
        public bool AuthenticateUser(string userName, string password)
        {
            string query = "SELECT * FROM customers WHERE  userName = @UserName AND password = @Password";

            cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@UserName", userName);
            cmd.Parameters.AddWithValue("@Password", password);

            return true;
        }
        public void CreateACC(string userName,string password,int Id_TaiKhoan)
        {
            string sql = "INSERT INTO NhanVien (userName,  password,Id_TaiKhoan) VALUES (@UserName,@Password,@ID_TAIKHOAN)";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ID_TAIKHOAN", Id_TaiKhoan);
            cmd.Parameters.AddWithValue("@UserName", userName);
            cmd.Parameters.AddWithValue("@Password", password);
          
            cmd.ExecuteNonQuery();
        }
  


    }
    
}
