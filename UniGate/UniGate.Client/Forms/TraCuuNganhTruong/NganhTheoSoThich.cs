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
    public partial class NganhTheoSoThich : Form
    {
        // =========================================================
        // 1. KHAI BÁO BIẾN VÀ DỮ LIỆU GIẢ LẬP
        // =========================================================

        // Giả lập ID bài trắc nghiệm Holland
        private const int HOLLAND_TEST_ID = 1;

        // Giả lập Mã kết quả Holland của người dùng (Giả định sau khi làm bài)
        private string UserResultCode = "ISA";

        // Danh sách giả lập (sẽ thay bằng truy vấn DB sau này)
        private List<Major> MajorsList;
        private List<CareerSuggestion> SuggestionsList;

        public NganhTheoSoThich()
        {
            InitializeComponent();
            LoadMockData(); // Tải dữ liệu mẫu

            // Gắn sự kiện
            this.Load += NganhTheoSoThich_Load;
            this.dgvSuggestions.SelectionChanged += dgvSuggestions_SelectionChanged;
        }

        // =========================================================
        // 2. HÀM TẠO DỮ LIỆU GIẢ LẬP
        // =========================================================
        private void LoadMockData()
        {
            // Dữ liệu Majors (Ngành học)
            MajorsList = new List<Major>
            {
                new Major { MajorID = 10, MajorName = "Công nghệ Thông tin",
                            Description = "Nghiên cứu, phát triển phần mềm, ứng dụng công nghệ. Phù hợp người có tư duy logic, giải quyết vấn đề tốt.",
                            GroupCode = "A00, A01" },
                new Major { MajorID = 20, MajorName = "Tâm lý học",
                            Description = "Nghiên cứu hành vi và tâm lý con người, tư vấn, trị liệu. Yêu cầu sự đồng cảm và khả năng phân tích.",
                            GroupCode = "C00, D01" },
                new Major { MajorID = 30, MajorName = "Thiết kế Đồ họa",
                            Description = "Thiết kế hình ảnh, thương hiệu, ấn phẩm truyền thông. Cần óc sáng tạo và kỹ năng sử dụng công cụ thiết kế.",
                            GroupCode = "H00, D01" },
                new Major { MajorID = 40, MajorName = "Quản trị Khách sạn",
                            Description = "Quản lý và điều hành dịch vụ lưu trú, du lịch. Đòi hỏi kỹ năng giao tiếp, tổ chức và kinh doanh.",
                            GroupCode = "A00, D01" },
            };

            // Dữ liệu CareerSuggestions (Liên kết gợi ý)
            SuggestionsList = new List<CareerSuggestion>
            {
                // Liên kết cho ISA (Nghiên cứu - Xã hội - Nghệ thuật)
                new CareerSuggestion { SuggestionID = 1, TestTypeID = HOLLAND_TEST_ID, ResultCode = "ISA", MajorID = 20,
                                       Note = "Phù hợp hoàn hảo: I (Nghiên cứu) và S (Xã hội) rất mạnh." },
                new CareerSuggestion { SuggestionID = 2, TestTypeID = HOLLAND_TEST_ID, ResultCode = "ISA", MajorID = 30,
                                       Note = "Phù hợp: Kết hợp I (Tư duy) và A (Sáng tạo), cần thiết cho thiết kế." },
                new CareerSuggestion { SuggestionID = 3, TestTypeID = HOLLAND_TEST_ID, ResultCode = "ISA", MajorID = 10,
                                       Note = "Phù hợp: Yếu tố I (Nghiên cứu) giúp bạn phân tích và lập trình logic." },
                
                // Liên kết cho một mã khác, ví dụ SEC
                new CareerSuggestion { SuggestionID = 4, TestTypeID = HOLLAND_TEST_ID, ResultCode = "SEC", MajorID = 40,
                                       Note = "Rất phù hợp: E (Kinh doanh) mạnh mẽ và S (Xã hội) cao." },
            };
        }

        // =========================================================
        // 3. XỬ LÝ KHI FORM LOAD (TẢI KẾT QUẢ TƯ VẤN)
        // =========================================================
        private void NganhTheoSoThich_Load(object sender, EventArgs e)
        {
            // 1. Hiển thị Mã kết quả và mô tả tóm tắt
            lblResultCode.Text = UserResultCode;
            lblTestName.Text = "KẾT QUẢ: MÔ HÌNH HOLLAND CODE";

            // Logic mô tả ngắn cho mã ISA
            txtResultDesc.Text = $"Mã tính cách của bạn là {UserResultCode}:\n\n" +
                                 "I (Nghiên cứu) - S (Xã hội) - A (Nghệ thuật).\n\n" +
                                 "Bạn có khả năng phân tích tốt, thích giao tiếp và làm việc nhóm, đồng thời có óc sáng tạo.";

            // 2. Lọc và ánh xạ dữ liệu gợi ý (Sử dụng LINQ để JOIN và FILTER)
            var suggestions = (from s in SuggestionsList
                               join m in MajorsList on s.MajorID equals m.MajorID
                               where s.ResultCode == UserResultCode && s.TestTypeID == HOLLAND_TEST_ID
                               select new SuggestionDisplay
                               {
                                   MajorID = m.MajorID,
                                   MajorName = m.MajorName,
                                   Note = s.Note
                               }).ToList();

            // 3. Hiển thị lên DataGridView
            dgvSuggestions.DataSource = suggestions;

            // 4. Nếu có gợi ý, tự động chọn dòng đầu tiên để hiển thị chi tiết
            if (suggestions.Count > 0)
            {
                dgvSuggestions.ClearSelection();
                dgvSuggestions.Rows[0].Selected = true;
            }
        }

        // =========================================================
        // 4. XỬ LÝ KHI NGƯỜI DÙNG CHỌN NGÀNH KHÁC (SelectionChanged)
        // =========================================================
        private void dgvSuggestions_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSuggestions.SelectedRows.Count == 0)
            {
                // Reset chi tiết khi không có dòng nào được chọn
                lblMajorName.Text = "Ngành: [Vui lòng chọn ngành học bên trên]";
                lblGroupCode.Text = "Tổ hợp xét tuyển chính: ";
                txtMajorDetail.Text = "";
                return;
            }

            // Lấy MajorID của ngành được chọn
            SuggestionDisplay selectedItem = dgvSuggestions.SelectedRows[0].DataBoundItem as SuggestionDisplay;

            if (selectedItem != null)
            {
                // Tìm thông tin chi tiết của ngành trong MajorsList
                Major selectedMajor = MajorsList.FirstOrDefault(m => m.MajorID == selectedItem.MajorID);

                if (selectedMajor != null)
                {
                    // Hiển thị chi tiết ngành
                    lblMajorName.Text = "Ngành: " + selectedMajor.MajorName;
                    lblGroupCode.Text = "Tổ hợp xét tuyển chính: " + selectedMajor.GroupCode;
                    txtMajorDetail.Text = selectedMajor.Description;
                }
            }
        }

        // =========================================================
        // 5. MÔ HÌNH DỮ LIỆU (Cần đặt ngoài class NganhTheoSoThich)
        // =========================================================

        // Mô phỏng bảng Majors
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
            public string ResultCode { get; set; } // Mã 3 ký tự Holland (VD: ISA)
            public int MajorID { get; set; }
            public string Note { get; set; }
        }

        // Mô hình dữ liệu hiển thị trên DataGridView
        public class SuggestionDisplay
        {
            public string MajorName { get; set; }
            public string Note { get; set; }
            public int MajorID { get; set; } // Dùng để truy vấn chi tiết
        }

        // =========================================================
        // 6. SỰ KIỆN CHƯA THỰC HIỆN
        // =========================================================
        // Thêm sự kiện cho nút btnCheckAdmission
        private void btnCheckAdmission_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng tra cứu điểm chuẩn đang được xây dựng!");
            // M sẽ gọi Form FrmAdmissionDetail tại đây, truyền MajorID vào.
        }
    }
}