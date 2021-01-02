namespace WindowsFormsApp1
{
    partial class KhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhachHang));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.frmKhachHang = new System.Windows.Forms.Panel();
            this.mtbDienThoai = new System.Windows.Forms.MaskedTextBox();
            this.chkGioiTinhKhach = new System.Windows.Forms.CheckBox();
            this.NgSinhKhach = new System.Windows.Forms.DateTimePicker();
            this.txtTenKhach = new System.Windows.Forms.TextBox();
            this.txtMaKhach = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkGioiTinhKH = new System.Windows.Forms.CheckBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtSoDiem = new System.Windows.Forms.TextBox();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.frmKhachHang.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(0, 389);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(894, 61);
            this.panel1.TabIndex = 0;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(777, 22);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 17;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(42, 22);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(189, 22);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnBoQua
            // 
            this.btnBoQua.Location = new System.Drawing.Point(630, 22);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(75, 23);
            this.btnBoQua.TabIndex = 16;
            this.btnBoQua.Text = "Bỏ qua";
            this.btnBoQua.UseVisualStyleBackColor = true;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(336, 22);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(483, 22);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 15;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
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
            // 
            // mtbDienThoai
            // 
            this.mtbDienThoai.Location = new System.Drawing.Point(670, 99);
            this.mtbDienThoai.Mask = "(999) 000-0000";
            this.mtbDienThoai.Name = "mtbDienThoai";
            this.mtbDienThoai.Size = new System.Drawing.Size(176, 26);
            this.mtbDienThoai.TabIndex = 22;
            this.mtbDienThoai.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mtbDienThoai_KeyUp);
            // 
            // chkGioiTinhKhach
            // 
            this.chkGioiTinhKhach.AutoSize = true;
            this.chkGioiTinhKhach.Checked = true;
            this.chkGioiTinhKhach.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGioiTinhKhach.Location = new System.Drawing.Point(211, 149);
            this.chkGioiTinhKhach.Name = "chkGioiTinhKhach";
            this.chkGioiTinhKhach.Size = new System.Drawing.Size(66, 24);
            this.chkGioiTinhKhach.TabIndex = 21;
            this.chkGioiTinhKhach.Text = "Nam";
            this.chkGioiTinhKhach.UseVisualStyleBackColor = true;
            this.chkGioiTinhKhach.KeyUp += new System.Windows.Forms.KeyEventHandler(this.chkGioiTinhKhach_KeyUp);
            // 
            // NgSinhKhach
            // 
            this.NgSinhKhach.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.NgSinhKhach.Location = new System.Drawing.Point(670, 46);
            this.NgSinhKhach.Name = "NgSinhKhach";
            this.NgSinhKhach.Size = new System.Drawing.Size(182, 26);
            this.NgSinhKhach.TabIndex = 19;
            this.NgSinhKhach.KeyUp += new System.Windows.Forms.KeyEventHandler(this.NgSinhKhach_KeyUp);
            // 
            // txtTenKhach
            // 
            this.txtTenKhach.Location = new System.Drawing.Point(211, 101);
            this.txtTenKhach.Name = "txtTenKhach";
            this.txtTenKhach.Size = new System.Drawing.Size(167, 26);
            this.txtTenKhach.TabIndex = 16;
            this.txtTenKhach.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTenKhach_KeyUp);
            // 
            // txtMaKhach
            // 
            this.txtMaKhach.Location = new System.Drawing.Point(211, 51);
            this.txtMaKhach.Name = "txtMaKhach";
            this.txtMaKhach.Size = new System.Drawing.Size(167, 26);
            this.txtMaKhach.TabIndex = 15;
            this.txtMaKhach.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMaKhach_KeyUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(451, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ngày sinh khách hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(37, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Giới tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(451, 102);
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
            this.label4.Location = new System.Drawing.Point(451, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(37, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(37, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(248, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 25);
            this.label1.TabIndex = 0;
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
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKhachHang.Location = new System.Drawing.Point(0, 214);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.RowHeadersWidth = 51;
            this.dgvKhachHang.RowTemplate.Height = 24;
            this.dgvKhachHang.Size = new System.Drawing.Size(894, 175);
            this.dgvKhachHang.TabIndex = 3;
            this.dgvKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellClick);
            // 
            // KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 450);
            this.Controls.Add(this.dgvKhachHang);
            this.Controls.Add(this.frmKhachHang);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KhachHang";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh mục khách hàng";
            this.Load += new System.EventHandler(this.KhachHang_Load_1);
            this.panel1.ResumeLayout(false);
            this.frmKhachHang.ResumeLayout(false);
            this.frmKhachHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel frmKhachHang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkGioiTinhKH;
        private System.Windows.Forms.TextBox txtSoDiem;
        private System.Windows.Forms.TextBox txtTenKhach;
        private System.Windows.Forms.TextBox txtMaKhach;
        private System.Windows.Forms.DateTimePicker NgSinhKhach;
        private System.Windows.Forms.CheckBox chkGioiTinhKhach;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.MaskedTextBox mtbDienThoai;
    }
}