namespace QuanLyCongTyDuLich
{
    partial class FrmLichTour
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.Label();
            this.txtMaLichTour = new System.Windows.Forms.TextBox();
            this.txtNgayKhoiHanh = new System.Windows.Forms.TextBox();
            this.txtSoNguoiDangKy = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.txtDaKhoiHanh = new System.Windows.Forms.TextBox();
            this.dataGridView_LichTour = new System.Windows.Forms.DataGridView();
            this.MaLichTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCongTy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKhoiHanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoNguoiDangKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaKhoiHanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cboMaCongTy = new System.Windows.Forms.ComboBox();
            this.cboMaHDV = new System.Windows.Forms.ComboBox();
            this.cboMaTour = new System.Windows.Forms.ComboBox();
            this.btnHuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_LichTour)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã lịch tour";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã công ty";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã Tour";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(314, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã HDV";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(314, 67);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày khởi hành";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(314, 110);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Số người đăng ký";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(579, 67);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Đã khởi hành";
            // 
            // txtTongTien
            // 
            this.txtTongTien.AutoSize = true;
            this.txtTongTien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(579, 25);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(65, 19);
            this.txtTongTien.TabIndex = 7;
            this.txtTongTien.Text = "Tổng tiền";
            // 
            // txtMaLichTour
            // 
            this.txtMaLichTour.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLichTour.Location = new System.Drawing.Point(132, 23);
            this.txtMaLichTour.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaLichTour.Name = "txtMaLichTour";
            this.txtMaLichTour.Size = new System.Drawing.Size(108, 26);
            this.txtMaLichTour.TabIndex = 8;
            // 
            // txtNgayKhoiHanh
            // 
            this.txtNgayKhoiHanh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayKhoiHanh.Location = new System.Drawing.Point(436, 64);
            this.txtNgayKhoiHanh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNgayKhoiHanh.Name = "txtNgayKhoiHanh";
            this.txtNgayKhoiHanh.Size = new System.Drawing.Size(108, 26);
            this.txtNgayKhoiHanh.TabIndex = 12;
            // 
            // txtSoNguoiDangKy
            // 
            this.txtSoNguoiDangKy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoNguoiDangKy.Location = new System.Drawing.Point(436, 107);
            this.txtSoNguoiDangKy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSoNguoiDangKy.Name = "txtSoNguoiDangKy";
            this.txtSoNguoiDangKy.Size = new System.Drawing.Size(108, 26);
            this.txtSoNguoiDangKy.TabIndex = 13;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(664, 23);
            this.textBox7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(108, 26);
            this.textBox7.TabIndex = 14;
            // 
            // txtDaKhoiHanh
            // 
            this.txtDaKhoiHanh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDaKhoiHanh.Location = new System.Drawing.Point(664, 64);
            this.txtDaKhoiHanh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDaKhoiHanh.Name = "txtDaKhoiHanh";
            this.txtDaKhoiHanh.Size = new System.Drawing.Size(108, 26);
            this.txtDaKhoiHanh.TabIndex = 15;
            // 
            // dataGridView_LichTour
            // 
            this.dataGridView_LichTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_LichTour.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLichTour,
            this.MaCongTy,
            this.MaTour,
            this.MaHDV,
            this.NgayKhoiHanh,
            this.SoNguoiDangKy,
            this.TongTien,
            this.DaKhoiHanh});
            this.dataGridView_LichTour.Location = new System.Drawing.Point(35, 185);
            this.dataGridView_LichTour.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView_LichTour.Name = "dataGridView_LichTour";
            this.dataGridView_LichTour.RowHeadersWidth = 51;
            this.dataGridView_LichTour.RowTemplate.Height = 24;
            this.dataGridView_LichTour.Size = new System.Drawing.Size(790, 141);
            this.dataGridView_LichTour.TabIndex = 16;
            this.dataGridView_LichTour.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_LichTour_CellClick);
            // 
            // MaLichTour
            // 
            this.MaLichTour.DataPropertyName = "MaLichTour";
            this.MaLichTour.HeaderText = "Mã lịch tour";
            this.MaLichTour.MinimumWidth = 6;
            this.MaLichTour.Name = "MaLichTour";
            this.MaLichTour.Width = 125;
            // 
            // MaCongTy
            // 
            this.MaCongTy.DataPropertyName = "MaCongTy";
            this.MaCongTy.HeaderText = "Mã công ty";
            this.MaCongTy.MinimumWidth = 6;
            this.MaCongTy.Name = "MaCongTy";
            this.MaCongTy.Width = 125;
            // 
            // MaTour
            // 
            this.MaTour.DataPropertyName = "MaTour";
            this.MaTour.HeaderText = "Mã tour";
            this.MaTour.MinimumWidth = 6;
            this.MaTour.Name = "MaTour";
            this.MaTour.Width = 125;
            // 
            // MaHDV
            // 
            this.MaHDV.DataPropertyName = "MaHDV";
            this.MaHDV.HeaderText = "Mã HDV";
            this.MaHDV.MinimumWidth = 6;
            this.MaHDV.Name = "MaHDV";
            this.MaHDV.Width = 125;
            // 
            // NgayKhoiHanh
            // 
            this.NgayKhoiHanh.DataPropertyName = "NgayKhoiHanh";
            this.NgayKhoiHanh.HeaderText = "Ngày khởi hành";
            this.NgayKhoiHanh.MinimumWidth = 6;
            this.NgayKhoiHanh.Name = "NgayKhoiHanh";
            this.NgayKhoiHanh.Width = 125;
            // 
            // SoNguoiDangKy
            // 
            this.SoNguoiDangKy.DataPropertyName = "SoNguoiDangKy";
            this.SoNguoiDangKy.HeaderText = "Số người đăng ký";
            this.SoNguoiDangKy.MinimumWidth = 6;
            this.SoNguoiDangKy.Name = "SoNguoiDangKy";
            this.SoNguoiDangKy.Width = 125;
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.MinimumWidth = 6;
            this.TongTien.Name = "TongTien";
            this.TongTien.Width = 125;
            // 
            // DaKhoiHanh
            // 
            this.DaKhoiHanh.DataPropertyName = "DaKhoiHanh";
            this.DaKhoiHanh.HeaderText = "Đã khởi hành";
            this.DaKhoiHanh.MinimumWidth = 6;
            this.DaKhoiHanh.Name = "DaKhoiHanh";
            this.DaKhoiHanh.Width = 125;
            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Location = new System.Drawing.Point(565, 366);
            this.btnDong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(61, 25);
            this.btnDong.TabIndex = 22;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnHienThi
            // 
            this.btnHienThi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienThi.Location = new System.Drawing.Point(159, 366);
            this.btnHienThi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(70, 25);
            this.btnHienThi.TabIndex = 23;
            this.btnHienThi.Text = "Hiển thị";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // cboMaCongTy
            // 
            this.cboMaCongTy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaCongTy.FormattingEnabled = true;
            this.cboMaCongTy.Location = new System.Drawing.Point(132, 64);
            this.cboMaCongTy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboMaCongTy.Name = "cboMaCongTy";
            this.cboMaCongTy.Size = new System.Drawing.Size(108, 27);
            this.cboMaCongTy.TabIndex = 24;
            this.cboMaCongTy.SelectedIndexChanged += new System.EventHandler(this.cboMaCongTy_SelectedIndexChanged);
            // 
            // cboMaHDV
            // 
            this.cboMaHDV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaHDV.FormattingEnabled = true;
            this.cboMaHDV.Location = new System.Drawing.Point(436, 23);
            this.cboMaHDV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboMaHDV.Name = "cboMaHDV";
            this.cboMaHDV.Size = new System.Drawing.Size(108, 27);
            this.cboMaHDV.TabIndex = 25;
            this.cboMaHDV.SelectedIndexChanged += new System.EventHandler(this.cboMaHDV_SelectedIndexChanged);
            // 
            // cboMaTour
            // 
            this.cboMaTour.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaTour.FormattingEnabled = true;
            this.cboMaTour.Location = new System.Drawing.Point(132, 107);
            this.cboMaTour.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboMaTour.Name = "cboMaTour";
            this.cboMaTour.Size = new System.Drawing.Size(108, 27);
            this.cboMaTour.TabIndex = 26;
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(364, 366);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(70, 25);
            this.btnHuy.TabIndex = 27;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // FrmLichTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 457);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.cboMaTour);
            this.Controls.Add(this.cboMaHDV);
            this.Controls.Add(this.cboMaCongTy);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.dataGridView_LichTour);
            this.Controls.Add(this.txtDaKhoiHanh);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.txtSoNguoiDangKy);
            this.Controls.Add(this.txtNgayKhoiHanh);
            this.Controls.Add(this.txtMaLichTour);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmLichTour";
            this.Text = "FrmLichTour";
            this.Load += new System.EventHandler(this.FrmLichTour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_LichTour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txtTongTien;
        private System.Windows.Forms.TextBox txtMaLichTour;
        private System.Windows.Forms.TextBox txtNgayKhoiHanh;
        private System.Windows.Forms.TextBox txtSoNguoiDangKy;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox txtDaKhoiHanh;
        private System.Windows.Forms.DataGridView dataGridView_LichTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLichTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCongTy;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKhoiHanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoNguoiDangKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaKhoiHanh;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnHienThi;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cboMaCongTy;
        private System.Windows.Forms.ComboBox cboMaHDV;
        private System.Windows.Forms.ComboBox cboMaTour;
        private System.Windows.Forms.Button btnHuy;
    }
}