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
using Microsoft.Reporting.WinForms;

namespace BanVeXePhuongTrang.GUI
{
    public partial class frmBCDoanhThuThang : Form
    {
        public frmBCDoanhThuThang()
        {
            InitializeComponent();            
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.TabControl TAB = frmMain.m_Tab;
            TAB.Tabs.Remove(TAB.SelectedTab);
            Close();
        }

        private void btBaoCao_Click(object sender, EventArgs e)
        {
            SetParammater();
            reportViewer1.RefreshReport();
        }

        private void frmBCDoanhThuThang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qUANLYXEKHACHDataSet1.tblBaoCaoDoanhThuThang' table. You can move, or remove it, as needed.
            //this.tblBaoCaoDoanhThuThangTableAdapter.Fill(this.qUANLYXEKHACHDataSet1.tblBaoCaoDoanhThuThang);
            // TODO: This line of code loads data into the 'qUANLYXEKHACHDataSet.tblBaoCaoDoanhThuThang' table. You can move, or remove it, as needed.
            this.tblBaoCaoDoanhThuThangTableAdapter.Fill(this.qUANLYXEKHACHDataSet.tblBaoCaoDoanhThuThang);
            // TODO: This line of code loads data into the 'qUANLYXEKHACHDataSet.tblBaoCaoDoanhThuThang' table. You can move, or remove it, as needed.

            for (int i = 1; i < 13; i++)
            {
                cbThang.Items.Add(i);
            }
            for (int i = 1990; i < DateTime.Now.Year; i++)
            {
                cbNam.Items.Add(i);
            }

            SetParammater();
            reportViewer1.RefreshReport();
        }

        void SetParammater() {
            ReportParameter[] param = new ReportParameter[2];
            param[0] = new ReportParameter("Thang");
            param[0].Values.Add(cbThang.SelectedItem.ToString());
            param[1] = new ReportParameter("Nam");
            param[1].Values.Add(cbNam.SelectedItem.ToString());

            reportViewer1.LocalReport.SetParameters(param);
        }

    }
}
