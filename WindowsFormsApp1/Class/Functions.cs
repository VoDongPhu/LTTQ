using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1.Class
{
    class Functions
    {
        public static SqlConnection Con;  
        //Tạo phương thức Connect()        

        public static void Connect()
        {
            Con = new SqlConnection();   //Khởi tạo đối tượng
            Con.ConnectionString = Properties.Settings.Default.QLBanHangConnectionString;
            
            //Kiểm tra kết nối
            if (Con.State != ConnectionState.Open)
            {
                Con.Open();
                MessageBox.Show("Kết nối thành công");
            }
                
            else 
                MessageBox.Show("Không thể kết nối với dữ liệu");

        }
        //Tạo phương thức Disconnect() 
        public static void Disconnect()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();   	//Đóng kết nối
                Con.Dispose(); 	//Giải phóng tài nguyên
                Con = null;
            }
        }
        public static DataTable GetDataToTable(string sql)
        {
            SqlDataAdapter dap = new SqlDataAdapter(sql,Con);// Định nghĩa đối tượng thuộc lớp SqlDataAdapter
            DataTable table = new DataTable();
            dap.Fill(table);
            return table;
        }
    }
}
