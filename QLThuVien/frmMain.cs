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
    public partial class frmMain : Form
    {
        public static string tendangnhap = null;
        QLSachDAO qlsachDAO= new QLSachDAO();
        QLDocGiaDAO QLDOCGIAdao= new QLDocGiaDAO();
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Loaddssach();
        }
        public void Loaddssach()
        {
            dataGridView1.DataSource = qlsachDAO.getList();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void btnQLDocGia_Click(object sender, EventArgs e)
        {
           frmQLDocGia frm=new frmQLDocGia();
            this.Hide();
            frm.ShowDialog();
        }

        private void btnQLSach_Click(object sender, EventArgs e)
        {
            frmQLSach frm=new frmQLSach();
            this.Hide();
            frm.ShowDialog();
        }

        private void btnQLMuon_Tra_Click(object sender, EventArgs e)
        {
            frmQLMuon_TraSach frm =new frmQLMuon_TraSach();
            this.Hide();

            frm.ShowDialog();
        }

        private void btnThemDocGia_Click(object sender, EventArgs e)
        {
            frmThemDocgia frm=new frmThemDocgia(); 
            frm.ShowDialog();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
