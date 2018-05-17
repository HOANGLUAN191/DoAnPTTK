namespace QuanLyPhongMay
{
    partial class frm_main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.imgHeThong = new DevExpress.Utils.ImageCollection(this.components);
            this.btnDangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnMatKhau = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.bntPhanQuyen = new DevExpress.XtraBars.BarButtonItem();
            this.btnBackup = new DevExpress.XtraBars.BarButtonItem();
            this.btnRestore = new DevExpress.XtraBars.BarButtonItem();
            this.skinRibbonGalleryBarItem = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.rpcQLCT = new DevExpress.XtraBars.Ribbon.RibbonPageCategory();
            this.rbChucNang = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbTroGiup = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbHeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgBaoMat = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgDuLieu = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgGiaoDien = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbDanhMuc = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHeThong)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Images = this.imgHeThong;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnDangNhap,
            this.btnMatKhau,
            this.btnDangXuat,
            this.bntPhanQuyen,
            this.btnBackup,
            this.btnRestore,
            this.skinRibbonGalleryBarItem,
            this.barSubItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 9;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.PageCategories.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageCategory[] {
            this.rpcQLCT});
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbHeThong,
            this.rbDanhMuc});
            this.ribbonControl1.Size = new System.Drawing.Size(758, 143);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // imgHeThong
            // 
            this.imgHeThong.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imgHeThong.ImageStream")));
            this.imgHeThong.Images.SetKeyName(0, "Backup.png");
            this.imgHeThong.Images.SetKeyName(1, "Logout-icon.png");
            this.imgHeThong.Images.SetKeyName(2, "pass.png");
            this.imgHeThong.Images.SetKeyName(3, "phanquyen.png");
            this.imgHeThong.Images.SetKeyName(4, "restore.png");
            this.imgHeThong.Images.SetKeyName(5, "dangnhap.png");
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Caption = "Đăng Nhập";
            this.btnDangNhap.Id = 1;
            this.btnDangNhap.ImageOptions.ImageIndex = 5;
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnDangNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangNhap_ItemClick);
            // 
            // btnMatKhau
            // 
            this.btnMatKhau.Caption = "Mật Khẩu";
            this.btnMatKhau.Id = 2;
            this.btnMatKhau.ImageOptions.ImageIndex = 2;
            this.btnMatKhau.Name = "btnMatKhau";
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Caption = "Đăng Xuất";
            this.btnDangXuat.Id = 3;
            this.btnDangXuat.ImageOptions.ImageIndex = 1;
            this.btnDangXuat.Name = "btnDangXuat";
            // 
            // bntPhanQuyen
            // 
            this.bntPhanQuyen.Caption = "Phân Quyền Người Dùng";
            this.bntPhanQuyen.Id = 4;
            this.bntPhanQuyen.ImageOptions.ImageIndex = 3;
            this.bntPhanQuyen.Name = "bntPhanQuyen";
            this.bntPhanQuyen.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // btnBackup
            // 
            this.btnBackup.Caption = "Sao Lưu Dữ Liệu";
            this.btnBackup.Id = 5;
            this.btnBackup.ImageOptions.ImageIndex = 0;
            this.btnBackup.Name = "btnBackup";
            // 
            // btnRestore
            // 
            this.btnRestore.Caption = "Phục Hồi Dữ Liệu";
            this.btnRestore.Id = 6;
            this.btnRestore.ImageOptions.ImageIndex = 4;
            this.btnRestore.Name = "btnRestore";
            // 
            // skinRibbonGalleryBarItem
            // 
            this.skinRibbonGalleryBarItem.Caption = "skinRibbonGalleryBarItem";
            this.skinRibbonGalleryBarItem.Id = 7;
            this.skinRibbonGalleryBarItem.Name = "skinRibbonGalleryBarItem";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "barSubItem1";
            this.barSubItem1.Id = 8;
            this.barSubItem1.Name = "barSubItem1";
            // 
            // rpcQLCT
            // 
            this.rpcQLCT.Name = "rpcQLCT";
            this.rpcQLCT.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbChucNang,
            this.rbTroGiup});
            this.rpcQLCT.Text = "QUẢN LÝ CÔNG TÁC THỰC HÀNH TIN HỌC";
            // 
            // rbChucNang
            // 
            this.rbChucNang.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.rbChucNang.Name = "rbChucNang";
            this.rbChucNang.Text = "Chức Năng";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // rbTroGiup
            // 
            this.rbTroGiup.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.rbTroGiup.Name = "rbTroGiup";
            this.rbTroGiup.Text = "Trợ Giúp";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "ribbonPageGroup4";
            // 
            // rbHeThong
            // 
            this.rbHeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgBaoMat,
            this.rpgDuLieu,
            this.rpgGiaoDien});
            this.rbHeThong.Name = "rbHeThong";
            this.rbHeThong.Text = "Hệ Thống";
            // 
            // rpgBaoMat
            // 
            this.rpgBaoMat.ItemLinks.Add(this.btnDangNhap);
            this.rpgBaoMat.ItemLinks.Add(this.btnMatKhau);
            this.rpgBaoMat.ItemLinks.Add(this.btnDangXuat);
            this.rpgBaoMat.ItemLinks.Add(this.bntPhanQuyen);
            this.rpgBaoMat.Name = "rpgBaoMat";
            this.rpgBaoMat.Text = "Bảo Mật";
            // 
            // rpgDuLieu
            // 
            this.rpgDuLieu.ItemLinks.Add(this.btnBackup);
            this.rpgDuLieu.ItemLinks.Add(this.btnRestore);
            this.rpgDuLieu.Name = "rpgDuLieu";
            this.rpgDuLieu.Text = "Dữ Liệu";
            // 
            // rpgGiaoDien
            // 
            this.rpgGiaoDien.ItemLinks.Add(this.skinRibbonGalleryBarItem);
            this.rpgGiaoDien.Name = "rpgGiaoDien";
            this.rpgGiaoDien.Text = "Giao Diện";
            // 
            // rbDanhMuc
            // 
            this.rbDanhMuc.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.rbDanhMuc.Name = "rbDanhMuc";
            this.rbDanhMuc.Text = "Danh Mục";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "ribbonPageGroup3";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 329);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(758, 31);
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 360);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "frm_main";
            this.Ribbon = this.ribbonControl1;
            this.StatusBar = this.ribbonStatusBar1;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_main_FormClosing);
            this.Load += new System.EventHandler(this.frm_main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHeThong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbHeThong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgBaoMat;
        private DevExpress.XtraBars.Ribbon.RibbonPageCategory rpcQLCT;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbChucNang;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbDanhMuc;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbTroGiup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btnDangNhap;
        private DevExpress.XtraBars.BarButtonItem btnMatKhau;
        private DevExpress.XtraBars.BarButtonItem btnDangXuat;
        private DevExpress.XtraBars.BarButtonItem bntPhanQuyen;
        private DevExpress.XtraBars.BarButtonItem btnBackup;
        private DevExpress.XtraBars.BarButtonItem btnRestore;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgDuLieu;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgGiaoDien;
        private DevExpress.Utils.ImageCollection imgHeThong;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
    }
}

