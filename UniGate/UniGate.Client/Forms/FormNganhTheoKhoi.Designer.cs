namespace UniGate.Client
{
    partial class FormNganhTheoKhoi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNganhTheoKhoi));
            label1 = new Label();
            lblKhoiDaChon = new Label();
            dgvNganh = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvNganh).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI Black", 13.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(262, 52);
            label1.Name = "label1";
            label1.Size = new Size(593, 52);
            label1.TabIndex = 2;
            label1.Text = "Danh Sách Ngành Theo Tổ Hợp";
            // 
            // lblKhoiDaChon
            // 
            lblKhoiDaChon.AutoSize = true;
            lblKhoiDaChon.BackColor = Color.Transparent;
            lblKhoiDaChon.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblKhoiDaChon.Location = new Point(169, 129);
            lblKhoiDaChon.Name = "lblKhoiDaChon";
            lblKhoiDaChon.Size = new Size(340, 45);
            lblKhoiDaChon.TabIndex = 3;
            lblKhoiDaChon.Text = "Tổ hợp bạn đã chọn:";
            // 
            // dgvNganh
            // 
            dgvNganh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNganh.Location = new Point(51, 203);
            dgvNganh.Name = "dgvNganh";
            dgvNganh.RowHeadersWidth = 82;
            dgvNganh.Size = new Size(940, 300);
            dgvNganh.TabIndex = 4;
            // 
            // FormNganhTheoKhoi
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1020, 576);
            Controls.Add(dgvNganh);
            Controls.Add(lblKhoiDaChon);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "FormNganhTheoKhoi";
            Text = "FormNganhTheoKhoi";
            ((System.ComponentModel.ISupportInitialize)dgvNganh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblKhoiDaChon;
        private DataGridView dgvNganh;
    }
}