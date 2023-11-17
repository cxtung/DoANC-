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
    public partial class frmQLDocGia : Form
    {
        QLDocGiaDAO qldocgia=new QLDocGiaDAO();
        public frmQLDocGia()
        {
            InitializeComponent();
            Loadddocgia();
        }
        public void Loadddocgia()
        {
            dgvQLDocGia.DataSource = qldocgia.getList();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemDocgia frm=new frmThemDocgia();
            Loadddocgia();
            frm.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            txtMa.Enabled = true;
        }

        private void dgvQLDocGia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowindex = e.RowIndex;
                if (rowindex == -1 || rowindex >= dgvQLDocGia.Rows.Count - 1)
                {
                    throw new Exception("Chưa chọn sản phẩm");
                }
                txtMa.Text = dgvQLDocGia.Rows[rowindex].Cells["Id_DocGia"].Value.ToString();
                txtHoTen.Text = dgvQLDocGia.Rows[rowindex].Cells["HoTen"].Value.ToString();
                txtDiaChi.Text = dgvQLDocGia.Rows[rowindex].Cells["SoDienThoai"].Value.ToString();
                txtSDT.Text = dgvQLDocGia.Rows[rowindex].Cells["DiaChi"].Value.ToString();
             
                btnXoa.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int Id_DocGia = int.Parse(txtMa.Text);
            string HoTen = txtHoTen.Text;
            string SoDienThoai = txtSDT.Text;
            string DiaChi = txtDiaChi.Text;
           
            QLDocGia docgia = new QLDocGia(Id_DocGia, HoTen, SoDienThoai, DiaChi);
            qldocgia.UpdateSV(docgia);
            Loadddocgia();
            MessageBox.Show("cập nhật thành công", "thông báo");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int Id_Sach = int.Parse(txtMa.Text);
            qldocgia.DeleteSV(Id_Sach);
            Loadddocgia();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmMain frm= new frmMain();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
