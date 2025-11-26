namespace UniGate.Client.Admin
{
    partial class FormQuanLiNganh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuanLiNganh));
            label1 = new Label();
            lblKhoiDaChon = new Label();
            cbbTruong = new ComboBox();
            lvNganh = new ListView();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI Black", 13.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(567, 36);
            label1.Name = "label1";
            label1.Size = new Size(304, 52);
            label1.TabIndex = 4;
            label1.Text = "Quản Lý Ngành";
            // 
            // lblKhoiDaChon
            // 
            lblKhoiDaChon.AutoSize = true;
            lblKhoiDaChon.BackColor = Color.Transparent;
            lblKhoiDaChon.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblKhoiDaChon.Location = new Point(179, 114);
            lblKhoiDaChon.Name = "lblKhoiDaChon";
            lblKhoiDaChon.Size = new Size(146, 45);
            lblKhoiDaChon.TabIndex = 5;
            lblKhoiDaChon.Text = "Trường:";
            // 
            // cbbTruong
            // 
            cbbTruong.FormattingEnabled = true;
            cbbTruong.Location = new Point(340, 121);
            cbbTruong.Name = "cbbTruong";
            cbbTruong.Size = new Size(501, 40);
            cbbTruong.TabIndex = 6;
            // 
            // lvNganh
            // 
            lvNganh.Location = new Point(76, 186);
            lvNganh.Name = "lvNganh";
            lvNganh.Size = new Size(971, 335);
            lvNganh.TabIndex = 7;
            lvNganh.UseCompatibleStateImageBehavior = false;
            lvNganh.View = View.Details;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI Black", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(1074, 203);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 55);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI Black", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.Location = new Point(1074, 302);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(150, 55);
            btnEdit.TabIndex = 10;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click_1;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI Black", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(1074, 421);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 55);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // FormQuanLiNganh
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1256, 576);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(lvNganh);
            Controls.Add(cbbTruong);
            Controls.Add(lblKhoiDaChon);
            Controls.Add(label1);
            Name = "FormQuanLiNganh";
            Text = "FormQuanLiNganh";
            Load += FormQuanLiNganh_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblKhoiDaChon;
        private ComboBox cbbTruong;
        private ListView lvNganh;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
    }
}