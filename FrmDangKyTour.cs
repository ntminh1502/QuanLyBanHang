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
    public partial class FrmDangKyTour : Form
    {
        SqlConnection con = new SqlConnection();
        DataTable tblDangKyTour;
        public FrmDangKyTour()
        {
            InitializeComponent();
        }

        private void FrmDangKyTour_Load(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=QuanLyCongTyDuLich;Integrated Security=True";
            con.ConnectionString = connectionstring;
            con.Open();
            LoadDataToGridView();
            Functions.FillCombo("SELECT MaLichTour FROM LichTour", cboMaLichTour, "MaLichTour");
            cboMaLichTour.SelectedIndex = -1;

        }
        private void LoadDataToGridView()
        {
            string sql = "SELECT * FROM DangKyTour";
            DataTable mytable = Functions.LoadDataToTable(sql);
            dataGridView_DangKyTour.DataSource = mytable;
            tblDangKyTour = Functions.LoadDataToTable(sql);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            con.Close();
            this.Close();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "SELECT * FROM LichTour WHERE MaLichTour = '"+ cboMaLichTour.Text + "'";
            tblDangKyTour = Functions.LoadDataToTable(sql);
            dataGridView_DangKyTour.DataSource = tblDangKyTour;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            LoadDataToGridView();
        }

        private void cboMaLichTour_SelectedIndexChanged(object sender, EventArgs e)
        {
            Functions.FillCombo("SELECT MaLichTour FROM LichTour WHERE NgayKhoiHanh > GetDate()"+ cboMaLichTour.SelectedValue + "'", cboMaLichTour, "MaLichTour");
        }

        private void dataGridView_DangKyTour_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaDangKy.Text = dataGridView_DangKyTour.CurrentRow.Cells["MaDangKy"].Value.ToString();
            txtMaKhach.Text = dataGridView_DangKyTour.CurrentRow.Cells["MaKhach"].Value.ToString();
            txtNgayDangKy.Text = dataGridView_DangKyTour.CurrentRow.Cells["NgayDangKy"].Value.ToString();
            txtSoLuongDangKy.Text = dataGridView_DangKyTour.CurrentRow.Cells["SoLuongDangKy"].Value.ToString();
            txtThanhTien.Text = dataGridView_DangKyTour.CurrentRow.Cells["ThanhTien"].Value.ToString();
            txtMaDangKy.Enabled = false;

        }
    }
}
