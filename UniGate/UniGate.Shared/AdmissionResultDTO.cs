using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Đặt trong Namespace chung cho DTOs
namespace UniGate.Shared.DTOs
{
    // Đây là lớp Model dùng để hiển thị kết quả cho DataGridView
    public class AdmissionResultDTO
    {
        public string UniversityName { get; set; } = string.Empty; // Sửa lỗi CS8618
        public string MajorCode { get; set; } = string.Empty;      // Sửa lỗi CS8618
        public string MajorName { get; set; } = string.Empty;      // Sửa lỗi CS8618
        public string CombinationCode { get; set; } = string.Empty; // Sửa lỗi CS8618
        public double BenchmarkScore { get; set; }
        public double ScoreDifference { get; set; }
        public string Probability { get; set; } = string.Empty;    // Sửa lỗi CS8618
    }
}
