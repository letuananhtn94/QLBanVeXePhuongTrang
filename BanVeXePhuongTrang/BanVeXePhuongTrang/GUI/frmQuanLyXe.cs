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
    public partial class frmQuanLyXe : Form
    {
        public frmQuanLyXe()
        {
            InitializeComponent();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            frmThemXe form = new frmThemXe();
            form.Show();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            frmSuaXe form = new frmSuaXe();
            form.Show();
        }
    }
}
