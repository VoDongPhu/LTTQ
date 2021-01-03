namespace WindowsFormsApp1
{
    partial class frmKhachHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mtbDienThoai = new System.Windows.Forms.MaskedTextBox();
            this.NgSinhKhach = new System.Windows.Forms.DateTimePicker();
            this.chkGioiTinhKhach = new System.Windows.Forms.CheckBox();
            this.txtTenKhach = new System.Windows.Forms.TextBox();
            this.txtMaKhach = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnDong);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnBoQua);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 461);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(981, 52);
            this.panel1.TabIndex = 0;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(782, 17);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 11;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(67, 17);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(210, 17);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnBoQua
            // 
            this.btnBoQua.Location = new System.Drawing.Point(639, 17);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(75, 23);
            this.btnBoQua.TabIndex = 10;
            this.btnBoQua.Text = "Bỏ qua";
            this.btnBoQua.UseVisualStyleBackColor = true;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(353, 17);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(496, 17);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
<<<<<<< HEAD:WindowsFormsApp1/frmKhachHang.Designer.cs
            // panel2
            // 
            this.panel2.Controls.Add(this.mtbDienThoai);
            this.panel2.Controls.Add(this.NgSinhKhach);
            this.panel2.Controls.Add(this.chkGioiTinhKhach);
            this.panel2.Controls.Add(this.txtTenKhach);
            this.panel2.Controls.Add(this.txtMaKhach);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(981, 183);
            this.panel2.TabIndex = 1;
=======
            // frmKhachHang
            // 
            this.frmKhachHang.BackColor = System.Drawing.SystemColors.Control;
            this.frmKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.frmKhachHang.Controls.Add(this.mtbDienThoai);
            this.frmKhachHang.Controls.Add(this.chkGioiTinhKhach);
            this.frmKhachHang.Controls.Add(this.NgSinhKhach);
            this.frmKhachHang.Controls.Add(this.txtTenKhach);
            this.frmKhachHang.Controls.Add(this.txtMaKhach);
            this.frmKhachHang.Controls.Add(this.label7);
            this.frmKhachHang.Controls.Add(this.label6);
            this.frmKhachHang.Controls.Add(this.label5);
            this.frmKhachHang.Controls.Add(this.label4);
            this.frmKhachHang.Controls.Add(this.label3);
            this.frmKhachHang.Controls.Add(this.label2);
            this.frmKhachHang.Controls.Add(this.label1);
            this.frmKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.frmKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmKhachHang.Location = new System.Drawing.Point(0, 0);
            this.frmKhachHang.Name = "frmKhachHang";
            this.frmKhachHang.Size = new System.Drawing.Size(894, 214);
            this.frmKhachHang.TabIndex = 2;
>>>>>>> f6b493ae7691762a7600f9de0469d1a279d38e66:WindowsFormsApp1/KhachHang.Designer.cs
            // 
            // mtbDienThoai
            // 
            this.mtbDienThoai.Location = new System.Drawing.Point(639, 86);
            this.mtbDienThoai.Mask = "(999) 000-0000";
            this.mtbDienThoai.Name = "mtbDienThoai";
            this.mtbDienThoai.Size = new System.Drawing.Size(178, 22);
            this.mtbDienThoai.TabIndex = 10;
            this.mtbDienThoai.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mtbDienThoai_KeyUp);
            // 
            // NgSinhKhach
            // 
            this.NgSinhKhach.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.NgSinhKhach.Location = new System.Drawing.Point(639, 42);
            this.NgSinhKhach.Name = "NgSinhKhach";
            this.NgSinhKhach.Size = new System.Drawing.Size(178, 22);
            this.NgSinhKhach.TabIndex = 9;
            this.NgSinhKhach.KeyUp += new System.Windows.Forms.KeyEventHandler(this.NgSinhKhach_KeyUp);
            // 
            // chkGioiTinhKhach
            // 
            this.chkGioiTinhKhach.AutoSize = true;
            this.chkGioiTinhKhach.Location = new System.Drawing.Point(200, 135);
            this.chkGioiTinhKhach.Name = "chkGioiTinhKhach";
            this.chkGioiTinhKhach.Size = new System.Drawing.Size(59, 21);
            this.chkGioiTinhKhach.TabIndex = 8;
            this.chkGioiTinhKhach.Text = "Nam";
            this.chkGioiTinhKhach.UseVisualStyleBackColor = true;
            this.chkGioiTinhKhach.KeyUp += new System.Windows.Forms.KeyEventHandler(this.chkGioiTinhKhach_KeyUp);
            // 
<<<<<<< HEAD:WindowsFormsApp1/frmKhachHang.Designer.cs
=======
            // NgSinhKhach
            // 
            this.NgSinhKhach.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.NgSinhKhach.Location = new System.Drawing.Point(670, 46);
            this.NgSinhKhach.Name = "NgSinhKhach";
            this.NgSinhKhach.Size = new System.Drawing.Size(182, 26);
            this.NgSinhKhach.TabIndex = 19;
            this.NgSinhKhach.KeyUp += new System.Windows.Forms.KeyEventHandler(this.NgSinhKhach_KeyUp);
            // 
>>>>>>> f6b493ae7691762a7600f9de0469d1a279d38e66:WindowsFormsApp1/KhachHang.Designer.cs
            // txtTenKhach
            // 
            this.txtTenKhach.Location = new System.Drawing.Point(200, 88);
            this.txtTenKhach.Name = "txtTenKhach";
            this.txtTenKhach.Size = new System.Drawing.Size(176, 22);
            this.txtTenKhach.TabIndex = 7;
            this.txtTenKhach.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTenKhach_KeyUp);
            // 
            // txtMaKhach
            // 
            this.txtMaKhach.Location = new System.Drawing.Point(200, 42);
            this.txtMaKhach.Name = "txtMaKhach";
<<<<<<< HEAD:WindowsFormsApp1/frmKhachHang.Designer.cs
            this.txtMaKhach.Size = new System.Drawing.Size(182, 22);
            this.txtMaKhach.TabIndex = 6;
=======
            this.txtMaKhach.Size = new System.Drawing.Size(167, 26);
            this.txtMaKhach.TabIndex = 15;
>>>>>>> f6b493ae7691762a7600f9de0469d1a279d38e66:WindowsFormsApp1/KhachHang.Designer.cs
            this.txtMaKhach.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMaKhach_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(220, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(246, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Danh mục khách hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(411, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(411, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày sinh khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(40, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giới tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(37, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(37, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 0;
<<<<<<< HEAD:WindowsFormsApp1/frmKhachHang.Designer.cs
            this.label1.Text = "Mã khách hàng";
=======
            this.label1.Text = "Danh Mục Khách Hàng";
            // 
            // chkGioiTinhKH
            // 
            this.chkGioiTinhKH.AutoSize = true;
            this.chkGioiTinhKH.Checked = true;
            this.chkGioiTinhKH.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGioiTinhKH.Location = new System.Drawing.Point(204, 153);
            this.chkGioiTinhKH.Name = "chkGioiTinhKH";
            this.chkGioiTinhKH.Size = new System.Drawing.Size(66, 24);
            this.chkGioiTinhKH.TabIndex = 13;
            this.chkGioiTinhKH.Text = "Nam";
            this.chkGioiTinhKH.UseVisualStyleBackColor = true;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(204, 99);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(173, 22);
            this.txtTenKH.TabIndex = 6;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(204, 51);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(173, 22);
            this.txtMaKH.TabIndex = 5;
            // 
            // txtSoDiem
            // 
            this.txtSoDiem.Location = new System.Drawing.Point(670, 154);
            this.txtSoDiem.Name = "txtSoDiem";
            this.txtSoDiem.Size = new System.Drawing.Size(200, 22);
            this.txtSoDiem.TabIndex = 16;
>>>>>>> f6b493ae7691762a7600f9de0469d1a279d38e66:WindowsFormsApp1/KhachHang.Designer.cs
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKhachHang.Location = new System.Drawing.Point(0, 183);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.RowHeadersWidth = 51;
            this.dgvKhachHang.RowTemplate.Height = 24;
            this.dgvKhachHang.Size = new System.Drawing.Size(981, 278);
            this.dgvKhachHang.TabIndex = 2;
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 513);
            this.Controls.Add(this.dgvKhachHang);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmKhachHang";
            this.Text = "Danh mục khách hàng";
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.MaskedTextBox mtbDienThoai;
        private System.Windows.Forms.DateTimePicker NgSinhKhach;
        private System.Windows.Forms.CheckBox chkGioiTinhKhach;
        private System.Windows.Forms.TextBox txtTenKhach;
        private System.Windows.Forms.TextBox txtMaKhach;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
    }
}