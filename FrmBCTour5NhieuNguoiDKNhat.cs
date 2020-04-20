using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using COMExcel = Microsoft.Office.Interop.Excel;


namespace QuanLyCongTyDuLich
{
    public partial class FrmBC3 : Form
    {
        DataTable tblBC3;
        public FrmBC3()
        {
            InitializeComponent();
        }

        private void FrmBC3_Load(object sender, EventArgs e)
        {
            btnHienThiBC3.Enabled = true;
            btnInBC3.Enabled = true;
            btnThoatBC3.Enabled = true;
        }

        private void btnHienThiBC3_Click(object sender, EventArgs e)
        {
            string sql = "SELECT TOP 5 d.MaTour, d.TenTour, c.MaCongTy,c.MaHDV,c.SoNguoiDangKyTour " +
                         "FROM tableDanhMucTour as d inner join(SELECT a.MaTour, a.MaCongTy, a.MaHDV, SUM(b.b1) as SoNguoiDangKyTour " +
                                                                "FROM tableLichTour as a inner join(SELECT MaLichTour, SUM(SoLuongDangKy) as b1 " +
                                                                                                    "FROM tableDangkyTour " +
                                                                                                     "GROUP BY MaLichTour) as b " +
                                                                "ON a.MaLichTour = b.MaLichTour " +
                                                                "Group by a.MaTour, a.MaCongTy, a.MaHDV) as c " +
                        "ON d.MaTour = c.MaTour";
            tblBC3 = Functions.LoadDataToTable(sql);
            dataGridViewBC3.DataSource = tblBC3;
            dataGridViewBC3.Columns[0].HeaderText = "Mã Tour";
            dataGridViewBC3.Columns[1].HeaderText = "Tên Tour";
            dataGridViewBC3.Columns[2].HeaderText = "Mã Công Ty";
            dataGridViewBC3.Columns[3].HeaderText = "Mã Hướng Dẫn Viên";
            dataGridViewBC3.Columns[4].HeaderText = "Số người ĐK Tour";
            dataGridViewBC3.Columns[0].Width = 100;
            dataGridViewBC3.Columns[1].Width = 100;
            dataGridViewBC3.Columns[2].Width = 100;
            dataGridViewBC3.Columns[3].Width = 100;
            dataGridViewBC3.Columns[4].Width = 100;
            dataGridViewBC3.AllowUserToAddRows = false;
            dataGridViewBC3.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnInBC3_Click(object sender, EventArgs e)
        {
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook;
            COMExcel.Worksheet exSheet;
            COMExcel.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            DataTable danhsach;

            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:Z300"].Font.Name = "Times new roman";
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5;
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:B1"].Value = "CÔNG TY DU LỊCH";
            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = "Đội Cấn - Hà Nội";
            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Điện thoại: 01635612685";
            exRange.Range["C2:G2"].Font.Size = 16;
            exRange.Range["C2:G2"].Font.Bold = true;
            exRange.Range["C2:G2"].Font.ColorIndex = 3;
            exRange.Range["C2:G2"].MergeCells = true;
            exRange.Range["C2:G2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C2:G2"].Value = "Báo cáo top 5 nhà cung cấp giao nhiều hàng nhất theo năm";
            sql = "SELECT TOP 5 d.MaTour, d.TenTour, c.MaCongTy,c.MaHDV,c.SoNguoiDangKyTour " +
                         "FROM tableDanhMucTour as d inner join(SELECT a.MaTour, a.MaCongTy, a.MaHDV, SUM(b.b1) as SoNguoiDangKyTour " +
                                                                "FROM tableLichTour as a inner join(SELECT MaLichTour, SUM(SoLuongDangKy) as b1 " +
                                                                                                    "FROM tableDangkyTour " +
                                                                                                     "GROUP BY MaLichTour) as b " +
                                                                "ON a.MaLichTour = b.MaLichTour " +
                                                                "Group by a.MaTour, a.MaCongTy, a.MaHDV) as c " +
                        "ON d.MaTour = c.MaTour";


            danhsach = Functions.LoadDataToTable(sql);

            exRange.Range["B5:G5"].Font.Bold = true;
            exRange.Range["B5:G5"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["B5:B5"].ColumnWidth = 12;
            exRange.Range["C5:C5"].ColumnWidth = 11;
            exRange.Range["D5:D5"].ColumnWidth = 23;
            exRange.Range["E5:E5"].ColumnWidth = 23;
            exRange.Range["F5:F5"].ColumnWidth = 23;
            exRange.Range["G5:G5"].ColumnWidth = 23;
            exRange.Range["B5:B5"].Value = "STT";
            exRange.Range["C5:C5"].Value = "Mã Tour";
            exRange.Range["D5:D5"].Value = "Tên Tour";
            exRange.Range["E5:E5"].Value = "Mã Công Ty";
            exRange.Range["F5:F5"].Value = "Mã Hướng Dẫn Viên";
            exRange.Range["G5:G5"].Value = "Số người Đk Tour";


            for (hang = 0; hang < danhsach.Rows.Count; hang++)
            {
                exSheet.Cells[2][hang + 6] = hang + 1;
                for (cot = 0; cot < danhsach.Columns.Count; cot++)
                {
                    exSheet.Cells[cot + 3][hang + 6] = danhsach.Rows[hang][cot].ToString();
                }
            }

            exRange = exSheet.Cells[2][hang + 8];
            exRange.Range["D1:F1"].MergeCells = true;
            exRange.Range["D1:F1"].Font.Italic = true;
            exRange.Range["D1:F1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["D1:F1"].Value = "Hà Nội, Ngày " + DateTime.Now.ToShortDateString();
            exSheet.Name = "Báo cáo";
            exApp.Visible = true;
        }

        private void btnThoatBC3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
