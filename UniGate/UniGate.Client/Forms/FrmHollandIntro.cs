using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace UniGate.Client.Forms
{
    public partial class FrmHollandIntro : Form
    {
        public FrmHollandIntro()
        {
            InitializeComponent();
        }

        private void btnStartTest_Click(object sender, EventArgs e)
        {
            // Mở form làm bài test Holland
            var testForm = new FrmHollandTest
            {
                StartPosition = FormStartPosition.CenterScreen
            };

            this.Hide();
            testForm.ShowDialog();   // chờ làm xong, đóng form test
            this.Show();             // quay lại màn giới thiệu
        }
    }
}

