using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyCongTyDuLich
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            Functions.connect();
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            Functions.closeConnect();
            Application.Exit();
        }

        private void HDV_Click(object sender, EventArgs e)
        {
            FrmHDV fHDV = new FrmHDV();
            fHDV.Show();
        }

        private void LichTour_Click(object sender, EventArgs e)
        {
            FrmLichTour fLT = new FrmLichTour();
            fLT.Show();
        }
        private void DangKyTour_Click(object sender, EventArgs e)
        {
            FrmDangKyTour fDKT = new FrmDangKyTour();
            fDKT.Show();
        }

        private void báoCáoDSTourChưaKhởiHànhTheoPhạmViToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBCTourChuaKhoiHanh frmBC1 = new FrmBCTourChuaKhoiHanh();
            frmBC1.ShowDialog();
        }

        private void báoCáo5TourCóSốNgườiĐKNhiềuNhấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBC3 fbc3 = new FrmBC3();
            fbc3.ShowDialog();
        }

        private void báoCáoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmBC2 fbc2 = new FrmBC2();
            fbc2.ShowDialog();
        }
    }
}
