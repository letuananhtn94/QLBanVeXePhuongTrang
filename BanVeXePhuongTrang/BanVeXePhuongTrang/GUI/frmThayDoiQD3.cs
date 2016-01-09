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
    public partial class frmThayDoiQD3 : Form
    {
        public frmThayDoiQD3()
        {
            InitializeComponent();
            cbHuyDatCho.Items.Add("True");
            cbHuyDatCho.Items.Add("False");

            cbHuyDatCho.SelectedIndex = 0;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.TabControl TAB = frmMain.m_Tab;
            TAB.Tabs.Remove(TAB.SelectedTab);
            Close();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
        }
    }
}
