// Thêm namespace này nếu chưa có
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

// --- 1. Dữ liệu Ngành học và Điểm chuẩn ---
public class AdmissionData
{
    public string UniversityName { get; set; } // Trường
    public string MajorCode { get; set; }     // Mã Ngành
    public string MajorName { get; set; }     // Tên Ngành
    public double BenchmarkScore { get; set; }  // Điểm Chuẩn (năm trước)
    public string CombinationCode { get; set; } // Mã Tổ hợp môn (A00, B00...)
    // Thêm cột Hiển thị cho DataGridView
    public double ScoreDifference { get; set; } // Chênh Lệch (TongDiem - DiemChuan)
    public string Probability { get; set; }    // Khả Năng (Đậu, Cân nhắc, Khó)
}

// --- 2. Dữ liệu Đầu vào của Người dùng ---
public class UserInput
{
    public double UserTotalScore { get; set; } // Tổng điểm (sau khi cộng Điểm UT)
    public string SelectedCombination { get; set; } // Tổ hợp môn người dùng chọn
}
