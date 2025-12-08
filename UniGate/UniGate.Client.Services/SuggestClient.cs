using System;
using System.Collections.Generic;
using System.Linq;

// Cần các using này để tìm thấy các lớp Model/DTO
using UniGate.Domain;           // Chứa ScoreInputModel
using UniGate.Shared.DTOs;      // Chứa AdmissionResultDTO

namespace UniGate.Client.Services
{
    // Đổi từ internal sang public để SuggestForm có thể truy cập được
    public class SuggestClient
    {
        // Hàm giả định lấy dữ liệu từ DB/API (Thay thế cho GetAdmissionDataFromDatabaseOrAPI)
        // Hàm này trả về danh sách các DTO để Form hiển thị
        public List<AdmissionResultDTO> GetAdmissionDataFromDatabaseOrAPI()
        {
            // *** THAY THẾ DỮ LIỆU HARDCODE NÀY BẰNG CODE GỌI API/DB THỰC TẾ ***
            // Dữ liệu mẫu (Hardcode)
            return new List<AdmissionResultDTO>
            {
                new AdmissionResultDTO { UniversityName = "ĐH Bách Khoa HN", MajorCode = "CNTT1", MajorName = "Công nghệ thông tin", CombinationCode = "A00", BenchmarkScore = 27.5 },
                new AdmissionResultDTO { UniversityName = "ĐH Kinh tế QT", MajorCode = "KTE1", MajorName = "Kinh tế học", CombinationCode = "A01", BenchmarkScore = 26.0 },
                new AdmissionResultDTO { UniversityName = "ĐH Quốc Gia", MajorCode = "TOAN", MajorName = "Khoa học Máy tính", CombinationCode = "A00", BenchmarkScore = 25.5 },
                new AdmissionResultDTO { UniversityName = "ĐH Y Dược", MajorCode = "YDHN", MajorName = "Y khoa", CombinationCode = "B00", BenchmarkScore = 28.5 },
                new AdmissionResultDTO { UniversityName = "ĐH Sư Phạm", MajorCode = "VAN", MajorName = "Văn học", CombinationCode = "C00", BenchmarkScore = 23.5 },
                new AdmissionResultDTO { UniversityName = "ĐH Ngoại Thương", MajorCode = "KTHN", MajorName = "Kinh tế", CombinationCode = "A00", BenchmarkScore = 27.0 },
                new AdmissionResultDTO { UniversityName = "ĐH Ngoại Thương", MajorCode = "KTHN", MajorName = "Kinh tế", CombinationCode = "D01", BenchmarkScore = 26.5 }
            };
        }

        // Hàm chính để lọc và so sánh điểm (FindPossibleMajors)
        public List<AdmissionResultDTO> FindPossibleMajors(ScoreInputModel userInput, List<AdmissionResultDTO> allAdmissionData)
        {
            var filteredMajors = new List<AdmissionResultDTO>();

            // 1. Lọc theo Tổ hợp môn
            var matchingMajors = allAdmissionData
                .Where(d => d.CombinationCode.Equals(userInput.SelectedCombination, StringComparison.OrdinalIgnoreCase))
                .ToList();

            // 2. Tính toán chênh lệch và Khả năng đậu
            foreach (var data in matchingMajors)
            {
                // Tạo bản sao để tính toán
                var result = new AdmissionResultDTO
                {
                    UniversityName = data.UniversityName,
                    MajorCode = data.MajorCode,
                    MajorName = data.MajorName,
                    CombinationCode = data.CombinationCode,
                    BenchmarkScore = data.BenchmarkScore
                };

                // Tính toán chênh lệch
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