﻿namespace BanVeXePhuongTrang.GUI
{
    partial class frmTaiKhoan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.cbQuyenHan = new System.Windows.Forms.ComboBox();
            this.chkPass = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.txtMatKhau = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTenDangNhap = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.dtNhanVien = new System.Windows.Forms.DataGridView();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuyenHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dockContainerItem2 = new DevComponents.DotNetBar.DockContainerItem();
            this.panelDockContainer2 = new DevComponents.DotNetBar.PanelDockContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTongLoaiThuoc = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.dockSite7 = new DevComponents.DotNetBar.DockSite();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.dockSite3 = new DevComponents.DotNetBar.DockSite();
            this.bar2 = new DevComponents.DotNetBar.Bar();
            this.txtTenNhanVien = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.mathuoc = new DevComponents.DotNetBar.LabelX();
            this.dockSite4 = new DevComponents.DotNetBar.DockSite();
            this.dockSite5 = new DevComponents.DotNetBar.DockSite();
            this.dockSite8 = new DevComponents.DotNetBar.DockSite();
            this.dnbNhomThuoc = new DevComponents.DotNetBar.DotNetBarManager(this.components);
            this.dockSite1 = new DevComponents.DotNetBar.DockSite();
            this.dockSite2 = new DevComponents.DotNetBar.DockSite();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.panelDockContainer1 = new DevComponents.DotNetBar.PanelDockContainer();
            this.btThemMoi = new DevComponents.DotNetBar.ButtonX();
            this.btluu = new DevComponents.DotNetBar.ButtonX();
            this.btThoat = new DevComponents.DotNetBar.ButtonX();
            this.btxoa = new DevComponents.DotNetBar.ButtonX();
            this.btthem = new DevComponents.DotNetBar.ButtonX();
            this.txtMaNhanVien = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dockContainerItem1 = new DevComponents.DotNetBar.DockContainerItem();
            this.dockSite6 = new DevComponents.DotNetBar.DockSite();
            ((System.ComponentModel.ISupportInitialize)(this.dtNhanVien)).BeginInit();
            this.panelDockContainer2.SuspendLayout();
            this.dockSite3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar2)).BeginInit();
            this.bar2.SuspendLayout();
            this.dockSite2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.bar1.SuspendLayout();
            this.panelDockContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelX6.Location = new System.Drawing.Point(10, 135);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(111, 17);
            this.labelX6.TabIndex = 19;
            this.labelX6.Text = "Mật khẩu";
            // 
            // cbQuyenHan
            // 
            this.cbQuyenHan.FormattingEnabled = true;
            this.cbQuyenHan.Items.AddRange(new object[] {
            "Quản Trị Viên",
            "Ban Giám Đốc",
            "Nhân Viên"});
            this.cbQuyenHan.Location = new System.Drawing.Point(11, 203);
            this.cbQuyenHan.Name = "cbQuyenHan";
            this.cbQuyenHan.Size = new System.Drawing.Size(162, 21);
            this.cbQuyenHan.TabIndex = 25;
            // 
            // chkPass
            // 
            this.chkPass.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.chkPass.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkPass.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkPass.Location = new System.Drawing.Point(179, 155);
            this.chkPass.Name = "chkPass";
            this.chkPass.Size = new System.Drawing.Size(109, 20);
            this.chkPass.TabIndex = 23;
            this.chkPass.Text = "Hiện mật khẩu";
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelX7.Location = new System.Drawing.Point(10, 180);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(111, 17);
            this.labelX7.TabIndex = 21;
            this.labelX7.Text = "Quyền hạn";
            // 
            // txtMatKhau
            // 
            // 
            // 
            // 
            this.txtMatKhau.Border.Class = "TextBoxBorder";
            this.txtMatKhau.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMatKhau.ButtonCustom.Tooltip = "";
            this.txtMatKhau.ButtonCustom2.Tooltip = "";
            this.txtMatKhau.ForeColor = System.Drawing.Color.Black;
            this.txtMatKhau.Location = new System.Drawing.Point(10, 155);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(163, 20);
            this.txtMatKhau.TabIndex = 20;
            this.txtMatKhau.WatermarkFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMatKhau.WatermarkText = "Nhập mật khẩu";
            // 
            // txtTenDangNhap
            // 
            // 
            // 
            // 
            this.txtTenDangNhap.Border.Class = "TextBoxBorder";
            this.txtTenDangNhap.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenDangNhap.ButtonCustom.Tooltip = "";
            this.txtTenDangNhap.ButtonCustom2.Tooltip = "";
            this.txtTenDangNhap.ForeColor = System.Drawing.Color.Black;
            this.txtTenDangNhap.Location = new System.Drawing.Point(10, 112);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(278, 20);
            this.txtTenDangNhap.TabIndex = 18;
            this.txtTenDangNhap.WatermarkFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenDangNhap.WatermarkText = "Nhập tên đăng nhập";
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelX5.Location = new System.Drawing.Point(10, 92);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(111, 16);
            this.labelX5.TabIndex = 17;
            this.labelX5.Text = "Tên đăng nhập";
            // 
            // dtNhanVien
            // 
            this.dtNhanVien.AllowUserToAddRows = false;
            this.dtNhanVien.AllowUserToDeleteRows = false;
            this.dtNhanVien.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtNhanVien.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dtNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtNhanVien.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNhanVien,
            this.TenNhanVien,
            this.TenDangNhap,
            this.MatKhau,
            this.QuyenHan});
            this.dtNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtNhanVien.GridColor = System.Drawing.SystemColors.Control;
            this.dtNhanVien.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dtNhanVien.Location = new System.Drawing.Point(0, 65);
            this.dtNhanVien.Name = "dtNhanVien";
            this.dtNhanVien.ReadOnly = true;
            this.dtNhanVien.RowHeadersVisible = false;
            this.dtNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtNhanVien.Size = new System.Drawing.Size(430, 386);
            this.dtNhanVien.TabIndex = 35;
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.DataPropertyName = "MaNhanVien";
            this.MaNhanVien.HeaderText = "Mã NV";
            this.MaNhanVien.Name = "MaNhanVien";
            this.MaNhanVien.ReadOnly = true;
            this.MaNhanVien.Visible = false;
            this.MaNhanVien.Width = 135;
            // 
            // TenNhanVien
            // 
            this.TenNhanVien.DataPropertyName = "TenNhanVien";
            this.TenNhanVien.HeaderText = "Tên nhân viên";
            this.TenNhanVien.Name = "TenNhanVien";
            this.TenNhanVien.ReadOnly = true;
            this.TenNhanVien.Width = 135;
            // 
            // TenDangNhap
            // 
            this.TenDangNhap.DataPropertyName = "TenDangNhap";
            this.TenDangNhap.HeaderText = "Tên đăng nhập";
            this.TenDangNhap.Name = "TenDangNhap";
            this.TenDangNhap.ReadOnly = true;
            this.TenDangNhap.Width = 135;
            // 
            // MatKhau
            // 
            this.MatKhau.DataPropertyName = "MatKhau";
            this.MatKhau.HeaderText = "Mật khẩu";
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.ReadOnly = true;
            this.MatKhau.Visible = false;
            this.MatKhau.Width = 135;
            // 
            // QuyenHan
            // 
            this.QuyenHan.DataPropertyName = "QuyenHan";
            this.QuyenHan.HeaderText = "Quyền hạn";
            this.QuyenHan.Name = "QuyenHan";
            this.QuyenHan.ReadOnly = true;
            this.QuyenHan.Width = 135;
            // 
            // dockContainerItem2
            // 
            this.dockContainerItem2.Control = this.panelDockContainer2;
            this.dockContainerItem2.Name = "dockContainerItem2";
            this.dockContainerItem2.Text = "Tìm kiếm nhân viên";
            // 
            // panelDockContainer2
            // 
            this.panelDockContainer2.Controls.Add(this.label2);
            this.panelDockContainer2.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelDockContainer2.Location = new System.Drawing.Point(3, 23);
            this.panelDockContainer2.Name = "panelDockContainer2";
            this.panelDockContainer2.Size = new System.Drawing.Size(424, 36);
            this.panelDockContainer2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelDockContainer2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panelDockContainer2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.panelDockContainer2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelDockContainer2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelDockContainer2.Style.GradientAngle = 90;
            this.panelDockContainer2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(9, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Danh sách tài khoản";
            // 
            // lbTongLoaiThuoc
            // 
            this.lbTongLoaiThuoc.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbTongLoaiThuoc.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbTongLoaiThuoc.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTongLoaiThuoc.ForeColor = System.Drawing.Color.Red;
            this.lbTongLoaiThuoc.Location = new System.Drawing.Point(149, 331);
            this.lbTongLoaiThuoc.Name = "lbTongLoaiThuoc";
            this.lbTongLoaiThuoc.Size = new System.Drawing.Size(73, 20);
            this.lbTongLoaiThuoc.TabIndex = 12;
            this.lbTongLoaiThuoc.Text = "0";
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelX4.Location = new System.Drawing.Point(14, 330);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(132, 20);
            this.labelX4.TabIndex = 9;
            this.labelX4.Text = "Tổng số nhân viên:";
            // 
            // dockSite7
            // 
            this.dockSite7.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite7.Dock = System.Windows.Forms.DockStyle.Top;
            this.dockSite7.Location = new System.Drawing.Point(0, 65);
            this.dockSite7.Name = "dockSite7";
            this.dockSite7.Size = new System.Drawing.Size(430, 0);
            this.dockSite7.TabIndex = 33;
            this.dockSite7.TabStop = false;
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelX2.Location = new System.Drawing.Point(10, 46);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(111, 17);
            this.labelX2.TabIndex = 3;
            this.labelX2.Text = "Tên nhân viên";
            // 
            // dockSite3
            // 
            this.dockSite3.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite3.Controls.Add(this.bar2);
            this.dockSite3.Dock = System.Windows.Forms.DockStyle.Top;
            this.dockSite3.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer(new DevComponents.DotNetBar.DocumentBaseContainer[] {
            ((DevComponents.DotNetBar.DocumentBaseContainer)(new DevComponents.DotNetBar.DocumentBarContainer(this.bar2, 430, 62)))}, DevComponents.DotNetBar.eOrientation.Vertical);
            this.dockSite3.Location = new System.Drawing.Point(0, 0);
            this.dockSite3.Name = "dockSite3";
            this.dockSite3.Size = new System.Drawing.Size(430, 65);
            this.dockSite3.TabIndex = 29;
            this.dockSite3.TabStop = false;
            // 
            // bar2
            // 
            this.bar2.AccessibleDescription = "DotNetBar Bar (bar2)";
            this.bar2.AccessibleName = "DotNetBar Bar";
            this.bar2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.bar2.AutoSyncBarCaption = true;
            this.bar2.CloseSingleTab = true;
            this.bar2.Controls.Add(this.panelDockContainer2);
            this.bar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar2.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Caption;
            this.bar2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.dockContainerItem2});
            this.bar2.LayoutType = DevComponents.DotNetBar.eLayoutType.DockContainer;
            this.bar2.Location = new System.Drawing.Point(0, 0);
            this.bar2.Name = "bar2";
            this.bar2.Size = new System.Drawing.Size(430, 62);
            this.bar2.Stretch = true;
            this.bar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.bar2.TabIndex = 0;
            this.bar2.TabStop = false;
            this.bar2.Text = "Tìm kiếm nhân viên";
            // 
            // txtTenNhanVien
            // 
            // 
            // 
            // 
            this.txtTenNhanVien.Border.Class = "TextBoxBorder";
            this.txtTenNhanVien.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenNhanVien.ButtonCustom.Tooltip = "";
            this.txtTenNhanVien.ButtonCustom2.Tooltip = "";
            this.txtTenNhanVien.ForeColor = System.Drawing.Color.Black;
            this.txtTenNhanVien.Location = new System.Drawing.Point(10, 66);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(278, 20);
            this.txtTenNhanVien.TabIndex = 2;
            this.txtTenNhanVien.WatermarkFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenNhanVien.WatermarkText = "Nhập tên nhân viên";
            // 
            // mathuoc
            // 
            this.mathuoc.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.mathuoc.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mathuoc.Font = new System.Drawing.Font("Tahoma", 11F);
            this.mathuoc.Location = new System.Drawing.Point(10, 3);
            this.mathuoc.Name = "mathuoc";
            this.mathuoc.Size = new System.Drawing.Size(111, 17);
            this.mathuoc.TabIndex = 1;
            this.mathuoc.Text = "Mã nhân viên";
            // 
            // dockSite4
            // 
            this.dockSite4.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dockSite4.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
            this.dockSite4.Location = new System.Drawing.Point(0, 451);
            this.dockSite4.Name = "dockSite4";
            this.dockSite4.Size = new System.Drawing.Size(430, 0);
            this.dockSite4.TabIndex = 30;
            this.dockSite4.TabStop = false;
            // 
            // dockSite5
            // 
            this.dockSite5.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite5.Dock = System.Windows.Forms.DockStyle.Left;
            this.dockSite5.Location = new System.Drawing.Point(0, 0);
            this.dockSite5.Name = "dockSite5";
            this.dockSite5.Size = new System.Drawing.Size(0, 451);
            this.dockSite5.TabIndex = 31;
            this.dockSite5.TabStop = false;
            // 
            // dockSite8
            // 
            this.dockSite8.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dockSite8.Location = new System.Drawing.Point(0, 451);
            this.dockSite8.Name = "dockSite8";
            this.dockSite8.Size = new System.Drawing.Size(430, 0);
            this.dockSite8.TabIndex = 34;
            this.dockSite8.TabStop = false;
            // 
            // dnbNhomThuoc
            // 
            this.dnbNhomThuoc.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.F1);
            this.dnbNhomThuoc.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlC);
            this.dnbNhomThuoc.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlA);
            this.dnbNhomThuoc.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlV);
            this.dnbNhomThuoc.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlX);
            this.dnbNhomThuoc.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlZ);
            this.dnbNhomThuoc.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlY);
            this.dnbNhomThuoc.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.Del);
            this.dnbNhomThuoc.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.Ins);
            this.dnbNhomThuoc.BottomDockSite = this.dockSite4;
            this.dnbNhomThuoc.EnableFullSizeDock = false;
            this.dnbNhomThuoc.LeftDockSite = this.dockSite1;
            this.dnbNhomThuoc.ParentForm = null;
            this.dnbNhomThuoc.RightDockSite = this.dockSite2;
            this.dnbNhomThuoc.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.dnbNhomThuoc.ToolbarBottomDockSite = this.dockSite8;
            this.dnbNhomThuoc.ToolbarLeftDockSite = this.dockSite5;
            this.dnbNhomThuoc.ToolbarRightDockSite = this.dockSite6;
            this.dnbNhomThuoc.ToolbarTopDockSite = this.dockSite7;
            this.dnbNhomThuoc.TopDockSite = this.dockSite3;
            // 
            // dockSite1
            // 
            this.dockSite1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dockSite1.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
            this.dockSite1.Location = new System.Drawing.Point(0, 0);
            this.dockSite1.Name = "dockSite1";
            this.dockSite1.Size = new System.Drawing.Size(0, 451);
            this.dockSite1.TabIndex = 27;
            this.dockSite1.TabStop = false;
            // 
            // dockSite2
            // 
            this.dockSite2.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite2.Controls.Add(this.bar1);
            this.dockSite2.Dock = System.Windows.Forms.DockStyle.Right;
            this.dockSite2.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer(new DevComponents.DotNetBar.DocumentBaseContainer[] {
            ((DevComponents.DotNetBar.DocumentBaseContainer)(new DevComponents.DotNetBar.DocumentBarContainer(this.bar1, 410, 451)))}, DevComponents.DotNetBar.eOrientation.Horizontal);
            this.dockSite2.Location = new System.Drawing.Point(430, 0);
            this.dockSite2.Name = "dockSite2";
            this.dockSite2.Size = new System.Drawing.Size(413, 451);
            this.dockSite2.TabIndex = 28;
            this.dockSite2.TabStop = false;
            // 
            // bar1
            // 
            this.bar1.AccessibleDescription = "DotNetBar Bar (bar1)";
            this.bar1.AccessibleName = "DotNetBar Bar";
            this.bar1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.bar1.AutoSyncBarCaption = true;
            this.bar1.CloseSingleTab = true;
            this.bar1.Controls.Add(this.panelDockContainer1);
            this.bar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar1.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Caption;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.dockContainerItem1});
            this.bar1.LayoutType = DevComponents.DotNetBar.eLayoutType.DockContainer;
            this.bar1.Location = new System.Drawing.Point(3, 0);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(410, 451);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.bar1.TabIndex = 0;
            this.bar1.TabStop = false;
            this.bar1.Text = "Nhập dữ liệu";
            // 
            // panelDockContainer1
            // 
            this.panelDockContainer1.Controls.Add(this.cbQuyenHan);
            this.panelDockContainer1.Controls.Add(this.chkPass);
            this.panelDockContainer1.Controls.Add(this.labelX7);
            this.panelDockContainer1.Controls.Add(this.txtMatKhau);
            this.panelDockContainer1.Controls.Add(this.labelX6);
            this.panelDockContainer1.Controls.Add(this.txtTenDangNhap);
            this.panelDockContainer1.Controls.Add(this.labelX5);
            this.panelDockContainer1.Controls.Add(this.btThemMoi);
            this.panelDockContainer1.Controls.Add(this.lbTongLoaiThuoc);
            this.panelDockContainer1.Controls.Add(this.labelX4);
            this.panelDockContainer1.Controls.Add(this.btluu);
            this.panelDockContainer1.Controls.Add(this.btThoat);
            this.panelDockContainer1.Controls.Add(this.btxoa);
            this.panelDockContainer1.Controls.Add(this.btthem);
            this.panelDockContainer1.Controls.Add(this.labelX2);
            this.panelDockContainer1.Controls.Add(this.txtTenNhanVien);
            this.panelDockContainer1.Controls.Add(this.mathuoc);
            this.panelDockContainer1.Controls.Add(this.txtMaNhanVien);
            this.panelDockContainer1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelDockContainer1.Location = new System.Drawing.Point(3, 23);
            this.panelDockContainer1.Name = "panelDockContainer1";
            this.panelDockContainer1.Size = new System.Drawing.Size(404, 425);
            this.panelDockContainer1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelDockContainer1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panelDockContainer1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.panelDockContainer1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelDockContainer1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelDockContainer1.Style.GradientAngle = 90;
            this.panelDockContainer1.TabIndex = 0;
            // 
            // btThemMoi
            // 
            this.btThemMoi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btThemMoi.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btThemMoi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btThemMoi.Image = global::BanVeXePhuongTrang.Properties.Resources.recycle_icon;
            this.btThemMoi.ImageFixedSize = new System.Drawing.Size(25, 25);
            this.btThemMoi.Location = new System.Drawing.Point(58, 288);
            this.btThemMoi.Name = "btThemMoi";
            this.btThemMoi.Size = new System.Drawing.Size(90, 29);
            this.btThemMoi.TabIndex = 13;
            this.btThemMoi.Text = "Thêm mới";
            // 
            // btluu
            // 
            this.btluu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btluu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btluu.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btluu.Image = global::BanVeXePhuongTrang.Properties.Resources.Save_icon;
            this.btluu.ImageFixedSize = new System.Drawing.Size(25, 25);
            this.btluu.Location = new System.Drawing.Point(121, 253);
            this.btluu.Name = "btluu";
            this.btluu.Size = new System.Drawing.Size(68, 29);
            this.btluu.TabIndex = 8;
            this.btluu.Text = "Lưu";
            // 
            // btThoat
            // 
            this.btThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btThoat.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btThoat.Image = global::BanVeXePhuongTrang.Properties.Resources.Windows_Close_Program_icon;
            this.btThoat.ImageFixedSize = new System.Drawing.Size(25, 25);
            this.btThoat.Location = new System.Drawing.Point(168, 288);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(81, 29);
            this.btThoat.TabIndex = 7;
            this.btThoat.Text = "Thoát";
            // 
            // btxoa
            // 
            this.btxoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btxoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btxoa.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btxoa.Image = global::BanVeXePhuongTrang.Properties.Resources.Actions_edit_delete_icon;
            this.btxoa.ImageFixedSize = new System.Drawing.Size(25, 25);
            this.btxoa.Location = new System.Drawing.Point(224, 253);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(61, 29);
            this.btxoa.TabIndex = 7;
            this.btxoa.Text = "Xóa";
            // 
            // btthem
            // 
            this.btthem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btthem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btthem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btthem.Image = global::BanVeXePhuongTrang.Properties.Resources.Actions_list_add_icon;
            this.btthem.ImageFixedSize = new System.Drawing.Size(25, 25);
            this.btthem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btthem.Location = new System.Drawing.Point(13, 253);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(72, 29);
            this.btthem.TabIndex = 6;
            this.btthem.Text = "Thêm";
            // 
            // txtMaNhanVien
            // 
            // 
            // 
            // 
            this.txtMaNhanVien.Border.Class = "TextBoxBorder";
            this.txtMaNhanVien.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaNhanVien.ButtonCustom.Tooltip = "";
            this.txtMaNhanVien.ButtonCustom2.Tooltip = "";
            this.txtMaNhanVien.ForeColor = System.Drawing.Color.Silver;
            this.txtMaNhanVien.Location = new System.Drawing.Point(10, 22);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(278, 20);
            this.txtMaNhanVien.TabIndex = 0;
            this.txtMaNhanVien.WatermarkFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaNhanVien.WatermarkText = "Nhập mã nhân viên";
            // 
            // dockContainerItem1
            // 
            this.dockContainerItem1.Control = this.panelDockContainer1;
            this.dockContainerItem1.Name = "dockContainerItem1";
            this.dockContainerItem1.Text = "Nhập dữ liệu";
            // 
            // dockSite6
            // 
            this.dockSite6.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite6.Dock = System.Windows.Forms.DockStyle.Right;
            this.dockSite6.Location = new System.Drawing.Point(843, 0);
            this.dockSite6.Name = "dockSite6";
            this.dockSite6.Size = new System.Drawing.Size(0, 451);
            this.dockSite6.TabIndex = 32;
            this.dockSite6.TabStop = false;
            // 
            // frmTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 451);
            this.Controls.Add(this.dtNhanVien);
            this.Controls.Add(this.dockSite7);
            this.Controls.Add(this.dockSite3);
            this.Controls.Add(this.dockSite4);
            this.Controls.Add(this.dockSite5);
            this.Controls.Add(this.dockSite8);
            this.Controls.Add(this.dockSite1);
            this.Controls.Add(this.dockSite2);
            this.Controls.Add(this.dockSite6);
            this.Name = "frmTaiKhoan";
            this.Text = "Quản lý tài khoản";
            ((System.ComponentModel.ISupportInitialize)(this.dtNhanVien)).EndInit();
            this.panelDockContainer2.ResumeLayout(false);
            this.panelDockContainer2.PerformLayout();
            this.dockSite3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bar2)).EndInit();
            this.bar2.ResumeLayout(false);
            this.dockSite2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.bar1.ResumeLayout(false);
            this.panelDockContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX6;
        private System.Windows.Forms.ComboBox cbQuyenHan;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkPass;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMatKhau;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenDangNhap;
        private DevComponents.DotNetBar.LabelX labelX5;
        private System.Windows.Forms.DataGridView dtNhanVien;
        private DevComponents.DotNetBar.DockContainerItem dockContainerItem2;
        private DevComponents.DotNetBar.PanelDockContainer panelDockContainer2;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.ButtonX btThemMoi;
        private DevComponents.DotNetBar.LabelX lbTongLoaiThuoc;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.DockSite dockSite7;
        private DevComponents.DotNetBar.ButtonX btluu;
        private DevComponents.DotNetBar.ButtonX btThoat;
        private DevComponents.DotNetBar.ButtonX btxoa;
        private DevComponents.DotNetBar.ButtonX btthem;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.DockSite dockSite3;
        private DevComponents.DotNetBar.Bar bar2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenNhanVien;
        private DevComponents.DotNetBar.LabelX mathuoc;
        private DevComponents.DotNetBar.DockSite dockSite4;
        private DevComponents.DotNetBar.DockSite dockSite5;
        private DevComponents.DotNetBar.DockSite dockSite8;
        private DevComponents.DotNetBar.DotNetBarManager dnbNhomThuoc;
        private DevComponents.DotNetBar.DockSite dockSite1;
        private DevComponents.DotNetBar.DockSite dockSite2;
        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.PanelDockContainer panelDockContainer1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaNhanVien;
        private DevComponents.DotNetBar.DockContainerItem dockContainerItem1;
        private DevComponents.DotNetBar.DockSite dockSite6;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDangNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuyenHan;
    }
}