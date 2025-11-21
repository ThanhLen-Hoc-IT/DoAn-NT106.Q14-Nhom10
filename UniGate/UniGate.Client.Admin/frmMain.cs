using System.Threading.Tasks.Dataflow;

namespace UniGate.Client.Admin
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnQuizMenu_Click(object sender, EventArgs e)
        {
            quizContextMenu.Show(btnQuizMenu, new Point(0, btnQuizMenu.Height));
        }

        private void btnScoreMenu_Click(object sender, EventArgs e)
        {
            scoreContextMenu.Show(btnScoreMenu, new Point(0, btnScoreMenu.Height));
        }

        private void btnUniversityMenu_Click(object sender, EventArgs e)
        {
            universityContextMenu.Show(btnUniversityMenu, new Point(0, btnUniversityMenu.Height));
        }

        private void btnMajorMenu_Click(object sender, EventArgs e)
        {
            majorContextMenu.Show(btnMajorMenu, new Point(0, btnMajorMenu.Height));
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

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
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked the Logout button!");
        }

        private void btnQuizMenu_MouseLeave(object sender, EventArgs e)
        {
            // Lệnh này sẽ ẩn ContextMenuStrip đi.
            // Dùng Hide() hoặc Close() tùy theo framework/loại control chính xác.
            // Nếu dùng ContextMenuStrip, Hide() hoặc Close() đều hoạt động
            // Hoặc: quizContextMenu.Close();
            if (!quizContextMenu.Bounds.Contains(Cursor.Position))
            {
                quizContextMenu.Hide();
            }

        }

        private void quizContextMenu_MouseLeave(object sender, EventArgs e)
        {
            quizContextMenu.Hide();
        }

        private void btnScoreMenu_MouseLeave(object sender, EventArgs e)
        {
            if (!scoreContextMenu.Bounds.Contains(Cursor.Position))
            {
                scoreContextMenu.Hide();
            }
        }

        private void btnUniversityMenu_MouseLeave(object sender, EventArgs e)
        {
            if (!universityContextMenu.Bounds.Contains(Cursor.Position))
            {
                universityContextMenu.Hide();
            }
        }

        private void btnMajorMenu_MouseLeave(object sender, EventArgs e)
        {
            if (!majorContextMenu.Bounds.Contains(Cursor.Position))
            {
                majorContextMenu.Hide();
            }
        }

        private void scoreContextMenu_MouseLeave(object sender, EventArgs e)
        {
            scoreContextMenu.Hide();
        }

        private void universityContextMenu_MouseLeave(object sender, EventArgs e)
        {
            universityContextMenu.Hide();
        }

        private void majorContextMenu_MouseLeave(object sender, EventArgs e)
        {
            majorContextMenu.Hide();
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
