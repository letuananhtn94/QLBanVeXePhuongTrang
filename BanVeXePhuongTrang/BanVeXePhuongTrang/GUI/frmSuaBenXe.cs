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
    public partial class frmSuaBenXe : Form
    {

        DataTable DanhSachSanBay;
        public frmSuaBenXe()
        {
            InitializeComponent();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbMaSanBay_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void cbMaSanBay_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btSua_Click(object sender, EventArgs e)
        {
          
        }
    }
}
