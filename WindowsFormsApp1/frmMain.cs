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
            IsMdiContainer = true;
        }          

        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    Class.Functions.Connect();
        //    this.IsMdiContainer = true;
        //}
       
        //private void mnuThoat_Click(object sender, EventArgs e)
        //{
        //    Class.Functions.Disconnect();
        //    Application.Exit();
        //}

        //private void mnuNhanVien_Click(object sender, EventArgs e)
        //{
        //    frmNhanVien frm = new frmNhanVien();
        //    frm.MdiParent = this;
        //    frm.Show();
        //}

        //private void mnuKhachHang_Click(object sender, EventArgs e)
        //{
        //    KhachHang frm = new KhachHang();
        //    frm.MdiParent = this;
        //    frm.Show();
        //}

        //private void mnuSanPham_Click(object sender, EventArgs e)
        //{
        //    frmSanPham frm = new frmSanPham();
        //    frm.MdiParent = this;
        //    frm.Show();
        //}
        //private void mnuHoaDon_Click(object sender, EventArgs e)
        //{
        //    frmHoaDon frm = new frmHoaDon();
        //    frm.MdiParent = this;
        //    frm.Show();
        //}
        //private void mnuTimKiemHoaDon_Click(object sender, EventArgs e)
        //{
        //    frmTimKiemHoaDon frm = new frmTimKiemHoaDon();
        //    frm.MdiParent = this;
        //    frm.Show();
        //}

        //private void mnuuFindHoaDon_Click(object sender, EventArgs e)
        //{
        //    frmTimKiemHoaDon frm = new frmTimKiemHoaDon();
        //    frm.MdiParent = this;
        //    frm.Show();
        //}

        //private void mnuHoaDonBan_Click(object sender, EventArgs e)
        //{
        //    frmHoaDon frm = new frmHoaDon();
        //    frm.MdiParent = this;
        //    frm.Show();
        //}

        private void ribbonExit_Click(object sender, EventArgs e)
        {
            Class.Functions.Disconnect();
            Application.Exit();
        }

        private void ribbonCustomer_Click(object sender, EventArgs e)
        {
            KhachHang frm = new KhachHang();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ribbonProduct_Click(object sender, EventArgs e)
        {
            frmSanPham frm = new frmSanPham();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ribbonEmployee_Click(object sender, EventArgs e)
        {
            frmNhanVien frm = new frmNhanVien();
            frm.MdiParent = this;
            frm.Show();
        }
<<<<<<< HEAD
        
        

        private void mnuHoaDonBan_Click(object sender, EventArgs e)
=======

        private void ribbonSaleBill_Click(object sender, EventArgs e)
>>>>>>> 562161aa30231269bdee86a6044ca31806b25285
        {
            frmHoaDon frm = new frmHoaDon();
            frm.MdiParent = this;
            frm.Show();
        }
<<<<<<< HEAD
        private void mnuTimKiem_Click(object sender, EventArgs e)
=======

        private void ribbonSearchBill_Click(object sender, EventArgs e)
>>>>>>> 562161aa30231269bdee86a6044ca31806b25285
        {
            frmTimKiemHoaDon frm = new frmTimKiemHoaDon();
            frm.MdiParent = this;
            frm.Show();
        }
<<<<<<< HEAD
        private void mnuHangNhap_Click(object sender, EventArgs e)
        {
            
=======

        private void frmMain_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
            this.IsMdiContainer = true;
>>>>>>> 562161aa30231269bdee86a6044ca31806b25285
        }
    }
}
