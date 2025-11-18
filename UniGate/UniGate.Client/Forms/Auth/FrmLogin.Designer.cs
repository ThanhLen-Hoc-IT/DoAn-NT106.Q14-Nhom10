namespace UniGate.Client.Forms.Auth
{
    partial class FrmLogin
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
        private void InitializeComponent()
        {
            label1 = new Label();
            txtUsername = new TextBox();
            textBox2 = new TextBox();
            btnLogin = new Button();
            linkLabel2 = new LinkLabel();
            txtPassword = new TextBox();
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(169, 66);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.ControlLightLight;
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.ImeMode = ImeMode.NoControl;
            txtUsername.Location = new Point(198, 66);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(300, 30);
            txtUsername.TabIndex = 2;
            txtUsername.Text = "User Name";
            txtUsername.Click += txtUsername_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(188, 131);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(0, 23);
            textBox2.TabIndex = 2;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DeepSkyBlue;
            btnLogin.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.ImageAlign = ContentAlignment.TopLeft;
            btnLogin.Location = new Point(198, 187);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(300, 43);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.ForeColor = SystemColors.ButtonFace;
            linkLabel2.LinkColor = Color.Black;
            linkLabel2.Location = new Point(198, 169);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(100, 15);
            linkLabel2.TabIndex = 5;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Forgot Password?";
            linkLabel2.VisitedLinkColor = Color.White;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.ControlLightLight;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(198, 115);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(300, 30);
            txtPassword.TabIndex = 3;
            txtPassword.Text = "Password";
            txtPassword.Click += txtPassword_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.ForeColor = SystemColors.ButtonFace;
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(361, 169);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(137, 15);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Don't Have An Account?";
            linkLabel1.VisitedLinkColor = Color.White;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 227);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 1;
            // 
            // FrmLogin
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(666, 333);
            Controls.Add(label2);
            Controls.Add(linkLabel1);
            Controls.Add(txtPassword);
            Controls.Add(linkLabel2);
            Controls.Add(btnLogin);
            Controls.Add(textBox2);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "FrmLogin";
            Opacity = 0.99D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }


        private Label label1;
        private TextBox txtUsername;
        private TextBox textBox2;
        private Button btnLogin;
        private LinkLabel linkLabel2;
        private TextBox txtPassword;
        private LinkLabel linkLabel1;
        private Label label2;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        #endregion
    }
}