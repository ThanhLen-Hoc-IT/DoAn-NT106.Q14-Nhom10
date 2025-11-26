namespace UniGate.Client.Forms.TraCuuNganhTruong
{
    partial class NganhPhuHop
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

        // NganhPhuHop.Designer.cs (Phần InitializeComponent)
        // M cần tạo các biến tương ứng trong phần khai báo private của Form.

        private void InitializeComponent()
        {
            this.lblUserScore = new System.Windows.Forms.Label();
            this.txtUserScore = new System.Windows.Forms.TextBox();
            this.lblGroupCode = new System.Windows.Forms.Label();
            this.txtGroupCode = new System.Windows.Forms.TextBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.lblResultCode = new System.Windows.Forms.Label();
            this.lblTestName = new System.Windows.Forms.Label();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.grpInput = new System.Windows.Forms.GroupBox();

            // Thiết lập tổng thể Form
            this.SuspendLayout();

            //
            // grpInput
            //
            this.grpInput.Controls.Add(this.btnFilter);
            this.grpInput.Controls.Add(this.txtGroupCode);
            this.grpInput.Controls.Add(this.lblGroupCode);
            this.grpInput.Controls.Add(this.txtUserScore);
            this.grpInput.Controls.Add(this.lblUserScore);
            this.grpInput.Controls.Add(this.lblResultCode);
            this.grpInput.Controls.Add(this.lblTestName);
            this.grpInput.Location = new System.Drawing.Point(12, 12);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(776, 110);
            this.grpInput.TabIndex = 0;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "THÔNG TIN ĐẦU VÀO & KẾT QUẢ TÍNH CÁCH";

            //
            // lblTestName
            //
            this.lblTestName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTestName.Location = new System.Drawing.Point(10, 25);
            this.lblTestName.Name = "lblTestName";
            this.lblTestName.Size = new System.Drawing.Size(200, 20);
            this.lblTestName.Text = "Mã Tính Cách: (Holland)";

            //
            // lblResultCode
            //
            this.lblResultCode.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResultCode.ForeColor = System.Drawing.Color.DarkRed;
            this.lblResultCode.Location = new System.Drawing.Point(10, 50);
            this.lblResultCode.Name = "lblResultCode";
            this.lblResultCode.Size = new System.Drawing.Size(150, 40);
            this.lblResultCode.Text = "ISA"; // Dữ liệu mẫu

            //
            // lblUserScore
            //
            this.lblUserScore.Location = new System.Drawing.Point(230, 30);
            this.lblUserScore.Name = "lblUserScore";
            this.lblUserScore.Size = new System.Drawing.Size(100, 23);
            this.lblUserScore.Text = "Điểm thi của bạn:";

            //
            // txtUserScore
            //
            this.txtUserScore.Location = new System.Drawing.Point(340, 27);
            this.txtUserScore.Name = "txtUserScore";
            this.txtUserScore.Size = new System.Drawing.Size(100, 23);
            this.txtUserScore.Text = "26.5"; // Điểm thi mẫu

            //
            // lblGroupCode
            //
            this.lblGroupCode.Location = new System.Drawing.Point(230, 65);
            this.lblGroupCode.Name = "lblGroupCode";
            this.lblGroupCode.Size = new System.Drawing.Size(100, 23);
            this.lblGroupCode.Text = "Tổ hợp xét tuyển:";

            //
            // txtGroupCode
            //
            this.txtGroupCode.Location = new System.Drawing.Point(340, 62);
            this.txtGroupCode.Name = "txtGroupCode";
            this.txtGroupCode.Size = new System.Drawing.Size(100, 23);
            this.txtGroupCode.Text = "A00"; // Tổ hợp mẫu

            //
            // btnFilter
            //
            this.btnFilter.Location = new System.Drawing.Point(470, 27);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(200, 60);
            this.btnFilter.TabIndex = 4;
            this.btnFilter.Text = "LỌC NGÀNH HỌC PHÙ HỢP";
            this.btnFilter.UseVisualStyleBackColor = true;

            //
            // dgvResults
            //
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.AllowUserToDeleteRows = false;
            this.dgvResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            // Bổ sung các cột trong code logic
            this.dgvResults.Location = new System.Drawing.Point(12, 130);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.ReadOnly = true;
            this.dgvResults.RowTemplate.Height = 25;
            this.dgvResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResults.Size = new System.Drawing.Size(776, 308);
            this.dgvResults.TabIndex = 1;

            //
            // NganhPhuHop (Form Chính)
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvResults);
            this.Controls.Add(this.grpInput);
            this.Text = "TRA CỨU NGÀNH HỌC PHÙ HỢP ĐIỂM THI";
            this.ResumeLayout(false);
        }

        // Khai báo các Controls
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.Label lblUserScore;
        private System.Windows.Forms.TextBox txtUserScore;
        private System.Windows.Forms.Label lblGroupCode;
        private System.Windows.Forms.TextBox txtGroupCode;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label lblResultCode;
        private System.Windows.Forms.Label lblTestName;
        private System.Windows.Forms.DataGridView dgvResults;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>

        #endregion
    }
}