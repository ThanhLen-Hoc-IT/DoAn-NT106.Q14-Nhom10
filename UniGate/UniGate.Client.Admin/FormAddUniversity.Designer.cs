namespace UniGate.Client.Admin
{
    partial class FormAddUniversity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddUniversity));
            lblKhoiDaChon = new Label();
            label1 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            txtCode = new TextBox();
            cboProvince = new ComboBox();
            label3 = new Label();
            txtDescription = new RichTextBox();
            label4 = new Label();
            txtLogo = new TextBox();
            picLogo = new PictureBox();
            btnLogo = new Button();
            btnImportExcel = new Button();
            txtImportFile = new TextBox();
            btnLuu = new Button();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // lblKhoiDaChon
            // 
            lblKhoiDaChon.AutoSize = true;
            lblKhoiDaChon.BackColor = Color.Transparent;
            lblKhoiDaChon.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblKhoiDaChon.Location = new Point(197, 88);
            lblKhoiDaChon.Name = "lblKhoiDaChon";
            lblKhoiDaChon.Size = new Size(205, 45);
            lblKhoiDaChon.TabIndex = 5;
            lblKhoiDaChon.Text = "Tên trường:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(275, 283);
            label1.Name = "label1";
            label1.Size = new Size(123, 45);
            label1.TabIndex = 6;
            label1.Text = "Mô tả:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(197, 150);
            label2.Name = "label2";
            label2.Size = new Size(201, 45);
            label2.TabIndex = 7;
            label2.Text = "Mã trường:";
            // 
            // txtName
            // 
            txtName.Location = new Point(408, 88);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(418, 45);
            txtName.TabIndex = 8;
            // 
            // txtCode
            // 
            txtCode.Location = new Point(408, 150);
            txtCode.Multiline = true;
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(418, 45);
            txtCode.TabIndex = 9;
            // 
            // cboProvince
            // 
            cboProvince.FormattingEnabled = true;
            cboProvince.Location = new Point(408, 211);
            cboProvince.Name = "cboProvince";
            cboProvince.Size = new Size(418, 40);
            cboProvince.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(298, 211);
            label3.Name = "label3";
            label3.Size = new Size(100, 45);
            label3.TabIndex = 11;
            label3.Text = "Tỉnh:";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(404, 290);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(588, 196);
            txtDescription.TabIndex = 12;
            txtDescription.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(275, 537);
            label4.Name = "label4";
            label4.Size = new Size(105, 45);
            label4.TabIndex = 13;
            label4.Text = "Logo:";
            // 
            // txtLogo
            // 
            txtLogo.Location = new Point(404, 537);
            txtLogo.Multiline = true;
            txtLogo.Name = "txtLogo";
            txtLogo.Size = new Size(518, 45);
            txtLogo.TabIndex = 14;
            // 
            // picLogo
            // 
            picLogo.Location = new Point(404, 588);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(388, 243);
            picLogo.TabIndex = 15;
            picLogo.TabStop = false;
            // 
            // btnLogo
            // 
            btnLogo.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogo.Location = new Point(954, 533);
            btnLogo.Name = "btnLogo";
            btnLogo.Size = new Size(150, 46);
            btnLogo.TabIndex = 16;
            btnLogo.Text = "Chọn";
            btnLogo.UseVisualStyleBackColor = true;
            btnLogo.Click += btnLogo_Click;
            // 
            // btnImportExcel
            // 
            btnImportExcel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnImportExcel.Location = new Point(954, 870);
            btnImportExcel.Name = "btnImportExcel";
            btnImportExcel.Size = new Size(150, 46);
            btnImportExcel.TabIndex = 17;
            btnImportExcel.Text = "Import File";
            btnImportExcel.UseVisualStyleBackColor = true;
            btnImportExcel.Click += btnImportExcel_Click;
            // 
            // txtImportFile
            // 
            txtImportFile.Location = new Point(408, 871);
            txtImportFile.Multiline = true;
            txtImportFile.Name = "txtImportFile";
            txtImportFile.Size = new Size(418, 45);
            txtImportFile.TabIndex = 18;
            // 
            // btnLuu
            // 
            btnLuu.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLuu.Location = new Point(576, 951);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(183, 72);
            btnLuu.TabIndex = 19;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // FormAddUniversity
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1346, 1049);
            Controls.Add(btnLuu);
            Controls.Add(txtImportFile);
            Controls.Add(btnImportExcel);
            Controls.Add(btnLogo);
            Controls.Add(picLogo);
            Controls.Add(txtLogo);
            Controls.Add(label4);
            Controls.Add(txtDescription);
            Controls.Add(label3);
            Controls.Add(cboProvince);
            Controls.Add(txtCode);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblKhoiDaChon);
            Name = "FormAddUniversity";
            Text = "FormAddUniversity";
            Load += FormAddUniversity_Load;
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKhoiDaChon;
        private Label label1;
        private Label label2;
        private TextBox txtName;
        private TextBox txtCode;
        private ComboBox cboProvince;
        private Label label3;
        private RichTextBox txtDescription;
        private Label label4;
        private TextBox txtLogo;
        private PictureBox picLogo;
        private Button btnLogo;
        private Button btnImportExcel;
        private TextBox txtImportFile;
        private Button btnLuu;
    }
}