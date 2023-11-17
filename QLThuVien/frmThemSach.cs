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
    public partial class frmThemSach : Form

    {
        QLSachDAO qlsachDAO=new QLSachDAO();
        public frmThemSach()
        {
            InitializeComponent();
        }

        private void frmThemSach_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtGiaSach.Text.Length == 0)
                {
                    throw new Exception("Không được để trống");
                }
                if (txtMasach.Text.Length == 0)
                {
                    throw new Exception("Không được để trống");
                }
                if (txtTacGia.Text.Length == 0)
                {
                    throw new Exception("Không được để trống");
                }
                if (txtTenSach.Text.Length == 0)
                {
                    throw new Exception("Không được để trống");
                }
                if (txtTheLoai.Text.Length == 0)
                {
                    throw new Exception("Không được để trống");
                }
                if (txtTrangThai.Text.Length == 0)
                {
                    throw new Exception("Không được để trống");
                }


                if (txtTenSach.Text == null)
                {
                    MessageBox.Show("Nhập tất cả");
                }
                else
                {
                    qlsachDAO.insert(int.Parse(txtMasach.Text), txtTenSach.Text, txtTheLoai.Text, txtTacGia.Text, float.Parse(txtGiaSach.Text),txtTrangThai.Text,txtVitri.Text);
                    MessageBox.Show("Thêm Thành công", "Thông báo");
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
