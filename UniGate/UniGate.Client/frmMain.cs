using System.Threading.Tasks.Dataflow;
using System.Drawing;
using UniGate.Client.Forms.TraCuuNganhTruong;

namespace UniGate.Client
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void lblQuiz_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked the Quiz label!");
        }

        private void lblQuizResults_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked the Quiz Results label!");
        }

        private void lblInputScore_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked the Input Score label!");
        }

        private void lblScoreManagement_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked the Score Management label!");
        }

        private void lblScorePercentile_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked the Score Percentile label!");
        }

        private void lblScoreConversion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked the Score Conversion label!");
        }

        private void lblMajorByInterest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked the Major By Interest label!");
            NganhTheoSoThich nganhTheoSoThichForm = new NganhTheoSoThich();
            nganhTheoSoThichForm.Show();

        }
        private void lblMajorByScore_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked the Major By Score label!");
        }

        private void lblMajorByBlock_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked the Major By Block label!");
        }

        private void lblMajorRecommend_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked the Major Recommend label!");
            NganhPhuHop nganhPhuHopForm = new NganhPhuHop();
            nganhPhuHopForm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked the Logout button!");
        }

       
        private void Label_MouseEnter(object sender, EventArgs e)
        {
            // Ép kiểu (cast) đối tượng sender thành Label
            Label currentLabel = sender as Label;

            // Kiểm tra để đảm bảo đối tượng này là Label (luôn làm việc này để tránh lỗi)
            if (currentLabel != null)
            {
                // Lưu màu gốc vào Tag (Optional nhưng nên làm nếu m không chắc màu gốc là gì)
                // Dùng Tag để lưu trữ thông tin tạm thời.
                currentLabel.Tag = currentLabel.BackColor;

                // Đổi màu nền khi chuột vào (m có thể chọn màu tùy ý)
                currentLabel.BackColor = Color.LightBlue;
                // Đổi màu chữ nếu cần để dễ nhìn
                currentLabel.ForeColor = Color.Black;
            }
        }

        private void Label_MouseLeave(object sender, EventArgs e)
        {
            // Ép kiểu (cast) đối tượng sender thành Label
            Label currentLabel = sender as Label;

            if (currentLabel != null)
            {
                // Hoàn lại màu nền về màu gốc
                // Nếu m đã lưu màu vào Tag, m có thể lấy ra:
                if (currentLabel.Tag != null && currentLabel.Tag is Color)
                {
                    currentLabel.BackColor = (Color)currentLabel.Tag;
                }
                else
                {
                    // Nếu không lưu Tag, m đặt lại màu mặc định của m
                    currentLabel.BackColor = Color.Transparent; // Ví dụ: Transparent
                }

                // Hoàn lại màu chữ mặc định
                currentLabel.ForeColor = Color.Black; // Ví dụ: DarkGray
            }
        }

    }
}
