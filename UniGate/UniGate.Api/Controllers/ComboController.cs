using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UniGate.Infrastructure.Data;

namespace UniGate.Api.Controllers
{
    [ApiController]
    [Route("api/combos")]
    public class ComboController : ControllerBase
    {
        private readonly AppDbContext _db;

        public ComboController(AppDbContext db)
        {
            _db = db;
        }

        // Lấy cơ bản
        [HttpGet]
        public IActionResult GetAll()
        {
            var list = _db.Combos
                .Include(c => c.ComboSubjects)
                .Select(c => new
                {
                    c.Id,
                    c.Code,
                    Subjects = c.ComboSubjects.Select(s => s.Subject).ToList()
                })
                .ToList();

            return Ok(list);
        }

        // Lấy tổ hợp + danh sách môn
        [HttpGet("with-subjects")]
        public IActionResult GetCombosWithSubjects()
        {
            var combos = _db.Combos
                .Include(c => c.ComboSubjects)
                .Select(c => new ComboInfoResponse
                {
                    Code = c.Code,
                    Subjects = c.ComboSubjects.Select(s => s.Subject).ToList()
                })
                .ToList();

            return Ok(combos);
        }
    }

    public class ComboInfoResponse
    {
        public string Code { get; set; }
        public List<string> Subjects { get; set; }
    }
}
