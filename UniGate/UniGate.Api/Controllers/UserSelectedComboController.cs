using Microsoft.AspNetCore.Mvc;
using UniGate.Infrastructure.Data;
using UniGate.Domain.Entities;
using UniGate.Application.DTOs.Score;

namespace UniGate.Api.Controllers
{
    [ApiController]
    [Route("api/user-combos")]
    public class UserSelectedComboController : ControllerBase
    {
        private readonly AppDbContext _db;

        public UserSelectedComboController(AppDbContext db)
        {
            _db = db;
        }

        [HttpPost("select")]
        public async Task<IActionResult> SelectCombos([FromBody] UserComboCodeSelectRequest req)
        {
            if (req.ComboCodes == null || req.ComboCodes.Count < 1 || req.ComboCodes.Count > 3)
                return BadRequest("Bạn phải chọn 1 đến 3 tổ hợp.");

            // Xóa chọn cũ
            var old = _db.UserSelectedCombos.Where(c => c.UserId == req.UserId);
            _db.UserSelectedCombos.RemoveRange(old);

            // Lưu mới theo MÃ TỔ HỢP (A00, A01,...)
            foreach (var code in req.ComboCodes)
            {
                var combo = _db.Combos.FirstOrDefault(c => c.Code == code);
                if (combo == null) continue;

                _db.UserSelectedCombos.Add(new UserSelectedCombo
                {
                    UserId = req.UserId,
                    ComboId = combo.Id
                });
            }

            await _db.SaveChangesAsync();

            return Ok("Đã lưu tổ hợp xét tuyển!");
        }

        // (Dành cho WinForms load về)
        [HttpGet("{userId}")]
        public IActionResult GetSelected(Guid userId)
        {
            var combos = _db.UserSelectedCombos
                            .Where(c => c.UserId == userId)
                            .Select(c => c.Combo.Code)
                            .ToList();

            return Ok(combos);
        }
    }
}
