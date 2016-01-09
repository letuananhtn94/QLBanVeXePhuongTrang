using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BanVeXePhuongTrang.BLL;
using BanVeXePhuongTrang.DAL;
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
            BLL_BenXe temp = new BLL_BenXe(txtMaBenXe.Text.ToString(), txtTenBenXe.Text.ToString());
            if(temp.canInsert())
            {
                DAL.QUANLYXEKHACHEntities db = new DAL.QUANLYXEKHACHEntities();

                tblBenXe t = new tblBenXe();
                t.MaBenXe = temp.maBenXe;
                t.TenBenXe = temp.tenBenXe;
                db.tblBenXes.Add(t);
                db.SaveChanges();

                btnTaoMoi_Click(sender, e);
                MessageBox.Show("Thêm thành công");
            }
            else 
            {
                MessageBox.Show("Không thành công");
            }
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            txtMaBenXe.Text = "";
            txtTenBenXe.Text = "";
        }

        private void panelEx1_Click(object sender, EventArgs e)
        {

        }
    }
}
