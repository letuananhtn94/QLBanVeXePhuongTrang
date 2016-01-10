using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BanVeXePhuongTrang.DAL;
using BanVeXePhuongTrang.BLL;

namespace BanVeXePhuongTrang.GUI
{
    public partial class frmThemTuyenXe : Form
    {
        public frmThemTuyenXe()
        {
            InitializeComponent();
           
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void cbMaSanBayDi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!cbTenBenDen.Text.Equals("") && !cbTenBenDi.Text.Equals(""))
            {
                QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();

                tblBenXe benXeDi = db.tblBenXes.Where(t => t.TenBenXe == cbTenBenDi.SelectedItem.ToString()).Single();
                tblBenXe benXeDen = db.tblBenXes.Where(t => t.TenBenXe == cbTenBenDen.SelectedItem.ToString()).Single();
                
                txtMaTuyen.Text = benXeDi.MaBenXe + "_" + benXeDen.MaBenXe;
            }
        }

        private void cbMaSanBayDen_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMaSanBayDi_SelectedIndexChanged(sender, e);
        }

        private void frmThemTuyenXe_Load(object sender, EventArgs e)
        {
            foreach (var item in new QUANLYXEKHACHEntities().tblBenXes.ToList())
            {
                cbTenBenDen.Items.Add(item.TenBenXe);
                cbTenBenDi.Items.Add(item.TenBenXe);
            }
        }

        private void btnThêm_Click(object sender, EventArgs e)
        {
            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();

            tblBenXe benXeDi = db.tblBenXes.Where(t => t.TenBenXe == cbTenBenDi.SelectedItem.ToString()).Single();
            tblBenXe benXeDen = db.tblBenXes.Where(t => t.TenBenXe == cbTenBenDen.SelectedItem.ToString()).Single();

            BLL_TuyenXe temp = new BLL_TuyenXe();
            if(temp.canInsert(benXeDi.MaBenXe, benXeDen.MaBenXe))
            {
                tblTuyenXe tuyenXe = new tblTuyenXe();
                tuyenXe.MaBenXeDi = benXeDi.MaBenXe;
                tuyenXe.MaBenXeDen = benXeDen.MaBenXe;
                tuyenXe.MaTuyen = txtMaTuyen.Text.ToString();

                db.tblTuyenXes.Add(tuyenXe);
                db.SaveChanges();

                MessageBox.Show("Thêm thành công");
            }
            else
                MessageBox.Show("Thêm thất bại");
        }
    }
}
