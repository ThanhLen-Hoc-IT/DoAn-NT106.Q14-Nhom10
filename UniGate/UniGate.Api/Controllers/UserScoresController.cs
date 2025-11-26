using Microsoft.AspNetCore.Mvc;
using UniGate.Infrastructure.Data;
using UniGate.Domain.Entities;
using UniGate.Application.DTOs.Score;

namespace UniGate.Api.Controllers
{
    [ApiController]
    [Route("api/user-scores")]
    public class UserScoresController : ControllerBase
    {
        private readonly AppDbContext _db;

        public UserScoresController(AppDbContext db)
        {
            _db = db;
        }

        // =====================================================
        // === LƯU HOẶC CẬP NHẬT BẢNG ĐIỂM NGƯỜI DÙNG ==========
        // =====================================================
        [HttpPost("save")]
        public async Task<IActionResult> SaveScores([FromBody] UserScoreRequest req)
        {
            if (req == null)
                return BadRequest("Dữ liệu không hợp lệ!");

            var score = await _db.UserScores.FindAsync(req.UserId);

            if (score == null)
            {
                score = new UserScores { UserId = req.UserId };
                _db.UserScores.Add(score);
            }

            // ==========================
            // ======= HỌC BẠ ===========
            // ==========================

            score.HB_Toan_10 = req.HB_Toan_10;
            score.HB_Toan_11 = req.HB_Toan_11;
            score.HB_Toan_12 = req.HB_Toan_12;

            score.HB_Van_10 = req.HB_Van_10;
            score.HB_Van_11 = req.HB_Van_11;
            score.HB_Van_12 = req.HB_Van_12;

            score.HB_Su_10 = req.HB_Su_10;
            score.HB_Su_11 = req.HB_Su_11;
            score.HB_Su_12 = req.HB_Su_12;

            score.HB_Dia_10 = req.HB_Dia_10;
            score.HB_Dia_11 = req.HB_Dia_11;
            score.HB_Dia_12 = req.HB_Dia_12;

            score.HB_GDKTPL_10 = req.HB_GDKTPL_10;
            score.HB_GDKTPL_11 = req.HB_GDKTPL_11;
            score.HB_GDKTPL_12 = req.HB_GDKTPL_12;

            score.HB_Ly_10 = req.HB_Ly_10;
            score.HB_Ly_11 = req.HB_Ly_11;
            score.HB_Ly_12 = req.HB_Ly_12;

            score.HB_Hoa_10 = req.HB_Hoa_10;
            score.HB_Hoa_11 = req.HB_Hoa_11;
            score.HB_Hoa_12 = req.HB_Hoa_12;

            score.HB_Sinh_10 = req.HB_Sinh_10;
            score.HB_Sinh_11 = req.HB_Sinh_11;
            score.HB_Sinh_12 = req.HB_Sinh_12;

            score.HB_Tin_10 = req.HB_Tin_10;
            score.HB_Tin_11 = req.HB_Tin_11;
            score.HB_Tin_12 = req.HB_Tin_12;

            score.HB_CongNghe_10 = req.HB_CongNghe_10;
            score.HB_CongNghe_11 = req.HB_CongNghe_11;
            score.HB_CongNghe_12 = req.HB_CongNghe_12;

            // Ngoại ngữ tuỳ chọn
            score.HB_NgoaiNgu_Mon = req.HB_NgoaiNgu_Mon;
            score.HB_NgoaiNgu_10 = req.HB_NgoaiNgu_10;
            score.HB_NgoaiNgu_11 = req.HB_NgoaiNgu_11;
            score.HB_NgoaiNgu_12 = req.HB_NgoaiNgu_12;

            // ==========================
            // ====== THPT ==============
            // ==========================

            score.Thpt_Toan = req.Thpt_Toan;   // bắt buộc
            score.Thpt_Van = req.Thpt_Van;     // bắt buộc

            score.Thpt_TuChon1_Mon = req.Thpt_TuChon1_Mon;
            score.Thpt_TuChon1_Diem = req.Thpt_TuChon1_Diem;

            score.Thpt_TuChon2_Mon = req.Thpt_TuChon2_Mon;
            score.Thpt_TuChon2_Diem = req.Thpt_TuChon2_Diem;

            // ==========================
            // ====== ĐGNL ==============
            // ==========================
            score.DGNL_NgonNgu = req.DGNL_NgonNgu;
            score.DGNL_Toan = req.DGNL_Toan;
            score.DGNL_TuDuy = req.DGNL_TuDuy;

            // ==========================
            // ====== ƯU TIÊN ===========
            // ==========================

            score.KhuVuc = req.KhuVuc;
            score.DoiTuong = req.DoiTuong;
            score.DiemCongThem = req.DiemCongThem;

            await _db.SaveChangesAsync();
            return Ok("Lưu điểm thành công!");
        }


        // =====================================================
        // === API GET: LẤY ĐIỂM THEO USER =====================
        // =====================================================
        [HttpGet("{userId}")]
        public async Task<IActionResult> GetScores(Guid userId)
        {
            var scores = await _db.UserScores.FindAsync(userId);

            if (scores == null)
                return NotFound("Người dùng chưa nhập điểm.");

            return Ok(scores);
        }
    }
}
