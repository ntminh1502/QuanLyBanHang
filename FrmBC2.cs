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
    public partial class FrmBC2 : Form
    {
        DataTable tblBC2;
        public FrmBC2()
        {
            InitializeComponent();
        }

        private void FrmBC2_Load(object sender, EventArgs e)
        {
            dateTPBC2TuNgay.Enabled = false;
            dateTPBC2DenNgay.Enabled = false;
            btnBatDauBC2.Enabled = true;
            btnHienThiBC2.Enabled = false;
            btnInBC2.Enabled = false;
            btnThoatBC2.Enabled = false;
        }

        private void btnBatDauBC2_Click(object sender, EventArgs e)
        {
            dateTPBC2TuNgay.Enabled = true;
            dateTPBC2DenNgay.Enabled = true;
            btnHienThiBC2.Enabled = true;
            btnInBC2.Enabled = true;
            btnThoatBC2.Enabled = true;
        }

        private void btnHienThiBC2_Click(object sender, EventArgs e)
        {
            string sql;
            if(dateTPBC2TuNgay.Text == "" && dateTPBC2DenNgay.Text == "")
            {
                MessageBox.Show("Chọn thời điểm báo cáo !");
            }    
            sql = "(SELECT d.MaLichTour,tableDangkyTour.NgayDangKy,d.TongTienLichTour FROM tableDangkyTour inner join " +
                "(SELECT  b.MaLichTour ,SUM(a.DonGia * c.SoLuongDangKy) as TongTienLichTour " +
                  "FROM tableDanhMucTour as a " +
                  "inner join tableLichTour as b on a.MaTour = b.MaTour " +
                  "inner join tableDangkyTour as c on b.MaLichTour = c.MaLichTour " +
                  "GROUP BY  b.MaLichTour) as d ON tableDangkyTour.MaLichTour = d.MaLichTour " +
                  "WHERE 1=1 ";

            if(dateTPBC2TuNgay.Text != "")
            {
                sql = sql + "AND tableDangkyTour.NgayDangKy >= '" + dateTPBC2TuNgay.Value + "' ";
            }    
            if(dateTPBC2DenNgay.Text != "")
            {
                sql = sql + "AND tableDangkyTour.NgayDangKy <= '" + dateTPBC2DenNgay.Value + "') as e ";
            }

            sql = "SELECT tableCongTy.MaCongTy, tableCongTy.TenCongTy, g.DoanhThu " +
                   "FROM tableCongTy " +
                   "inner join(SELECT tableDanhMucTour.MaCongTy, SUM(f.TongTienTour) as DoanhThu " +
                                "FROM tableDanhMucTour " +
                                "inner join(SELECT d.MaTour, SUM(e.TongTienLichTour) as TongTienTour " +
                                            "FROM tableLichTour as d " +
                                             "inner join " + sql +
                                             "ON d.MaLichTour = e.MaLichTour " +
                                             "GROUP BY d.MaTour ) AS f " +
                                "ON tableDanhMucTour.MaTour = f.MaTour " +
                                "GROUP BY tableDanhMucTour.MaCongTy) as g " +
                    "ON tableCongTy.MaCongTy = g.MaCongTy ";

            tblBC2 = Functions.LoadDataToTable(sql);
            dataGridViewBC2.DataSource = tblBC2;
            dataGridViewBC2.Columns[0].HeaderText = "Mã Công Ty";
            dataGridViewBC2.Columns[1].HeaderText = "Tên Công Ty";
            dataGridViewBC2.Columns[2].HeaderText = "Doanh Thu";
            dataGridViewBC2.Columns[0].Width = 100;
            dataGridViewBC2.Columns[1].Width = 100;
            dataGridViewBC2.Columns[2].Width = 100;
            dataGridViewBC2.AllowUserToAddRows = false;
            dataGridViewBC2.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnInBC2_Click(object sender, EventArgs e)
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
            exRange.Range["A1:A1"].ColumnWidth = 10;
            exRange.Range["B1:B1"].ColumnWidth = 20;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:B1"].Value = "QUẢN LÝ CÔNG TY DU LỊCH";
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
            exRange.Range["C2:G2"].Value = "Báo cáo Doanh thu các Tour của các Công Ty";
            sql = "(SELECT d.MaLichTour,tableDangkyTour.NgayDangKy,d.TongTienLichTour FROM tableDangkyTour inner join " +
                "(SELECT  b.MaLichTour ,SUM(a.DonGia * c.SoLuongDangKy) as TongTienLichTour " +
                  "FROM tableDanhMucTour as a " +
                  "inner join tableLichTour as b on a.MaTour = b.MaTour " +
                  "inner join tableDangkyTour as c on b.MaLichTour = c.MaLichTour " +
                  "GROUP BY  b.MaLichTour) as d ON tableDangkyTour.MaLichTour = d.MaLichTour " +
                  "WHERE 1=1 ";

            if (dateTPBC2TuNgay.Text != "")
            {
                sql = sql + "AND tableDangkyTour.NgayDangKy >= '" + dateTPBC2TuNgay.Value + "' ";
            }
            if (dateTPBC2DenNgay.Text != "")
            {
                sql = sql + "AND tableDangkyTour.NgayDangKy <= '" + dateTPBC2DenNgay.Value + "') as e ";
            }

            sql = "SELECT tableCongTy.MaCongTy, tableCongTy.TenCongTy, g.DoanhThu " +
                   "FROM tableCongTy " +
                   "inner join(SELECT tableDanhMucTour.MaCongTy, SUM(f.TongTienTour) as DoanhThu " +
                                "FROM tableDanhMucTour " +
                                "inner join(SELECT d.MaTour, SUM(e.TongTienLichTour) as TongTienTour " +
                                            "FROM tableLichTour as d " +
                                             "inner join " + sql +
                                             "ON d.MaLichTour = e.MaLichTour " +
                                             "GROUP BY d.MaTour ) AS f " +
                                "ON tableDanhMucTour.MaTour = f.MaTour " +
                                "GROUP BY tableDanhMucTour.MaCongTy) as g " +
                    "ON tableCongTy.MaCongTy = g.MaCongTy ";


            danhsach = Functions.LoadDataToTable(sql);

            exRange.Range["B5:G5"].Font.Bold = true;
            exRange.Range["B5:G5"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["B5:B5"].ColumnWidth = 12;
            exRange.Range["C5:C5"].ColumnWidth = 15;
            exRange.Range["D5:D5"].ColumnWidth = 50;
            exRange.Range["E5:E5"].ColumnWidth = 23;
            exRange.Range["B5:B5"].Value = "STT";
            exRange.Range["C5:C5"].Value = "Mã Công Ty";
            exRange.Range["D5:D5"].Value = "Tên Công Ty";
            exRange.Range["E5:E5"].Value = "Doanh Thu";


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

        private void btnThoatBC2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
