using System;
using System.Collections.Generic;
using System.Drawing; // Cần thiết nếu dùng các đối tượng màu sắc/font, nên có
using System.Linq;
using System.Windows.Forms;
// Nếu bạn đặt Models và Services trong namespace khác, bạn cần thêm using ở đây
// Ví dụ: using ProjectName.Models;
// Ví dụ: using ProjectName.Services;


// *************************************************************************
// THAY THẾ 'YourProjectNamespace' bằng tên Namespace chính của Project bạn
// *************************************************************************
namespace YourProjectNamespace
{
    // --- LỚP RESULTSMAJOR (Lớp Form, phải là lớp đầu tiên trong file nếu không có namespace) ---
    public partial class ResultsMajor : Form
    {
        private AdmissionService _admissionService = new AdmissionService();
        private List<AdmissionData> _allAdmissionData;

        public ResultsMajor()
        {
            // InitializeComponent() là hàm khởi tạo tất cả controls, KHÔNG ĐƯỢC XÓA!
            InitializeComponent();

            // Tải dữ liệu và khởi tạo controls khi Form được tạo
            LoadInitialData();
            SetupDataGridView();
        }

        private void LoadInitialData()
        {
            // 1. Tải toàn bộ dữ liệu điểm chuẩn khi khởi động (chỉ 1 lần)
            try
            {
                // Gọi hàm lấy dữ liệu từ service (hiện tại là hardcode)
                _allAdmissionData = _admissionService.GetAdmissionDataFromDatabaseOrAPI();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _allAdmissionData = new List<AdmissionData>(); // Khởi tạo rỗng nếu lỗi
            }

            // 2. Điền dữ liệu cho ComboBox Tổ hợp môn
            // Lấy danh sách tổ hợp môn duy nhất từ dữ liệu điểm chuẩn
            var combinations = _allAdmissionData
                                .Select(d => d.CombinationCode)
                                .Distinct()
                                .OrderBy(c => c)
                                .ToList();

            // SỬA: ComboBox DataSource chỉ cần gán List<string> là đủ
            cboToHop.DataSource = combinations;
            cboToHop.SelectedIndex = -1; // Không chọn mặc định

            // 3. (Tùy chọn) Điền dữ liệu cho ComboBox Chọn vùng
            cboChonVung.Items.AddRange(new object[] { "Khu vực 1 (KV1)", "Khu vực 2 (KV2)", "Khu vực 3 (KV3)" });
            cboChonVung.SelectedIndex = -1;
        }

        private void SetupDataGridView()
        {
            // Cài đặt hiển thị cho DataGridView
            dgvKetQua.AutoGenerateColumns = false;

            // ... (Phần Setup Cột này đã đúng) ...

            // Khai báo các cột hiển thị theo thứ tự bạn muốn
            dgvKetQua.Columns.Add("UniversityName", "Trường");
            dgvKetQua.Columns.Add("MajorCode", "Mã Ngành");
            dgvKetQua.Columns.Add("MajorName", "Tên Ngành");
            dgvKetQua.Columns.Add("BenchmarkScore", "Điểm Chuẩn");
            dgvKetQua.Columns.Add("ScoreDifference", "Chênh Lệch");
            dgvKetQua.Columns.Add("Probability", "Khả Năng");

            // Gán thuộc tính DataPropertyName để mapping với Model
            dgvKetQua.Columns["UniversityName"].DataPropertyName = "UniversityName";
            dgvKetQua.Columns["MajorCode"].DataPropertyName = "MajorCode";
            dgvKetQua.Columns["MajorName"].DataPropertyName = "MajorName";
            dgvKetQua.Columns["BenchmarkScore"].DataPropertyName = "BenchmarkScore";
            dgvKetQua.Columns["ScoreDifference"].DataPropertyName = "ScoreDifference";
            dgvKetQua.Columns["Probability"].DataPropertyName = "Probability";

            // Định dạng cột Điểm
            dgvKetQua.Columns["BenchmarkScore"].DefaultCellStyle.Format = "N2";
            dgvKetQua.Columns["ScoreDifference"].DefaultCellStyle.Format = "N2";

            // Định dạng màu chữ cho cột Khả năng
            dgvKetQua.CellFormatting += DgvKetQua_CellFormatting;
        }

        // Hàm này giúp tô màu Khả năng đậu cho dễ nhìn
        private void DgvKetQua_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgvKetQua.Columns["Probability"].Index && e.RowIndex >= 0)
            {
                var probability = e.Value.ToString();

                if (probability.Contains("Rất Cao"))
                {
                    e.CellStyle.ForeColor = Color.Green;
                }
                else if (probability.Contains("Cao"))
                {
                    e.CellStyle.ForeColor = Color.DarkGreen;
                }
                else if (probability.Contains("Cân nhắc"))
                {
                    e.CellStyle.ForeColor = Color.Orange;
                }
                else if (probability.Contains("Khó"))
                {
                    e.CellStyle.ForeColor = Color.Red;
                }
            }
        }

        // Xử lý sự kiện khi nhấn nút "Xem Gợi Ý"
        private void btnXemGoiY_Click(object sender, EventArgs e)
        {
            // 1. Validate và Lấy dữ liệu Đầu vào

            // 1.1. Lấy Tổng điểm (điểm thi) và Điểm Ưu tiên
            double tongDiemThi, diemUT;

            // Phải nhập Tổng điểm thi
            if (!double.TryParse(txtTongDiem.Text, out tongDiemThi) || tongDiemThi <= 0)
            {
                MessageBox.Show("Vui lòng nhập Tổng điểm thi hợp lệ và lớn hơn 0.", "Lỗi Dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTongDiem.Focus();
                return;
            }

            // Nếu không nhập Điểm UT, coi như 0
            if (!double.TryParse(txtDiemUT.Text, out diemUT))
            {
                diemUT = 0;
            }

            // Tính tổng điểm cuối cùng
            double finalScore = tongDiemThi + diemUT;

            // 1.2. Lấy Tổ hợp môn
            // SỬA: Khi DataSource đã được gán List<string>, dùng SelectedItem.ToString()
            string selectedCombination = cboToHop.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedCombination))
            {
                MessageBox.Show("Vui lòng chọn Tổ hợp môn.", "Lỗi Dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var userInput = new UserInput
            {
                UserTotalScore = finalScore,
                SelectedCombination = selectedCombination
            };

            // 2. Thực hiện Logic So sánh
            var possibleMajors = _admissionService.FindPossibleMajors(userInput, _allAdmissionData);

            // 3. Hiển thị Kết quả lên DataGridView

            // Gán nguồn dữ liệu
            dgvKetQua.DataSource = possibleMajors;

            // Nếu không tìm thấy
            if (possibleMajors.Count == 0)
            {
                MessageBox.Show($"Không tìm thấy ngành nào phù hợp với điểm {finalScore} và tổ hợp {selectedCombination}.", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }

    // *************************************************************************
    // LỚP ADMISSIONSERVICE (đã chuyển vào namespace và đặt sau Form)
    // *************************************************************************
    public class AdmissionService
    {
        // Hàm giả định lấy dữ liệu từ DB/API (Bạn cần thay thế bằng code thật)
        public List<AdmissionData> GetAdmissionDataFromDatabaseOrAPI()
        {
            // ... (Giữ nguyên code Hardcode mẫu của bạn) ...
            return new List<AdmissionData>
            {
                new AdmissionData { UniversityName = "ĐH Bách Khoa HN", MajorCode = "CNTT1", MajorName = "Công nghệ thông tin", CombinationCode = "A00", BenchmarkScore = 27.5 },
                new AdmissionData { UniversityName = "ĐH Kinh tế QT", MajorCode = "KTE1", MajorName = "Kinh tế học", CombinationCode = "A01", BenchmarkScore = 26.0 },
                new AdmissionData { UniversityName = "ĐH Quốc Gia", MajorCode = "TOAN", MajorName = "Khoa học Máy tính", CombinationCode = "A00", BenchmarkScore = 25.5 },
                new AdmissionData { UniversityName = "ĐH Y Dược", MajorCode = "YDHN", MajorName = "Y khoa", CombinationCode = "B00", BenchmarkScore = 28.5 },
                new AdmissionData { UniversityName = "ĐH Sư Phạm", MajorCode = "VAN", MajorName = "Văn học", CombinationCode = "C00", BenchmarkScore = 23.5 },
                new AdmissionData { UniversityName = "ĐH Ngoại Thương", MajorCode = "KTHN", MajorName = "Kinh tế", CombinationCode = "A00", BenchmarkScore = 27.0 },
                new AdmissionData { UniversityName = "ĐH Ngoại Thương", MajorCode = "KTHN", MajorName = "Kinh tế", CombinationCode = "D01", BenchmarkScore = 26.5 }
            };
        }

        // Hàm chính để lọc và so sánh điểm
        public List<AdmissionData> FindPossibleMajors(UserInput userInput, List<AdmissionData> allAdmissionData)
        {
            var filteredMajors = new List<AdmissionData>();

            // 1. Lọc theo Tổ hợp môn
            var matchingMajors = allAdmissionData
                .Where(d => d.CombinationCode.Equals(userInput.SelectedCombination, StringComparison.OrdinalIgnoreCase))
                .ToList();

            // 2. Tính toán chênh lệch và Khả năng đậu
            foreach (var data in matchingMajors)
            {
                // Tạo một bản sao (clone)
                var result = new AdmissionData
                {
                    UniversityName = data.UniversityName,
                    MajorCode = data.MajorCode,
                    MajorName = data.MajorName,
                    BenchmarkScore = data.BenchmarkScore,
                    CombinationCode = data.CombinationCode
                };

                result.ScoreDifference = userInput.UserTotalScore - data.BenchmarkScore;

                // Xác định Khả năng đậu (logic này đã tốt, giữ nguyên)
                if (result.ScoreDifference >= 1.0)
                {
                    result.Probability = "Rất Cao (Khả năng đậu: 95%+)";
                }
                else if (result.ScoreDifference >= 0 && result.ScoreDifference < 1.0)
                {
                    result.Probability = "Cao (Khả năng đậu: 70-95%)";
                }
                else if (result.ScoreDifference >= -0.5 && result.ScoreDifference < 0)
                {
                    result.Probability = "Cân nhắc (Khả năng đậu: 40-70%)";
                }
                else
                {
                    result.Probability = "Khó (Khả năng đậu: < 40%)";
                }

                filteredMajors.Add(result);
            }

            // Sắp xếp kết quả theo Chênh lệch giảm dần
            return filteredMajors.OrderByDescending(m => m.ScoreDifference).ToList();
        }
    }
}