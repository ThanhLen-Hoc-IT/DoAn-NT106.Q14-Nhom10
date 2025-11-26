namespace UniGate.Client.Admin
{
    partial class FormThemNganh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThemNganh));
            lblKhoiDaChon = new Label();
            label1 = new Label();
            txt_MaNganh = new TextBox();
            txt_TenNganh = new TextBox();
            label2 = new Label();
            chcklbToHop = new CheckedListBox();
            label3 = new Label();
            txtDiemChuan = new TextBox();
            btnSave = new Button();
            btnImport = new Button();
            txtImport = new TextBox();
            SuspendLayout();
            // 
            // lblKhoiDaChon
            // 
            lblKhoiDaChon.AutoSize = true;
            lblKhoiDaChon.BackColor = Color.Transparent;
            lblKhoiDaChon.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblKhoiDaChon.Location = new Point(187, 71);
            lblKhoiDaChon.Name = "lblKhoiDaChon";
            lblKhoiDaChon.Size = new Size(197, 45);
            lblKhoiDaChon.TabIndex = 6;
            lblKhoiDaChon.Text = "Mã Ngành:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(187, 150);
            label1.Name = "label1";
            label1.Size = new Size(201, 45);
            label1.TabIndex = 7;
            label1.Text = "Tên Ngành:";
            // 
            // txt_MaNganh
            // 
            txt_MaNganh.Location = new Point(407, 71);
            txt_MaNganh.Multiline = true;
            txt_MaNganh.Name = "txt_MaNganh";
            txt_MaNganh.Size = new Size(200, 45);
            txt_MaNganh.TabIndex = 8;
            // 
            // txt_TenNganh
            // 
            txt_TenNganh.Location = new Point(407, 150);
            txt_TenNganh.Multiline = true;
            txt_TenNganh.Name = "txt_TenNganh";
            txt_TenNganh.Size = new Size(397, 45);
            txt_TenNganh.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(239, 237);
            label2.Name = "label2";
            label2.Size = new Size(145, 45);
            label2.TabIndex = 10;
            label2.Text = "Tổ Hợp:";
            // 
            // chcklbToHop
            // 
            chcklbToHop.FormattingEnabled = true;
            chcklbToHop.Location = new Point(407, 237);
            chcklbToHop.Name = "chcklbToHop";
            chcklbToHop.ScrollAlwaysVisible = true;
            chcklbToHop.Size = new Size(397, 256);
            chcklbToHop.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(163, 539);
            label3.Name = "label3";
            label3.Size = new Size(221, 45);
            label3.TabIndex = 12;
            label3.Text = "Điểm Chuẩn:";
            // 
            // txtDiemChuan
            // 
            txtDiemChuan.Location = new Point(407, 539);
            txtDiemChuan.Multiline = true;
            txtDiemChuan.Name = "txtDiemChuan";
            txtDiemChuan.Size = new Size(200, 45);
            txtDiemChuan.TabIndex = 13;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI Black", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(428, 736);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 55);
            btnSave.TabIndex = 14;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click_1;
            // 
            // btnImport
            // 
            btnImport.Font = new Font("Segoe UI Black", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnImport.Location = new Point(787, 639);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(211, 55);
            btnImport.TabIndex = 15;
            btnImport.Text = "Import File";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click_1;
            // 
            // txtImport
            // 
            txtImport.Location = new Point(346, 649);
            txtImport.Multiline = true;
            txtImport.Name = "txtImport";
            txtImport.Size = new Size(397, 45);
            txtImport.TabIndex = 16;
            // 
            // FormThemNganh
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1020, 819);
            Controls.Add(txtImport);
            Controls.Add(btnImport);
            Controls.Add(btnSave);
            Controls.Add(txtDiemChuan);
            Controls.Add(label3);
            Controls.Add(chcklbToHop);
            Controls.Add(label2);
            Controls.Add(txt_TenNganh);
            Controls.Add(txt_MaNganh);
            Controls.Add(label1);
            Controls.Add(lblKhoiDaChon);
            Name = "FormThemNganh";
            Text = "v";
            Load += FormThemNganh_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKhoiDaChon;
        private Label label1;
        private TextBox txt_MaNganh;
        private TextBox txt_TenNganh;
        private Label label2;
        private CheckedListBox chcklbToHop;
        private Label label3;
        private TextBox txtDiemChuan;
        private Button btnSave;
        private Button btnImport;
        private TextBox txtImport;
    }
}