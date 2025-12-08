namespace UniGate.Client.Forms
{
    partial class SuggestForm : System.Windows.Forms.Form
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
            lblNhapDiem = new Label();
            cboToHop = new ComboBox();
            btnXemGoiY = new Button();
            txtDiemUT = new TextBox();
            txtTongDiem = new TextBox();
            lblToHop = new Label();
            lblTongDiem = new Label();
            lblDiemUT = new Label();
            lblTuyChon = new Label();
            cboChonVung = new ComboBox();
            lblChonVung = new Label();
            lblKQ = new Label();
            dgvKetQua = new DataGridView();
            Truong = new DataGridViewTextBoxColumn();
            Manganh = new DataGridViewTextBoxColumn();
            TenNganh = new DataGridViewTextBoxColumn();
            DiemChuan = new DataGridViewTextBoxColumn();
            ChenhLech = new DataGridViewTextBoxColumn();
            khannang = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvKetQua).BeginInit();
            SuspendLayout();
            // 
            // lblNhapDiem
            // 
            lblNhapDiem.AutoSize = true;
            lblNhapDiem.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNhapDiem.Location = new Point(150, 31);
            lblNhapDiem.Name = "lblNhapDiem";
            lblNhapDiem.Size = new Size(307, 30);
            lblNhapDiem.TabIndex = 0;
            lblNhapDiem.Text = "NHẬP ĐIỂM XÉT TUYỂN";
            // 
            // cboToHop
            // 
            cboToHop.FormattingEnabled = true;
            cboToHop.Location = new Point(236, 121);
            cboToHop.Margin = new Padding(3, 4, 3, 4);
            cboToHop.Name = "cboToHop";
            cboToHop.Size = new Size(134, 33);
            cboToHop.TabIndex = 1;
            // 
            // btnXemGoiY
            // 
            btnXemGoiY.Location = new Point(447, 165);
            btnXemGoiY.Margin = new Padding(3, 4, 3, 4);
            btnXemGoiY.Name = "btnXemGoiY";
            btnXemGoiY.Size = new Size(140, 68);
            btnXemGoiY.TabIndex = 2;
            btnXemGoiY.Text = "Xem Gợi Ý";
            btnXemGoiY.UseVisualStyleBackColor = true;
            // 
            // txtDiemUT
            // 
            txtDiemUT.Location = new Point(236, 264);
            txtDiemUT.Margin = new Padding(3, 4, 3, 4);
            txtDiemUT.Name = "txtDiemUT";
            txtDiemUT.Size = new Size(134, 31);
            txtDiemUT.TabIndex = 3;
            // 
            // txtTongDiem
            // 
            txtTongDiem.Location = new Point(236, 182);
            txtTongDiem.Margin = new Padding(3, 4, 3, 4);
            txtTongDiem.Name = "txtTongDiem";
            txtTongDiem.Size = new Size(134, 31);
            txtTongDiem.TabIndex = 4;
            // 
            // lblToHop
            // 
            lblToHop.AutoSize = true;
            lblToHop.Location = new Point(44, 125);
            lblToHop.Name = "lblToHop";
            lblToHop.Size = new Size(117, 25);
            lblToHop.TabIndex = 5;
            lblToHop.Text = "Chọn tổ hợp:";
            // 
            // lblTongDiem
            // 
            lblTongDiem.AutoSize = true;
            lblTongDiem.Location = new Point(44, 190);
            lblTongDiem.Name = "lblTongDiem";
            lblTongDiem.Size = new Size(98, 25);
            lblTongDiem.TabIndex = 6;
            lblTongDiem.Text = "Tổng điểm";
            // 
            // lblDiemUT
            // 
            lblDiemUT.AutoSize = true;
            lblDiemUT.Location = new Point(44, 268);
            lblDiemUT.Name = "lblDiemUT";
            lblDiemUT.Size = new Size(80, 25);
            lblDiemUT.TabIndex = 7;
            lblDiemUT.Text = "Điểm UT";
            // 
            // lblTuyChon
            // 
            lblTuyChon.AutoSize = true;
            lblTuyChon.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTuyChon.Location = new Point(150, 364);
            lblTuyChon.Name = "lblTuyChon";
            lblTuyChon.Size = new Size(208, 30);
            lblTuyChon.TabIndex = 8;
            lblTuyChon.Text = "TÙY CHỌN LỌC";
            // 
            // cboChonVung
            // 
            cboChonVung.FormattingEnabled = true;
            cboChonVung.Location = new Point(236, 452);
            cboChonVung.Margin = new Padding(3, 4, 3, 4);
            cboChonVung.Name = "cboChonVung";
            cboChonVung.Size = new Size(134, 33);
            cboChonVung.TabIndex = 9;
            // 
            // lblChonVung
            // 
            lblChonVung.AutoSize = true;
            lblChonVung.Location = new Point(44, 462);
            lblChonVung.Name = "lblChonVung";
            lblChonVung.Size = new Size(99, 25);
            lblChonVung.TabIndex = 13;
            lblChonVung.Text = "Chọn vùng";
            // 
            // lblKQ
            // 
            lblKQ.AutoSize = true;
            lblKQ.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKQ.Location = new Point(848, 31);
            lblKQ.Name = "lblKQ";
            lblKQ.Size = new Size(402, 30);
            lblKQ.TabIndex = 14;
            lblKQ.Text = "KẾT QUẢ GỢI Ý NGUYỆN VỌNG";
            // 
            // dgvKetQua
            // 
            dgvKetQua.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKetQua.Columns.AddRange(new DataGridViewColumn[] { Truong, Manganh, TenNganh, DiemChuan, ChenhLech, khannang });
            dgvKetQua.Location = new Point(706, 92);
            dgvKetQua.Margin = new Padding(3, 4, 3, 4);
            dgvKetQua.Name = "dgvKetQua";
            dgvKetQua.RowHeadersWidth = 62;
            dgvKetQua.RowTemplate.Height = 28;
            dgvKetQua.Size = new Size(1047, 654);
            dgvKetQua.TabIndex = 15;
            // 
            // Truong
            // 
            Truong.HeaderText = "Trường";
            Truong.MinimumWidth = 8;
            Truong.Name = "Truong";
            Truong.Width = 150;
            // 
            // Manganh
            // 
            Manganh.HeaderText = "Mã Ngành";
            Manganh.MinimumWidth = 8;
            Manganh.Name = "Manganh";
            Manganh.Width = 150;
            // 
            // TenNganh
            // 
            TenNganh.HeaderText = "Tên Ngành";
            TenNganh.MinimumWidth = 8;
            TenNganh.Name = "TenNganh";
            TenNganh.Width = 150;
            // 
            // DiemChuan
            // 
            DiemChuan.HeaderText = "Điểm Chuẩn";
            DiemChuan.MinimumWidth = 8;
            DiemChuan.Name = "DiemChuan";
            DiemChuan.Width = 150;
            // 
            // ChenhLech
            // 
            ChenhLech.HeaderText = "Chênh Lệch";
            ChenhLech.MinimumWidth = 8;
            ChenhLech.Name = "ChenhLech";
            ChenhLech.Width = 150;
            // 
            // khannang
            // 
            khannang.HeaderText = "Khả Năng";
            khannang.MinimumWidth = 8;
            khannang.Name = "khannang";
            khannang.Width = 150;
            // 
            // SuggestForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1766, 878);
            Controls.Add(dgvKetQua);
            Controls.Add(lblKQ);
            Controls.Add(lblChonVung);
            Controls.Add(cboChonVung);
            Controls.Add(lblTuyChon);
            Controls.Add(lblDiemUT);
            Controls.Add(lblTongDiem);
            Controls.Add(lblToHop);
            Controls.Add(txtTongDiem);
            Controls.Add(txtDiemUT);
            Controls.Add(btnXemGoiY);
            Controls.Add(cboToHop);
            Controls.Add(lblNhapDiem);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SuggestForm";
            Text = "ResultsMajor";
            ((System.ComponentModel.ISupportInitialize)dgvKetQua).EndInit();
            ResumeLayout(false);
            PerformLayout();

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