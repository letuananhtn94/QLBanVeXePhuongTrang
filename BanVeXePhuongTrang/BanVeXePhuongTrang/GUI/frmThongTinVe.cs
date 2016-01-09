using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BanVeXePhuongTrang;

namespace BanVeXePhuongTrang.GUI
{
    public partial class frmThongTinVe : Form
    {
        DataTable DSSanBay;
        DataTable DSTuyenBay;
        DataTable DSHangVe;
        DataTable DSCTGhe;

        String MaSanBayDi = "";
        String MaSanBayDen = "";
        int DonGia;

        

        public frmThongTinVe()
        {
            InitializeComponent();
           
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.TabControl TAB = frmMain.m_Tab;
            TAB.Tabs.Remove(TAB.SelectedTab);
            Close();
        }

        private void cbMaChuyenBay_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void cbMaChuyenBay_SelectedIndexChanged(object sender, EventArgs e)
        {
        }


        private void cbHangVe_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void cbHangVe_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
           
        }

        private void txtCMND_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
