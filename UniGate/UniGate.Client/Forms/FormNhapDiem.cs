using System;
using System.Linq;
using System.Windows.Forms;
using UniGate.Shared;
using UniGate.Application.DTOs.Score;
using UniGate.Client.Utils;

namespace UniGate.Client.Forms
{
    public partial class FormNhapDiem : Form
    {
        private Guid _userId;

        // ====== Danh sách môn cố định ======
        private readonly string[] AllSubjects =
        {
            "Vật Lý", "Hóa Học", "Sinh Học",
            "Lịch Sử", "Địa Lý", "GDKTPL",
            "Tiếng Anh", "Tiếng Nhật", "Tiếng Hàn",
            "Tiếng Pháp", "Tiếng Đức", "Tiếng Trung", "Tiếng Nga"
        };

        private readonly string[] Languages =
        {
            "Tiếng Anh", "Tiếng Nhật", "Tiếng Hàn",
            "Tiếng Pháp", "Tiếng Đức", "Tiếng Trung", "Tiếng Nga"
        };


        public FormNhapDiem()
        {
            InitializeComponent();

            // Test user
            _userId = Guid.Parse("11111111-1111-1111-1111-111111111111");

            // Load Ngoại Ngữ (Học Bạ)
            cbForeignLang.Items.AddRange(new string[]
            {
                "Tiếng Anh", "Tiếng Nhật", "Tiếng Hàn",
                "Tiếng Trung", "Tiếng Đức", "Tiếng Pháp", "Tiếng Nga"
            });

            // Load THPT môn tự chọn
            LoadSubjects();

            cbTHPT_Mon1.SelectedIndexChanged += Handle_THPT_Changed;
            cbTHPT_Mon2.SelectedIndexChanged += Handle_THPT_Changed;

            // Enable OwnerDraw để disable item
            cbTHPT_Mon1.DrawMode = DrawMode.OwnerDrawFixed;
            cbTHPT_Mon2.DrawMode = DrawMode.OwnerDrawFixed;

            cbTHPT_Mon1.DrawItem += ComboBox_DrawItem;
            cbTHPT_Mon2.DrawItem += ComboBox_DrawItem;

            cbTHPT_Mon1.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTHPT_Mon2.DropDownStyle = ComboBoxStyle.DropDownList;

            // Khu vực – đối tượng
            cbKhuVuc.Items.AddRange(new[] { "KV1", "KV2", "KV2-NT", "KV3" });
            cbDoiTuong.Items.AddRange(new[] { "ƯT1", "ƯT2" });
        }

        // ============================================================
        //          LOAD MÔN
        // ============================================================
        private void LoadSubjects()
        {
            cbTHPT_Mon1.Items.Clear();
            cbTHPT_Mon2.Items.Clear();

            foreach (var s in AllSubjects)
            {
                cbTHPT_Mon1.Items.Add(new ComboBoxItem(s));
                cbTHPT_Mon2.Items.Add(new ComboBoxItem(s));
            }
        }


        // ============================================================
        //       HANDLE LOGIC RÀNG BUỘC MÔN TỰ CHỌN
        // ============================================================
        private void Handle_THPT_Changed(object sender, EventArgs e)
        {
            ComboBox cb1 = cbTHPT_Mon1;
            ComboBox cb2 = cbTHPT_Mon2;

            var item1 = cb1.SelectedItem as ComboBoxItem;
            var item2 = cb2.SelectedItem as ComboBoxItem;

            // Reset Enable
            ResetEnableState(cb1);
            ResetEnableState(cb2);

            // Không cho 2 môn trùng nhau
            if (item1 != null && item2 != null && item1.Text == item2.Text)
            {
                MessageBox.Show("Hai môn tự chọn không được trùng nhau!");
                ((ComboBox)sender).SelectedIndex = -1;
                return;
            }

            // Nếu cb1 chọn ngoại ngữ → disable ngoại ngữ ở cb2
            if (item1 != null && Languages.Contains(item1.Text))
            {
                DisableLanguages(cb2);
            }
            // Nếu cb2 chọn ngoại ngữ → disable ngoại ngữ ở cb1
            else if (item2 != null && Languages.Contains(item2.Text))
            {
                DisableLanguages(cb1);
            }

            cb1.Refresh();
            cb2.Refresh();
        }


        private void ResetEnableState(ComboBox cb)
        {
            foreach (ComboBoxItem item in cb.Items)
            {
                item.Enabled = true;

                if (item.Text.Contains("(không chọn được)"))
                    item.Text = item.Text.Replace(" (không chọn được)", "");
            }
        }

        private void DisableLanguages(ComboBox cb)
        {
            foreach (ComboBoxItem item in cb.Items)
            {
                if (Languages.Contains(item.Text))
                {
                    item.Enabled = false;

                    if (!item.Text.Contains("(không chọn được)"))
                        item.Text += " (không chọn được)";
                }
            }
        }


        // ============================================================
        //            DRAW ITEM – ĐỂ ITEM DISABLED BỊ MÀU XÁM
        // ============================================================
        private void ComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            ComboBox cb = sender as ComboBox;
            ComboBoxItem item = cb.Items[e.Index] as ComboBoxItem;

            e.DrawBackground();

            var color = item.Enabled ? System.Drawing.Color.Black : System.Drawing.Color.Gray;

            using (var brush = new System.Drawing.SolidBrush(color))
            {
                e.Graphics.DrawString(item.Text, cb.Font, brush, e.Bounds);
            }

            e.DrawFocusRectangle();
        }


        // ============================================================
        //            BUTTON LƯU
        // ============================================================
        private async void btnSave_Click(object sender, EventArgs e)
        {
            var req = new UserScoreRequest
            {
                UserId = _userId,

                // HỌC BẠ
                HB_NgoaiNgu_Mon = cbForeignLang.Text,
                HB_Toan_10 = Parse(txt10_Toan),
                HB_Toan_11 = Parse(txt11_Toan),
                HB_Toan_12 = Parse(txt12_Toan),

                HB_Van_10 = Parse(txt10_Van),
                HB_Van_11 = Parse(txt11_Van),
                HB_Van_12 = Parse(txt12_Van),

                HB_Su_10 = Parse(txt10_Su),
                HB_Su_11 = Parse(txt11_Su),
                HB_Su_12 = Parse(txt12_Su),

                HB_Dia_10 = Parse(txt10_Dia),
                HB_Dia_11 = Parse(txt11_Dia),
                HB_Dia_12 = Parse(txt12_Dia),

                HB_GDKTPL_10 = Parse(txt10_GDKTPL),
                HB_GDKTPL_11 = Parse(txt11_GDKTPL),
                HB_GDKTPL_12 = Parse(txt12_GDKTPL),

                HB_Ly_10 = Parse(txt10_Ly),
                HB_Ly_11 = Parse(txt11_Ly),
                HB_Ly_12 = Parse(txt12_Ly),

                HB_Hoa_10 = Parse(txt10_Hoa),
                HB_Hoa_11 = Parse(txt11_Hoa),
                HB_Hoa_12 = Parse(txt12_Hoa),

                HB_Sinh_10 = Parse(txt10_Sinh),
                HB_Sinh_11 = Parse(txt11_Sinh),
                HB_Sinh_12 = Parse(txt12_Sinh),

                HB_Tin_10 = Parse(txt10_Tin),
                HB_Tin_11 = Parse(txt11_Tin),
                HB_Tin_12 = Parse(txt12_Tin),

                HB_CongNghe_10 = Parse(txt10_CongNghe),
                HB_CongNghe_11 = Parse(txt11_CongNghe),
                HB_CongNghe_12 = Parse(txt12_CongNghe),

                HB_NgoaiNgu_10 = Parse(txt10_NN),
                HB_NgoaiNgu_11 = Parse(txt11_NN),
                HB_NgoaiNgu_12 = Parse(txt12_NN),

                // THPT
                Thpt_Toan = Parse(txtTHPT_Toan),
                Thpt_Van = Parse(txtTHPT_Van),

                Thpt_TuChon1_Mon = cbTHPT_Mon1.Text,
                Thpt_TuChon1_Diem = Parse(txtTHPT_Mon1),

                Thpt_TuChon2_Mon = cbTHPT_Mon2.Text,
                Thpt_TuChon2_Diem = Parse(txtTHPT_Mon2),

                // ĐGNL
                DGNL_NgonNgu = Parse(txtDgnl_NgonNgu),
                DGNL_Toan = Parse(txtDgnl_Toan),
                DGNL_TuDuy = Parse(txtDgnl_TuDuy),

                // ƯU TIÊN
                KhuVuc = cbKhuVuc.Text,
                DoiTuong = cbDoiTuong.Text,
                DiemCongThem = Parse(txtDiemCong)
            };

            var result = await ApiClient.PostAsync("api/user-scores/save", req);

            MessageBox.Show("Lưu thành công!");
        }

        private float? Parse(TextBox txt)
        {
            if (float.TryParse(txt.Text, out float v))
                return v;
            return null;
        }
    }

    // ============================================================
    //     CLASS COMBOBOX ITEM (ENABLE / DISABLE)
    // ============================================================
    public class ComboBoxItem
    {
        public string Text { get; set; }
        public bool Enabled { get; set; } = true;

        public ComboBoxItem(string text)
        {
            Text = text;
        }

        public override string ToString() => Text;
    }
}

