using BanVeXePhuongTrang.DAL;
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
    public partial class frmTraCuuChuyenDi : Form
    {
        DataTable DSSanBay;
        public frmTraCuuChuyenDi()
        {
            InitializeComponent();

           
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.TabControl TAB = frmMain.m_Tab;
            TAB.Tabs.Remove(TAB.SelectedTab);
            Close();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
        }

        private void cbSanBayDi_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cbBenXeDen_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (!cbBenXeDen.Text.Equals(""))
            //{
            //    DataRow[] row = DSSanBay.Select("MaSanBay='" + cbSanBayDen.Text + "'");

            //    txtTenSanBayDen.Text = row[0].ItemArray[(int)Support.BLL.Support.IDSanBay.TenSanBay].ToString();
            //}
        }

        private void cbBenXeDi_MouseClick(object sender, MouseEventArgs e)
        {
            try{
                cbBenXeDi.Items.Clear();
                txtTenBenXeDi.Text = "";
                
            }
            catch { }
        }

        private void cbBenXeDen_MouseClick(object sender, MouseEventArgs e)
        {
            try {
                cbBenXeDen.Items.Clear();
                txtTenBenXeDen.Text = "";
                //QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();
                //cbBenXeDi.DataSource = db.tblBenXes.Select(t => t.TenBenXe).ToList();
            }
            catch { }
        }

        private void frmTraCuuChuyenDi_Load(object sender, EventArgs e)
        {
            try { 
            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();
            cbBenXeDi.DataSource = db.tblBenXes.Select(t => t.TenBenXe).ToList();
            cbBenXeDen.Items.Clear();           
            cbBenXeDi.DataSource = db.tblBenXes.Select(t => t.TenBenXe).ToList();
            }
            catch { }
        }
    }
}
