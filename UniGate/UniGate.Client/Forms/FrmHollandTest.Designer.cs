using System.Drawing;
using System.Windows.Forms;

namespace UniGate.Client.Forms
{
    partial class FrmHollandTest
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(FrmHollandTest));
            this.panelMain = new Panel();
            this.progressBar = new ProgressBar();
            this.lblProgress = new Label();
            this.flowQuestions = new FlowLayoutPanel();
            this.lblCurrentQuestion = new Label();
            this.panelQuestion = new Panel();
            this.lblQuestionTitle = new Label();
            this.lblQuestionText = new Label();
            this.btnRate1 = new Button();
            this.btnRate2 = new Button();
            this.btnRate3 = new Button();
            this.btnRate4 = new Button();
            this.btnRate5 = new Button();
            this.btnPrev = new Button();
            this.btnNext = new Button();
            this.panelMain.SuspendLayout();
            this.panelQuestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = Color.WhiteSmoke;
            this.panelMain.BackgroundImage = (Image)resources.GetObject("panelMain.BackgroundImage");
            this.panelMain.Controls.Add(this.progressBar);
            this.panelMain.Controls.Add(this.lblProgress);
            this.panelMain.Controls.Add(this.flowQuestions);
            this.panelMain.Controls.Add(this.lblCurrentQuestion);
            this.panelMain.Controls.Add(this.panelQuestion);
            this.panelMain.Controls.Add(this.btnPrev);
            this.panelMain.Controls.Add(this.btnNext);
            this.panelMain.Dock = DockStyle.Fill;
            this.panelMain.Location = new Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new Padding(20);
            this.panelMain.Size = new Size(900, 500);
            this.panelMain.TabIndex = 0;
            // 
            // progressBar
            // 
            this.progressBar.Location = new Point(20, 20);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new Size(650, 12);
            this.progressBar.TabIndex = 0;
            // 
            // lblProgress
            // 
            this.lblProgress.Font = new Font("Segoe UI", 10F);
            this.lblProgress.Location = new Point(680, 15);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new Size(140, 25);
            this.lblProgress.TabIndex = 1;
            this.lblProgress.Text = "0 / 60";
            // 
            // flowQuestions
            // 
            this.flowQuestions.AutoScroll = true;
            this.flowQuestions.BackColor = Color.White;
            this.flowQuestions.Location = new Point(20, 50);
            this.flowQuestions.Name = "flowQuestions";
            this.flowQuestions.Size = new Size(820, 80);
            this.flowQuestions.TabIndex = 2;
            // 
            // lblCurrentQuestion
            // 
            this.lblCurrentQuestion.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.lblCurrentQuestion.Location = new Point(20, 140);
            this.lblCurrentQuestion.Name = "lblCurrentQuestion";
            this.lblCurrentQuestion.Size = new Size(400, 30);
            this.lblCurrentQuestion.TabIndex = 3;
            this.lblCurrentQuestion.Text = "Question 1";
            // 
            // panelQuestion
            // 
            this.panelQuestion.BackColor = Color.White;
            this.panelQuestion.Controls.Add(this.lblQuestionTitle);
            this.panelQuestion.Controls.Add(this.lblQuestionText);
            this.panelQuestion.Controls.Add(this.btnRate1);
            this.panelQuestion.Controls.Add(this.btnRate2);
            this.panelQuestion.Controls.Add(this.btnRate3);
            this.panelQuestion.Controls.Add(this.btnRate4);
            this.panelQuestion.Controls.Add(this.btnRate5);
            this.panelQuestion.Location = new Point(20, 180);
            this.panelQuestion.Name = "panelQuestion";
            this.panelQuestion.Padding = new Padding(20);
            this.panelQuestion.Size = new Size(820, 220);
            this.panelQuestion.TabIndex = 4;
            // 
            // lblQuestionTitle
            // 
            this.lblQuestionTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.lblQuestionTitle.Location = new Point(10, 10);
            this.lblQuestionTitle.Name = "lblQuestionTitle";
            this.lblQuestionTitle.Size = new Size(600, 35);
            this.lblQuestionTitle.TabIndex = 0;
            this.lblQuestionTitle.Text = "Mức độ yêu thích với hoạt động:";
            // 
            // lblQuestionText
            // 
            this.lblQuestionText.Font = new Font("Segoe UI", 14F);
            this.lblQuestionText.Location = new Point(10, 55);
            this.lblQuestionText.Name = "lblQuestionText";
            this.lblQuestionText.Size = new Size(600, 35);
            this.lblQuestionText.TabIndex = 1;
            this.lblQuestionText.Text = "Sửa chữa đồ điện tử";
            // 
            // btnRate1
            // 
            this.btnRate1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.btnRate1.Location = new Point(30, 120);
            this.btnRate1.Name = "btnRate1";
            this.btnRate1.Size = new Size(70, 70);
            this.btnRate1.TabIndex = 2;
            this.btnRate1.Text = "1";
            this.btnRate1.Tag = "1";
            this.btnRate1.UseVisualStyleBackColor = true;
            this.btnRate1.Click += new System.EventHandler(this.btnRate1_Click);
            // 
            // btnRate2
            // 
            this.btnRate2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.btnRate2.Location = new Point(120, 120);
            this.btnRate2.Name = "btnRate2";
            this.btnRate2.Size = new Size(70, 70);
            this.btnRate2.TabIndex = 3;
            this.btnRate2.Text = "2";
            this.btnRate2.Tag = "2";
            this.btnRate2.UseVisualStyleBackColor = true;
            this.btnRate2.Click += new System.EventHandler(this.btnRate2_Click);
            // 
            // btnRate3
            // 
            this.btnRate3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.btnRate3.Location = new Point(210, 120);
            this.btnRate3.Name = "btnRate3";
            this.btnRate3.Size = new Size(70, 70);
            this.btnRate3.TabIndex = 4;
            this.btnRate3.Text = "3";
            this.btnRate3.Tag = "3";
            this.btnRate3.UseVisualStyleBackColor = true;
            this.btnRate3.Click += new System.EventHandler(this.btnRate3_Click);
            // 
            // btnRate4
            // 
            this.btnRate4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.btnRate4.Location = new Point(300, 120);
            this.btnRate4.Name = "btnRate4";
            this.btnRate4.Size = new Size(70, 70);
            this.btnRate4.TabIndex = 5;
            this.btnRate4.Text = "4";
            this.btnRate4.Tag = "4";
            this.btnRate4.UseVisualStyleBackColor = true;
            this.btnRate4.Click += new System.EventHandler(this.btnRate4_Click);
            // 
            // btnRate5
            // 
            this.btnRate5.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.btnRate5.Location = new Point(390, 120);
            this.btnRate5.Name = "btnRate5";
            this.btnRate5.Size = new Size(70, 70);
            this.btnRate5.TabIndex = 6;
            this.btnRate5.Text = "5";
            this.btnRate5.Tag = "5";
            this.btnRate5.UseVisualStyleBackColor = true;
            this.btnRate5.Click += new System.EventHandler(this.btnRate5_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new Point(20, 420);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new Size(120, 40);
            this.btnPrev.TabIndex = 5;
            this.btnPrev.Text = "← Previous";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new Point(720, 420);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new Size(120, 40);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Next →";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // FrmHollandTest
            // 
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(900, 500);
            this.Controls.Add(this.panelMain);
            this.Name = "FrmHollandTest";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Holland Test";
            this.Load += new System.EventHandler(this.FrmHollandTest_Load);
            this.panelMain.ResumeLayout(false);
            this.panelQuestion.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private Panel panelMain;
        private ProgressBar progressBar;
        private Label lblProgress;
        private FlowLayoutPanel flowQuestions;
        private Label lblCurrentQuestion;
        private Panel panelQuestion;
        private Label lblQuestionTitle;
        private Label lblQuestionText;
        private Button btnRate1;
        private Button btnRate2;
        private Button btnRate3;
        private Button btnRate4;
        private Button btnRate5;
        private Button btnPrev;
        private Button btnNext;
    }
}
