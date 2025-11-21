namespace UniGate.Client.Forms.TraCuuNganhTruong
{
    partial class NganhTheoSoThich
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

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "NganhTheoSoThich";
            this.grpResultSummary = new System.Windows.Forms.GroupBox();
            this.txtResultDesc = new System.Windows.Forms.TextBox();
            this.lblResultCode = new System.Windows.Forms.Label();
            this.lblTestName = new System.Windows.Forms.Label();
            this.grpMajorSuggestions = new System.Windows.Forms.GroupBox();
            this.dgvSuggestions = new System.Windows.Forms.DataGridView();
            this.MajorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpMajorDetail = new System.Windows.Forms.GroupBox();
            this.btnCheckAdmission = new System.Windows.Forms.Button();
            this.lblGroupCode = new System.Windows.Forms.Label();
            this.txtMajorDetail = new System.Windows.Forms.TextBox();
            this.lblMajorName = new System.Windows.Forms.Label();

            // Tạm dừng bố cục để thiết lập (Suspend Layout)
            this.grpResultSummary.SuspendLayout();
            this.grpMajorSuggestions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuggestions)).BeginInit();
            this.grpMajorDetail.SuspendLayout();
            this.SuspendLayout();

            // 
            // grpResultSummary (Vùng 1: Kết quả Trắc nghiệm)
            // 
            this.grpResultSummary.Controls.Add(this.txtResultDesc);
            this.grpResultSummary.Controls.Add(this.lblResultCode);
            this.grpResultSummary.Controls.Add(this.lblTestName);
            this.grpResultSummary.Location = new System.Drawing.Point(12, 12);
            this.grpResultSummary.Name = "grpResultSummary";
            this.grpResultSummary.Size = new System.Drawing.Size(240, 426);
            this.grpResultSummary.TabIndex = 0;
            this.grpResultSummary.TabStop = false;
            this.grpResultSummary.Text = "KẾT QUẢ CỦA BẠN";

            // 
            // lblTestName
            // 
            this.lblTestName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTestName.Location = new System.Drawing.Point(10, 25);
            this.lblTestName.Name = "lblTestName";
            this.lblTestName.Size = new System.Drawing.Size(220, 25);
            this.lblTestName.Text = "Mô hình Holland Code (RIASEC)";

            // 
            // lblResultCode
            // 
            this.lblResultCode.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResultCode.ForeColor = System.Drawing.Color.DarkRed;
            this.lblResultCode.Location = new System.Drawing.Point(10, 50);
            this.lblResultCode.Name = "lblResultCode";
            this.lblResultCode.Size = new System.Drawing.Size(220, 80);
            this.lblResultCode.Text = "ISA"; // Dữ liệu mẫu
            this.lblResultCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // txtResultDesc
            // 
            this.txtResultDesc.Location = new System.Drawing.Point(10, 140);
            this.txtResultDesc.Multiline = true;
            this.txtResultDesc.Name = "txtResultDesc";
            this.txtResultDesc.ReadOnly = true;
            this.txtResultDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultDesc.Size = new System.Drawing.Size(220, 270);
            this.txtResultDesc.TabIndex = 2;
            this.txtResultDesc.Text = "Mô tả chi tiết về tính cách/sở thích của mã ISA: Nghiên cứu, Xã hội, Nghệ thuật. Thích làm việc với ý tưởng, giúp đỡ người khác, có óc sáng tạo."; // Dữ liệu mẫu

            // 
            // grpMajorSuggestions (Vùng 2a: Danh sách Gợi ý - Top Right)
            // 
            this.grpMajorSuggestions.Controls.Add(this.dgvSuggestions);
            this.grpMajorSuggestions.Location = new System.Drawing.Point(265, 12);
            this.grpMajorSuggestions.Name = "grpMajorSuggestions";
            this.grpMajorSuggestions.Size = new System.Drawing.Size(523, 200);
            this.grpMajorSuggestions.TabIndex = 1;
            this.grpMajorSuggestions.TabStop = false;
            this.grpMajorSuggestions.Text = "DANH SÁCH NGÀNH PHÙ HỢP";

            // 
            // dgvSuggestions
            // 
            this.dgvSuggestions.AllowUserToAddRows = false;
            this.dgvSuggestions.AllowUserToDeleteRows = false;
            this.dgvSuggestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuggestions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
        this.MajorName,
        this.Note});
            this.dgvSuggestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSuggestions.Location = new System.Drawing.Point(3, 19);
            this.dgvSuggestions.MultiSelect = false;
            this.dgvSuggestions.Name = "dgvSuggestions";
            this.dgvSuggestions.ReadOnly = true;
            this.dgvSuggestions.RowTemplate.Height = 25;
            this.dgvSuggestions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSuggestions.Size = new System.Drawing.Size(517, 178);
            this.dgvSuggestions.TabIndex = 0;
            // Thêm sự kiện CellClick hoặc SelectionChanged để hiển thị chi tiết (sẽ code sau)

            // 
            // MajorName (Cột Ngành Học)
            // 
            this.MajorName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MajorName.DataPropertyName = "MajorName";
            this.MajorName.HeaderText = "Ngành Học Gợi Ý";
            this.MajorName.Name = "MajorName";
            this.MajorName.ReadOnly = true;

            // 
            // Note (Cột Mức độ Phù hợp)
            // 
            this.Note.DataPropertyName = "Note";
            this.Note.HeaderText = "Mức Độ Phù Hợp (Lý do)";
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
            this.Note.Width = 180;

            // 
            // grpMajorDetail (Vùng 2b: Chi tiết Ngành - Bottom Right)
            // 
            this.grpMajorDetail.Controls.Add(this.btnCheckAdmission);
            this.grpMajorDetail.Controls.Add(this.lblGroupCode);
            this.grpMajorDetail.Controls.Add(this.txtMajorDetail);
            this.grpMajorDetail.Controls.Add(this.lblMajorName);
            this.grpMajorDetail.Location = new System.Drawing.Point(265, 220);
            this.grpMajorDetail.Name = "grpMajorDetail";
            this.grpMajorDetail.Size = new System.Drawing.Size(523, 218);
            this.grpMajorDetail.TabIndex = 2;
            this.grpMajorDetail.TabStop = false;
            this.grpMajorDetail.Text = "THÔNG TIN CHI TIẾT NGÀNH";

            // 
            // lblMajorName
            // 
            this.lblMajorName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMajorName.Location = new System.Drawing.Point(10, 25);
            this.lblMajorName.Name = "lblMajorName";
            this.lblMajorName.Size = new System.Drawing.Size(350, 25);
            this.lblMajorName.Text = "Ngành: [Vui lòng chọn ngành học bên trên]";

            // 
            // lblGroupCode
            // 
            this.lblGroupCode.Location = new System.Drawing.Point(10, 55);
            this.lblGroupCode.Name = "lblGroupCode";
            this.lblGroupCode.Size = new System.Drawing.Size(250, 20);
            this.lblGroupCode.Text = "Tổ hợp xét tuyển chính: [Chưa có]";

            // 
            // txtMajorDetail
            // 
            this.txtMajorDetail.Location = new System.Drawing.Point(10, 80);
            this.txtMajorDetail.Multiline = true;
            this.txtMajorDetail.Name = "txtMajorDetail";
            this.txtMajorDetail.ReadOnly = true;
            this.txtMajorDetail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMajorDetail.Size = new System.Drawing.Size(500, 90);
            this.txtMajorDetail.TabIndex = 1;
            this.txtMajorDetail.Text = "Mô tả chi tiết về ngành học được chọn sẽ hiển thị tại đây.";

            // 
            // btnCheckAdmission
            // 
            this.btnCheckAdmission.Location = new System.Drawing.Point(300, 180);
            this.btnCheckAdmission.Name = "btnCheckAdmission";
            this.btnCheckAdmission.Size = new System.Drawing.Size(210, 30);
            this.btnCheckAdmission.TabIndex = 3;
            this.btnCheckAdmission.Text = "Xem Điểm Chuẩn & Trường Tuyển Sinh >>";
            this.btnCheckAdmission.UseVisualStyleBackColor = true;

            // 
            // NganhTheoSoThich (Cài đặt Form chính)
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpMajorDetail);
            this.Controls.Add(this.grpMajorSuggestions);
            this.Controls.Add(this.grpResultSummary);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Text = "Tư Vấn Ngành Học Theo Sở Thích (Holland Code)";

            // Tạm dừng bố cục để thiết lập (Resume Layout)
            this.grpResultSummary.ResumeLayout(false);
            this.grpResultSummary.PerformLayout();
            this.grpMajorSuggestions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuggestions)).EndInit();
            this.grpMajorDetail.ResumeLayout(false);
            this.grpMajorDetail.PerformLayout();
            this.ResumeLayout(false);
        }

        // =========================================================
        // Khai báo biến (Mục #region Windows Form Designer generated code)
        // =========================================================
        private System.Windows.Forms.GroupBox grpResultSummary;
        private System.Windows.Forms.Label lblTestName;
        private System.Windows.Forms.Label lblResultCode;
        private System.Windows.Forms.TextBox txtResultDesc;
        private System.Windows.Forms.GroupBox grpMajorSuggestions;
        private System.Windows.Forms.DataGridView dgvSuggestions;
        private System.Windows.Forms.GroupBox grpMajorDetail;
        private System.Windows.Forms.Label lblMajorName;
        private System.Windows.Forms.TextBox txtMajorDetail;
        private System.Windows.Forms.Label lblGroupCode;
        private System.Windows.Forms.Button btnCheckAdmission;
        private System.Windows.Forms.DataGridViewTextBoxColumn MajorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        // =========================================================

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>

        #endregion
    }
}