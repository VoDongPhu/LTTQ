using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                Class.Functions.Disconnect(); //Đóng kết nối
                Application.Exit(); //Thoát
            }

        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            KhachHang frm = new KhachHang();
            frm.ShowDialog();
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien frmNhanVien = new frmNhanVien();
            frmNhanVien.ShowDialog();
        }

        private void mnuSanPham_Click(object sender, EventArgs e)
        {
            frmSanPham frmSanPham = new frmSanPham();
            frmSanPham.ShowDialog();
        }

        private void mnuHoaDonBan_Click(object sender, EventArgs e)
        {
            frmHoaDon frmHoaDon = new frmHoaDon();
            frmHoaDon.ShowDialog();
        }

        private void mnuFindHoaDon_Click(object sender, EventArgs e)
        {
            frmTimKiemHoaDon frmTimKiemHoaDon = new frmTimKiemHoaDon();
            frmTimKiemHoaDon.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect(); //Mở kết nối
        }
    }
}
