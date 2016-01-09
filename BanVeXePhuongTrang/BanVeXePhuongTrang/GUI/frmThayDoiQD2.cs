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
    public partial class frmThayDoiQD2 : Form
    {
        public frmThayDoiQD2()
        {
            InitializeComponent();
            
        }

    
        private void btThoat_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.TabControl TAB = frmMain.m_Tab;
            TAB.Tabs.Remove(TAB.SelectedTab);
            Close();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
           
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
           
        }

    }
}
