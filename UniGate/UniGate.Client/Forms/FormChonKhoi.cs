using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using UniGate.Client.Models;
using UniGate.Client.Utils;


namespace UniGate.Client
{
    public partial class FormChonKhoi : Form
    {
        private Dictionary<string, float> _dsDiemToHop = new();


        // DTO

        public class ComboInfo
        {
            public string Code { get; set; }
            public List<string> Subjects { get; set; }
        }

        private int ExtractNumber(string code)
        {
            // Lấy phần số trong chuỗi (vd: "A00" -> "00")
            string num = new string(code.Where(char.IsDigit).ToArray());
            return int.TryParse(num, out int n) ? n : 0;
        }




        private List<ComboInfo> _combos;
        private UserScoreResponse _scores;
        // Danh sách tổ hợp người dùng đã tick (A00, A01,...)
        private List<string> _selectedCombos = new List<string>();


        public FormChonKhoi()
        {
            InitializeComponent();
        }

        private async void FormChonKhoi_Load(object sender, EventArgs e)
        {
            SessionManager.UserId = Guid.Parse("11111111-1111-1111-1111-111111111111");

            try
            {
                // Lấy điểm người dùng 
                try
                {
                    _scores = await ApiClient.GetAsync<UserScoreResponse>(
                        $"api/user-scores/{SessionManager.UserId}");
                }
                catch
                {
                    _scores = new UserScoreResponse();   // tránh null
                }

                // Lấy tổ hợp 
                _combos = await ApiClient.GetAsync<List<ComboInfo>>(
                    "api/combos/with-subjects");

                // sắp xếp cho đẹp thoai
                _combos = _combos
                    .OrderBy(c => c.Code.Substring(0, 1))     // Sắp theo chữ cái A, B, C, D...
                    .ThenBy(c => ExtractNumber(c.Code))       // Sắp theo số 00, 01, 02...
                    .ToList();


                if (_combos == null)
                    _combos = new List<ComboInfo>();

                // Null protection cho từng combo
                foreach (var c in _combos)
                    c.Subjects ??= new List<string>();

                // Cấu hình listview 
                listViewKhoi.View = View.Details;
                listViewKhoi.FullRowSelect = true;
                listViewKhoi.CheckBoxes = true;
                listViewKhoi.GridLines = true;

                listViewKhoi.Columns.Clear();
                listViewKhoi.Columns.Add("Tổ hợp", 80);
                listViewKhoi.Columns.Add("Điểm", 70);
                listViewKhoi.Columns.Add("Chi tiết", 300);

                // Hiển thị
                HienThiDiemToHop();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu:\n" + ex.Message);
            }
            MessageBox.Show(JsonConvert.SerializeObject(_scores, Formatting.Indented));


        }

        private float? GetSubjectScore(string mon)
        {
            if (_scores == null) return null;
            var s = _scores;

            // ===== Tính TB 3 năm học bạ =====
            float? TinhTb(float? a, float? b, float? c)
            {
                if (a == null || b == null || c == null) return null;
                return (a.Value + b.Value + c.Value) / 3f;
            }

            // ===== Các môn ngoại ngữ =====
            string[] allLang =
            {
        "Tiếng Anh", "Tiếng Nhật", "Tiếng Hàn",
        "Tiếng Pháp", "Tiếng Đức", "Tiếng Trung", "Tiếng Nga"
    };

            // Nếu tổ hợp yêu cầu ngoại ngữ → dùng điểm ngoại ngữ chung
            if (allLang.Contains(mon))
            {
                // THPT: nếu user chọn ngoại ngữ ở THPT
                if (s.Thpt_TuChon1_Mon == mon) return s.Thpt_TuChon1_Diem;
                if (s.Thpt_TuChon2_Mon == mon) return s.Thpt_TuChon2_Diem;

                // Học bạ: dùng TB Ngoại ngữ 10-11-12
                return TinhTb(s.HB_NgoaiNgu_10, s.HB_NgoaiNgu_11, s.HB_NgoaiNgu_12);
            }

            // ===== Các môn khác =====
            return mon switch
            {
                "Toán" => s.Thpt_Toan ??
                          TinhTb(s.HB_Toan_10, s.HB_Toan_11, s.HB_Toan_12),

                "Ngữ văn" => s.Thpt_Van ??
                             TinhTb(s.HB_Van_10, s.HB_Van_11, s.HB_Van_12),

                "Vật lí" => (s.Thpt_TuChon1_Mon == "Vật Lý" ? s.Thpt_TuChon1_Diem :
                             s.Thpt_TuChon2_Mon == "Vật Lý" ? s.Thpt_TuChon2_Diem : null)
                             ?? TinhTb(s.HB_Ly_10, s.HB_Ly_11, s.HB_Ly_12),

                "Hóa học" => (s.Thpt_TuChon1_Mon == "Hóa Học" ? s.Thpt_TuChon1_Diem :
                              s.Thpt_TuChon2_Mon == "Hóa Học" ? s.Thpt_TuChon2_Diem : null)
                              ?? TinhTb(s.HB_Hoa_10, s.HB_Hoa_11, s.HB_Hoa_12),

                "Sinh học" => (s.Thpt_TuChon1_Mon == "Sinh Học" ? s.Thpt_TuChon1_Diem :
                               s.Thpt_TuChon2_Mon == "Sinh Học" ? s.Thpt_TuChon2_Diem : null)
                               ?? TinhTb(s.HB_Sinh_10, s.HB_Sinh_11, s.HB_Sinh_12),

                "Lịch sử" => (s.Thpt_TuChon1_Mon == "Lịch Sử" ? s.Thpt_TuChon1_Diem :
                              s.Thpt_TuChon2_Mon == "Lịch Sử" ? s.Thpt_TuChon2_Diem : null)
                              ?? TinhTb(s.HB_Su_10, s.HB_Su_11, s.HB_Su_12),

                "Địa lí" => (s.Thpt_TuChon1_Mon == "Địa Lý" ? s.Thpt_TuChon1_Diem :
                              s.Thpt_TuChon2_Mon == "Địa Lý" ? s.Thpt_TuChon2_Diem : null)
                              ?? TinhTb(s.HB_Dia_10, s.HB_Dia_11, s.HB_Dia_12),

                "GDKTPL" => (s.Thpt_TuChon1_Mon == "GDKTPL" ? s.Thpt_TuChon1_Diem :
                              s.Thpt_TuChon2_Mon == "GDKTPL" ? s.Thpt_TuChon2_Diem : null)
                              ?? TinhTb(s.HB_GDKTPL_10, s.HB_GDKTPL_11, s.HB_GDKTPL_12),

                _ => null
            };
        }




        private void HienThiDiemToHop()
        {
            listViewKhoi.Items.Clear();
            List<(string Code, float Score, string Detail)> dsDiem = new();

            float diemUuTien = TinhDiemUuTien();

            foreach (var c in _combos)
            {
                float tong = 0;
                bool hopLe = true;
                string detail = "";

                foreach (string mon in c.Subjects)
                {
                    float? diem = GetSubjectScore(mon);

                    if (diem == null)
                    {
                        hopLe = false;
                        break;
                    }

                    tong += diem.Value;


                    detail += $"{mon} + ";
                }

                if (!hopLe) continue;


                detail = detail.TrimEnd('+', ' ');

                // CỘNG ĐIỂM ƯU TIÊN
                float tongSauUuTien = tong + diemUuTien;

                dsDiem.Add((c.Code, tongSauUuTien, detail));

                var item = new ListViewItem(c.Code);
                item.SubItems.Add(tongSauUuTien.ToString("0.00"));
                item.SubItems.Add(detail);

                listViewKhoi.Items.Add(item);
            }

            // top 3 tổ hợp gợi ý
            var top3 = dsDiem.OrderByDescending(x => x.Score).Take(3).ToList();

            if (top3.Count >= 1)
                lblTop1.Text = $"{top3[0].Code} – {top3[0].Score:0.00}";
            if (top3.Count >= 2)
                lblTop2.Text = $"{top3[1].Code} – {top3[1].Score:0.00}";
            if (top3.Count >= 3)
                lblTop3.Text = $"{top3[2].Code} – {top3[2].Score:0.00}";
        }

        private float TinhDiemUuTien()
        {
            float cong = 0;

            // KHU VỰC 
            switch (_scores.KhuVuc)
            {
                case "KV1": cong += 0.75f; break;
                case "KV2": cong += 0.25f; break;
                case "KV2-NT": cong += 0.25f; break;
                case "KV3": cong += 0f; break;
            }

            //  ĐỐI TƯỢNG 
            switch (_scores.DoiTuong)
            {
                case "ƯT1": cong += 2f; break;
                case "ƯT2": cong += 1f; break;
                default: cong += 0; break;
            }

            // ĐIỂM CỘNG THÊM 
            if (_scores.DiemCongThem != null)
                cong += _scores.DiemCongThem.Value;

            return cong;
        }







        private async void btnXemNganh_Click_1(object sender, EventArgs e)
        {
            if (_selectedCombos.Count == 0)
            {
                MessageBox.Show("Bạn phải chọn ít nhất một tổ hợp!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //  Gửi API lưu tổ hợp đã chọn
            var req = new
            {
                UserId = SessionManager.UserId,
                ComboCodes = _selectedCombos
            };

            await ApiClient.PostAsync("api/user-combos/select", req);

            // Sau khi lưu thành công ->mở form ngành
            var frm = new FormNganhTheoKhoi(_selectedCombos);
            frm.ShowDialog();

        }



        private void ListViewKhoi_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            string code = e.Item.SubItems[0].Text; // Mã tổ hợp: A00, A01,...

            if (e.Item.Checked)
            {
                if (!_selectedCombos.Contains(code))
                    _selectedCombos.Add(code);
            }
            else
            {
                _selectedCombos.Remove(code);
            }
        }

        
    }
}
