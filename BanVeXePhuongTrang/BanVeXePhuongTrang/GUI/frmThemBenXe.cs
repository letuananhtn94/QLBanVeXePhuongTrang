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
    public partial class frmThemBenXe : Form
    {
        public frmThemBenXe()
        {
            InitializeComponent();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
           
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            txtMaSanBay.Text = "";
            txtTenSanBay.Text = "";
        }

        private void panelEx1_Click(object sender, EventArgs e)
        {

        }
    }
}
