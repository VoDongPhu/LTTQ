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
    public partial class KhachHang : Form
    {
         DataTable tblKhachHang;//Bảng khách hàng

        public KhachHang()
        {
            InitializeComponent();
        }

        public void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * from tblKhachHang";
            tblKhachHang = Functions.GetDataToTable(sql); //Lấy dữ liệu từ bảng
            dgvKhachHang.DataSource = tblKhachHang;
            dgvKhachHang.DataSource = tblKhachHang;//Hiển thị vào dataGridView
            dgvKhachHang.Columns[0].HeaderText = "Mã khách";
            dgvKhachHang.Columns[1].HeaderText = "Tên khách";
            dgvKhachHang.Columns[2].HeaderText = "Ngày sinh";
            dgvKhachHang.Columns[3].HeaderText = "Điện thoại";
            dgvKhachHang.Columns[4].HeaderText = "Giới tính";
            dgvKhachHang.Columns[0].Width = 100;
            dgvKhachHang.Columns[1].Width = 150;
            dgvKhachHang.Columns[2].Width = 150;
            dgvKhachHang.Columns[3].Width = 150;
            dgvKhachHang.Columns[4].Width = 100;
            dgvKhachHang.AllowUserToAddRows = false;
            dgvKhachHang.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void KhachHang_Load_1(object sender, EventArgs e)
        {
            txtMaKhach.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            LoadDataGridView();
        }
        //hàm khỏi tạo lại các giá trị
        private void ResetValues()
        {
            txtMaKhach.Text = "";
            txtTenKhach.Text = "";
            mtbDienThoai.Text = "";
            chkGioiTinhKhach.Checked = false;
            NgSinhKhach.Value = DateTime.Now;

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoQua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtMaKhach.Enabled = true;
            txtMaKhach.Focus();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql, gt;

            if (txtMaKhach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaKhach.Focus();
                return;
            }

            if (txtTenKhach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenKhach.Focus();
                return;
            }

            if (NgSinhKhach.Text == "  /  /")
            {
                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NgSinhKhach.Focus();
                return;
            }
            if (!Functions.IsDate(NgSinhKhach.Text))
            {
                MessageBox.Show("Bạn phải nhập lại ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NgSinhKhach.Text = "";
                NgSinhKhach.Focus();
                return;
            }

            if (chkGioiTinhKhach.Checked == true)
                gt = "Nam";
            else
                gt = "Nữ";
            sql = "SELECT MaKhachHang FROM tblKhachHang WHERE MaKhachHang=N'" + txtMaKhach.Text.Trim() + "'";

            if (mtbDienThoai.Text == "(  )    -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mtbDienThoai.Focus();
                return;
            }
            //Kiểm tra đã tồn tại mã khách chưa
            
            sql = "SELECT MaKhachHang FROM tblKhachHang WHERE MaKhachHang=N'" + txtMaKhach.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã khách hàng này đã tồn tại, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaKhach.Focus();
                txtMaKhach.Text = "";
                return;
            }
            //Chèn thêm
            sql = "INSERT INTO tblKhachHang(MaKhachHang,TenKhachHang,NgSinhKhachHang, SoDTKhachHang, GioiTinhKhachhang) VALUES (N'" + txtMaKhach.Text.Trim() +
                "',N'" + txtTenKhach.Text.Trim() + "','"+ NgSinhKhach.Value + "','"+ mtbDienThoai.Text + "',N'" + gt + "')";
            Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValues();

            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;
            txtMaKhach.Enabled = false;

        }
    

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (tblKhachHang.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaKhach.Text == "")
            {
                MessageBox.Show("Bạn phải chọn bản ghi cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenKhach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenKhach.Focus();
                return;
            }
         
            if (mtbDienThoai.Text == "(  )    -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mtbDienThoai.Focus();
                return;
            }

            if (chkGioiTinhKhach.Checked == true)
                gt = "Nam";
            else
                gt= "Nữ";

            sql = "UPDATE tblKhachHang SET  TenKhachHang=N'" + txtTenKhach.Text.Trim().ToString() +
                    "',SoDTKhachHang='" + mtbDienThoai.Text.ToString() + "',GioiTinhKhachHang=N'" + gt +
                    "',NgSinhKhachHang='" + NgSinhKhach.Value +
                    "' WHERE MaKhachHang=N'" + txtMaKhach.Text + "'";
            Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
            btnBoQua.Enabled = false;
        }
        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaKhach.Focus();
                return;
            }
            if (tblKhachHang.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaKhach.Text = dgvKhachHang.CurrentRow.Cells["MaKhachHang"].Value.ToString();
            txtTenKhach.Text = dgvKhachHang.CurrentRow.Cells["TenKhachHang"].Value.ToString();
            if (dgvKhachHang.CurrentRow.Cells["GioiTinhKhachHang"].Value.ToString() == "Nam") chkGioiTinhKhach.Checked = true;
            else chkGioiTinhKhach.Checked = false;
            NgSinhKhach.Value = (DateTime)dgvKhachHang.CurrentRow.Cells["NgSinhKhachhang"].Value;
            mtbDienThoai.Text = dgvKhachHang.CurrentRow.Cells["SoDTKhachHang"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoQua.Enabled = true;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblKhachHang.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaKhach.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE tblKhachHang WHERE MaKhachHang=N'" + txtMaKhach.Text + "'";
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
            txtMaKhach.Enabled = false;
        }

        private void txtMaKhach_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtTenKhach_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void mtbDienThoai_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void NgSinhKhach_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void chkGioiTinhKhach_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}
