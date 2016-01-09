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
    public partial class frmThemTuyenXe : Form
    {
        DataTable DSSanBay;

        public frmThemTuyenXe()
        {
            InitializeComponent();
           
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
           
        }

        private void cbMaSanBayDi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!cbMaSanBayDen.Text.Equals("") && !cbMaSanBayDi.Text.Equals(""))
            {
                String temp = cbMaSanBayDi.Text.ToString() + "_" + cbMaSanBayDen.Text.ToString();
                txtMaTuyen.Text = temp;
            }
        }

        private void cbMaSanBayDen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cbMaSanBayDen.Text.Equals("") && !cbMaSanBayDi.Text.Equals(""))
            {
                String temp = cbMaSanBayDi.Text.ToString() + "_" + cbMaSanBayDen.Text.ToString();
                txtMaTuyen.Text = temp;
            }
        }
    }
}
