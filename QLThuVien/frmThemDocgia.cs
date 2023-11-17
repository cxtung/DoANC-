using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThuVien
{
    public partial class frmThemDocgia : Form
    {
        QLDocGiaDAO qldocgiaDAO=new QLDocGiaDAO();
        public frmThemDocgia()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtMa.Text.Length == 0)
                {
                    throw new Exception("Không được để trống");
                }
                if (txtHoTen.Text.Length == 0)
                {
                    throw new Exception("Không được để trống");
                }
                if (txtDiaChi.Text.Length == 0)
                {
                    throw new Exception("Không được để trống");
                }
                if (txtSDT.Text.Length == 0)
                {
                    throw new Exception("Không được để trống");
                }


                if (txtMa.Text == null)
                {
                    MessageBox.Show("Kiểm tra thông tin thêm độc giả");

                }
                else
                {
                    qldocgiaDAO.taodocgia(int.Parse(txtMa.Text), txtHoTen.Text, txtSDT.Text, txtDiaChi.Text);
                    MessageBox.Show("Đăng ký Thành công", "Thôn báo");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
