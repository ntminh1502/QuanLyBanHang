using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using COMExecl = Microsoft.Office.Interop.Excel;

namespace QuanLyCongTyDuLich
{
    public partial class FrmBCTourChuaKhoiHanh : Form
    {
        DataTable tblBC1;
        public FrmBCTourChuaKhoiHanh()
        {
            InitializeComponent();
        }

        private void FrmBCTourChuaKhoiHanh_Load(object sender, EventArgs e)
        {
            btnInBC1.Enabled = false;
            btnThoat.Enabled = true;
            btnHienThiBC1.Enabled = false;
            txtTenPhamVi.ReadOnly = true;
            cboDaKhoiHanh.Enabled = false;
            cboDaKhoiHanh.Items.Add("Chưa");
            cboDaKhoiHanh.Items.Add("Sắp");
            cboDaKhoiHanh.Items.Add("Đang");
            cboMaPhamVi.Enabled = false;
            Functions.FillCombo("SELECT MaPhamVi, TenPhamVi FROM tablePhamVi", cboMaPhamVi, "MaPhamVi");
            cboMaPhamVi.SelectedIndex = -1;
        }

        private void cboMaPhamVi_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cboMaPhamVi.Text == "")
                txtTenPhamVi.Text = "";
            str = "SELECT TenPhamVi FROM tablePhamVi WHERE MaPhamVi = N'" + cboMaPhamVi.SelectedValue + "'";
            txtTenPhamVi.Text = Functions.GetFieldValues(str);
        }

        private void btnHienThiBC1_Click(object sender, EventArgs e)
        {
            string sql;
            if ((cboDaKhoiHanh.Text == "") || (cboMaPhamVi.Text == ""))
            {
                MessageBox.Show("Hãy nhập đủ điều kiện!!!", "Yêu cầu ...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT a.MaTour, TenTour, SoNgay, MaPhamVi, NgayKhoiHanh " +
                    "FROM tableDanhMucTour a join tableLichTour b on a.MaTour = b.MaTour" +
                    " WHERE MaPhamVi = N'" + cboMaPhamVi.Text + "' AND DaKhoiHanh = N'" + cboDaKhoiHanh.Text + "'";
            //if (txtDaKhoiHanh.Text != "")
            //  sql = sql + " AND b.DaKhoiHanh Like N'%" + txtDaKhoiHanh.Text + "%'";
            //if (cboMaPhamVi.Text != "")
            //  sql = sql + " AND a.MaPhamVi Like N'%" + cboMaPhamVi.SelectedValue + "%'";
            //tblBC1 = Functions.LoadDataToTable(sql);

            //if(tblBC1.Rows.Count == 0)
            //{
            //    MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!!","Thông báo",
            //                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            //else
            //    MessageBox.Show("Có"+ tblBC1.Rows.Count + "Bản ghi thỏa mãn điều kiện!!!",
            //                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            tblBC1 = Functions.LoadDataToTable(sql);
            dataGridViewBC1.DataSource = tblBC1;
            dataGridViewBC1.Columns[0].HeaderText = "Mã Tour";
            dataGridViewBC1.Columns[1].HeaderText = "Tên Tour";
            dataGridViewBC1.Columns[2].HeaderText = "Số Ngày";
            dataGridViewBC1.Columns[3].HeaderText = "Mã Phạm Vi";
            //dataGridViewBC1.Columns[4].HeaderText = "Đã Khởi Hành";
            dataGridViewBC1.Columns[4].HeaderText = "Ngày Khởi Hành";
            dataGridViewBC1.Columns[0].Width = 100;
            dataGridViewBC1.Columns[1].Width = 100;
            dataGridViewBC1.Columns[2].Width = 100;
            dataGridViewBC1.Columns[3].Width = 100;
            //dataGridViewBC1.Columns[4].Width = 10;
            dataGridViewBC1.Columns[4].Width = 100;
            dataGridViewBC1.AllowUserToAddRows = false;
            dataGridViewBC1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnBatDau_Click(object sender, EventArgs e)
        {
            cboDaKhoiHanh.Enabled = true;
            cboMaPhamVi.Enabled = true;
            btnHienThiBC1.Enabled = true;
            btnInBC1.Enabled = true;
            cboDaKhoiHanh.Text = "";
            cboDaKhoiHanh.Focus();
            cboMaPhamVi.Text = "";
            cboMaPhamVi.Focus();

        }

        private void btnInBC1_Click(object sender, EventArgs e)
        {
            if (cboDaKhoiHanh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập năm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboDaKhoiHanh.Focus();
                return;
            }
            if (cboMaPhamVi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn quí", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaPhamVi.Focus();
                return;
            }

            COMExecl.Application exApp = new COMExecl.Application();
            COMExecl.Workbook exBook;
            COMExecl.Worksheet exSheet;
            COMExecl.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            DataTable danhsach;

            exBook = exApp.Workbooks.Add(COMExecl.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1: B3"].Font.Size = 10;
            exRange.Range["A1: B3"].Font.Name = "Times new roman";
            exRange.Range["A1: B3"].Font.Bold = true;
            exRange.Range["A1: B3"].Font.ColorIndex = 5; //Màu xanh da trời
            exRange.Range["A1: A1"].ColumnWidth = 7;
            exRange.Range["B1: B1"].ColumnWidth = 15;
            exRange.Range["A1: B1"].MergeCells = true;
            exRange.Range["A1: B1"].HorizontalAlignment = COMExecl.XlHAlign.xlHAlignCenter;
            exRange.Range["A1: B1"].Value = "Công Ty Du Lịch";
            exRange.Range["A2: B2"].MergeCells = true;
            exRange.Range["A2: B2"].HorizontalAlignment = COMExecl.XlHAlign.xlHAlignCenter;
            exRange.Range["A2: B2"].Value = "Cầu Giấy -Hà Nội";
            exRange.Range["A3: B3"].MergeCells = true;
            exRange.Range["A3: B3"].HorizontalAlignment = COMExecl.XlHAlign.xlHAlignCenter;
            exRange.Range["A3: B3"].Value = "Điện thoại: (04)37562222";
            exRange.Range["C4: E4"].Font.Size = 16;
            exRange.Range["C4: E4"].Font.Name = "Times new roman";
            exRange.Range["C4: E4"].Font.Bold = true;
            exRange.Range["C4: E4"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C4: E4"].MergeCells = true;
            exRange.Range["C4: E4"].HorizontalAlignment = COMExecl.XlHAlign.xlHAlignCenter;
            exRange.Range["C4: E4"].Value = "BÁO CÁO DS TOUR CHƯA KHỞI HÀNH";

            sql = "SELECT a.MaTour, TenTour, SoNgay, MaPhamVi, NgayKhoiHanh " +
                   "FROM tableDanhMucTour a join tableLichTour b on a.MaTour = b.MaTour" +
                   " WHERE MaPhamVi = N'" + cboMaPhamVi.Text + "' AND DaKhoiHanh = N'" + cboDaKhoiHanh.Text + "'";
            danhsach = Functions.LoadDataToTable(sql);

            exRange.Range["B6:G6"].Font.Bold = true;//In đậm các chữ 
            exRange.Range["B6:G6"].HorizontalAlignment = COMExecl.XlHAlign.xlHAlignCenter;
            exRange.Range["B6:B6"].ColumnWidth = 12;
            exRange.Range["C6:C6"].ColumnWidth = 15;
            exRange.Range["D6:D6"].ColumnWidth = 25;
            exRange.Range["E6:E6"].ColumnWidth = 15;
            exRange.Range["F6:F6"].ColumnWidth = 15;
            exRange.Range["G6:G6"].ColumnWidth = 15;
            exRange.Range["C8:C8"].ColumnWidth = 18;

            exRange.Range["B6:B6"].Value = "STT";
            exRange.Range["C6:C6"].Value = "Mã Tour";
            exRange.Range["D6:D6"].Value = "Tên Tour";
            exRange.Range["E6:E6"].Value = "Số Ngày";
            exRange.Range["F6:F6"].Value = "Mã Phạm Vi";
            exRange.Range["G6:G6"].Value = "Ngày Khởi Hành";

            for (hang = 0; hang < danhsach.Rows.Count; hang++)
            {
                exSheet.Cells[2][hang + 7] = hang + 1;//điền số thứ tự vào cột 2 bắt đầu từ hàng 7 (mở excel ra hình dung)
                for (cot = 0; cot < danhsach.Columns.Count; cot++)
                {
                    exSheet.Cells[cot + 3][hang + 7] = danhsach.Rows[hang][cot].ToString();//điền thông tin các cột còn lại từ dữ liệu đã đc đổ vào từ biến "danhsach" bắt đầu từ cột 3, hàng 6
                }
            }

            exRange = exSheet.Cells[2][hang + 9];//chỗ này là đánh dấu vị trí viết cái dòng "Hà Nội, ngày..."
            exRange.Range["D1:F1"].MergeCells = true;
            exRange.Range["D1:F1"].Font.Italic = true;
            exRange.Range["D1:F1"].HorizontalAlignment = COMExecl.XlHAlign.xlHAlignCenter;
            exRange.Range["D1:F1"].Value = "Hà Nội, Ngày " + DateTime.Now.ToShortDateString();
            exSheet.Name = "Báo cáo";
            exApp.Visible = true;

    }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
