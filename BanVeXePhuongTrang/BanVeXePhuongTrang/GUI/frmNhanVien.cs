using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanVeXePhuongTrang.GUI
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        int vitri = 0;

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
          

        }
        Boolean KiemTraThem = false;
        public void LoadDataGridView()
        {
            try
            {
                this.dtNhanVien.AutoGenerateColumns = false;
                //txtMaNhanVien.ReadOnly = true;
                lbTongLoaiThuoc.Text = dtNhanVien.RowCount.ToString();
                this.dtNhanVien.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        //-----------Gán nguồn từ DataGridView cho textbox khi lick chuột-------------
        public void Gan_click()
        {
            try
            {
                if (this.dtNhanVien.SelectedRows.Count == 0)
                    return;
                DataGridViewRow r = this.dtNhanVien.SelectedRows[0];

                GanDK(r);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        public void GanDK(DataGridViewRow r)
        {
            try
            {

                if (dtNhanVien.Rows.Count != 0)
                {
                    this.txtMaNhanVien.Text = r.Cells[0].Value.ToString();
                    this.txtTenNhanVien.Text = r.Cells[1].Value.ToString();
                    this.txtDiaChi.Text = r.Cells[2].Value.ToString();
                    this.txtDienThoai.Text = r.Cells[3].Value.ToString();
                    this.txtNgaySinh.Text = r.Cells[4].Value.ToString();
                    this.txtCMND.Text = r.Cells[5].Value.ToString();
                    this.cbLoaiNV.Text = ConvertToStringQuyenHan(r);
                }
                else
                {
                    this.txtMaNhanVien.Text = "";
                    this.txtTenNhanVien.Text = "";
                    this.txtDiaChi.Text = "";
                    this.txtDienThoai.Text = "";
                    this.txtNgaySinh.Text = "";
                    this.txtCMND.Text = "";
                    this.cbLoaiNV.Text = "Nhân Viên";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            reset();
            KiemTraThem = true;
            dtNhanVien.Enabled = false;
            btxoa.Enabled = false;
        }

        int ConvertQuyenHan()
        {
            if (cbLoaiNV.Text.Equals("Quản Trị Viên"))
            {
                return 1;
            }
            else if (cbLoaiNV.Text.Equals("Ban Giám Đốc"))
            {
                return 2;
            }

            return 0;
        }

        string ConvertToStringQuyenHan(DataGridViewRow r)
        {

            if (r.Cells[6].Value.Equals(1))
                return "Quản Trị Viên";
            else if (r.Cells[6].Value.Equals(2))
                return "Ban Giám Đốc";

            return "Nhân Viên";
        }

        private void btluu_Click(object sender, EventArgs e)
        {
           
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
           
        }

        private void btkhong_Click(object sender, EventArgs e)
        {
            reset();
            Gan_click();
        }
        public void reset()
        {
            this.txtMaNhanVien.Text = "";
            this.txtTenNhanVien.Text = "";
            this.txtDiaChi.Text = "";
            this.txtDienThoai.Text = "";
            this.txtNgaySinh.Text = "";
            this.txtCMND.Text = "";
            this.cbLoaiNV.Text = "Nhân Viên";
            LoadDataGridView();

            dtNhanVien.Enabled = true;
            btxoa.Enabled = true;
            // Gan_click();
        }

        private void dtNhanVien_Click(object sender, EventArgs e)
        {
            
        }

        private void chkPass_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void dtNhanVien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                if (e.Value == null || e.Value == DBNull.Value)
                    return;
                if ((int)e.Value == 1)
                {
                    e.Value = Convert.ToInt32(e.Value).ToString("Quản Trị Viên");
                }
                else if((int) e.Value == 2)
                {
                    e.Value = Convert.ToInt32(e.Value).ToString("Ban Giám Đốc");
                }
                else
                {
                    e.Value = Convert.ToInt32(e.Value).ToString("Nhân Viên");
                }

            }
        }

        private void txtDienThoai_Validating(object sender, CancelEventArgs e)
        {
            if (txtDienThoai.Text.Length > 20)
            {
                MessageBox.Show("điện thoại nhập vào vượt quá giới hạn cho chép (<20 ký tự)");
                txtDienThoai.Focus();
            }
        }

        private void txtDiaChi_Validating(object sender, CancelEventArgs e)
        {
            if (txtDiaChi.Text.Length > 100)
            {
                MessageBox.Show("Địa chỉ nhập vào vượt quá giới hạn cho chép (<100 ký tự)");
                txtDiaChi.Focus();
            }
        }

        private void txtTenDangNhap_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void txtMatKhau_Validating(object sender, CancelEventArgs e)
        {
            if (txtCMND.Text.Length > 30 || txtCMND.Text.Length < 3)
            {
                MessageBox.Show("Mật khẩu từ 3 đến 30 ký tự");
                txtCMND.Focus();
            }

        }

        private void txtTenNhanVien_Validating(object sender, CancelEventArgs e)
        {
            if (txtTenNhanVien.Text.Length > 50)
            {
                MessageBox.Show("Tên nhân viên nhập vào vượt quá giới hạn cho chép (<50 ký tự)");
                txtTenNhanVien.Focus();
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.TabControl TAB = frmMain.m_Tab;
            TAB.Tabs.Remove(TAB.SelectedTab);
            Close();
        }

        private void cbQuyenHan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
