using System.Collections.Generic;
using System.Linq;
using System;
// Đảm bảo tên namespace này trùng với namespace của Form ResultsMajor và Model.cs
namespace FormResult
{
    // Lớp này chịu trách nhiệm cho tất cả các phép tính và truy vấn dữ liệu
    public class AdmissionService
    {
        // Hàm giả định lấy dữ liệu từ DB/API (Bạn cần thay thế bằng code thật)
        public List<AdmissionData> GetAdmissionDataFromDatabaseOrAPI()
        {
            // Vui lòng thay thế bằng code kết nối Database (SQL, SQLite) hoặc API của bạn
            // Dữ liệu mẫu (Hardcode) để bạn chạy thử chức năng
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
                // ... (Logic tính toán và phân loại Khả năng Đậu giữ nguyên) ...
                var result = new AdmissionData
                {
                    UniversityName = data.UniversityName,
                    MajorCode = data.MajorCode,
                    MajorName = data.MajorName,
                    BenchmarkScore = data.BenchmarkScore,
                    CombinationCode = data.CombinationCode
                };

                result.ScoreDifference = userInput.UserTotalScore - data.BenchmarkScore;

                // Xác định Khả năng đậu
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

            return filteredMajors.OrderByDescending(m => m.ScoreDifference).ToList();
        }
    }
}