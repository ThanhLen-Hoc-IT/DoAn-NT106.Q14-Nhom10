using Microsoft.AspNetCore.Mvc;
using UniGate.Infrastructure.Data;
using UniGate.Domain.Entities;

namespace UniGate.Api.Controllers
{
    [ApiController]
    [Route("api/combo-scores")]
    public class ComboScoreController : ControllerBase
    {
        private readonly AppDbContext _db;

        public ComboScoreController(AppDbContext db)
        {
            _db = db;
        }

        
        // API: Tính điểm các tổ hợp
        
        [HttpGet("{userId}")]
        public IActionResult GetComboScores(Guid userId)
        {
            var scores = _db.UserScores.FirstOrDefault(s => s.UserId == userId);
            if (scores == null)
                return NotFound("Chưa có điểm!");

            var combos = _db.Combos.ToList();
            var result = new List<object>();

            foreach (var combo in combos)
            {
                var subjects = _db.ComboSubjects
                                  .Where(cs => cs.ComboId == combo.Id)
                                  .Select(cs => cs.Subject.ToLower())
                                  .ToList();

                float? total = TinhCombo(scores, subjects);
                if (total != null)
                {
                    result.Add(new
                    {
                        Combo = combo.Code,
                        Score = total
                    });
                }
            }

            return Ok(result.OrderByDescending(x => ((dynamic)x).Score));
        }

        
        // Tính điểm 1 tổ hợp
        
        private float? TinhCombo(UserScores s, List<string> monList)
        {
            float sum = 0;
            int count = 0;

            foreach (var mon in monList)
            {
                float? diem = LayDiemMon(s, mon);
                if (diem == null) return null;

                sum += diem.Value;
                count++;
            }

            return count == 0 ? null : sum;
        }


       
        // Lấy điểm 1 môn
       
        private float? LayDiemMon(UserScores s, string mon)
        {
            mon = mon.ToLower().Trim();

            bool coThpt = s.Thpt_Toan != null || s.Thpt_Van != null || s.Thpt_TuChon1_Diem != null;

           
            // Nếu có THPT → ưu tiên THPT
            
            if (coThpt)
            {
                switch (mon)
                {
                    case "toán":
                        return s.Thpt_Toan;

                    case "văn":
                        return s.Thpt_Van;

                    case "lý":
                    case "vật lí":
                        return LayDiemTuChon(s, "Lý");

                    case "hóa":
                    case "hóa học":
                        return LayDiemTuChon(s, "Hóa");

                    case "sinh":
                        return LayDiemTuChon(s, "Sinh");

                    case "địa":
                    case "địa lí":
                        return LayDiemTuChon(s, "Địa");

                    case "sử":
                    case "lịch sử":
                        return LayDiemTuChon(s, "Sử");

                    // --- NGOẠI NGỮ ---
                    case "anh":
                    case "nhật":
                    case "hàn":
                    case "trung":
                    case "đức":
                    case "pháp":
                    case "nga":
                        return LayDiemTuChon(s, ChuanHoaNgoaiNgu(mon));

                    default:
                        return null;
                }
            }

            
            //  KHÔNG có THPT → dùng HỌC BẠ (TB cộng 10-11-12)
           
            switch (mon)
            {
                case "toán":
                    return TinhTB(s.HB_Toan_10, s.HB_Toan_11, s.HB_Toan_12);

                case "văn":
                    return TinhTB(s.HB_Van_10, s.HB_Van_11, s.HB_Van_12);

                case "lý":
                case "vật lí":
                    return TinhTB(s.HB_Ly_10, s.HB_Ly_11, s.HB_Ly_12);

                case "hóa":
                case "hóa học":
                    return TinhTB(s.HB_Hoa_10, s.HB_Hoa_11, s.HB_Hoa_12);

                case "sinh":
                    return TinhTB(s.HB_Sinh_10, s.HB_Sinh_11, s.HB_Sinh_12);

                case "địa":
                case "địa lí":
                    return TinhTB(s.HB_Dia_10, s.HB_Dia_11, s.HB_Dia_12);

                case "sử":
                case "lịch sử":
                    return TinhTB(s.HB_Su_10, s.HB_Su_11, s.HB_Su_12);

                // ngoại ngữ
                case "anh":
                case "nhật":
                case "hàn":
                case "trung":
                case "đức":
                case "pháp":
                case "nga":
                    if (mon == s.HB_NgoaiNgu_Mon?.ToLower())
                        return TinhTB(s.HB_NgoaiNgu_10, s.HB_NgoaiNgu_11, s.HB_NgoaiNgu_12);

                    return null;

                default:
                    return null;
            }
        }


       
        // Lấy điểm môn tự chọn THPT
       
        private float? LayDiemTuChon(UserScores s, string mon)
        {
            if (s.Thpt_TuChon1_Mon == mon) return s.Thpt_TuChon1_Diem;
            if (s.Thpt_TuChon2_Mon == mon) return s.Thpt_TuChon2_Diem;

            return null;
        }

       
        // Tính trung bình học bạ 10–11–12
       
        private float? TinhTB(float? x, float? y, float? z)
        {
            if (x == null || y == null || z == null) return null;
            return (x.Value + y.Value + z.Value) / 3f;
        }

        // Chuẩn hoá ngoại ngữ
        
        private string ChuanHoaNgoaiNgu(string mon) =>
            mon switch
            {
                "anh" => "Anh",
                "nhật" => "Nhật",
                "hàn" => "Hàn",
                "trung" => "Trung",
                "đức" => "Đức",
                "pháp" => "Pháp",
                "nga" => "Nga",
                _ => mon
            };
    }
}
