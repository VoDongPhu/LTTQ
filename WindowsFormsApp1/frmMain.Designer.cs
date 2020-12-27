namespace WindowsFormsApp1
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
<<<<<<< HEAD
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimKiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoaDonBan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBCHangTon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBCDoanhThu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 28);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(895, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuDanhMuc,
            this.mnuHoaDon,
            this.mnuBaoCao});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(895, 28);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThoat});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(69, 24);
            this.mnuFile.Text = "&Tệp tin";
            this.mnuFile.Click += new System.EventHandler(this.mnuFiles_Click);
=======
            this.ribbonFile = new System.Windows.Forms.RibbonTab();
            this.ribbonExit = new System.Windows.Forms.RibbonPanel();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.ribbonForm = new System.Windows.Forms.Ribbon();
            this.ribbonCategory = new System.Windows.Forms.RibbonTab();
            this.ribbonCustomer = new System.Windows.Forms.RibbonPanel();
            this.ribbonProduct = new System.Windows.Forms.RibbonPanel();
            this.ribbonEmployee = new System.Windows.Forms.RibbonPanel();
            this.ribbonBill = new System.Windows.Forms.RibbonTab();
            this.ribbonSaleBill = new System.Windows.Forms.RibbonPanel();
            this.ribbonSearchBill = new System.Windows.Forms.RibbonPanel();
            this.ribbonReport = new System.Windows.Forms.RibbonTab();
            this.ribbonStock = new System.Windows.Forms.RibbonPanel();
            this.ribbonRevenue = new System.Windows.Forms.RibbonPanel();
            this.ribbonOrbMenuItem1 = new System.Windows.Forms.RibbonOrbMenuItem();
            this.SuspendLayout();
            // 
            // ribbonFile
            // 
            this.ribbonFile.Name = "ribbonFile";
            this.ribbonFile.Panels.Add(this.ribbonExit);
            this.ribbonFile.Text = "Tệp tin";
>>>>>>> 562161aa30231269bdee86a6044ca31806b25285
            // 
            // ribbonExit
            // 
<<<<<<< HEAD
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnuThoat.Size = new System.Drawing.Size(183, 26);
            this.mnuThoat.Text = "Thoát";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
=======
            this.ribbonExit.Name = "ribbonExit";
            this.ribbonExit.Text = "Thoát";
            this.ribbonExit.Click += new System.EventHandler(this.ribbonExit_Click);
>>>>>>> 562161aa30231269bdee86a6044ca31806b25285
            // 
            // ribbonPanel1
            // 
<<<<<<< HEAD
            this.mnuDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNhanVien,
            this.mnuKhachHang,
            this.mnuSanPham,
            this.mnuTimKiem});
            this.mnuDanhMuc.Name = "mnuDanhMuc";
            this.mnuDanhMuc.Size = new System.Drawing.Size(90, 24);
            this.mnuDanhMuc.Text = "&Danh mục";
=======
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Text = "ribbonPanel1";
>>>>>>> 562161aa30231269bdee86a6044ca31806b25285
            // 
            // ribbonForm
            // 
<<<<<<< HEAD
            this.mnuNhanVien.Name = "mnuNhanVien";
            this.mnuNhanVien.Size = new System.Drawing.Size(224, 26);
            this.mnuNhanVien.Text = "&Nhân viên";
            this.mnuNhanVien.Click += new System.EventHandler(this.mnuNhanVien_Click);
=======
            this.ribbonForm.Font = new System.Drawing.Font("Segoe UI", 9.6F);
            this.ribbonForm.Location = new System.Drawing.Point(0, 0);
            this.ribbonForm.Minimized = false;
            this.ribbonForm.Name = "ribbonForm";
>>>>>>> 562161aa30231269bdee86a6044ca31806b25285
            // 
            // 
<<<<<<< HEAD
            this.mnuKhachHang.Name = "mnuKhachHang";
            this.mnuKhachHang.Size = new System.Drawing.Size(224, 26);
            this.mnuKhachHang.Text = "&Khách hàng";
            this.mnuKhachHang.Click += new System.EventHandler(this.mnuKhachHang_Click);
=======
>>>>>>> 562161aa30231269bdee86a6044ca31806b25285
            // 
            this.ribbonForm.OrbDropDown.BorderRoundness = 8;
            this.ribbonForm.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbonForm.OrbDropDown.Name = "";
            this.ribbonForm.OrbDropDown.Size = new System.Drawing.Size(0, 72);
            this.ribbonForm.OrbDropDown.TabIndex = 0;
            this.ribbonForm.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribbonForm.Size = new System.Drawing.Size(895, 129);
            this.ribbonForm.TabIndex = 2;
            this.ribbonForm.Tabs.Add(this.ribbonFile);
            this.ribbonForm.Tabs.Add(this.ribbonCategory);
            this.ribbonForm.Tabs.Add(this.ribbonBill);
            this.ribbonForm.Tabs.Add(this.ribbonReport);
            this.ribbonForm.Text = "Thoát";
            // 
<<<<<<< HEAD
            this.mnuSanPham.Name = "mnuSanPham";
            this.mnuSanPham.Size = new System.Drawing.Size(224, 26);
            this.mnuSanPham.Text = "&Sản Phẩm";
            this.mnuSanPham.Click += new System.EventHandler(this.mnuSanPham_Click);
            // 
            // mnuTimKiem
            // 
            this.mnuTimKiem.Name = "mnuTimKiem";
            this.mnuTimKiem.Size = new System.Drawing.Size(224, 26);
            this.mnuTimKiem.Text = "Tìm kiếm";
            this.mnuTimKiem.Click += new System.EventHandler(this.mnuTimKiem_Click);
            // 
            // mnuHoaDon
            // 
            this.mnuHoaDon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHoaDonBan});
            this.mnuHoaDon.Name = "mnuHoaDon";
            this.mnuHoaDon.Size = new System.Drawing.Size(81, 24);
            this.mnuHoaDon.Text = "&Hóa đơn";
=======
            // ribbonCategory
            // 
            this.ribbonCategory.Name = "ribbonCategory";
            this.ribbonCategory.Panels.Add(this.ribbonCustomer);
            this.ribbonCategory.Panels.Add(this.ribbonProduct);
            this.ribbonCategory.Panels.Add(this.ribbonEmployee);
            this.ribbonCategory.Text = "Danh mục";
            // 
            // ribbonCustomer
>>>>>>> 562161aa30231269bdee86a6044ca31806b25285
            // 
            this.ribbonCustomer.Name = "ribbonCustomer";
            this.ribbonCustomer.Text = "Khách hàng";
            this.ribbonCustomer.Click += new System.EventHandler(this.ribbonCustomer_Click);
            // 
<<<<<<< HEAD
            this.mnuHoaDonBan.Name = "mnuHoaDonBan";
            this.mnuHoaDonBan.Size = new System.Drawing.Size(179, 26);
            this.mnuHoaDonBan.Text = "Hóa đơn bán";
            this.mnuHoaDonBan.Click += new System.EventHandler(this.mnuHoaDonBan_Click);
            // 
            // mnuBaoCao
            // 
            this.mnuBaoCao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBCHangTon,
            this.mnuBCDoanhThu,
            this.mnuHangNhap});
            this.mnuBaoCao.Name = "mnuBaoCao";
            this.mnuBaoCao.Size = new System.Drawing.Size(77, 24);
            this.mnuBaoCao.Text = "&Báo cáo";
=======
            // ribbonProduct
            // 
            this.ribbonProduct.Name = "ribbonProduct";
            this.ribbonProduct.Text = "Sản phẩm";
            this.ribbonProduct.Click += new System.EventHandler(this.ribbonProduct_Click);
            // 
            // ribbonEmployee
            // 
            this.ribbonEmployee.Name = "ribbonEmployee";
            this.ribbonEmployee.Text = "Nhân viên";
            this.ribbonEmployee.Click += new System.EventHandler(this.ribbonEmployee_Click);
            // 
            // ribbonBill
            // 
            this.ribbonBill.Name = "ribbonBill";
            this.ribbonBill.Panels.Add(this.ribbonSaleBill);
            this.ribbonBill.Panels.Add(this.ribbonSearchBill);
            this.ribbonBill.Text = "Hóa đơn";
            // 
            // ribbonSaleBill
            // 
            this.ribbonSaleBill.Name = "ribbonSaleBill";
            this.ribbonSaleBill.Text = "Hóa đơn bán";
            this.ribbonSaleBill.Click += new System.EventHandler(this.ribbonSaleBill_Click);
            // 
            // ribbonSearchBill
            // 
            this.ribbonSearchBill.Name = "ribbonSearchBill";
            this.ribbonSearchBill.Text = "Tìm kiếm hóa đơn";
            this.ribbonSearchBill.Click += new System.EventHandler(this.ribbonSearchBill_Click);
            // 
            // ribbonReport
>>>>>>> 562161aa30231269bdee86a6044ca31806b25285
            // 
            this.ribbonReport.Name = "ribbonReport";
            this.ribbonReport.Panels.Add(this.ribbonStock);
            this.ribbonReport.Panels.Add(this.ribbonRevenue);
            this.ribbonReport.Text = "Báo cáo";
            // 
<<<<<<< HEAD
            this.mnuBCHangTon.Name = "mnuBCHangTon";
            this.mnuBCHangTon.Size = new System.Drawing.Size(224, 26);
            this.mnuBCHangTon.Text = "Hàng tồn";
=======
            // ribbonStock
>>>>>>> 562161aa30231269bdee86a6044ca31806b25285
            // 
            this.ribbonStock.Name = "ribbonStock";
            this.ribbonStock.Text = "Hàng tồn kho";
            // 
<<<<<<< HEAD
            this.mnuBCDoanhThu.Name = "mnuBCDoanhThu";
            this.mnuBCDoanhThu.Size = new System.Drawing.Size(224, 26);
            this.mnuBCDoanhThu.Text = "Doanh thu";
=======
            // ribbonRevenue
            // 
            this.ribbonRevenue.Name = "ribbonRevenue";
            this.ribbonRevenue.Text = "Doanh thu";
            // 
            // ribbonOrbMenuItem1
            // 
            this.ribbonOrbMenuItem1.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem1.Image")));
            this.ribbonOrbMenuItem1.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem1.LargeImage")));
            this.ribbonOrbMenuItem1.Name = "ribbonOrbMenuItem1";
            this.ribbonOrbMenuItem1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem1.SmallImage")));
            this.ribbonOrbMenuItem1.Text = "ribbonOrbMenuItem1";
>>>>>>> 562161aa30231269bdee86a6044ca31806b25285
            // 
            // mnuHangNhap
            // 
            this.mnuHangNhap.Name = "mnuHangNhap";
            this.mnuHangNhap.Size = new System.Drawing.Size(224, 26);
            this.mnuHangNhap.Text = "Hàng nhập";
            this.mnuHangNhap.Click += new System.EventHandler(this.mnuHangNhap_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(895, 364);
            this.Controls.Add(this.ribbonForm);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmMain";
            this.Text = "Chương trình quản lý bán hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }


        #endregion
<<<<<<< HEAD

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem mnuNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnuKhachHang;
        private System.Windows.Forms.ToolStripMenuItem mnuSanPham;
        private System.Windows.Forms.ToolStripMenuItem mnuHoaDon;
        private System.Windows.Forms.ToolStripMenuItem mnuHoaDonBan;
        private System.Windows.Forms.ToolStripMenuItem mnuBaoCao;
        private System.Windows.Forms.ToolStripMenuItem mnuBCHangTon;
        private System.Windows.Forms.ToolStripMenuItem mnuBCDoanhThu;
        private System.Windows.Forms.ToolStripMenuItem mnuTimKiem;
        private System.Windows.Forms.ToolStripMenuItem mnuHangNhap;
=======
        private System.Windows.Forms.RibbonTab ribbonFile;
        private System.Windows.Forms.RibbonPanel ribbonExit;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.Ribbon ribbonForm;
        private System.Windows.Forms.RibbonTab ribbonCategory;
        private System.Windows.Forms.RibbonPanel ribbonCustomer;
        private System.Windows.Forms.RibbonPanel ribbonProduct;
        private System.Windows.Forms.RibbonPanel ribbonEmployee;
        private System.Windows.Forms.RibbonTab ribbonBill;
        private System.Windows.Forms.RibbonPanel ribbonSaleBill;
        private System.Windows.Forms.RibbonPanel ribbonSearchBill;
        private System.Windows.Forms.RibbonTab ribbonReport;
        private System.Windows.Forms.RibbonPanel ribbonStock;
        private System.Windows.Forms.RibbonPanel ribbonRevenue;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonOrbMenuItem1;
>>>>>>> 562161aa30231269bdee86a6044ca31806b25285
    }
}

