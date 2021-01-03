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
    public partial class frmDangNhap : Form
    {
        
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection();   //Khởi tạo đối tượng
            Con.ConnectionString = Properties.Settings.Default.QLBanHangConnectionString;
            Con.Open();
            string sql;
            string tk = txtTaiKhoan.Text;
            string mk = txtMatKhau.Text;
            sql = "select * from DangNhap where TaiKhoan='" + tk+"' and MatKhau='" + mk + "'";

            SqlCommand cmd = new SqlCommand(sql, Con);
            SqlDataReader dta = cmd.ExecuteReader();
            if(dta.Read()==true)
            {
                if(MessageBox.Show("Đăng nhập thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information)==DialogResult.OK);
                {
                    this.Hide();
                    frmMain frm = new frmMain();
                    frm.ShowDialog();
                    this.Close();
                }
                
                
            }    
            else
            {
                MessageBox.Show("Đăng nhập thất bại","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }    
            

            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
