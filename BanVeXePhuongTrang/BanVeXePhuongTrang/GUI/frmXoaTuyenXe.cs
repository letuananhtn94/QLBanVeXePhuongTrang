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
    public partial class frmXoaTuyenXe : Form
    {
        public frmXoaTuyenXe()
        {
            InitializeComponent();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        static public void XoaTuyenBay(String MaTuyenBay)
        {
           
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if(cbMaTuyenBay.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng chọn tuyến bay muốn xóa", "Lỗi");
                return;
            }

            XoaTuyenBay(cbMaTuyenBay.Text);

            MessageBox.Show("Xóa thành công", "Thông báo");
            cbMaTuyenBay.Text = "";
        }

        private void cbMaTuyenBay_MouseClick(object sender, MouseEventArgs e)
        {
           
        }
    }
}
