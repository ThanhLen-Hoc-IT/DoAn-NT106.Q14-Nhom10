using System.Drawing;
using System.Windows.Forms;

namespace UniGate.Client.Forms
{
    partial class FrmHollandResult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHollandResult));
            panelMain = new Panel();
            btnClose = new Button();
            btnBack = new Button();
            panelDetail = new Panel();
            lblSummaryTitle = new Label();
            txtSummary = new TextBox();
            lblC = new Label();
            lblE = new Label();
            lblS = new Label();
            lblA = new Label();
            lblI = new Label();
            lblR = new Label();
            panelCode = new Panel();
            lblTop3Value = new Label();
            lblTop3Caption = new Label();
            lblYourCodeValue = new Label();
            lblYourCodeCaption = new Label();
            panelHeader = new Panel();
            lblHeaderSub = new Label();
            lblHeaderTitle = new Label();
            panelMain.SuspendLayout();
            panelDetail.SuspendLayout();
            panelCode.SuspendLayout();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.White;
            panelMain.BackgroundImage = (Image)resources.GetObject("panelMain.BackgroundImage");
            panelMain.Controls.Add(btnClose);
            panelMain.Controls.Add(btnBack);
            panelMain.Controls.Add(panelDetail);
            panelMain.Controls.Add(panelCode);
            panelMain.Controls.Add(panelHeader);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(20);
            panelMain.Size = new Size(900, 600);
            panelMain.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Bottom;
            btnClose.Font = new Font("Segoe UI", 10F);
            btnClose.Location = new Point(630, 540);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(140, 35);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += BtnClose_Click;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Bottom;
            btnBack.Font = new Font("Segoe UI", 10F);
            btnBack.Location = new Point(130, 540);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(160, 35);
            btnBack.TabIndex = 3;
            btnBack.Text = "← Back to test";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += BtnBack_Click;
            // 
            // panelDetail
            // 
            panelDetail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelDetail.BackColor = Color.White;
            panelDetail.BorderStyle = BorderStyle.FixedSingle;
            panelDetail.Controls.Add(lblSummaryTitle);
            panelDetail.Controls.Add(txtSummary);
            panelDetail.Controls.Add(lblC);
            panelDetail.Controls.Add(lblE);
            panelDetail.Controls.Add(lblS);
            panelDetail.Controls.Add(lblA);
            panelDetail.Controls.Add(lblI);
            panelDetail.Controls.Add(lblR);
            panelDetail.Location = new Point(30, 230);
            panelDetail.Name = "panelDetail";
            panelDetail.Padding = new Padding(16);
            panelDetail.Size = new Size(840, 290);
            panelDetail.TabIndex = 2;
            panelDetail.Paint += panelDetail_Paint;
            // 
            // lblSummaryTitle
            // 
            lblSummaryTitle.AutoSize = true;
            lblSummaryTitle.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblSummaryTitle.Location = new Point(19, 130);
            lblSummaryTitle.Name = "lblSummaryTitle";
            lblSummaryTitle.Size = new Size(192, 25);
            lblSummaryTitle.TabIndex = 7;
            lblSummaryTitle.Text = "Personality summary";
            // 
            // txtSummary
            // 
            txtSummary.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSummary.Location = new Point(23, 160);
            txtSummary.Multiline = true;
            txtSummary.Name = "txtSummary";
            txtSummary.ScrollBars = ScrollBars.Vertical;
            txtSummary.Size = new Size(790, 110);
            txtSummary.TabIndex = 6;
            // 
            // lblC
            // 
            lblC.AutoSize = true;
            lblC.Font = new Font("Segoe UI", 10F);
            lblC.Location = new Point(430, 90);
            lblC.Name = "lblC";
            lblC.Size = new Size(25, 23);
            lblC.TabIndex = 5;
            lblC.Text = "C:";
            // 
            // lblE
            // 
            lblE.AutoSize = true;
            lblE.Font = new Font("Segoe UI", 10F);
            lblE.Location = new Point(430, 60);
            lblE.Name = "lblE";
            lblE.Size = new Size(23, 23);
            lblE.TabIndex = 4;
            lblE.Text = "E:";
            // 
            // lblS
            // 
            lblS.AutoSize = true;
            lblS.Font = new Font("Segoe UI", 10F);
            lblS.Location = new Point(430, 30);
            lblS.Name = "lblS";
            lblS.Size = new Size(23, 23);
            lblS.TabIndex = 3;
            lblS.Text = "S:";
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Font = new Font("Segoe UI", 10F);
            lblA.Location = new Point(20, 90);
            lblA.Name = "lblA";
            lblA.Size = new Size(25, 23);
            lblA.TabIndex = 2;
            lblA.Text = "A:";
            // 
            // lblI
            // 
            lblI.AutoSize = true;
            lblI.Font = new Font("Segoe UI", 10F);
            lblI.Location = new Point(20, 60);
            lblI.Name = "lblI";
            lblI.Size = new Size(19, 23);
            lblI.TabIndex = 1;
            lblI.Text = "I:";
            // 
            // lblR
            // 
            lblR.AutoSize = true;
            lblR.Font = new Font("Segoe UI", 10F);
            lblR.Location = new Point(20, 30);
            lblR.Name = "lblR";
            lblR.Size = new Size(24, 23);
            lblR.TabIndex = 0;
            lblR.Text = "R:";
            // 
            // panelCode
            // 
            panelCode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelCode.BackColor = Color.FromArgb(225, 248, 240);
            panelCode.BorderStyle = BorderStyle.FixedSingle;
            panelCode.Controls.Add(lblTop3Value);
            panelCode.Controls.Add(lblTop3Caption);
            panelCode.Controls.Add(lblYourCodeValue);
            panelCode.Controls.Add(lblYourCodeCaption);
            panelCode.Location = new Point(30, 120);
            panelCode.Name = "panelCode";
            panelCode.Padding = new Padding(16);
            panelCode.Size = new Size(840, 90);
            panelCode.TabIndex = 1;
            // 
            // lblTop3Value
            // 
            lblTop3Value.AutoSize = true;
            lblTop3Value.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblTop3Value.Location = new Point(210, 52);
            lblTop3Value.Name = "lblTop3Value";
            lblTop3Value.Size = new Size(79, 25);
            lblTop3Value.TabIndex = 3;
            lblTop3Value.Text = "R - I - A";
            // 
            // lblTop3Caption
            // 
            lblTop3Caption.AutoSize = true;
            lblTop3Caption.Font = new Font("Segoe UI", 10F);
            lblTop3Caption.Location = new Point(19, 52);
            lblTop3Caption.Name = "lblTop3Caption";
            lblTop3Caption.Size = new Size(183, 23);
            lblTop3Caption.TabIndex = 2;
            lblTop3Caption.Text = "Top 3 dominant codes:";
            // 
            // lblYourCodeValue
            // 
            lblYourCodeValue.AutoSize = true;
            lblYourCodeValue.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblYourCodeValue.ForeColor = Color.ForestGreen;
            lblYourCodeValue.Location = new Point(210, 10);
            lblYourCodeValue.Name = "lblYourCodeValue";
            lblYourCodeValue.Size = new Size(117, 41);
            lblYourCodeValue.TabIndex = 1;
            lblYourCodeValue.Text = "RIASEC";
            // 
            // lblYourCodeCaption
            // 
            lblYourCodeCaption.AutoSize = true;
            lblYourCodeCaption.Font = new Font("Segoe UI", 10F);
            lblYourCodeCaption.Location = new Point(19, 20);
            lblYourCodeCaption.Name = "lblYourCodeCaption";
            lblYourCodeCaption.Size = new Size(90, 23);
            lblYourCodeCaption.TabIndex = 0;
            lblYourCodeCaption.Text = "Your code:";
            // 
            // panelHeader
            // 
            panelHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelHeader.BackColor = Color.White;
            panelHeader.BorderStyle = BorderStyle.FixedSingle;
            panelHeader.Controls.Add(lblHeaderSub);
            panelHeader.Controls.Add(lblHeaderTitle);
            panelHeader.Location = new Point(30, 20);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(840, 90);
            panelHeader.TabIndex = 0;
            // 
            // lblHeaderSub
            // 
            lblHeaderSub.Font = new Font("Segoe UI", 9F);
            lblHeaderSub.Location = new Point(15, 45);
            lblHeaderSub.Name = "lblHeaderSub";
            lblHeaderSub.Size = new Size(810, 35);
            lblHeaderSub.TabIndex = 1;
            lblHeaderSub.Text = "Here is your personality profile and the 3 dominant Holland codes.";
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.AutoSize = true;
            lblHeaderTitle.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            lblHeaderTitle.ForeColor = Color.ForestGreen;
            lblHeaderTitle.Location = new Point(15, 5);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(411, 46);
            lblHeaderTitle.TabIndex = 0;
            lblHeaderTitle.Text = "Your Holland Code Result";
            // 
            // FrmHollandResult
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 600);
            Controls.Add(panelMain);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmHollandResult";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Holland Result";
            Load += FrmHollandResult_Load;
            panelMain.ResumeLayout(false);
            panelDetail.ResumeLayout(false);
            panelDetail.PerformLayout();
            panelCode.ResumeLayout(false);
            panelCode.PerformLayout();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private Panel panelMain;
        private Panel panelHeader;
        private Label lblHeaderSub;
        private Label lblHeaderTitle;
        private Panel panelCode;
        private Label lblTop3Value;
        private Label lblTop3Caption;
        private Label lblYourCodeValue;
        private Label lblYourCodeCaption;
        private Panel panelDetail;
        private Label lblSummaryTitle;
        private TextBox txtSummary;
        private Label lblC;
        private Label lblE;
        private Label lblS;
        private Label lblA;
        private Label lblI;
        private Label lblR;
        private Button btnBack;
        private Button btnClose;
    }
}
