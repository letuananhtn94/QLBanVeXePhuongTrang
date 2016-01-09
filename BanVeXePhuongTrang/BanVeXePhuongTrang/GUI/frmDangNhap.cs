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
    public partial class frmDangNhap : Form
    {
        //public delegate void TruyenLaiDuLieu(string MaNhanVien, string data);
        //public static TruyenLaiDuLieu truyendulieu;
        public frmDangNhap()
        {
            InitializeComponent();
            frmMain.TenDangNhap = "Chưa đăng nhập";
            frmMain.MaNhanVien = "";
        }

        private void btHuyBo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            
        }

        private void txtMatKhau_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btDangNhap.Focus();
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
