﻿namespace BanVeXePhuongTrang.GUI
{
    partial class frmThemTuyenXe
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
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.cbTenBenDen = new System.Windows.Forms.ComboBox();
            this.cbTenBenDi = new System.Windows.Forms.ComboBox();
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.btnThêm = new DevComponents.DotNetBar.ButtonX();
            this.btThoat = new DevComponents.DotNetBar.ButtonX();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtMaTuyen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.panelEx1.SuspendLayout();
            this.panelEx2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.panelEx2);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(563, 322);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.cbTenBenDen);
            this.panelEx2.Controls.Add(this.cbTenBenDi);
            this.panelEx2.Controls.Add(this.reflectionLabel1);
            this.panelEx2.Controls.Add(this.btnThêm);
            this.panelEx2.Controls.Add(this.btThoat);
            this.panelEx2.Controls.Add(this.PictureBox1);
            this.panelEx2.Controls.Add(this.txtMaTuyen);
            this.panelEx2.Controls.Add(this.label1);
            this.panelEx2.Controls.Add(this.Label3);
            this.panelEx2.Controls.Add(this.Label2);
            this.panelEx2.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx2.Location = new System.Drawing.Point(0, 0);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(563, 322);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 1;
            // 
            // cbTenBenDen
            // 
            this.cbTenBenDen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTenBenDen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbTenBenDen.FormattingEnabled = true;
            this.cbTenBenDen.Location = new System.Drawing.Point(245, 194);
            this.cbTenBenDen.Name = "cbTenBenDen";
            this.cbTenBenDen.Size = new System.Drawing.Size(216, 27);
            this.cbTenBenDen.TabIndex = 92;
            this.cbTenBenDen.SelectedIndexChanged += new System.EventHandler(this.cbMaSanBayDen_SelectedIndexChanged);
            // 
            // cbTenBenDi
            // 
            this.cbTenBenDi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTenBenDi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbTenBenDi.FormattingEnabled = true;
            this.cbTenBenDi.Location = new System.Drawing.Point(245, 153);
            this.cbTenBenDi.Name = "cbTenBenDi";
            this.cbTenBenDi.Size = new System.Drawing.Size(216, 27);
            this.cbTenBenDi.TabIndex = 91;
            this.cbTenBenDi.SelectedIndexChanged += new System.EventHandler(this.cbMaSanBayDi_SelectedIndexChanged);
            // 
            // reflectionLabel1
            // 
            // 
            // 
            // 
            this.reflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionLabel1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.reflectionLabel1.Location = new System.Drawing.Point(200, 35);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(251, 56);
            this.reflectionLabel1.TabIndex = 88;
            this.reflectionLabel1.Text = "<b><font size=\"+6\"><i></i><font color=\"#B02B2C\">THÊM TUYẾN XE</font></font></b>";
            // 
            // btnThêm
            // 
            this.btnThêm.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThêm.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThêm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThêm.Image = global::BanVeXePhuongTrang.Properties.Resources.Actions_list_add_icon;
            this.btnThêm.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btnThêm.Location = new System.Drawing.Point(245, 255);
            this.btnThêm.Name = "btnThêm";
            this.btnThêm.Size = new System.Drawing.Size(96, 37);
            this.btnThêm.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThêm.TabIndex = 87;
            this.btnThêm.Text = "Thêm";
            this.btnThêm.Click += new System.EventHandler(this.btnThêm_Click);
            // 
            // btThoat
            // 
            this.btThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btThoat.Image = global::BanVeXePhuongTrang.Properties.Resources.Windows_Close_Program_icon;
            this.btThoat.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btThoat.Location = new System.Drawing.Point(381, 255);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(99, 37);
            this.btThoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btThoat.TabIndex = 85;
            this.btThoat.Text = "Thoát";
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = global::BanVeXePhuongTrang.Properties.Resources.xe_phuong_trang_3;
            this.PictureBox1.Location = new System.Drawing.Point(77, 35);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(88, 56);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 42;
            this.PictureBox1.TabStop = false;
            // 
            // txtMaTuyen
            // 
            this.txtMaTuyen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaTuyen.ForeColor = System.Drawing.Color.Blue;
            this.txtMaTuyen.Location = new System.Drawing.Point(245, 114);
            this.txtMaTuyen.Name = "txtMaTuyen";
            this.txtMaTuyen.ReadOnly = true;
            this.txtMaTuyen.Size = new System.Drawing.Size(216, 26);
            this.txtMaTuyen.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(77, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 23);
            this.label1.TabIndex = 36;
            this.label1.Text = "Bến Xe Đến:";
            // 
            // Label3
            // 
            this.Label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Label3.Location = new System.Drawing.Point(77, 157);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(124, 23);
            this.Label3.TabIndex = 36;
            this.Label3.Text = "Bến Xe Đi:";
            // 
            // Label2
            // 
            this.Label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Label2.Location = new System.Drawing.Point(77, 117);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(124, 23);
            this.Label2.TabIndex = 35;
            this.Label2.Text = "Mã Tuyến Xe:";
            // 
            // frmThemTuyenXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 322);
            this.Controls.Add(this.panelEx1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmThemTuyenXe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Tuyến Xe";
            this.Load += new System.EventHandler(this.frmThemTuyenXe_Load);
            this.panelEx1.ResumeLayout(false);
            this.panelEx2.ResumeLayout(false);
            this.panelEx2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
        private DevComponents.DotNetBar.ButtonX btnThêm;
        private DevComponents.DotNetBar.ButtonX btThoat;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.TextBox txtMaTuyen;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTenBenDen;
        private System.Windows.Forms.ComboBox cbTenBenDi;
    }
}