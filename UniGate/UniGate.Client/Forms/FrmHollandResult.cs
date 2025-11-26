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
    public partial class FrmHollandResult : Form
    {
        private readonly Dictionary<string, int> _scores;

        public FrmHollandResult(Dictionary<string, int> scores)
        {
            InitializeComponent();
            _scores = scores ?? new Dictionary<string, int>();
        }

        public FrmHollandResult() : this(new Dictionary<string, int>())
        {
        }

        private void FrmHollandResult_Load(object sender, EventArgs e)
        {
            int rScore = _scores.TryGetValue("R", out var vr) ? vr : 0;
            int iScore = _scores.TryGetValue("I", out var vi) ? vi : 0;
            int aScore = _scores.TryGetValue("A", out var va) ? va : 0;
            int sScore = _scores.TryGetValue("S", out var vs) ? vs : 0;
            int eScore = _scores.TryGetValue("E", out var ve) ? ve : 0;
            int cScore = _scores.TryGetValue("C", out var vc) ? vc : 0;

            // 6 dòng điểm chi tiết
            lblR.Text = $"Realistic (R): {rScore}";
            lblI.Text = $"Investigative (I): {iScore}";
            lblA.Text = $"Artistic (A): {aScore}";
            lblS.Text = $"Social (S): {sScore}";
            lblE.Text = $"Enterprising (E): {eScore}";
            lblC.Text = $"Conventional (C): {cScore}";

            // Tính mã Holland + top 3 để show ở panel xanh
            var list = new List<(string Code, int Score)>
            {
                ("R", rScore),
                ("I", iScore),
                ("A", aScore),
                ("S", sScore),
                ("E", eScore),
                ("C", cScore)
            };

            var ordered = list.OrderByDescending(x => x.Score).ToList();
            string hollandCode = string.Concat(ordered.Select(x => x.Code));   // ví dụ "RIASEC"
            string top3 = string.Join(" - ", ordered.Take(3).Select(x => x.Code));

            lblYourCodeValue.Text = hollandCode;
            lblTop3Value.Text = top3;

            // tuỳ bạn: txtSummary có thể tự điền gợi ý hoặc để trống cho user xem sau
            // txtSummary.Text = "...";
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelDetail_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
