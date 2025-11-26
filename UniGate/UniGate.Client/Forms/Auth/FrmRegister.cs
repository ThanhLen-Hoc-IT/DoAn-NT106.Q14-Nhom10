using System;
using System.Windows.Forms;

namespace UniGate.Client.Forms.Auth
{
    public partial class FrmRegister : Form
    {
        // để Login lấy lại email sau khi đăng ký
        public string RegisteredEmail { get; private set; }

        public FrmRegister()
        {
            InitializeComponent();
        }

        // Button Sign Up
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;
            string confirm = txtConfirmPassword.Text;

            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill all required fields.");
                return;
            }

            if (password != confirm)
            {
                MessageBox.Show("Password and Confirm Password do not match.");
                return;
            }

            // TODO: sau này gọi API /register ở đây
            // demo: coi như đăng ký thành công
            MessageBox.Show("Sign up successfully!", "Success");

            RegisteredEmail = email;

            // Trả về cho Login biết là đăng ký OK
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // Link: "Already have an account? Login right now"
        private void lnkGoLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Người dùng hủy đăng ký, quay về Login
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
