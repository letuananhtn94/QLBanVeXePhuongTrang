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
    public partial class frmVeXe : Form
    {
       
        public frmVeXe()
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

        private void btnLapVe_Click(object sender, EventArgs e)
        {
            frmThongTinVe form = new frmThongTinVe();
            form.Show();
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.TabControl TAB = frmMain.m_Tab;
            TAB.Tabs.Remove(TAB.SelectedTab);
            Close();
        }

        private void btnDanhSach_Click(object sender, EventArgs e)
        {
            frmDanhSachDatVe form = new frmDanhSachDatVe();
            form.Show();
        }

        private void checkBoxX1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
