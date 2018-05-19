namespace QuanLyPhongMay.Views
{
    partial class frm_PhanQuyen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_PhanQuyen));
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnExit = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.tileNavCategory1 = new DevExpress.XtraBars.Navigation.TileNavCategory();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.scTimNguoiDung = new DevExpress.XtraEditors.SearchControl();
            this.dtgvTimNguoiDung = new System.Windows.Forms.DataGridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gcPhanQUyen = new DevExpress.XtraEditors.GroupControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TenChucNang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xem = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Them = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Sua = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Xoa = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtPhanQuyen = new System.Windows.Forms.TextBox();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.labelPQ = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scTimNguoiDung.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTimNguoiDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhanQUyen)).BeginInit();
            this.gcPhanQUyen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager
            // 
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnSave,
            this.barButtonItem2,
            this.btnExit,
            this.barButtonItem3,
            this.barButtonItem4});
            this.barManager.MaxItemId = 6;
            this.barManager.StatusBar = this.bar3;
            // 
            // btnSave
            // 
            this.btnSave.Caption = "Lưu";
            this.btnSave.Id = 0;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Name = "btnSave";
            // 
            // btnExit
            // 
            this.btnExit.Caption = "Thoát";
            this.btnExit.Id = 2;
            this.btnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.Image")));
            this.btnExit.Name = "btnExit";
            // 
            // bar3
            // 
            this.bar3.BarName = "Custom 3";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem3, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem4, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Custom 3";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager;
            this.barDockControlTop.Size = new System.Drawing.Size(1022, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 409);
            this.barDockControlBottom.Manager = this.barManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(1022, 43);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 409);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1022, 0);
            this.barDockControlRight.Manager = this.barManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 409);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.ActAsDropDown = true;
            this.barButtonItem2.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.barButtonItem2.Caption = "Thoát";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // tileNavCategory1
            // 
            this.tileNavCategory1.Name = "tileNavCategory1";
            this.tileNavCategory1.OwnerCollection = null;
            // 
            // 
            // 
            this.tileNavCategory1.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Lưu";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // bar1
            // 
            this.bar1.BarName = "Main menu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSave, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnExit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Main menu";
            // 
            // scTimNguoiDung
            // 
            this.scTimNguoiDung.Location = new System.Drawing.Point(9, 24);
            this.scTimNguoiDung.MenuManager = this.barManager;
            this.scTimNguoiDung.Name = "scTimNguoiDung";
            this.scTimNguoiDung.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.scTimNguoiDung.Size = new System.Drawing.Size(155, 20);
            this.scTimNguoiDung.TabIndex = 18;
            // 
            // dtgvTimNguoiDung
            // 
            this.dtgvTimNguoiDung.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvTimNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTimNguoiDung.Location = new System.Drawing.Point(9, 49);
            this.dtgvTimNguoiDung.Name = "dtgvTimNguoiDung";
            this.dtgvTimNguoiDung.Size = new System.Drawing.Size(271, 312);
            this.dtgvTimNguoiDung.TabIndex = 19;
            // 
            // groupControl1
            // 
            this.groupControl1.AutoSize = true;
            this.groupControl1.Controls.Add(this.scTimNguoiDung);
            this.groupControl1.Controls.Add(this.dtgvTimNguoiDung);
            this.groupControl1.Location = new System.Drawing.Point(0, 37);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(283, 366);
            this.groupControl1.TabIndex = 20;
            this.groupControl1.Text = "Tìm Người Dùng";
            // 
            // gcPhanQUyen
            // 
            this.gcPhanQUyen.Controls.Add(this.txtPhanQuyen);
            this.gcPhanQUyen.Controls.Add(this.dataGridView1);
            this.gcPhanQUyen.Location = new System.Drawing.Point(286, 37);
            this.gcPhanQUyen.Name = "gcPhanQUyen";
            this.gcPhanQUyen.Size = new System.Drawing.Size(736, 366);
            this.gcPhanQUyen.TabIndex = 25;
            this.gcPhanQUyen.Text = "Phân Quyền Cho";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenChucNang,
            this.Xem,
            this.Them,
            this.Sua,
            this.Xoa});
            this.dataGridView1.Location = new System.Drawing.Point(5, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(726, 312);
            this.dataGridView1.TabIndex = 0;
            // 
            // TenChucNang
            // 
            this.TenChucNang.HeaderText = "Tên Chức Năng";
            this.TenChucNang.Name = "TenChucNang";
            this.TenChucNang.ReadOnly = true;
            this.TenChucNang.Width = 282;
            // 
            // Xem
            // 
            this.Xem.HeaderText = "Xem";
            this.Xem.Name = "Xem";
            this.Xem.ReadOnly = true;
            // 
            // Them
            // 
            this.Them.HeaderText = "Thêm";
            this.Them.Name = "Them";
            this.Them.ReadOnly = true;
            this.Them.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Them.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Sua
            // 
            this.Sua.HeaderText = "Sửa";
            this.Sua.Name = "Sua";
            this.Sua.ReadOnly = true;
            // 
            // Xoa
            // 
            this.Xoa.HeaderText = "Xóa";
            this.Xoa.Name = "Xoa";
            this.Xoa.ReadOnly = true;
            // 
            // txtPhanQuyen
            // 
            this.txtPhanQuyen.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhanQuyen.Location = new System.Drawing.Point(5, 24);
            this.txtPhanQuyen.Name = "txtPhanQuyen";
            this.txtPhanQuyen.ReadOnly = true;
            this.txtPhanQuyen.Size = new System.Drawing.Size(205, 20);
            this.txtPhanQuyen.TabIndex = 1;
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Lưu";
            this.barButtonItem3.Id = 4;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Thoát";
            this.barButtonItem4.Id = 5;
            this.barButtonItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // labelPQ
            // 
            this.labelPQ.AutoSize = true;
            this.labelPQ.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPQ.Location = new System.Drawing.Point(332, 9);
            this.labelPQ.Name = "labelPQ";
            this.labelPQ.Size = new System.Drawing.Size(358, 22);
            this.labelPQ.TabIndex = 30;
            this.labelPQ.Text = "QUẢN LÝ PHÂN QUYỀN NGƯỜI DÙNG";
            // 
            // frm_PhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 452);
            this.Controls.Add(this.labelPQ);
            this.Controls.Add(this.gcPhanQUyen);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frm_PhanQuyen";
            this.Text = "Phân Quyền Người Dùng";
            this.Load += new System.EventHandler(this.frm_PhanQuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scTimNguoiDung.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTimNguoiDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcPhanQUyen)).EndInit();
            this.gcPhanQUyen.ResumeLayout(false);
            this.gcPhanQUyen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarButtonItem btnExit;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Navigation.TileNavCategory tileNavCategory1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.Bar bar1;
        private System.Windows.Forms.DataGridView dtgvTimNguoiDung;
        private DevExpress.XtraEditors.SearchControl scTimNguoiDung;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl gcPhanQUyen;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenChucNang;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Xem;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Them;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Sua;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Xoa;
        private System.Windows.Forms.TextBox txtPhanQuyen;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private System.Windows.Forms.Label labelPQ;
    }
}