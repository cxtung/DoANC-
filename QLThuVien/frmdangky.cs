using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QLThuVien
{
    public partial class frmdangky : Form
    {
        NhanVienDAO nhanvienDAO = new NhanVienDAO();

        public frmdangky()
        {
            InitializeComponent();
        }

        private void btnDangky_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtUser.Text.Length == 0)
                {
                    throw new Exception("Không được để trống");
                }
                if (txtPassword.Text.Length == 0)
                {
                    throw new Exception("Không được để trống");
                }
                if (txtID.Text.Length == 0)
                {
                    throw new Exception("Không được để trống");
                }
                if (txtXacNhan.Text.Length == 0)
                {
                    throw new Exception("Không được để trống");
                }


                if (txtPassword.Text == txtXacNhan.Text)
                {
                    nhanvienDAO.CreateACC(txtUser.Text,  txtPassword.Text,int.Parse(txtID.Text));
                    MessageBox.Show("Đăng ký Thành công", "Thôn báo");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Xác nhận mật khẩu không khớp");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
