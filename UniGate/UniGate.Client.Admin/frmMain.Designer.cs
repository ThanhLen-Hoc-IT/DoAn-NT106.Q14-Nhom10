namespace UniGate.Client.Admin
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            components = new System.ComponentModel.Container();
            panel2 = new Panel();
            lblMajorByInterest = new Label();
            lblMajorRecommend = new Label();
            lblMajorByBlock = new Label();
            lblMajorByScore = new Label();
            h2TraCuuNganhTruong = new Label();
            lblScoreManagement = new Label();
            lblScoreConversion = new Label();
            lblScorePercentile = new Label();
            lblInputScore = new Label();
            h2DanhGiaDiemThi = new Label();
            lblQuiz = new Label();
            lblQuizResults = new Label();
            h2KhamPhaBanThan = new Label();
            btnLogout = new Button();
            lblLogout = new Label();
            panelMenu = new Panel();
            btnMajorMenu = new Button();
            btnUniversityMenu = new Button();
            btnScoreMenu = new Button();
            btnQuizMenu = new Button();
            quizContextMenu = new ContextMenuStrip(components);
            ehheToolStripMenuItem = new ToolStripMenuItem();
            hihiToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            lblLenKhung = new Label();
            scoreContextMenu = new ContextMenuStrip(components);
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            majorContextMenu = new ContextMenuStrip(components);
            toolStripMenuItem8 = new ToolStripMenuItem();
            toolStripMenuItem9 = new ToolStripMenuItem();
            toolStripMenuItem10 = new ToolStripMenuItem();
            universityContextMenu = new ContextMenuStrip(components);
            toolStripMenuItem5 = new ToolStripMenuItem();
            toolStripMenuItem6 = new ToolStripMenuItem();
            toolStripMenuItem7 = new ToolStripMenuItem();
            toolStripMenuItem14 = new ToolStripMenuItem();
            toolStripMenuItem15 = new ToolStripMenuItem();
            toolStripMenuItem16 = new ToolStripMenuItem();
            panel2.SuspendLayout();
            panelMenu.SuspendLayout();
            quizContextMenu.SuspendLayout();
            scoreContextMenu.SuspendLayout();
            majorContextMenu.SuspendLayout();
            universityContextMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(lblMajorByInterest);
            panel2.Controls.Add(lblMajorRecommend);
            panel2.Controls.Add(lblMajorByBlock);
            panel2.Controls.Add(lblMajorByScore);
            panel2.Controls.Add(h2TraCuuNganhTruong);
            panel2.Controls.Add(lblScoreManagement);
            panel2.Controls.Add(lblScoreConversion);
            panel2.Controls.Add(lblScorePercentile);
            panel2.Controls.Add(lblInputScore);
            panel2.Controls.Add(h2DanhGiaDiemThi);
            panel2.Controls.Add(lblQuiz);
            panel2.Controls.Add(lblQuizResults);
            panel2.Controls.Add(h2KhamPhaBanThan);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 76);
            panel2.Name = "panel2";
            panel2.Size = new Size(229, 702);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // lblMajorByInterest
            // 
            lblMajorByInterest.BackColor = SystemColors.ControlLightLight;
            lblMajorByInterest.Font = new Font("Microsoft Sans Serif", 9.75F);
            lblMajorByInterest.Location = new Point(-1, 428);
            lblMajorByInterest.Name = "lblMajorByInterest";
            lblMajorByInterest.Size = new Size(226, 46);
            lblMajorByInterest.TabIndex = 23;
            lblMajorByInterest.Text = "Ngành Theo Sở Thích";
            lblMajorByInterest.TextAlign = ContentAlignment.MiddleLeft;
            lblMajorByInterest.Click += lblMajorByInterest_Click;
            lblMajorByInterest.MouseEnter += Label_MouseEnter;
            lblMajorByInterest.MouseLeave += Label_MouseLeave;
            // 
            // lblMajorRecommend
            // 
            lblMajorRecommend.BackColor = SystemColors.ControlLightLight;
            lblMajorRecommend.Font = new Font("Microsoft Sans Serif", 9.75F);
            lblMajorRecommend.Location = new Point(-3, 570);
            lblMajorRecommend.Name = "lblMajorRecommend";
            lblMajorRecommend.Size = new Size(226, 46);
            lblMajorRecommend.TabIndex = 22;
            lblMajorRecommend.Text = "Ngành Phù hợp";
            lblMajorRecommend.TextAlign = ContentAlignment.MiddleLeft;
            lblMajorRecommend.Click += lblMajorRecommend_Click;
            lblMajorRecommend.MouseEnter += Label_MouseEnter;
            lblMajorRecommend.MouseLeave += Label_MouseLeave;
            // 
            // lblMajorByBlock
            // 
            lblMajorByBlock.BackColor = SystemColors.ControlLightLight;
            lblMajorByBlock.Font = new Font("Microsoft Sans Serif", 9.75F);
            lblMajorByBlock.Location = new Point(-3, 520);
            lblMajorByBlock.Name = "lblMajorByBlock";
            lblMajorByBlock.Size = new Size(226, 46);
            lblMajorByBlock.TabIndex = 20;
            lblMajorByBlock.Text = "Ngành Theo Khối";
            lblMajorByBlock.TextAlign = ContentAlignment.MiddleLeft;
            lblMajorByBlock.Click += lblMajorByBlock_Click;
            lblMajorByBlock.MouseEnter += Label_MouseEnter;
            lblMajorByBlock.MouseLeave += Label_MouseLeave;
            // 
            // lblMajorByScore
            // 
            lblMajorByScore.BackColor = SystemColors.ControlLightLight;
            lblMajorByScore.Font = new Font("Microsoft Sans Serif", 9.75F);
            lblMajorByScore.Location = new Point(-3, 474);
            lblMajorByScore.Name = "lblMajorByScore";
            lblMajorByScore.Size = new Size(226, 46);
            lblMajorByScore.TabIndex = 21;
            lblMajorByScore.Text = "Ngành Theo Điểm";
            lblMajorByScore.TextAlign = ContentAlignment.MiddleLeft;
            lblMajorByScore.Click += lblMajorByScore_Click;
            lblMajorByScore.MouseEnter += Label_MouseEnter;
            lblMajorByScore.MouseLeave += Label_MouseLeave;
            // 
            // h2TraCuuNganhTruong
            // 
            h2TraCuuNganhTruong.BackColor = SystemColors.ControlLightLight;
            h2TraCuuNganhTruong.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            h2TraCuuNganhTruong.Location = new Point(-1, 380);
            h2TraCuuNganhTruong.Name = "h2TraCuuNganhTruong";
            h2TraCuuNganhTruong.Size = new Size(226, 46);
            h2TraCuuNganhTruong.TabIndex = 19;
            h2TraCuuNganhTruong.Text = "Tra cứu Ngành & Trường";
            h2TraCuuNganhTruong.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblScoreManagement
            // 
            lblScoreManagement.BackColor = SystemColors.ControlLightLight;
            lblScoreManagement.Font = new Font("Microsoft Sans Serif", 9.75F);
            lblScoreManagement.Location = new Point(1, 242);
            lblScoreManagement.Name = "lblScoreManagement";
            lblScoreManagement.Size = new Size(226, 46);
            lblScoreManagement.TabIndex = 18;
            lblScoreManagement.Text = "Quản lý Điểm thi";
            lblScoreManagement.TextAlign = ContentAlignment.MiddleLeft;
            lblScoreManagement.Click += lblScoreManagement_Click;
            lblScoreManagement.MouseEnter += Label_MouseEnter;
            lblScoreManagement.MouseLeave += Label_MouseLeave;
            // 
            // lblScoreConversion
            // 
            lblScoreConversion.BackColor = SystemColors.ControlLightLight;
            lblScoreConversion.Font = new Font("Microsoft Sans Serif", 9.75F);
            lblScoreConversion.Location = new Point(-1, 334);
            lblScoreConversion.Name = "lblScoreConversion";
            lblScoreConversion.Size = new Size(226, 46);
            lblScoreConversion.TabIndex = 8;
            lblScoreConversion.Text = "quy doi diem";
            lblScoreConversion.TextAlign = ContentAlignment.MiddleLeft;
            lblScoreConversion.Click += lblScoreConversion_Click;
            lblScoreConversion.MouseEnter += Label_MouseEnter;
            lblScoreConversion.MouseLeave += Label_MouseLeave;
            // 
            // lblScorePercentile
            // 
            lblScorePercentile.BackColor = SystemColors.ControlLightLight;
            lblScorePercentile.Font = new Font("Microsoft Sans Serif", 9.75F);
            lblScorePercentile.Location = new Point(1, 288);
            lblScorePercentile.Name = "lblScorePercentile";
            lblScorePercentile.Size = new Size(226, 46);
            lblScorePercentile.TabIndex = 7;
            lblScorePercentile.Text = "xem phanvi/trung vi";
            lblScorePercentile.TextAlign = ContentAlignment.MiddleLeft;
            lblScorePercentile.Click += lblScorePercentile_Click;
            lblScorePercentile.MouseEnter += Label_MouseEnter;
            lblScorePercentile.MouseLeave += Label_MouseLeave;
            // 
            // lblInputScore
            // 
            lblInputScore.BackColor = SystemColors.ControlLightLight;
            lblInputScore.Font = new Font("Microsoft Sans Serif", 9.75F);
            lblInputScore.Location = new Point(1, 192);
            lblInputScore.Name = "lblInputScore";
            lblInputScore.Size = new Size(226, 46);
            lblInputScore.TabIndex = 6;
            lblInputScore.Text = "nhap diem";
            lblInputScore.TextAlign = ContentAlignment.MiddleLeft;
            lblInputScore.Click += lblInputScore_Click;
            lblInputScore.MouseEnter += Label_MouseEnter;
            lblInputScore.MouseLeave += Label_MouseLeave;
            // 
            // h2DanhGiaDiemThi
            // 
            h2DanhGiaDiemThi.BackColor = SystemColors.ControlLightLight;
            h2DanhGiaDiemThi.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            h2DanhGiaDiemThi.Location = new Point(1, 144);
            h2DanhGiaDiemThi.Name = "h2DanhGiaDiemThi";
            h2DanhGiaDiemThi.Size = new Size(226, 46);
            h2DanhGiaDiemThi.TabIndex = 5;
            h2DanhGiaDiemThi.Text = "Đánh giá Điểm thi";
            h2DanhGiaDiemThi.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblQuiz
            // 
            lblQuiz.BackColor = SystemColors.ControlLightLight;
            lblQuiz.Font = new Font("Microsoft Sans Serif", 9.75F);
            lblQuiz.Location = new Point(1, 48);
            lblQuiz.Name = "lblQuiz";
            lblQuiz.Size = new Size(226, 46);
            lblQuiz.TabIndex = 4;
            lblQuiz.Text = "trac nghiem tinh cach";
            lblQuiz.TextAlign = ContentAlignment.MiddleLeft;
            lblQuiz.Click += lblQuiz_Click;
            lblQuiz.MouseEnter += Label_MouseEnter;
            lblQuiz.MouseLeave += Label_MouseLeave;
            // 
            // lblQuizResults
            // 
            lblQuizResults.BackColor = SystemColors.ControlLightLight;
            lblQuizResults.Font = new Font("Microsoft Sans Serif", 9.75F);
            lblQuizResults.Location = new Point(1, 96);
            lblQuizResults.Name = "lblQuizResults";
            lblQuizResults.Size = new Size(226, 46);
            lblQuizResults.TabIndex = 3;
            lblQuizResults.Text = "ket qua";
            lblQuizResults.TextAlign = ContentAlignment.MiddleLeft;
            lblQuizResults.Click += lblQuizResults_Click;
            lblQuizResults.MouseEnter += Label_MouseEnter;
            lblQuizResults.MouseLeave += Label_MouseLeave;
            // 
            // h2KhamPhaBanThan
            // 
            h2KhamPhaBanThan.BackColor = SystemColors.ControlLightLight;
            h2KhamPhaBanThan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            h2KhamPhaBanThan.Location = new Point(1, 1);
            h2KhamPhaBanThan.Name = "h2KhamPhaBanThan";
            h2KhamPhaBanThan.Size = new Size(226, 46);
            h2KhamPhaBanThan.TabIndex = 2;
            h2KhamPhaBanThan.Text = "Khám phá Bản thân";
            h2KhamPhaBanThan.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(1003, 26);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(114, 32);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "btnLogout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblLogout
            // 
            lblLogout.AutoSize = true;
            lblLogout.Location = new Point(949, 34);
            lblLogout.Name = "lblLogout";
            lblLogout.Size = new Size(48, 16);
            lblLogout.TabIndex = 3;
            lblLogout.Text = "Logout";
            // 
            // panelMenu
            // 
            panelMenu.Controls.Add(btnMajorMenu);
            panelMenu.Controls.Add(btnUniversityMenu);
            panelMenu.Controls.Add(btnScoreMenu);
            panelMenu.Controls.Add(lblLogout);
            panelMenu.Controls.Add(btnQuizMenu);
            panelMenu.Controls.Add(btnLogout);
            panelMenu.Dock = DockStyle.Top;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(1152, 76);
            panelMenu.TabIndex = 0;
            // 
            // btnMajorMenu
            // 
            btnMajorMenu.Location = new Point(756, 19);
            btnMajorMenu.Name = "btnMajorMenu";
            btnMajorMenu.Size = new Size(165, 46);
            btnMajorMenu.TabIndex = 6;
            btnMajorMenu.Text = "Quản lý ngành ";
            btnMajorMenu.UseVisualStyleBackColor = true;
            btnMajorMenu.Click += btnMajorMenu_Click;
            btnMajorMenu.MouseLeave += btnMajorMenu_MouseLeave;
            btnMajorMenu.MouseHover += btnMajorMenu_Click;
            // 
            // btnUniversityMenu
            // 
            btnUniversityMenu.Location = new Point(577, 19);
            btnUniversityMenu.Name = "btnUniversityMenu";
            btnUniversityMenu.Size = new Size(173, 46);
            btnUniversityMenu.TabIndex = 4;
            btnUniversityMenu.Text = "Quản lý Trường";
            btnUniversityMenu.UseVisualStyleBackColor = true;
            btnUniversityMenu.Click += btnUniversityMenu_Click;
            btnUniversityMenu.MouseLeave += btnUniversityMenu_MouseLeave;
            btnUniversityMenu.MouseHover += btnUniversityMenu_Click;
            // 
            // btnScoreMenu
            // 
            btnScoreMenu.Location = new Point(406, 19);
            btnScoreMenu.Name = "btnScoreMenu";
            btnScoreMenu.Size = new Size(165, 46);
            btnScoreMenu.TabIndex = 5;
            btnScoreMenu.Text = "Quản lý Điểm Thi";
            btnScoreMenu.UseVisualStyleBackColor = true;
            btnScoreMenu.Click += btnScoreMenu_Click;
            btnScoreMenu.MouseLeave += btnScoreMenu_MouseLeave;
            btnScoreMenu.MouseHover += btnScoreMenu_Click;
            // 
            // btnQuizMenu
            // 
            btnQuizMenu.Location = new Point(226, 19);
            btnQuizMenu.Name = "btnQuizMenu";
            btnQuizMenu.Size = new Size(174, 46);
            btnQuizMenu.TabIndex = 3;
            btnQuizMenu.Text = "Quản lý Quiz Tính Cách";
            btnQuizMenu.UseVisualStyleBackColor = true;
            btnQuizMenu.Click += btnQuizMenu_Click;
            btnQuizMenu.MouseLeave += btnQuizMenu_MouseLeave;
            btnQuizMenu.MouseHover += btnQuizMenu_Click;
            // 
            // quizContextMenu
            // 
            quizContextMenu.AutoSize = false;
            quizContextMenu.Items.AddRange(new ToolStripItem[] { ehheToolStripMenuItem, hihiToolStripMenuItem, toolStripMenuItem1 });
            quizContextMenu.Name = "contextMenuStrip1";
            quizContextMenu.Size = new Size(226, 160);
            quizContextMenu.Text = "menuAdd";
            quizContextMenu.MouseLeave += quizContextMenu_MouseLeave;
            // 
            // ehheToolStripMenuItem
            // 
            ehheToolStripMenuItem.AutoSize = false;
            ehheToolStripMenuItem.Font = new Font("Segoe UI", 12F);
            ehheToolStripMenuItem.Name = "ehheToolStripMenuItem";
            ehheToolStripMenuItem.Size = new Size(226, 46);
            ehheToolStripMenuItem.Text = "them cau hoi";
            // 
            // hihiToolStripMenuItem
            // 
            hihiToolStripMenuItem.AutoSize = false;
            hihiToolStripMenuItem.Name = "hihiToolStripMenuItem";
            hihiToolStripMenuItem.Size = new Size(226, 46);
            hihiToolStripMenuItem.Text = "xoa cau hoi";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.AutoSize = false;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(226, 46);
            toolStripMenuItem1.Text = "sua cau hoi";
            toolStripMenuItem1.ToolTipText = "huhu";
            // 
            // lblLenKhung
            // 
            lblLenKhung.AutoSize = true;
            lblLenKhung.Location = new Point(500, 472);
            lblLenKhung.Name = "lblLenKhung";
            lblLenKhung.Size = new Size(160, 16);
            lblLenKhung.TabIndex = 3;
            lblLenKhung.Text = "khuong thanh len bi khung";
            // 
            // scoreContextMenu
            // 
            scoreContextMenu.AutoSize = false;
            scoreContextMenu.Items.AddRange(new ToolStripItem[] { toolStripMenuItem2, toolStripMenuItem3 });
            scoreContextMenu.Name = "contextMenuStrip1";
            scoreContextMenu.Size = new Size(226, 160);
            scoreContextMenu.Text = "contextMenuStrip1";
            scoreContextMenu.MouseLeave += scoreContextMenu_MouseLeave;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.AutoSize = false;
            toolStripMenuItem2.Font = new Font("Segoe UI", 12F);
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(226, 46);
            toolStripMenuItem2.Text = "them moi diem chuan";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.AutoSize = false;
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(226, 46);
            toolStripMenuItem3.Text = "them moi pho diem";
            // 
            // majorContextMenu
            // 
            majorContextMenu.AutoSize = false;
            majorContextMenu.Items.AddRange(new ToolStripItem[] { toolStripMenuItem8, toolStripMenuItem9, toolStripMenuItem10 });
            majorContextMenu.Name = "contextMenuStrip1";
            majorContextMenu.Size = new Size(226, 160);
            majorContextMenu.Text = "contextMenuStrip1";
            majorContextMenu.MouseLeave += majorContextMenu_MouseLeave;
            // 
            // toolStripMenuItem8
            // 
            toolStripMenuItem8.AutoSize = false;
            toolStripMenuItem8.Font = new Font("Segoe UI", 12F);
            toolStripMenuItem8.Name = "toolStripMenuItem8";
            toolStripMenuItem8.Size = new Size(226, 46);
            toolStripMenuItem8.Text = "them nganh";
            // 
            // toolStripMenuItem9
            // 
            toolStripMenuItem9.AutoSize = false;
            toolStripMenuItem9.Name = "toolStripMenuItem9";
            toolStripMenuItem9.Size = new Size(226, 46);
            toolStripMenuItem9.Text = "xoa nganh";
            // 
            // toolStripMenuItem10
            // 
            toolStripMenuItem10.AutoSize = false;
            toolStripMenuItem10.Name = "toolStripMenuItem10";
            toolStripMenuItem10.Size = new Size(226, 46);
            toolStripMenuItem10.Text = "sua nganh";
            toolStripMenuItem10.ToolTipText = "huhu";
            // 
            // universityContextMenu
            // 
            universityContextMenu.AutoSize = false;
            universityContextMenu.Items.AddRange(new ToolStripItem[] { toolStripMenuItem5, toolStripMenuItem6, toolStripMenuItem7 });
            universityContextMenu.Name = "contextMenuStrip1";
            universityContextMenu.Size = new Size(226, 160);
            universityContextMenu.Text = "contextMenuStrip1";
            universityContextMenu.MouseLeave += universityContextMenu_MouseLeave;
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.AutoSize = false;
            toolStripMenuItem5.Font = new Font("Segoe UI", 12F);
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(226, 46);
            toolStripMenuItem5.Text = "them truong";
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.AutoSize = false;
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new Size(226, 46);
            toolStripMenuItem6.Text = "xoa truong";
            // 
            // toolStripMenuItem7
            // 
            toolStripMenuItem7.AutoSize = false;
            toolStripMenuItem7.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem14, toolStripMenuItem15, toolStripMenuItem16 });
            toolStripMenuItem7.Name = "toolStripMenuItem7";
            toolStripMenuItem7.Size = new Size(226, 46);
            toolStripMenuItem7.Text = "sua truong";
            toolStripMenuItem7.ToolTipText = "huhu";
            // 
            // toolStripMenuItem14
            // 
            toolStripMenuItem14.AutoSize = false;
            toolStripMenuItem14.Name = "toolStripMenuItem14";
            toolStripMenuItem14.Size = new Size(180, 46);
            toolStripMenuItem14.Text = "truong";
            // 
            // toolStripMenuItem15
            // 
            toolStripMenuItem15.AutoSize = false;
            toolStripMenuItem15.Name = "toolStripMenuItem15";
            toolStripMenuItem15.Size = new Size(180, 46);
            toolStripMenuItem15.Text = "nganh";
            // 
            // toolStripMenuItem16
            // 
            toolStripMenuItem16.AutoSize = false;
            toolStripMenuItem16.Name = "toolStripMenuItem16";
            toolStripMenuItem16.Size = new Size(180, 46);
            toolStripMenuItem16.Text = "phuong thuc tuyen sinh";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 778);
            Controls.Add(lblLenKhung);
            Controls.Add(panel2);
            Controls.Add(panelMenu);
            Font = new Font("Microsoft Sans Serif", 9.75F);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            panel2.ResumeLayout(false);
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            quizContextMenu.ResumeLayout(false);
            scoreContextMenu.ResumeLayout(false);
            majorContextMenu.ResumeLayout(false);
            universityContextMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
        private Panel panel2;
        private Label h2KhamPhaBanThan;
        private Label lblQuiz;
        private Label lblQuizResults;
        private Label h2DanhGiaDiemThi;
        private Label lblScoreConversion;
        private Label lblScorePercentile;
        private Label lblInputScore;
        private Label lblMajorByInterest;
        private Label lblMajorRecommend;
        private Label lblMajorByScore;
        private Label lblMajorByBlock;
        private Label h2TraCuuNganhTruong;
        private Label lblScoreManagement;
        private Button btnLogout;
        private Label lblLogout;
        private Panel panelMenu;

        private ContextMenuStrip quizContextMenu;
        private ToolStripMenuItem ehheToolStripMenuItem;
        private ToolStripMenuItem hihiToolStripMenuItem;
        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>

        #endregion

        private Button btnQuizMenu;
        private Button btnScoreMenu;
        private Button btnUniversityMenu;
        private Button btnMajorMenu;
        private ToolStripMenuItem toolStripMenuItem1;
        private Label lblLenKhung;
        private ContextMenuStrip scoreContextMenu;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ContextMenuStrip majorContextMenu;
        private ToolStripMenuItem toolStripMenuItem8;
        private ToolStripMenuItem toolStripMenuItem9;
        private ToolStripMenuItem toolStripMenuItem10;
        private ContextMenuStrip universityContextMenu;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem6;
        private ToolStripMenuItem toolStripMenuItem7;
        private ToolStripMenuItem toolStripMenuItem14;
        private ToolStripMenuItem toolStripMenuItem15;
        private ToolStripMenuItem toolStripMenuItem16;
    }
}
