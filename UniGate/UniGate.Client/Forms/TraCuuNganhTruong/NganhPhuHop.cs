using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniGate.Client.Forms.TraCuuNganhTruong
{
    public partial class NganhPhuHop : Form
    {
        // =========================================================
        // 1. KHAI BÁO BIẾN VÀ DỮ LIỆU GIẢ LẬP
        // =========================================================
        private const int HOLLAND_TEST_ID = 1;
        private string UserResultCode = "ISA"; // Mã tính cách giả lập

        // Danh sách giả lập (Cần bổ sung các lớp này ở cuối file)
        private List<Major> MajorsList;
        private List<CareerSuggestion> SuggestionsList;
        private List<University> UniversitiesList;
        private List<Admission> AdmissionsList;

        public NganhPhuHop()
        {
            InitializeComponent();
            LoadMockData();

            this.Load += NganhPhuHop_Load;
            this.btnFilter.Click += btnFilter_Click;

            // Tự động chạy lọc khi form load
            this.Shown += (sender, e) => FilterAndDisplayResults();
        }

        // =========================================================
        // 2. HÀM TẠO DỮ LIỆU GIẢ LẬP (Bổ sung thêm Admission và University)
        // =========================================================
        private void LoadMockData()
        {
            // --- Dữ liệu 1: Majors ---
            MajorsList = new List<Major>
            {
                new Major { MajorID = 10, MajorName = "Công nghệ Thông tin", Description = "...", GroupCode = "A00, A01" },
                new Major { MajorID = 20, MajorName = "Tâm lý học", Description = "...", GroupCode = "C00, D01" },
                new Major { MajorID = 30, MajorName = "Thiết kế Đồ họa", Description = "...", GroupCode = "H00, D01" },
                new Major { MajorID = 40, MajorName = "Kế toán", Description = "...", GroupCode = "A00, D01" },
                new Major { MajorID = 50, MajorName = "Sư phạm Văn", Description = "...", GroupCode = "C00, D14" },
            };

            // --- Dữ liệu 2: Suggestions (Liên kết tính cách) ---
            SuggestionsList = new List<CareerSuggestion>
            {
                new CareerSuggestion { ResultCode = "ISA", MajorID = 10, Note = "Phù hợp: I (Nghiên cứu) mạnh." },
                new CareerSuggestion { ResultCode = "ISA", MajorID = 20, Note = "Rất phù hợp: I (Nghiên cứu) và S (Xã hội) cao." },
                new CareerSuggestion { ResultCode = "ISA", MajorID = 30, Note = "Phù hợp: Kết hợp I (Tư duy) và A (Sáng tạo)." },
                new CareerSuggestion { ResultCode = "ISA", MajorID = 40, Note = "Ít phù hợp: Chỉ vì có yếu tố I." },
                new CareerSuggestion { ResultCode = "SEC", MajorID = 40, Note = "Rất phù hợp: E (Kinh doanh) và C (Quy ước) cao." },
                new CareerSuggestion { ResultCode = "SEA", MajorID = 50, Note = "Rất phù hợp: S (Xã hội) mạnh." },
            };

            // --- Dữ liệu 3: Universities ---
            UniversitiesList = new List<University>
            {
                new University { UniversityID = 100, UniversityName = "ĐH Bách Khoa TP.HCM", Province = "TPHCM" },
                new University { UniversityID = 200, UniversityName = "ĐH Sư phạm Hà Nội", Province = "Hà Nội" },
                new University { UniversityID = 300, UniversityName = "ĐH Kinh tế Quốc dân", Province = "Hà Nội" },
            };

            // --- Dữ liệu 4: Admissions (Điểm chuẩn) ---
            AdmissionsList = new List<Admission>
            {
                // IT ở Bách Khoa (ID 10)
                new Admission { UniversityID = 100, MajorID = 10, Year = 2024, MedianScore = 27.5f },
                new Admission { UniversityID = 100, MajorID = 10, Year = 2023, MedianScore = 26.5f }, // CÓ khả năng thấp hơn 26.5

                // Tâm lý học ở Sư phạm HN (ID 20)
                new Admission { UniversityID = 200, MajorID = 20, Year = 2024, MedianScore = 25.0f }, // CHẮC CHẮN thấp hơn 26.5

                // Kế toán ở KTQD (ID 40)
                new Admission { UniversityID = 300, MajorID = 40, Year = 2024, MedianScore = 26.8f }, // CAO hơn 26.5
            };
        }

        // =========================================================
        // 3. KHỞI TẠO VÀ HIỂN THỊ BAN ĐẦU
        // =========================================================
        private void NganhPhuHop_Load(object sender, EventArgs e)
        {
            lblResultCode.Text = UserResultCode;
            lblTestName.Text = "Mã Tính Cách: " + UserResultCode;

            // Thêm cột cho DataGridView (Không thể làm trong Designer nếu dùng DataBinding phức tạp)
            SetupDataGridViewColumns();
        }

        private void SetupDataGridViewColumns()
        {
            dgvResults.AutoGenerateColumns = false;

            // Tên Ngành - Tên Trường - Điểm Chuẩn - Tổ Hợp - Phù hợp
            dgvResults.Columns.Clear();
            dgvResults.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "MajorName", HeaderText = "Ngành Học", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvResults.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "UniversityName", HeaderText = "Trường Đại học", Width = 200 });
            dgvResults.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "MedianScore", HeaderText = "Điểm chuẩn (2024)", Width = 120 });
            dgvResults.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "GroupCode", HeaderText = "Tổ hợp xét", Width = 90 });
            dgvResults.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "SuitabilityNote", HeaderText = "Lý do Phù hợp Tính cách", Width = 180 });
        }

        // =========================================================
        // 4. LOGIC LỌC DỮ LIỆU CHÍNH (3 TIÊU CHÍ)
        // =========================================================
        private void btnFilter_Click(object sender, EventArgs e)
        {
            FilterAndDisplayResults();
        }

        private void FilterAndDisplayResults()
        {
            // 1. Đọc dữ liệu nhập từ người dùng
            if (!float.TryParse(txtUserScore.Text, out float userScore))
            {
                MessageBox.Show("Vui lòng nhập điểm thi hợp lệ.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string userGroupCode = txtGroupCode.Text.Trim().ToUpper();

            // 2. Thực hiện Truy vấn/Lọc (LINQ tương đương với JOIN/WHERE trong SQL)
            var query = from admission in AdmissionsList
                        join university in UniversitiesList on admission.UniversityID equals university.UniversityID
                        join major in MajorsList on admission.MajorID equals major.MajorID
                        join suggestion in SuggestionsList on major.MajorID equals suggestion.MajorID

                        where suggestion.ResultCode == UserResultCode // TIÊU CHÍ 1: Phù hợp tính cách
                        where admission.MedianScore <= userScore      // TIÊU CHÍ 2: Điểm chuẩn thấp hơn điểm thi
                        where major.GroupCode.Contains(userGroupCode) // TIÊU CHÍ 3: Ngành có xét tổ hợp này (Giả định GroupCode lưu dạng A00, A01, D01)

                        select new ComprehensiveSuggestionDisplay
                        {
                            MajorID = major.MajorID,
                            MajorName = major.MajorName,
                            UniversityName = university.UniversityName,
                            GroupCode = major.GroupCode,
                            MedianScore = admission.MedianScore,
                            SuitabilityNote = suggestion.Note
                        };

            // 3. Hiển thị kết quả
            var results = query.ToList();
            dgvResults.DataSource = results;

            if (results.Count == 0)
            {
                MessageBox.Show("Không tìm thấy ngành/trường nào phù hợp cả 3 tiêu chí.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // =========================================================
        // 5. MÔ HÌNH DỮ LIỆU (M cần đặt ngoài class NganhPhuHop)
        // =========================================================

        // Mô phỏng bảng Majors (Đã định nghĩa trước, nhưng tóm tắt lại)
        public class Major
        {
            public int MajorID { get; set; }
            public string MajorName { get; set; }
            public string Description { get; set; }
            public string GroupCode { get; set; }
        }

        // Mô phỏng bảng CareerSuggestions
        public class CareerSuggestion
        {
            public int SuggestionID { get; set; }
            public int TestTypeID { get; set; }
            public string ResultCode { get; set; }
            public int MajorID { get; set; }
            public string Note { get; set; }
        }

        // Mô phỏng bảng Universities
        public class University
        {
            public int UniversityID { get; set; }
            public string UniversityName { get; set; }
            public string Province { get; set; }
        }

        // Mô phỏng bảng Admissions (Điểm chuẩn)
        public class Admission
        {
            public int AdmissionID { get; set; }
            public int UniversityID { get; set; }
            public int MajorID { get; set; }
            public int Year { get; set; }
            public float MedianScore { get; set; } // Điểm chuẩn trung vị
        }

        // Mô hình hiển thị (Display Model)
        public class ComprehensiveSuggestionDisplay
        {
            public int MajorID { get; set; }
            public string MajorName { get; set; }
            public string UniversityName { get; set; }
            public string GroupCode { get; set; }
            public float MedianScore { get; set; }
            public string SuitabilityNote { get; set; }
        }
    }
}
