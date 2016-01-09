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
    public partial class frmQuanLyTuyenXe : Form
    {
        public frmQuanLyTuyenXe()
        {
            InitializeComponent();
            LoadDanhSachTuyenBay();
        }

        void LoadDanhSachTuyenBay()
        {
            
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.TabControl TAB = frmMain.m_Tab;
            TAB.Tabs.Remove(TAB.SelectedTab);
            Close();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            frmThemTuyenXe form = new frmThemTuyenXe();
            form.Show();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            frmXoaTuyenXe form = new frmXoaTuyenXe();
            form.Show();
        }

      
        private void buttonX1_Click(object sender, EventArgs e)
        {
            LoadDanhSachTuyenBay();
        }
    }
}
