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
    public partial class frmBCDoanhThuThang : Form
    {
        public frmBCDoanhThuThang()
        {
            InitializeComponent();
            for (int i = 0; i < 20; i++)
            {
                int n = 2010 + i;
                cbNam.Items.Add(n);
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.TabControl TAB = frmMain.m_Tab;
            TAB.Tabs.Remove(TAB.SelectedTab);
            Close();
        }

        private void btBaoCao_Click(object sender, EventArgs e)
        {
            
        }
    }
}
