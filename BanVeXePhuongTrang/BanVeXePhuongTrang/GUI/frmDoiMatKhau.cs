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
    public partial class frmDoiMatKhau : Form
    {
        string ten;
        public frmDoiMatKhau(string strTextBox)
        {
            InitializeComponent();
            ten = strTextBox;
        }

        private void btluu_Click(object sender, EventArgs e)
        {
           
        }

        private void bttkhong_Click(object sender, EventArgs e)
        {
            
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
           
           

        }


        private void txtMatKhauNew_Validating_1(object sender, CancelEventArgs e)
        {
            if (txtMatKhauMoi.Text.Length > 15 || txtMatKhauMoi.Text.Length < 3)
            {
                MessageBox.Show("Mật khẩu phải từ 3 đến 15 ký tự");
                txtMatKhauMoi.Focus();
            }
        }

        private void txtMatKhauXacNhan_Validating_1(object sender, CancelEventArgs e)
        {
            if (!txtMatKhauXacNhan.Text.Equals(txtMatKhauMoi.Text))
            {
                MessageBox.Show("Mat Khẩu xác nhận không chính sác");
                txtMatKhauXacNhan.Focus();
            }
        }
    }
}
