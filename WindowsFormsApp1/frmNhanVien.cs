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
using WindowsFormsApp1.Class;

namespace WindowsFormsApp1
{
    public partial class frmNhanVien : Form
    {
        private DataTable tblNhanVien;
        public frmNhanVien()
        {
            InitializeComponent();
        }
        public void LoadDataGridView()
        {
            string sql;
            sql = "select * from tblNhanVien";
            tblNhanVien = Functions.GetDataToTable(sql);//lấy dữ liệu
            dgvNhanVien.DataSource = tblNhanVien;
            dgvNhanVien.DataSource = tblNhanVien;
            dgvNhanVien.Columns[0].HeaderText = "Mã nhân viên";
            dgvNhanVien.Columns[1].HeaderText = "Tên nhân viên";
            dgvNhanVien.Columns[2].HeaderText = "Giới tính";
            dgvNhanVien.Columns[3].HeaderText = "Ngày sinh";
            dgvNhanVien.Columns[4].HeaderText = "Số Điện thoại";
            dgvNhanVien.Columns[5].HeaderText = "Mật khẩu";
            dgvNhanVien.Columns[6].HeaderText = "Ngày vào làm";
            dgvNhanVien.Columns[0].Width = 100;
            dgvNhanVien.Columns[1].Width = 150;
            dgvNhanVien.Columns[2].Width = 100;
            dgvNhanVien.Columns[3].Width = 150;
            dgvNhanVien.Columns[4].Width = 100;
            dgvNhanVien.Columns[5].Width = 100;
            dgvNhanVien.Columns[6].Width = 100;
            dgvNhanVien.AllowUserToAddRows = false;
            dgvNhanVien.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            txtMaNV.Enabled = false;
            btnLuu.Enabled = false;// vô hiệu hóa chức năng
            btnBoQua.Enabled = false;
            LoadDataGridView();
        }

        private void frmNhanVien_Click(object sender, EventArgs e)
        {
            
        }

        private void SDTNV_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dgvNhanVien_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNV.Focus();
                return;
            }
            if (tblNhanVien.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaNV.Text = dgvNhanVien.CurrentRow.Cells["MaNhanVien"].Value.ToString();
            txtTenNV.Text = dgvNhanVien.CurrentRow.Cells["TenNhanVien"].Value.ToString();
            if (dgvNhanVien.CurrentRow.Cells["GioiTinhNhanVien"].Value.ToString() == "Nam") chkGioiTinhNV.Checked = true;
            else chkGioiTinhNV.Checked = false;
            txtMatKhau.Text = dgvNhanVien.CurrentRow.Cells["MatKhau"].Value.ToString();
            SDTNV.Text = dgvNhanVien.CurrentRow.Cells["SoDTNhanVien"].Value.ToString();
            NgSinhNV.Value = (DateTime)dgvNhanVien.CurrentRow.Cells["NgSinhNhanVien"].Value;
            NgVaoLam.Value = (DateTime)dgvNhanVien.CurrentRow.Cells["NgVaoLam"].Value;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnXoa.Enabled = true;
        }
    }
}
