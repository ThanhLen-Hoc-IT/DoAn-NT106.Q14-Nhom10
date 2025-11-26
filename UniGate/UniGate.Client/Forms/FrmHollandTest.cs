using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using UniGate.Client.Models;   // nhớ có dòng này

namespace UniGate.Client.Forms
{
    public partial class FrmHollandTest : Form
    {
        // Danh sách câu hỏi
        private readonly List<HollandQuestion> _questions;

        // Lưu đáp án: key = Id câu hỏi, value = điểm 1..5
        private readonly Dictionary<int, int> _answers = new();

        // Index câu hiện tại trong _questions
        private int _currentIndex = 0;

        public FrmHollandTest()
        {
            InitializeComponent();

            // Lấy câu hỏi từ ngân hàng
            _questions = HollandQuestionBank.GetQuestions() ?? new List<HollandQuestion>();

            // Tạo 60 nút số câu
            BuildQuestionButtons();
        }

        private void FrmHollandTest_Load(object sender, EventArgs e)
        {
            if (_questions.Count > 0)
            {
                ShowQuestion(0);
            }
        }

        #region UI helper

        private void BuildQuestionButtons()
        {
            flowQuestions.Controls.Clear();

            for (int i = 0; i < _questions.Count; i++)
            {
                var btn = new Button
                {
                    Width = 40,
                    Height = 40,
                    Margin = new Padding(5),
                    Text = (i + 1).ToString(),
                    Tag = i, // lưu index
                    FlatStyle = FlatStyle.Flat,
                    BackColor = Color.White
                };

                btn.Click += QuestionIndexButton_Click;
                flowQuestions.Controls.Add(btn);
            }
        }

        private void QuestionIndexButton_Click(object sender, EventArgs e)
        {
            int index = (int)((Button)sender).Tag;
            ShowQuestion(index);
        }

        private void ShowQuestion(int index)
        {
            if (index < 0 || index >= _questions.Count)
                return;

            _currentIndex = index;
            var q = _questions[index];

            lblCurrentQuestion.Text = $"Question {index + 1}";
            lblQuestionTitle.Text = "Mức độ yêu thích với hoạt động:";
            lblQuestionText.Text = q.Text;

            // highlight nút số câu hiện tại
            for (int i = 0; i < flowQuestions.Controls.Count; i++)
            {
                if (flowQuestions.Controls[i] is Button b)
                {
                    b.BackColor = (i == index) ? Color.LightSkyBlue : Color.White;
                }
            }

            // Reset màu 5 nút 1..5
            ResetRatingButtonsColor();

            // Nếu đã trả lời rồi thì tô lại nút tương ứng
            if (_answers.TryGetValue(q.Id, out var point))
            {
                HighlightRating(point);
            }

            UpdateProgress();
        }

        private void ResetRatingButtonsColor()
        {
            Button[] btns = { btnRate1, btnRate2, btnRate3, btnRate4, btnRate5 };
            foreach (var b in btns)
            {
                b.BackColor = Color.Gainsboro;
                b.ForeColor = Color.Black;
            }
        }

        private void HighlightRating(int point)
        {
            Button[] btns = { btnRate1, btnRate2, btnRate3, btnRate4, btnRate5 };
            ResetRatingButtonsColor();

            if (point >= 1 && point <= 5)
            {
                btns[point - 1].BackColor = Color.RoyalBlue;
                btns[point - 1].ForeColor = Color.White;
            }
        }

        private void UpdateProgress()
        {
            int answered = _answers.Count;
            int total = _questions.Count;

            progressBar.Maximum = total == 0 ? 1 : total;
            progressBar.Value = Math.Min(answered, progressBar.Maximum);
            lblProgress.Text = $"{answered} / {total}";
        }

        #endregion

        #region Rating buttons

        private void RatingButton_Click(object sender, EventArgs e)
        {
            if (_currentIndex < 0 || _currentIndex >= _questions.Count)
                return;

            var btn = (Button)sender;
            int point = int.Parse(btn.Tag.ToString());  // 1..5

            var q = _questions[_currentIndex];
            _answers[q.Id] = point; // LƯU ĐÁP ÁN

            HighlightRating(point);
            UpdateProgress();
        }

        private void btnRate1_Click(object sender, EventArgs e) => RatingButton_Click(sender, e);
        private void btnRate2_Click(object sender, EventArgs e) => RatingButton_Click(sender, e);
        private void btnRate3_Click(object sender, EventArgs e) => RatingButton_Click(sender, e);
        private void btnRate4_Click(object sender, EventArgs e) => RatingButton_Click(sender, e);
        private void btnRate5_Click(object sender, EventArgs e) => RatingButton_Click(sender, e);

        #endregion

        #region Điều hướng câu hỏi

        private void btnPrev_Click(object sender, EventArgs e)
        {
            int newIndex = _currentIndex - 1;
            if (newIndex < 0) newIndex = 0;
            ShowQuestion(newIndex);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int newIndex = _currentIndex + 1;
            if (newIndex >= _questions.Count)
            {
                // Hết câu -> nộp bài
                SubmitTest();
            }
            else
            {
                ShowQuestion(newIndex);
            }
        }

        #endregion

        #region Tính điểm & mở form kết quả

        private void SubmitTest()
        {
            if (_questions.Count == 0) return;

            int scoreR = 0, scoreI = 0, scoreA = 0, scoreS = 0, scoreE = 0, scoreC = 0;

            foreach (var q in _questions)
            {
                if (!_answers.TryGetValue(q.Id, out int point))
                    continue;

                switch (q.Group)
                {
                    case 'R': scoreR += point; break;
                    case 'I': scoreI += point; break;
                    case 'A': scoreA += point; break;
                    case 'S': scoreS += point; break;
                    case 'E': scoreE += point; break;
                    case 'C': scoreC += point; break;
                }
            }

            var scores = new Dictionary<string, int>
            {
                ["R"] = scoreR,
                ["I"] = scoreI,
                ["A"] = scoreA,
                ["S"] = scoreS,
                ["E"] = scoreE,
                ["C"] = scoreC
            };

            using (var f = new FrmHollandResult(scores))
            {
                f.ShowDialog();
            }
        }

        #endregion
    }
}
