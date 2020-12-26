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
            // 
            // ribbonExit
            // 
            this.ribbonExit.Name = "ribbonExit";
            this.ribbonExit.Text = "Thoát";
            this.ribbonExit.Click += new System.EventHandler(this.ribbonExit_Click);
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Text = "ribbonPanel1";
            // 
            // ribbonForm
            // 
            this.ribbonForm.Font = new System.Drawing.Font("Segoe UI", 9.6F);
            this.ribbonForm.Location = new System.Drawing.Point(0, 0);
            this.ribbonForm.Minimized = false;
            this.ribbonForm.Name = "ribbonForm";
            // 
            // 
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
            // ribbonCategory
            // 
            this.ribbonCategory.Name = "ribbonCategory";
            this.ribbonCategory.Panels.Add(this.ribbonCustomer);
            this.ribbonCategory.Panels.Add(this.ribbonProduct);
            this.ribbonCategory.Panels.Add(this.ribbonEmployee);
            this.ribbonCategory.Text = "Danh mục";
            // 
            // ribbonCustomer
            // 
            this.ribbonCustomer.Name = "ribbonCustomer";
            this.ribbonCustomer.Text = "Khách hàng";
            this.ribbonCustomer.Click += new System.EventHandler(this.ribbonCustomer_Click);
            // 
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
            // 
            this.ribbonReport.Name = "ribbonReport";
            this.ribbonReport.Panels.Add(this.ribbonStock);
            this.ribbonReport.Panels.Add(this.ribbonRevenue);
            this.ribbonReport.Text = "Báo cáo";
            // 
            // ribbonStock
            // 
            this.ribbonStock.Name = "ribbonStock";
            this.ribbonStock.Text = "Hàng tồn kho";
            // 
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
    }
}

