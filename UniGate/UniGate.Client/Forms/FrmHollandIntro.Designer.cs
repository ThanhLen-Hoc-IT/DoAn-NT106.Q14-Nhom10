using System.Windows.Forms;
using System.Drawing;

namespace UniGate.Client.Forms
{
    partial class FrmHollandIntro
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(FrmHollandIntro));
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelSteps = new System.Windows.Forms.Panel();
            this.lblStep3 = new System.Windows.Forms.Label();
            this.lblStep2 = new System.Windows.Forms.Label();
            this.lblStep1 = new System.Windows.Forms.Label();
            this.lblStepsTitle = new System.Windows.Forms.Label();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.lblGroups = new System.Windows.Forms.Label();
            this.lblGroupsCaption = new System.Windows.Forms.Label();
            this.lblLimit = new System.Windows.Forms.Label();
            this.lblLimitCaption = new System.Windows.Forms.Label();
            this.lblActivities = new System.Windows.Forms.Label();
            this.lblActivitiesCaption = new System.Windows.Forms.Label();
            this.btnStartTest = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblBadge = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.panelSteps.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.BackgroundImage =
                (System.Drawing.Image)resources.GetObject("panelMain.BackgroundImage");
            this.panelMain.Controls.Add(this.panelSteps);
            this.panelMain.Controls.Add(this.panelInfo);
            this.panelMain.Controls.Add(this.btnStartTest);
            this.panelMain.Controls.Add(this.panelHeader);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(32, 24, 32, 24);
            this.panelMain.Size = new System.Drawing.Size(900, 600);
            this.panelMain.TabIndex = 0;
            // 
            // panelSteps
            // 
            this.panelSteps.Anchor = ((System.Windows.Forms.AnchorStyles)
                (((System.Windows.Forms.AnchorStyles.Top |
                   System.Windows.Forms.AnchorStyles.Left) |
                  System.Windows.Forms.AnchorStyles.Right)));
            this.panelSteps.BackColor = System.Drawing.Color.White;
            this.panelSteps.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSteps.Controls.Add(this.lblStep3);
            this.panelSteps.Controls.Add(this.lblStep2);
            this.panelSteps.Controls.Add(this.lblStep1);
            this.panelSteps.Controls.Add(this.lblStepsTitle);
            this.panelSteps.Location = new System.Drawing.Point(35, 320);
            this.panelSteps.Name = "panelSteps";
            this.panelSteps.Padding = new System.Windows.Forms.Padding(16);
            this.panelSteps.Size = new System.Drawing.Size(830, 140);
            this.panelSteps.TabIndex = 3;
            // 
            // lblStep3
            // 
            this.lblStep3.AutoSize = true;
            this.lblStep3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblStep3.Location = new System.Drawing.Point(24, 100);
            this.lblStep3.Name = "lblStep3";
            this.lblStep3.Size = new System.Drawing.Size(270, 23);
            this.lblStep3.TabIndex = 3;
            this.lblStep3.Text = "STEP 3 – View your Holland result.";
            // 
            // lblStep2
            // 
            this.lblStep2.AutoSize = true;
            this.lblStep2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblStep2.Location = new System.Drawing.Point(24, 74);
            this.lblStep2.Name = "lblStep2";
            this.lblStep2.Size = new System.Drawing.Size(230, 23);
            this.lblStep2.TabIndex = 2;
            this.lblStep2.Text = "STEP 2 – Answer all 60 items.";
            // 
            // lblStep1
            // 
            this.lblStep1.AutoSize = true;
            this.lblStep1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblStep1.Location = new System.Drawing.Point(24, 48);
            this.lblStep1.Name = "lblStep1";
            this.lblStep1.Size = new System.Drawing.Size(246, 23);
            this.lblStep1.TabIndex = 1;
            this.lblStep1.Text = "STEP 1 – Start the Holland test.";
            // 
            // lblStepsTitle
            // 
            this.lblStepsTitle.AutoSize = true;
            this.lblStepsTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11F,
                System.Drawing.FontStyle.Bold);
            this.lblStepsTitle.Location = new System.Drawing.Point(16, 16);
            this.lblStepsTitle.Name = "lblStepsTitle";
            this.lblStepsTitle.Size = new System.Drawing.Size(263, 25);
            this.lblStepsTitle.TabIndex = 0;
            this.lblStepsTitle.Text = "Holland Test – simple 3 steps:";
            // 
            // panelInfo
            // 
            this.panelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)
                (((System.Windows.Forms.AnchorStyles.Top |
                   System.Windows.Forms.AnchorStyles.Left) |
                  System.Windows.Forms.AnchorStyles.Right)));
            this.panelInfo.BackColor = System.Drawing.Color.White;
            this.panelInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInfo.Controls.Add(this.lblGroups);
            this.panelInfo.Controls.Add(this.lblGroupsCaption);
            this.panelInfo.Controls.Add(this.lblLimit);
            this.panelInfo.Controls.Add(this.lblLimitCaption);
            this.panelInfo.Controls.Add(this.lblActivities);
            this.panelInfo.Controls.Add(this.lblActivitiesCaption);
            this.panelInfo.Location = new System.Drawing.Point(35, 210);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Padding = new System.Windows.Forms.Padding(16);
            this.panelInfo.Size = new System.Drawing.Size(830, 90);
            this.panelInfo.TabIndex = 2;
            // 
            // lblGroups
            // 
            this.lblGroups.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGroups.AutoSize = true;
            this.lblGroups.Font = new System.Drawing.Font("Segoe UI", 16F,
                System.Drawing.FontStyle.Bold);
            this.lblGroups.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblGroups.Location = new System.Drawing.Point(672, 34);
            this.lblGroups.Name = "lblGroups";
            this.lblGroups.Size = new System.Drawing.Size(33, 37);
            this.lblGroups.TabIndex = 5;
            this.lblGroups.Text = "6";
            // 
            // lblGroupsCaption
            // 
            this.lblGroupsCaption.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGroupsCaption.AutoSize = true;
            this.lblGroupsCaption.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblGroupsCaption.Location = new System.Drawing.Point(622, 16);
            this.lblGroupsCaption.Name = "lblGroupsCaption";
            this.lblGroupsCaption.Size = new System.Drawing.Size(134, 20);
            this.lblGroupsCaption.TabIndex = 4;
            this.lblGroupsCaption.Text = "RIASEC personality";
            // 
            // lblLimit
            // 
            this.lblLimit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLimit.AutoSize = true;
            this.lblLimit.Font = new System.Drawing.Font("Segoe UI", 16F,
                System.Drawing.FontStyle.Bold);
            this.lblLimit.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblLimit.Location = new System.Drawing.Point(431, 34);
            this.lblLimit.Name = "lblLimit";
            this.lblLimit.Size = new System.Drawing.Size(39, 37);
            this.lblLimit.TabIndex = 3;
            this.lblLimit.Text = "∞";
            // 
            // lblLimitCaption
            // 
            this.lblLimitCaption.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLimitCaption.AutoSize = true;
            this.lblLimitCaption.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLimitCaption.Location = new System.Drawing.Point(382, 16);
            this.lblLimitCaption.Name = "lblLimitCaption";
            this.lblLimitCaption.Size = new System.Drawing.Size(131, 20);
            this.lblLimitCaption.TabIndex = 2;
            this.lblLimitCaption.Text = "No time limitation";
            // 
            // lblActivities
            // 
            this.lblActivities.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblActivities.AutoSize = true;
            this.lblActivities.Font = new System.Drawing.Font("Segoe UI", 16F,
                System.Drawing.FontStyle.Bold);
            this.lblActivities.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblActivities.Location = new System.Drawing.Point(179, 34);
            this.lblActivities.Name = "lblActivities";
            this.lblActivities.Size = new System.Drawing.Size(49, 37);
            this.lblActivities.TabIndex = 1;
            this.lblActivities.Text = "60";
            // 
            // lblActivitiesCaption
            // 
            this.lblActivitiesCaption.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblActivitiesCaption.AutoSize = true;
            this.lblActivitiesCaption.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblActivitiesCaption.Location = new System.Drawing.Point(124, 16);
            this.lblActivitiesCaption.Name = "lblActivitiesCaption";
            this.lblActivitiesCaption.Size = new System.Drawing.Size(145, 20);
            this.lblActivitiesCaption.TabIndex = 0;
            this.lblActivitiesCaption.Text = "Career-related items";
            // 
            // btnStartTest
            // 
            this.btnStartTest.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnStartTest.BackColor = System.Drawing.Color.FromArgb(0, 180, 255);
            this.btnStartTest.FlatAppearance.BorderSize = 0;
            this.btnStartTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartTest.Font = new System.Drawing.Font("Segoe UI Semibold", 12F,
                System.Drawing.FontStyle.Bold);
            this.btnStartTest.ForeColor = System.Drawing.Color.White;
            this.btnStartTest.Location = new System.Drawing.Point(320, 480);
            this.btnStartTest.Name = "btnStartTest";
            this.btnStartTest.Size = new System.Drawing.Size(260, 48);
            this.btnStartTest.TabIndex = 4;
            this.btnStartTest.Text = "Start Holland Test";
            this.btnStartTest.UseVisualStyleBackColor = false;
            this.btnStartTest.Click += new System.EventHandler(this.btnStartTest_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.Anchor = ((System.Windows.Forms.AnchorStyles)
                (((System.Windows.Forms.AnchorStyles.Top |
                   System.Windows.Forms.AnchorStyles.Left) |
                  System.Windows.Forms.AnchorStyles.Right)));
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.lblSubTitle);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.lblBadge);
            this.panelHeader.Location = new System.Drawing.Point(35, 24);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(830, 170);
            this.panelHeader.TabIndex = 1;
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubTitle.Location = new System.Drawing.Point(70, 100);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(690, 54);
            this.lblSubTitle.TabIndex = 2;
            this.lblSubTitle.Text =
                "Discover your career personality and explore suitable career paths based on the Holland (RIASEC) model.";
            this.lblSubTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 26F,
                System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblTitle.Location = new System.Drawing.Point(70, 44);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(690, 52);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Test Holland Codes";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBadge
            // 
            this.lblBadge.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBadge.AutoSize = true;
            this.lblBadge.BackColor = System.Drawing.Color.FromArgb(230, 248, 255);
            this.lblBadge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBadge.Font = new System.Drawing.Font("Segoe UI Semibold", 9F,
                System.Drawing.FontStyle.Bold);
            this.lblBadge.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblBadge.Location = new System.Drawing.Point(338, 12);
            this.lblBadge.Margin = new System.Windows.Forms.Padding(3);
            this.lblBadge.Name = "lblBadge";
            this.lblBadge.Padding = new System.Windows.Forms.Padding(10, 4, 10, 4);
            this.lblBadge.Size = new System.Drawing.Size(168, 30);
            this.lblBadge.TabIndex = 0;
            this.lblBadge.Text = "Career Test (RIASEC)";
            // 
            // FrmHollandIntro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmHollandIntro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Holland Test Introduction";
            this.panelMain.ResumeLayout(false);
            this.panelSteps.ResumeLayout(false);
            this.panelSteps.PerformLayout();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelSteps;
        private System.Windows.Forms.Label lblStep3;
        private System.Windows.Forms.Label lblStep2;
        private System.Windows.Forms.Label lblStep1;
        private System.Windows.Forms.Label lblStepsTitle;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label lblGroups;
        private System.Windows.Forms.Label lblGroupsCaption;
        private System.Windows.Forms.Label lblLimit;
        private System.Windows.Forms.Label lblLimitCaption;
        private System.Windows.Forms.Label lblActivities;
        private System.Windows.Forms.Label lblActivitiesCaption;
        private System.Windows.Forms.Button btnStartTest;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblBadge;
    }
}
