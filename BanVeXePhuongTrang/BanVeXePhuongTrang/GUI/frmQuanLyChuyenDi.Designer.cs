﻿namespace BanVeXePhuongTrang.GUI
{
    partial class frmQuanLyChuyenDi
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
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgvCTLichChuyenBay = new System.Windows.Forms.DataGridView();
            this.dataGridViewLabelXColumn1 = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.dataGridViewLabelXColumn2 = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.ThoiGianDung = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.GhiChu = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dtgvLichChuyenBay = new System.Windows.Forms.DataGridView();
            this.MaChuyenDi = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.MaTuyenDi = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.MaXe = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.KhoiHanh = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.GiaVe = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btSua = new DevComponents.DotNetBar.ButtonX();
            this.btThoat = new DevComponents.DotNetBar.ButtonX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.btThem = new DevComponents.DotNetBar.ButtonX();
            this.btXoa = new DevComponents.DotNetBar.ButtonX();
            this.panelEx1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCTLichChuyenBay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLichChuyenBay)).BeginInit();
            this.groupPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.groupBox2);
            this.panelEx1.Controls.Add(this.reflectionLabel1);
            this.panelEx1.Controls.Add(this.PictureBox1);
            this.panelEx1.Controls.Add(this.groupPanel1);
            this.panelEx1.Controls.Add(this.groupPanel2);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(1015, 503);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgvCTLichChuyenBay);
            this.groupBox2.Location = new System.Drawing.Point(24, 362);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(775, 123);
            this.groupBox2.TabIndex = 92;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết lịch chuyến đi";
            // 
            // dtgvCTLichChuyenBay
            // 
            this.dtgvCTLichChuyenBay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCTLichChuyenBay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewLabelXColumn1,
            this.dataGridViewLabelXColumn2,
            this.ThoiGianDung,
            this.GhiChu});
            this.dtgvCTLichChuyenBay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvCTLichChuyenBay.GridColor = System.Drawing.SystemColors.Control;
            this.dtgvCTLichChuyenBay.Location = new System.Drawing.Point(3, 16);
            this.dtgvCTLichChuyenBay.Name = "dtgvCTLichChuyenBay";
            this.dtgvCTLichChuyenBay.Size = new System.Drawing.Size(769, 104);
            this.dtgvCTLichChuyenBay.TabIndex = 90;
            // 
            // dataGridViewLabelXColumn1
            // 
            this.dataGridViewLabelXColumn1.HeaderText = "Mã Bến Xe";
            this.dataGridViewLabelXColumn1.Name = "dataGridViewLabelXColumn1";
            this.dataGridViewLabelXColumn1.ReadOnly = true;
            this.dataGridViewLabelXColumn1.Width = 80;
            // 
            // dataGridViewLabelXColumn2
            // 
            this.dataGridViewLabelXColumn2.HeaderText = "Bến Xe Trung Gian";
            this.dataGridViewLabelXColumn2.Name = "dataGridViewLabelXColumn2";
            this.dataGridViewLabelXColumn2.ReadOnly = true;
            this.dataGridViewLabelXColumn2.Width = 150;
            // 
            // ThoiGianDung
            // 
            this.ThoiGianDung.HeaderText = "Thời Gian Dừng";
            this.ThoiGianDung.Name = "ThoiGianDung";
            this.ThoiGianDung.ReadOnly = true;
            // 
            // GhiChu
            // 
            this.GhiChu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GhiChu.HeaderText = "Ghi Chú";
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.ReadOnly = true;
            // 
            // reflectionLabel1
            // 
            // 
            // 
            // 
            this.reflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionLabel1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.reflectionLabel1.Location = new System.Drawing.Point(322, 23);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(317, 56);
            this.reflectionLabel1.TabIndex = 85;
            this.reflectionLabel1.Text = "<b><font size=\"+6\"><i></i><font color=\"#B02B2C\">QUẢN LÝ CHUYẾN ĐI</font></font></" +
    "b>";
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = global::BanVeXePhuongTrang.Properties.Resources.xe_phuong_trang_3;
            this.PictureBox1.Location = new System.Drawing.Point(75, 23);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(118, 57);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 52;
            this.PictureBox1.TabStop = false;
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.dtgvLichChuyenBay);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(19, 86);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(783, 271);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 87;
            this.groupPanel1.Text = "Danh sách chuyến đi";
            // 
            // dtgvLichChuyenBay
            // 
            this.dtgvLichChuyenBay.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtgvLichChuyenBay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvLichChuyenBay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaChuyenDi,
            this.MaTuyenDi,
            this.MaXe,
            this.KhoiHanh,
            this.GiaVe});
            this.dtgvLichChuyenBay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvLichChuyenBay.Location = new System.Drawing.Point(0, 0);
            this.dtgvLichChuyenBay.Name = "dtgvLichChuyenBay";
            this.dtgvLichChuyenBay.Size = new System.Drawing.Size(777, 250);
            this.dtgvLichChuyenBay.TabIndex = 0;
            this.dtgvLichChuyenBay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvLichChuyenBay_CellClick);
            // 
            // MaChuyenDi
            // 
            this.MaChuyenDi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaChuyenDi.HeaderText = "Mã Chuyến Đi";
            this.MaChuyenDi.Name = "MaChuyenDi";
            // 
            // MaTuyenDi
            // 
            this.MaTuyenDi.HeaderText = "Mã Tuyến";
            this.MaTuyenDi.Name = "MaTuyenDi";
            this.MaTuyenDi.Width = 150;
            // 
            // MaXe
            // 
            this.MaXe.HeaderText = "Mã Xe";
            this.MaXe.Name = "MaXe";
            this.MaXe.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaXe.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // KhoiHanh
            // 
            this.KhoiHanh.HeaderText = "Khởi Hành";
            this.KhoiHanh.Name = "KhoiHanh";
            this.KhoiHanh.Width = 200;
            // 
            // GiaVe
            // 
            this.GiaVe.HeaderText = "Giá Vé";
            this.GiaVe.Name = "GiaVe";
            this.GiaVe.Width = 150;
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.btSua);
            this.groupPanel2.Controls.Add(this.btThoat);
            this.groupPanel2.Controls.Add(this.buttonX1);
            this.groupPanel2.Controls.Add(this.btThem);
            this.groupPanel2.Controls.Add(this.btXoa);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Location = new System.Drawing.Point(818, 86);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(191, 396);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel2.TabIndex = 88;
            this.groupPanel2.Text = "Chức năng";
            // 
            // btSua
            // 
            this.btSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btSua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btSua.Image = global::BanVeXePhuongTrang.Properties.Resources.Pencil_icon;
            this.btSua.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btSua.Location = new System.Drawing.Point(40, 163);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(106, 48);
            this.btSua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btSua.TabIndex = 86;
            this.btSua.Text = "Sửa";
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThoat
            // 
            this.btThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btThoat.Image = global::BanVeXePhuongTrang.Properties.Resources.Windows_Close_Program_icon;
            this.btThoat.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btThoat.Location = new System.Drawing.Point(40, 292);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(106, 53);
            this.btThoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btThoat.TabIndex = 83;
            this.btThoat.Text = "Thoát";
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonX1.Image = global::BanVeXePhuongTrang.Properties.Resources.edit_validated_icon;
            this.buttonX1.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.buttonX1.Location = new System.Drawing.Point(40, 228);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(106, 48);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 84;
            this.buttonX1.Text = "Cập nhật";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // btThem
            // 
            this.btThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btThem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btThem.Image = global::BanVeXePhuongTrang.Properties.Resources.Actions_list_add_icon;
            this.btThem.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btThem.Location = new System.Drawing.Point(40, 13);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(106, 47);
            this.btThem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btThem.TabIndex = 86;
            this.btThem.Text = "Thêm";
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btXoa
            // 
            this.btXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btXoa.Image = global::BanVeXePhuongTrang.Properties.Resources.Actions_edit_delete_icon;
            this.btXoa.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btXoa.Location = new System.Drawing.Point(40, 85);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(106, 53);
            this.btXoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btXoa.TabIndex = 86;
            this.btXoa.Text = "Xóa";
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // frmQuanLyChuyenDi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 503);
            this.Controls.Add(this.panelEx1);
            this.Name = "frmQuanLyChuyenDi";
            this.Text = "Quản Lý Chuyến Đi";
            this.panelEx1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCTLichChuyenBay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLichChuyenBay)).EndInit();
            this.groupPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        internal System.Windows.Forms.PictureBox PictureBox1;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.ButtonX btThoat;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
        private DevComponents.DotNetBar.ButtonX btSua;
        private DevComponents.DotNetBar.ButtonX btXoa;
        private DevComponents.DotNetBar.ButtonX btThem;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private System.Windows.Forms.DataGridView dtgvLichChuyenBay;
        private System.Windows.Forms.DataGridView dtgvCTLichChuyenBay;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn dataGridViewLabelXColumn1;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn dataGridViewLabelXColumn2;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn ThoiGianDung;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn GhiChu;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn MaChuyenDi;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn MaTuyenDi;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn MaXe;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn KhoiHanh;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn GiaVe;
    }
}