using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniGate.Application.DTOs.Score
{
    public class UserScoreRequest
    {
        public Guid UserId { get; set; }
        public float? HB_Toan_10 { get; set; }
        public float? HB_Toan_11 { get; set; }
        public float? HB_Toan_12 { get; set; }

        public float? HB_Van_10 { get; set; }
        public float? HB_Van_11 { get; set; }
        public float? HB_Van_12 { get; set; }

        public float? HB_Su_10 { get; set; }
        public float? HB_Su_11 { get; set; }
        public float? HB_Su_12 { get; set; }

        public float? HB_Dia_10 { get; set; }
        public float? HB_Dia_11 { get; set; }
        public float? HB_Dia_12 { get; set; }

        public float? HB_GDKTPL_10 { get; set; }
        public float? HB_GDKTPL_11 { get; set; }
        public float? HB_GDKTPL_12 { get; set; }

        public float? HB_Ly_10 { get; set; }
        public float? HB_Ly_11 { get; set; }
        public float? HB_Ly_12 { get; set; }

        public float? HB_Hoa_10 { get; set; }
        public float? HB_Hoa_11 { get; set; }
        public float? HB_Hoa_12 { get; set; }

        public float? HB_Sinh_10 { get; set; }
        public float? HB_Sinh_11 { get; set; }
        public float? HB_Sinh_12 { get; set; }

        public float? HB_Tin_10 { get; set; }
        public float? HB_Tin_11 { get; set; }
        public float? HB_Tin_12 { get; set; }

        public float? HB_CongNghe_10 { get; set; }
        public float? HB_CongNghe_11 { get; set; }
        public float? HB_CongNghe_12 { get; set; }

        // Ngoại ngữ (chọn môn)
        public string? HB_NgoaiNgu_Mon { get; set; }
        public float? HB_NgoaiNgu_10 { get; set; }
        public float? HB_NgoaiNgu_11 { get; set; }
        public float? HB_NgoaiNgu_12 { get; set; }


        // ======================
        // THPT (Thi tốt nghiệp)
        // ======================
        public float? Thpt_Toan { get; set; }
        public float? Thpt_Van { get; set; }

        public string? Thpt_TuChon1_Mon { get; set; }
        public float? Thpt_TuChon1_Diem { get; set; }

        public string? Thpt_TuChon2_Mon { get; set; }
        public float? Thpt_TuChon2_Diem { get; set; }


        // ======================
        // ĐÁNH GIÁ NĂNG LỰC
        // ======================
        public float? DGNL_NgonNgu { get; set; }
        public float? DGNL_Toan { get; set; }
        public float? DGNL_TuDuy { get; set; }


        // ======================
        // ƯU TIÊN
        // ======================
        public string? KhuVuc { get; set; }
        public string? DoiTuong { get; set; }
        public float? DiemCongThem { get; set; }
    }

}
