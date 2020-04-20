using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyCongTyDuLich
{
    public partial class FrmLichTour : Form
    {
        SqlConnection con = new SqlConnection();
        DataTable tblLichTour;
        public FrmLichTour()
        {
            InitializeComponent();
        }

        private void FrmLichTour_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=QuanLyCongTyDuLich;Integrated Security=True";
            con.ConnectionString = connectionString;
            con.Open();
            LoadDataToGridview();
            Functions.FillCombo("select MaCongTy from CongTy", cboMaCongTy, "MaCongTy");
            cboMaCongTy.SelectedIndex = -1;
            //Functions.FillCombo("select MaHDV from LichTour where MaCongTy= '"+cboMaCongTy.SelectedValue+"'", 
            //    cboMaHDV, "MaHDV");
            //cboMaHDV.SelectedIndex = -1;
            //Functions.FillCombo("select MaTour from LichTour where MaCongTy='"+cboMaCongTy.Text+"'", cboMaTour, "MaTour");
            //cboMaTour.SelectedIndex = -1;
            
        }
        private void LoadDataToGridview()
        {
            string sql = "select * from LichTour";
            DataTable myTable = Functions.LoadDataToTable(sql);
            dataGridView_LichTour.DataSource = myTable;
            tblLichTour = Functions.LoadDataToTable(sql);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            con.Close();
            this.Close();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            
            string sql;
            
            sql = "select * from LichTour where MaCongTy= '" + cboMaCongTy.Text +"' and MaHDV= '"
                +cboMaHDV.Text+"' and MaTour= '"+cboMaTour.Text+"'";
            
            tblLichTour = Functions.LoadDataToTable(sql);
            dataGridView_LichTour.DataSource = tblLichTour;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            
            LoadDataToGridview();
        }      

        private void cboMaCongTy_SelectedIndexChanged(object sender, EventArgs e)
        {
            Functions.FillCombo("select MaHDV from LichTour where MaCongTy ='" + cboMaCongTy.SelectedValue + "'", cboMaHDV, "MaHDV");
        }

        private void cboMaHDV_SelectedIndexChanged(object sender, EventArgs e)
        {
            Functions.FillCombo("select MaTour from LichTour where MaHDV ='" + cboMaHDV.SelectedValue +"' and MaCongTy= '"
                +cboMaCongTy.SelectedValue+"'", cboMaTour, "MaTour");
        }

        private void dataGridView_LichTour_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDaKhoiHanh.Text = dataGridView_LichTour.CurrentRow.Cells["DaKhoiHanh"].Value.ToString();
            txtMaLichTour.Text = dataGridView_LichTour.CurrentRow.Cells["MalichTour"].Value.ToString();
            txtNgayKhoiHanh.Text = dataGridView_LichTour.CurrentRow.Cells["NgayKhoiHanh"].Value.ToString();
            txtSoNguoiDangKy.Text = dataGridView_LichTour.CurrentRow.Cells["SoNguoiDangKy"].Value.ToString();
            txtTongTien.Text = dataGridView_LichTour.CurrentRow.Cells["TongTien"].Value.ToString();
            txtMaLichTour.Enabled = false;
        }
    }
}
