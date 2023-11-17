using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace QLThuVien
{
    public partial class frmLogin : Form
    {
        NhanVienDAO nhanvienDAO=new NhanVienDAO();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtUser.Text.Length == 0)
                {
                    throw new Exception("Không được để trống tên đăng nhập");
                }
                if (txtPassword.Text.Length == 0)
                {
                    throw new Exception("Không được để trống tên đăng nhập");
                }
                if (nhanvienDAO.AuthenticateUser(txtUser.Text, txtPassword.Text))
                {
                    frmMain frm = new frmMain();
                    this.Hide();
                    frm.ShowDialog();
                    

                }
                else
                {
                    MessageBox.Show("Đăng Nhập Thất Bại. Vui lòng kiểm tra lại tên đăng nhập và mật khẩu.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDangky_Click(object sender, EventArgs e)
        {
            frmdangky frm=new frmdangky();
            frm.ShowDialog();
        }
    }
}
