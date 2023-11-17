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
    public partial class frmQLSach : Form
    {
        QLSachDAO qlsachDAO = new QLSachDAO();
        public frmQLSach()
        {
            InitializeComponent();
        }
        public void Loaddssach()
        {
            dataGridView1.DataSource = qlsachDAO.getList();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemSach frm = new frmThemSach();
            frm.ShowDialog();
        }

  

        private void frmQLSach_Load(object sender, EventArgs e)
        {
            Loaddssach();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            this.Hide();
            frm.ShowDialog();
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            txtMasach.Enabled = true;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           

                int Id_Sach = int.Parse(txtMasach.Text);
                qlsachDAO.DeleteSV(Id_Sach);
                Loaddssach();

              
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
           
                int Id_Sach = int.Parse(txtMasach.Text);
                string TenSach = txtTenSach.Text;
                string TheLoai = txtTheLoai.Text;
                string TacGia = txtTacGia.Text;
                string ViTri = txtVitri.Text;
                string TrangThai = txtTrangThai.Text;
                float GiaSach = float.Parse(txtGiaSach.Text);
                QLSach sach = new QLSach(Id_Sach, TenSach, TheLoai, TacGia, GiaSach, ViTri, TrangThai);
                qlsachDAO.UpdateSV(sach);
                Loaddssach();
                MessageBox.Show("cập nhật thành công", "thông báo");
         

        
        }


        

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowindex = e.RowIndex;
                if (rowindex == -1 || rowindex >= dataGridView1.Rows.Count - 1)
                {
                    throw new Exception("Chưa chọn sản phẩm");
                }
                txtMasach.Text = dataGridView1.Rows[rowindex].Cells["Id_Sach"].Value.ToString();
                txtTenSach.Text = dataGridView1.Rows[rowindex].Cells["TenSach"].Value.ToString();
                txtTacGia.Text = dataGridView1.Rows[rowindex].Cells["TheLoai"].Value.ToString();
                txtTheLoai.Text = dataGridView1.Rows[rowindex].Cells["TheLoai"].Value.ToString();
                txtGiaSach.Text = dataGridView1.Rows[rowindex].Cells["GiaSach"].Value.ToString();
                txtVitri.Text = dataGridView1.Rows[rowindex].Cells["ViTri"].Value.ToString();
                txtTrangThai.Text = dataGridView1.Rows[rowindex].Cells["TrangThai"].Value.ToString();
                btnXoa.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {

            int Id_Sach = int.Parse(txtMasach.Text);
            string TenSach = txtTenSach.Text;
            string TheLoai = txtTheLoai.Text;
            string TacGia = txtTacGia.Text;
            string ViTri = txtVitri.Text;
            string TrangThai = txtTrangThai.Text;
            float GiaSach = float.Parse(txtGiaSach.Text);
            QLSach sach = new QLSach(Id_Sach, TenSach, TheLoai, TacGia, GiaSach, ViTri, TrangThai);
            qlsachDAO.UpdateSV(sach);
            Loaddssach();
            MessageBox.Show("cập nhật thành công", "thông báo");
        }
    }
}
