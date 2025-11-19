using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace UniGate.Client.Forms.Auth
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }



        private bool CheckLogin(string username, string password)
        {
            // Tài khoản mẫu
            string correctUser = "User Name";
            string correctPass = "Password";

            if (username == correctUser && password == correctPass)
                return true;

            return false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text.Trim();
            string pass = txtPassword.Text.Trim();

            // Kiểm tra người dùng không nhập gì
            if (user == "" || pass == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Username và Password!");
                return;
            }

            // Gọi hàm kiểm tra
            if (CheckLogin(user, pass))
            {
                MessageBox.Show("Đăng nhập thành công!");


                // Mở Form mới sau khi login OK
                //MainForm mainForm = new MainForm();
                //mainForm.Show();

                this.Hide();   // Ẩn form login nếu muốn
                frmMain mainForm = new frmMain();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
            }
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
        }
    }
}
