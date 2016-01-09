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
    public partial class frmDanhSachDatVe : Form
    {
        public frmDanhSachDatVe()
        {
            InitializeComponent();
        }

    
        private void cbDanhSachChuyenBay_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void cbDanhSachChuyenBay_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn lưu những thay đổi", "Thông báo", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                if(dataGridView1.Rows[0].Cells[0].Value == null)
                {
                    MessageBox.Show("Không có dữ liệu để lưu", "Thông báo");
                    return;
                }

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                   
                }

                MessageBox.Show("Cập nhật thành công", "Thông báo");
                cbDanhSachChuyenBay_SelectedIndexChanged(sender, e);
            }
        }

        private void textBoxX1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
