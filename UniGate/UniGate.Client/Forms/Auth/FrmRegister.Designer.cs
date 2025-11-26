using System.Drawing;
using System.Windows.Forms;

namespace UniGate.Client.Forms.Auth   // sửa lại nếu namespace khác
{
    partial class FrmRegister
    {
        private System.ComponentModel.IContainer components = null;

        private Panel panelMain;
        private Label lblUserName;
        private Label lblEmail;
        private Label lblPassword;
        private Label lblConfirmPassword;
        private TextBox txtUserName;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private Button btnSignUp;
        private LinkLabel lnkGoLogin;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegister));
            panelMain = new Panel();
            lnkGoLogin = new LinkLabel();
            btnSignUp = new Button();
            txtConfirmPassword = new TextBox();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            txtUserName = new TextBox();
            lblConfirmPassword = new Label();
            lblPassword = new Label();
            lblEmail = new Label();
            lblUserName = new Label();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.Anchor = AnchorStyles.None;
            panelMain.BackColor = Color.White;
            panelMain.Controls.Add(lnkGoLogin);
            panelMain.Controls.Add(btnSignUp);
            panelMain.Controls.Add(txtConfirmPassword);
            panelMain.Controls.Add(txtPassword);
            panelMain.Controls.Add(txtEmail);
            panelMain.Controls.Add(txtUserName);
            panelMain.Controls.Add(lblConfirmPassword);
            panelMain.Controls.Add(lblPassword);
            panelMain.Controls.Add(lblEmail);
            panelMain.Controls.Add(lblUserName);
            panelMain.Location = new Point(140, 60);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(24);
            panelMain.Size = new Size(520, 430);
            panelMain.TabIndex = 0;
            // 
            // lnkGoLogin
            // 
            lnkGoLogin.AutoSize = true;
            lnkGoLogin.Font = new Font("Segoe UI", 9F);
            lnkGoLogin.LinkColor = Color.RoyalBlue;
            lnkGoLogin.Location = new Point(24, 270);
            lnkGoLogin.Name = "lnkGoLogin";
            lnkGoLogin.Size = new Size(286, 20);
            lnkGoLogin.TabIndex = 8;
            lnkGoLogin.TabStop = true;
            lnkGoLogin.Text = "Already have an account? Login right now";
            lnkGoLogin.LinkClicked += lnkGoLogin_LinkClicked;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.FromArgb(0, 180, 255);
            btnSignUp.FlatAppearance.BorderSize = 0;
            btnSignUp.FlatStyle = FlatStyle.Flat;
            btnSignUp.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnSignUp.ForeColor = Color.White;
            btnSignUp.Location = new Point(24, 310);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(470, 55);
            btnSignUp.TabIndex = 9;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new Font("Segoe UI", 10F);
            txtConfirmPassword.Location = new Point(24, 230);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '•';
            txtConfirmPassword.Size = new Size(470, 30);
            txtConfirmPassword.TabIndex = 7;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 10F);
            txtPassword.Location = new Point(24, 170);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.Size = new Size(470, 30);
            txtPassword.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.Location = new Point(24, 110);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(470, 30);
            txtEmail.TabIndex = 3;
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 10F);
            txtUserName.Location = new Point(24, 50);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(470, 30);
            txtUserName.TabIndex = 1;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Segoe UI", 10F);
            lblConfirmPassword.Location = new Point(24, 205);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(146, 23);
            lblConfirmPassword.TabIndex = 6;
            lblConfirmPassword.Text = "Confirm Password";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 10F);
            lblPassword.Location = new Point(24, 145);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(80, 23);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10F);
            lblEmail.Location = new Point(24, 85);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(51, 23);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 10F);
            lblUserName.Location = new Point(24, 25);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(95, 23);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "User Name";
            // 
            // FrmRegister
            // 
            AcceptButton = btnSignUp;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 550);
            Controls.Add(panelMain);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign Up";
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ResumeLayout(false);

        }

        #endregion
    }
}
