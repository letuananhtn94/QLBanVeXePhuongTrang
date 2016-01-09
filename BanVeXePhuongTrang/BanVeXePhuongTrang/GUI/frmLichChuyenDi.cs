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
    public partial class frmLichChuyenDi : Form
    {
        int MaxRowHangVe;
        int MaxSBTrungGian;
        int MinTGDung, MaxTGDung, MinTGBay;
        DataTable DSSanBay, DSSanBayDen, DSSanBayDi, DSTuyenBay, DSThamSo;
        enum IDTuyenBay
        {
            MaTuyenBay = 0,
            MaSanBayDi = 1,
            MaSanBayDen = 2
        }

        enum IDThamSo
        {
            MaxSoSanBayTG = 0,
            MaxTGDung = 1,
            MinTGDung = 2,
            MinTGBay = 3,
            TGDatVe = 5,
            TGHuyVe = 6
        }

        enum IDSanBay
        {
            MaSanBay = 0,
            TenSanBay = 1
        }

        public frmLichChuyenDi()
        {
            InitializeComponent();
          
        }

        private void loadSoHangVe()
        {
          
        }

       

        private void btThoat_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.TabControl TAB = frmMain.m_Tab;
            TAB.Tabs.Remove(TAB.SelectedTab);
            Close();
        }

        private void dataGridView2_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            if (dataGridView2.Rows.Count > MaxSBTrungGian)
                dataGridView2.AllowUserToAddRows = false;
            {
                dataGridView2.Rows[dataGridView2.RowCount - 1].Cells[0].Value = "";
                dataGridView2.Rows[dataGridView2.RowCount - 1].Cells[1].Value = "";
            }
        }

        private void cbSanBayDi_MouseClick(object sender, MouseEventArgs e)
        {

           
           
        }

        private void cbSanBayDen_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        // update combox SanBayTrungGian



       
        private List<CT_LichChuyenBay> solveDataInputCT_LichChuyenBay()
        {
            List<CT_LichChuyenBay> list = new List<CT_LichChuyenBay>();

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if ((row.Cells[0].Value == null || row.Cells[0].Value == "") && (row.Cells[1].Value == null || row.Cells[1].Value == ""))
                    break;

                string MaSanBayTrungGian = "";
                DataRow[] rows = DSSanBay.Select("TenSanBay='" + row.Cells[0].Value + "'");

                for (int i = 0; i < rows.Length; i++)
                {
                    MaSanBayTrungGian = rows[i].ItemArray[(int)IDSanBay.MaSanBay].ToString();
                }

                if (row.Cells[2].Value != null)
                    list.Add(new CT_LichChuyenBay(txtMaChuyenDi.Text, MaSanBayTrungGian, Convert.ToInt32(row.Cells[1].Value.ToString()), row.Cells[2].Value.ToString()));
                else
                    list.Add(new CT_LichChuyenBay(txtMaChuyenDi.Text, MaSanBayTrungGian, Convert.ToInt32(row.Cells[1].Value.ToString()), ""));
            }

            return list;
        }

    
        private void buttonX3_Click(object sender, EventArgs e)
        {
           
        }


        class LichChuyenBay
        {
            public string MaChuyenBay;
            public string MaTuyenBay;
            public DateTime KhoiHanh;
            public int ThoiGianBay;
            public int DonGia;


            public LichChuyenBay(string maChuyenBay, string maTuyenBay, DateTime khoiHanh, int donGia, int thoiGianBay)
            {
                this.MaChuyenBay = maChuyenBay;
                this.KhoiHanh = khoiHanh;
                this.ThoiGianBay = thoiGianBay;
                this.DonGia = donGia;
                this.MaTuyenBay = maTuyenBay;
            }
        }

        class CT_LichChuyenBay
        {
            public string MaChuyenBay;
            public string MaSanBayTrungGian;
            public string GhiChu;
            public int ThoiGianDung;

            public CT_LichChuyenBay(string maChuyenBay, string maSanBayTrungGian, int thoiGianDung, string ghiChu)
            {
                MaChuyenBay = maChuyenBay;
                MaSanBayTrungGian = maSanBayTrungGian;
                ThoiGianDung = thoiGianDung;
                GhiChu = ghiChu;
            }
        }

        class CT_Ghe
        {
            public string MaChuyenBay;
            public string MaHangVe;
            public int SoGhe;
            public int SoGheDat;
            public int SoGheTrong;

            public CT_Ghe(string maChuyenBay, string maHangVe, int soGhe, int soGheDat, int soGheTrong)
            {
                MaChuyenBay = maChuyenBay;
                MaHangVe = maHangVe;
                SoGhe = soGhe;
                SoGheDat = soGheDat;
                SoGheTrong = soGheTrong;
            }
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
          
        }

        private void btnSanBayDi_Click(object sender, EventArgs e)
        {
            frmThemBenXe form = new frmThemBenXe();
            form.Show();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            frmThemTuyenXe form = new frmThemTuyenXe();
            form.Show();
        }

    
    }
}