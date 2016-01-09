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
    public partial class frmXoaBenXe : Form
    {
        DataTable data;
        public frmXoaBenXe()
        {
            InitializeComponent();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbMaSanBay_MouseClick(object sender, MouseEventArgs e)
        {
            cbMaSanBay.Items.Clear();
            cbMaSanBay.Text = "";

            foreach (DataRow row in data.Rows)
            {
                cbMaSanBay.Items.Add(row.ItemArray[0].ToString());
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
        }
    }
}
