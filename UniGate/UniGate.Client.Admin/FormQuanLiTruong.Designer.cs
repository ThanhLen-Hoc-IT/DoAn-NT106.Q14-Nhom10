namespace UniGate.Client.Admin
{
    partial class FormQuanLiTruong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuanLiTruong));
            label1 = new Label();
            lblKhoiDaChon = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            lvSchools = new ListView();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI Black", 13.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(388, 38);
            label1.Name = "label1";
            label1.Size = new Size(316, 52);
            label1.TabIndex = 3;
            label1.Text = "Quản Lý Trường";
            // 
            // lblKhoiDaChon
            // 
            lblKhoiDaChon.AutoSize = true;
            lblKhoiDaChon.BackColor = Color.Transparent;
            lblKhoiDaChon.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblKhoiDaChon.Location = new Point(86, 133);
            lblKhoiDaChon.Name = "lblKhoiDaChon";
            lblKhoiDaChon.Size = new Size(178, 45);
            lblKhoiDaChon.TabIndex = 4;
            lblKhoiDaChon.Text = "Tìm Kiếm:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(270, 133);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(505, 56);
            txtSearch.TabIndex = 5;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI Black", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(826, 133);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(150, 55);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Tìm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI Black", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.Location = new Point(1106, 306);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(150, 55);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI Black", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(1106, 426);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 55);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lvSchools
            // 
            lvSchools.Location = new Point(86, 218);
            lvSchools.Name = "lvSchools";
            lvSchools.Size = new Size(983, 291);
            lvSchools.TabIndex = 11;
            lvSchools.UseCompatibleStateImageBehavior = false;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(1106, 218);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 46);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnThem_Click;
            // 
            // FormQuanLiTruong
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1278, 576);
            Controls.Add(btnAdd);
            Controls.Add(lvSchools);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(lblKhoiDaChon);
            Controls.Add(label1);
            Name = "FormQuanLiTruong";
            Text = "FormUniversityList";
            Load += FormQuanLiTruong_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblKhoiDaChon;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnEdit;
        private Button btnDelete;
        private ListView lvSchools;
        private Button btnAdd;
    }
}