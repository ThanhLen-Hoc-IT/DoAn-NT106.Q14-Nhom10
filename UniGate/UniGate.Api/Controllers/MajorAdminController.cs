using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UniGate.Application.DTOs.Major;
using UniGate.Infrastructure.Data;
using UniGate.Domain.Entities;

namespace UniGate.Api.Controllers
{
    [ApiController]
    [Route("api/admin/majors")]
    public class MajorAdminController : ControllerBase
    {
        private readonly AppDbContext _db;

        public MajorAdminController(AppDbContext db)
        {
            _db = db;
        }

        // GET: api/admin/majors?schoolId=3
        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] int? schoolId)
        {
            var query = _db.Majors
                .Include(m => m.School)
                .Include(m => m.MajorCombos)
                .ThenInclude(mc => mc.Combo)
                .AsQueryable();

            if (schoolId.HasValue)
                query = query.Where(m => m.SchoolId == schoolId);

            var result = await query
                .Select(m => new MajorDto
                {
                    Id = m.Id,
                    MajorCode = m.MajorCode,
                    Name = m.Name,
                    SchoolId = m.SchoolId,
                    SchoolName = m.School.Name,
                    Combos = m.MajorCombos.Select(x => x.Combo.Code).ToList()
                })
                .ToListAsync();

            return Ok(result);
        }

        // GET api/admin/majors/{id}
        [HttpGet("{id:guid}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var m = await _db.Majors
                .Include(x => x.MajorCombos)
                .ThenInclude(c => c.Combo)
                .Include(s => s.School)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (m == null) return NotFound("Không tìm thấy ngành.");

            return Ok(new MajorDto
            {
                Id = m.Id,
                MajorCode = m.MajorCode,
                Name = m.Name,
                SchoolId = m.SchoolId,
                SchoolName = m.School.Name,
                Combos = m.MajorCombos.Select(x => x.Combo.Code).ToList()
            });
        }

        // POST api/admin/majors
        [HttpPost]
        public async Task<IActionResult> Create(MajorCreateRequest req)
        {
            var major = new Major
            {
                Id = Guid.NewGuid(),
                MajorCode = req.MajorCode,
                Name = req.Name,
                SchoolId = req.SchoolId
            };

            _db.Majors.Add(major);
            await _db.SaveChangesAsync();

            //lưu combo
            foreach (var comboId in req.ComboIds)
            {
                _db.MajorCombos.Add(new MajorCombo
                {
                    ComboId = comboId,
                    MajorId = major.Id
                });
            }

            await _db.SaveChangesAsync();
            return Ok("Thêm ngành thành công!");
        }

        // PUT api/admin/majors/{id}
        [HttpPut("{id:guid}")]
        public async Task<IActionResult> Update(Guid id, MajorUpdateRequest req)
        {
            if (id != req.Id)
                return BadRequest("Id không khớp.");

            var m = await _db.Majors
                .Include(x => x.MajorCombos)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (m == null) return NotFound("Không tìm thấy ngành.");

            m.MajorCode = req.MajorCode;
            m.Name = req.Name;
            m.SchoolId = req.SchoolId;

            // Xóa combo cũ
            _db.MajorCombos.RemoveRange(m.MajorCombos);

            // Gắn combo mới
            foreach (var comboId in req.ComboIds)
            {
                _db.MajorCombos.Add(new MajorCombo
                {
                    MajorId = id,
                    ComboId = comboId
                });
            }

            await _db.SaveChangesAsync();
            return Ok("Cập nhật ngành thành công!");
        }

        // DELETE api/admin/majors/{id}
        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var m = await _db.Majors.FindAsync(id);
            if (m == null) return NotFound("Không tìm thấy ngành.");

            _db.Majors.Remove(m);
            await _db.SaveChangesAsync();

            return Ok("Đã xoá ngành.");
        }
    }
}
