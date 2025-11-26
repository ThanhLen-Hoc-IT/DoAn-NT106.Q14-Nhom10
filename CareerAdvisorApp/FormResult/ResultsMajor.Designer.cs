namespace YourProjectNamespace
{
    partial class ResultsMajor
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
            this.lblNhapDiem = new System.Windows.Forms.Label();
            this.cboToHop = new System.Windows.Forms.ComboBox();
            this.btnXemGoiY = new System.Windows.Forms.Button();
            this.txtDiemUT = new System.Windows.Forms.TextBox();
            this.txtTongDiem = new System.Windows.Forms.TextBox();
            this.lblToHop = new System.Windows.Forms.Label();
            this.lblTongDiem = new System.Windows.Forms.Label();
            this.lblDiemUT = new System.Windows.Forms.Label();
            this.lblTuyChon = new System.Windows.Forms.Label();
            this.cboChonVung = new System.Windows.Forms.ComboBox();
            this.lblChonVung = new System.Windows.Forms.Label();
            this.lblKQ = new System.Windows.Forms.Label();
            this.dgvKetQua = new System.Windows.Forms.DataGridView();
            this.Truong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemChuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChenhLech = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khannang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).BeginInit();

            // 
            // lblNhapDiem
            // 
            this.lblNhapDiem.AutoSize = true;
            this.lblNhapDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhapDiem.Location = new System.Drawing.Point(135, 25);
            this.lblNhapDiem.Name = "lblNhapDiem";
            this.lblNhapDiem.Size = new System.Drawing.Size(307, 30);
            this.lblNhapDiem.TabIndex = 0;
            this.lblNhapDiem.Text = "NHẬP ĐIỂM XÉT TUYỂN";
            // 
            // cboToHop
            // 
            this.cboToHop.FormattingEnabled = true;
            this.cboToHop.Location = new System.Drawing.Point(212, 97);
            this.cboToHop.Name = "cboToHop";
            this.cboToHop.Size = new System.Drawing.Size(121, 28);
            this.cboToHop.TabIndex = 1;
            // 
            // btnXemGoiY
            // 
            this.btnXemGoiY.Location = new System.Drawing.Point(402, 132);
            this.btnXemGoiY.Name = "btnXemGoiY";
            this.btnXemGoiY.Size = new System.Drawing.Size(126, 54);
            this.btnXemGoiY.TabIndex = 2;
            this.btnXemGoiY.Text = "Xem Gợi Ý";
            this.btnXemGoiY.UseVisualStyleBackColor = true;
            // 
            // txtDiemUT
            // 
            this.txtDiemUT.Location = new System.Drawing.Point(212, 211);
            this.txtDiemUT.Name = "txtDiemUT";
            this.txtDiemUT.Size = new System.Drawing.Size(121, 26);
            this.txtDiemUT.TabIndex = 3;
            // 
            // txtTongDiem
            // 
            this.txtTongDiem.Location = new System.Drawing.Point(212, 146);
            this.txtTongDiem.Name = "txtTongDiem";
            this.txtTongDiem.Size = new System.Drawing.Size(121, 26);
            this.txtTongDiem.TabIndex = 4;
            // 
            // lblToHop
            // 
            this.lblToHop.AutoSize = true;
            this.lblToHop.Location = new System.Drawing.Point(40, 100);
            this.lblToHop.Name = "lblToHop";
            this.lblToHop.Size = new System.Drawing.Size(100, 20);
            this.lblToHop.TabIndex = 5;
            this.lblToHop.Text = "Chọn tổ hợp:";
            // 
            // lblTongDiem
            // 
            this.lblTongDiem.AutoSize = true;
            this.lblTongDiem.Location = new System.Drawing.Point(40, 152);
            this.lblTongDiem.Name = "lblTongDiem";
            this.lblTongDiem.Size = new System.Drawing.Size(83, 20);
            this.lblTongDiem.TabIndex = 6;
            this.lblTongDiem.Text = "Tổng điểm";
            // 
            // lblDiemUT
            // 
            this.lblDiemUT.AutoSize = true;
            this.lblDiemUT.Location = new System.Drawing.Point(40, 214);
            this.lblDiemUT.Name = "lblDiemUT";
            this.lblDiemUT.Size = new System.Drawing.Size(71, 20);
            this.lblDiemUT.TabIndex = 7;
            this.lblDiemUT.Text = "Điểm UT";
            // 
            // lblTuyChon
            // 
            this.lblTuyChon.AutoSize = true;
            this.lblTuyChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuyChon.Location = new System.Drawing.Point(135, 291);
            this.lblTuyChon.Name = "lblTuyChon";
            this.lblTuyChon.Size = new System.Drawing.Size(208, 30);
            this.lblTuyChon.TabIndex = 8;
            this.lblTuyChon.Text = "TÙY CHỌN LỌC";
            // 
            // cboChonVung
            // 
            this.cboChonVung.FormattingEnabled = true;
            this.cboChonVung.Location = new System.Drawing.Point(212, 362);
            this.cboChonVung.Name = "cboChonVung";
            this.cboChonVung.Size = new System.Drawing.Size(121, 28);
            this.cboChonVung.TabIndex = 9;
            // 
            // lblChonVung
            // 
            this.lblChonVung.AutoSize = true;
            this.lblChonVung.Location = new System.Drawing.Point(40, 370);
            this.lblChonVung.Name = "lblChonVung";
            this.lblChonVung.Size = new System.Drawing.Size(85, 20);
            this.lblChonVung.TabIndex = 13;
            this.lblChonVung.Text = "Chọn vùng";
            // 
            // lblKQ
            // 
            this.lblKQ.AutoSize = true;
            this.lblKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKQ.Location = new System.Drawing.Point(763, 25);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(402, 30);
            this.lblKQ.TabIndex = 14;
            this.lblKQ.Text = "KẾT QUẢ GỢI Ý NGUYỆN VỌNG";
            // 
            // dgvKetQua
            // 
            this.dgvKetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKetQua.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Truong,
            this.Manganh,
            this.TenNganh,
            this.DiemChuan,
            this.ChenhLech,
            this.khannang});
            this.dgvKetQua.Location = new System.Drawing.Point(635, 74);
            this.dgvKetQua.Name = "dgvKetQua";
            this.dgvKetQua.RowHeadersWidth = 62;
            this.dgvKetQua.RowTemplate.Height = 28;
            this.dgvKetQua.Size = new System.Drawing.Size(942, 523);
            this.dgvKetQua.TabIndex = 15;
            // 
            // Truong
            // 
            this.Truong.HeaderText = "Trường";
            this.Truong.MinimumWidth = 8;
            this.Truong.Name = "Truong";
            this.Truong.Width = 150;
            // 
            // Manganh
            // 
            this.Manganh.HeaderText = "Mã Ngành";
            this.Manganh.MinimumWidth = 8;
            this.Manganh.Name = "Manganh";
            this.Manganh.Width = 150;
            // 
            // TenNganh
            // 
            this.TenNganh.HeaderText = "Tên Ngành";
            this.TenNganh.MinimumWidth = 8;
            this.TenNganh.Name = "TenNganh";
            this.TenNganh.Width = 150;
            // 
            // DiemChuan
            // 
            this.DiemChuan.HeaderText = "Điểm Chuẩn";
            this.DiemChuan.MinimumWidth = 8;
            this.DiemChuan.Name = "DiemChuan";
            this.DiemChuan.Width = 150;
            // 
            // ChenhLech
            // 
            this.ChenhLech.HeaderText = "Chênh Lệch";
            this.ChenhLech.MinimumWidth = 8;
            this.ChenhLech.Name = "ChenhLech";
            this.ChenhLech.Width = 150;
            // 
            // khannang
            // 
            this.khannang.HeaderText = "Khả Năng";
            this.khannang.MinimumWidth = 8;
            this.khannang.Name = "khannang";
            this.khannang.Width = 150;
            // 
            // ResultsMajor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1589, 702);
            this.Controls.Add(this.dgvKetQua);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.lblChonVung);
            this.Controls.Add(this.cboChonVung);
            this.Controls.Add(this.lblTuyChon);
            this.Controls.Add(this.lblDiemUT);
            this.Controls.Add(this.lblTongDiem);
            this.Controls.Add(this.lblToHop);
            this.Controls.Add(this.txtTongDiem);
            this.Controls.Add(this.txtDiemUT);
            this.Controls.Add(this.btnXemGoiY);
            this.Controls.Add(this.cboToHop);
            this.Controls.Add(this.lblNhapDiem);
            this.Name = "ResultsMajor";
            this.Text = "ResultsMajor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNhapDiem;
        private System.Windows.Forms.ComboBox cboToHop;
        private System.Windows.Forms.Button btnXemGoiY;
        private System.Windows.Forms.TextBox txtDiemUT;
        private System.Windows.Forms.TextBox txtTongDiem;
        private System.Windows.Forms.Label lblToHop;
        private System.Windows.Forms.Label lblTongDiem;
        private System.Windows.Forms.Label lblDiemUT;
        internal System.Windows.Forms.Label lblTuyChon;
        private System.Windows.Forms.ComboBox cboChonVung;
        private System.Windows.Forms.Label lblChonVung;
        private System.Windows.Forms.Label lblKQ;
        private System.Windows.Forms.DataGridView dgvKetQua;
        private System.Windows.Forms.DataGridViewTextBoxColumn Truong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemChuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChenhLech;
        private System.Windows.Forms.DataGridViewTextBoxColumn khannang;
    }
}