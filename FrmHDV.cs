using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyCongTyDuLich;

namespace QuanLyCongTyDuLich
{
    public partial class FrmHDV : Form
    {
        SqlConnection con = new SqlConnection();
        DataTable tblHDV;
        public FrmHDV()
        {
            InitializeComponent();
        }

        private void FrmHDV_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-FUFFDKL;Initial Catalog=QuanLyCongTyDuLich;Integrated Security=True";
            con.ConnectionString = connectionString;
            con.Open();
            LoadDataToGridview();

        }
        private void LoadDataToGridview()
        {
            string sql = "select * from HuongDanVien";
            DataTable myTable = Functions.LoadDataToTable(sql);
           
            dataGridView1.DataSource = myTable;
            tblHDV = Functions.LoadDataToTable(sql);

        }
        private void RunSql(string sql)
        {

            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            LoadDataToGridview();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHDV.Text = dataGridView1.CurrentRow.Cells["MaHDV"].Value.ToString();
            txtTenHDV.Text = dataGridView1.CurrentRow.Cells["TenHDV"].Value.ToString();
            txtMaCongTy.Text = dataGridView1.CurrentRow.Cells["MaCongTy"].Value.ToString();
            txtNgaySinh.Text = dataGridView1.CurrentRow.Cells["NgaySinh"].Value.ToString();
            txtGioiTinh.Text = dataGridView1.CurrentRow.Cells["GioiTinh"].Value.ToString();
            txtMaTinh.Text = dataGridView1.CurrentRow.Cells["MaTinh"].Value.ToString();
            txtMaTrinhDo.Text = dataGridView1.CurrentRow.Cells["MaTrinhDo"].Value.ToString();
            txtMaTruongDT.Text = dataGridView1.CurrentRow.Cells["MaTruongDT"].Value.ToString();
            txtNgayVaoCongTy.Text = dataGridView1.CurrentRow.Cells["NgayVaoCongTy"].Value.ToString();
            txtMaHDV.Enabled = false;
        }

        private void resetValues()
        {
            txtMaHDV.Text = "";
            txtTenHDV.Text = "";
            txtMaCongTy.Text = "";
            txtNgaySinh.Text = "";
            txtGioiTinh.Text = "";
            txtMaTinh.Text = "";
            txtMaTrinhDo.Text = "";
            txtMaTruongDT.Text = "";
            txtNgayVaoCongTy.Text = "";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            resetValues();
            txtMaHDV.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if(tblHDV.Rows.Count==0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaHDV.Text=="")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(MessageBox.Show("Bạn có muốn xóa không?","Thông báo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question)==DialogResult.Yes)
            {
                sql = "Delete from HuongDanVien where MaHDV= '" + txtMaHDV.Text + "'";
                RunSql(sql);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblHDV.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaHDV.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "update HuongDanVien set TenHDV= N'" + txtTenHDV.Text +
                "', MaCongTy= '" + txtMaCongTy.Text + "', NgaySinh= '" + Functions.ConvertDateTime(txtNgaySinh.Text) + "', GioiTinh= N'" + txtGioiTinh.Text +
                "', MaTinh= '" + txtMaTinh.Text + "', MaTrinhDo= '" + txtMaTrinhDo.Text + "', MaTruongDT= '" + txtMaTruongDT.Text +
                "', NgayVaoCongTy= '" +Functions.ConvertDateTime(txtNgayVaoCongTy.Text) + "' where MaHDV= '" + txtMaHDV.Text + "'";
            RunSql(sql);
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if(txtMaHDV.Text=="")
            {
                MessageBox.Show("Bạn cần nhập mã hướng dẫn viên");
                txtMaHDV.Focus();
                return;
            }
            if(txtTenHDV.Text=="")
            {
                MessageBox.Show("Bạn cần nhập tên hướng dẫn viên");
                txtTenHDV.Focus();
                return;
            }
            if (txtMaCongTy.Text == "")
            {
                MessageBox.Show("Bạn cần nhập mã công ty");
                txtMaCongTy.Focus();
                return;
            }
            if (txtNgaySinh.Text == "")
            {
                MessageBox.Show("Bạn cần nhập ngày sinh");
                txtNgaySinh.Focus();
                return;
            }
            if (txtGioiTinh.Text == "")
            {
                MessageBox.Show("Bạn cần nhập giới tính");
                txtGioiTinh.Focus();
                return;
            }
            if (txtMaTinh.Text == "")
            {
                MessageBox.Show("Bạn cần nhập mã tỉnh");
                txtMaTinh.Focus();
                return;
            }
            if (txtMaTrinhDo.Text == "")
            {
                MessageBox.Show("Bạn cần nhập mã trình độ");
                txtMaTrinhDo.Focus();
                return;
            }
            if (txtMaTruongDT.Text == "")
            {
                MessageBox.Show("Bạn cần nhập mã trường đào tạo");
                txtMaTruongDT.Focus();
                return;
            }
            if (txtNgayVaoCongTy.Text == "")
            {
                MessageBox.Show("Bạn cần nhập ngày vào công ty");
                txtNgayVaoCongTy.Focus();
                return;
            }
            sql = "select MaHDV from HuongDanVien where MaHDV= '" + txtMaHDV.Text + "'";
            if(Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã HDV này đã tồn tại, bạn phải nhập mã khác", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaHDV.Focus();
                txtMaHDV.Text = "";
                return;
            }
            sql = "insert into HuongDanVien values ('" + txtMaHDV.Text + "', N'" + txtTenHDV.Text + "', '" + txtMaCongTy.Text +
                    "', '" +Functions.ConvertDateTime(txtNgaySinh.Text) + "', N'" + txtGioiTinh.Text + "', '" + txtMaTinh.Text + 
                    "', '" + txtMaTrinhDo.Text + "', '" + txtMaTruongDT.Text + "', '" +Functions.ConvertDateTime(txtNgayVaoCongTy.Text) + "')";
            MessageBox.Show(sql);             
            RunSql(sql);               
                        
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
             txtMaHDV.Text = dataGridView1.CurrentRow.Cells["MaHDV"].Value.ToString();
             txtTenHDV.Text = dataGridView1.CurrentRow.Cells["TenHDV"].Value.ToString();
             txtMaCongTy.Text = dataGridView1.CurrentRow.Cells["MaCongTy"].Value.ToString();
             txtNgaySinh.Text = dataGridView1.CurrentRow.Cells["NgaySinh"].Value.ToString();
             txtGioiTinh.Text = dataGridView1.CurrentRow.Cells["GioiTinh"].Value.ToString();
             txtMaTinh.Text = dataGridView1.CurrentRow.Cells["MaTinh"].Value.ToString();
             txtMaTrinhDo.Text = dataGridView1.CurrentRow.Cells["MaTrinhDo"].Value.ToString();
             txtMaTruongDT.Text = dataGridView1.CurrentRow.Cells["MaTruongDT"].Value.ToString();
             txtNgayVaoCongTy.Text = dataGridView1.CurrentRow.Cells["NgayVaoCongTy"].Value.ToString();
             txtMaHDV.Enabled = false;
             /*
             resetValues();
             btnHuy.Enabled = false;
             btnThem.Enabled = true;
             btnXoa.Enabled = true;
             btnSua.Enabled = true;
             btnLuu.Enabled = false;
             txtMaHDV.Enabled = false;
             */
            LoadDataToGridview();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            con.Close();
            this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sql;
            if((txtTenHDV.Text=="")&&(txtMaCongTy.Text=="")&&(txtMaTruongDT.Text==""))
            {
                MessageBox.Show("Bạn cần nhập điều kiện tìm kiếm", "Yêu cầu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "select * from HuongDanVien where 1=1";
            if(txtTenHDV.Text!="")
            {
                sql = sql + "and TenHDV like N'%" + txtTenHDV.Text + "%'";
            }
            if(txtMaCongTy.Text!="")
            {
                sql = sql + "and MaCongTY like N'%" + txtMaCongTy.Text + "%'";
            }
            if(txtMaTruongDT.Text!="")
            {
                sql = sql + "and MaTruongDT like N'%" + txtMaTruongDT.Text + "%'";
            }
            tblHDV = Functions.LoadDataToTable(sql);
            if(tblHDV.Rows.Count==0)
            {
                MessageBox.Show("Không có bản ghi nào thỏa mãn", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Có " + tblHDV.Rows.Count + " bản ghi thỏa mãn", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            dataGridView1.DataSource = tblHDV;

        }
    }
}
