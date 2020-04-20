namespace QuanLyCongTyDuLich
{
    partial class FrmBC3
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridViewBC3 = new System.Windows.Forms.DataGridView();
            this.btnHienThiBC3 = new System.Windows.Forms.Button();
            this.btnInBC3 = new System.Windows.Forms.Button();
            this.btnThoatBC3 = new System.Windows.Forms.Button();
            this.MaTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCongTy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoNguoiDKTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBC3)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBox1.Location = new System.Drawing.Point(137, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(497, 32);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "BÁO CÁO 5 TOUR CÓ SỐ NGƯỜI ĐK LỚN NHẤT";
            // 
            // dataGridViewBC3
            // 
            this.dataGridViewBC3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBC3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTour,
            this.TenTour,
            this.MaCongTy,
            this.MaHDV,
            this.SoNguoiDKTour});
            this.dataGridViewBC3.Location = new System.Drawing.Point(99, 76);
            this.dataGridViewBC3.Name = "dataGridViewBC3";
            this.dataGridViewBC3.Size = new System.Drawing.Size(544, 150);
            this.dataGridViewBC3.TabIndex = 1;
            // 
            // btnHienThiBC3
            // 
            this.btnHienThiBC3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnHienThiBC3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienThiBC3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnHienThiBC3.Location = new System.Drawing.Point(219, 291);
            this.btnHienThiBC3.Name = "btnHienThiBC3";
            this.btnHienThiBC3.Size = new System.Drawing.Size(139, 40);
            this.btnHienThiBC3.TabIndex = 2;
            this.btnHienThiBC3.Text = "Hiển Thị";
            this.btnHienThiBC3.UseVisualStyleBackColor = false;
            this.btnHienThiBC3.Click += new System.EventHandler(this.btnHienThiBC3_Click);
            // 
            // btnInBC3
            // 
            this.btnInBC3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnInBC3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInBC3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnInBC3.Location = new System.Drawing.Point(407, 291);
            this.btnInBC3.Name = "btnInBC3";
            this.btnInBC3.Size = new System.Drawing.Size(113, 40);
            this.btnInBC3.TabIndex = 3;
            this.btnInBC3.Text = "In Báo Cáo";
            this.btnInBC3.UseVisualStyleBackColor = false;
            this.btnInBC3.Click += new System.EventHandler(this.btnInBC3_Click);
            // 
            // btnThoatBC3
            // 
            this.btnThoatBC3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnThoatBC3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoatBC3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnThoatBC3.Location = new System.Drawing.Point(559, 291);
            this.btnThoatBC3.Name = "btnThoatBC3";
            this.btnThoatBC3.Size = new System.Drawing.Size(75, 40);
            this.btnThoatBC3.TabIndex = 4;
            this.btnThoatBC3.Text = "Thoát";
            this.btnThoatBC3.UseVisualStyleBackColor = false;
            this.btnThoatBC3.Click += new System.EventHandler(this.btnThoatBC3_Click);
            // 
            // MaTour
            // 
            this.MaTour.DataPropertyName = "MaTour";
            this.MaTour.HeaderText = "Mã Tour";
            this.MaTour.Name = "MaTour";
            // 
            // TenTour
            // 
            this.TenTour.DataPropertyName = "TenTour";
            this.TenTour.HeaderText = "Tên Tour";
            this.TenTour.Name = "TenTour";
            // 
            // MaCongTy
            // 
            this.MaCongTy.DataPropertyName = "MaCongTy";
            this.MaCongTy.HeaderText = "Mã Công Ty";
            this.MaCongTy.Name = "MaCongTy";
            // 
            // MaHDV
            // 
            this.MaHDV.DataPropertyName = "MaHDV";
            this.MaHDV.HeaderText = "Mã Hướng Dẫn Viên";
            this.MaHDV.Name = "MaHDV";
            // 
            // SoNguoiDKTour
            // 
            this.SoNguoiDKTour.DataPropertyName = "SoNguoiDKTour";
            this.SoNguoiDKTour.HeaderText = "Số Người ĐK Tour";
            this.SoNguoiDKTour.Name = "SoNguoiDKTour";
            // 
            // FrmBC3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoatBC3);
            this.Controls.Add(this.btnInBC3);
            this.Controls.Add(this.btnHienThiBC3);
            this.Controls.Add(this.dataGridViewBC3);
            this.Controls.Add(this.textBox1);
            this.Name = "FrmBC3";
            this.Text = "FrmBCTour5NhieuNguoiDKNhat";
            this.Load += new System.EventHandler(this.FrmBC3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBC3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridViewBC3;
        private System.Windows.Forms.Button btnHienThiBC3;
        private System.Windows.Forms.Button btnInBC3;
        private System.Windows.Forms.Button btnThoatBC3;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCongTy;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoNguoiDKTour;
    }
}