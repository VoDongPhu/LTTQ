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
            dgvNhanVien.Columns[2].HeaderText = "Ngày sinh";
            dgvNhanVien.Columns[3].HeaderText = "Giới tính";
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
            NgVaoLam.Value = (DateTime)dgvNhanVien.CurrentRow.Cells["NgayVaoLam"].Value;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnBoQua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtMaNV.Enabled = true;
            txtMaNV.Focus();

        }
        private void ResetValues()
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            txtMatKhau.Text = "";
            chkGioiTinhNV.Checked = false;
            SDTNV.Text = "";
            NgSinhNV.Value = DateTime.Now;
            NgVaoLam.Value = DateTime.Now;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (txtMaNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNV.Focus();
                return;
            }
            if (txtTenNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNV.Focus();
                return;
            }
            if (txtMatKhau.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Focus();
                return;
            }
            if (SDTNV.Text == "(   )     -")
            {
                MessageBox.Show("Bạn phải nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SDTNV.Focus();
                return;
            }
            if (chkGioiTinhNV.Checked == true)
                gt = "Nam";
            else
                gt = "Nữ";
            sql = "SELECT MaNhanVien FROM tblNhanVien WHERE MaNhanVien=N'" + txtMaNV.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã nhân viên này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNV.Focus();
                txtMaNV.Text = "";
                return;
            }
            sql = "INSERT INTO tblNhanVien(MaNhanVien,TenNhanVien,NgSinhNhanVien, MatKhau,SoDTNhanVien, GioiTinhNhanVien,NgayVaoLam) VALUES (N'" + txtMaNV.Text.Trim() + "',N'" + txtTenNV.Text.Trim() + "','" + NgSinhNV.Value + "',N'" + txtMatKhau.Text.Trim() + "','" + SDTNV.Text + "',N'" + gt + "','" + NgVaoLam.Value + "')";
            Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;
            txtMaNV.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if(tblNhanVien.Rows.Count==0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(txtMaNV.Text.Trim().Length==0)
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(txtTenNV.Text.Trim().Length==0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNV.Focus();
                return;
            }
            if (txtMatKhau.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Focus();
                return;
            }
            if (SDTNV.Text == "(   )     -")
            {
                MessageBox.Show("Bạn phải nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SDTNV.Focus();
                return;
            }
            if (chkGioiTinhNV.Checked == true)
                gt = "Nam";
            else
                gt = "Nữ";
            sql = "UPDATE tblNhanVien SET  TenNhanVien=N'" + txtTenNV.Text.Trim().ToString() +
                    "',MatKhau=N'" + txtMatKhau.Text.Trim().ToString() +
                    "',SoDTNhanVien='" + SDTNV.Text.ToString() + "',GioiTinhNhanVien=N'" + gt +
                    "',NgSinhNhanVien='" + NgSinhNV.Value +
                    "',NgayVaoLam='"+NgVaoLam.Value +
                    "' WHERE MaNhanVien=N'" + txtMaNV.Text + "'";
            Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
            btnBoQua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblNhanVien.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblNhanVien WHERE MaNhanVien=N'" + txtMaNV.Text + "'";
                Functions.RunSQL(sql);
                LoadDataGridView();
                ResetValues();
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnBoQua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaNV.Enabled = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
