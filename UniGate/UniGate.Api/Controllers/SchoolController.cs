using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UniGate.Infrastructure.Data;
using UniGate.Domain.Entities;
using UniGate.Application.DTOs.School;

namespace UniGate.Api.Controllers
{
    [ApiController]
    [Route("api/schools")]
    public class SchoolController : ControllerBase
    {
        private readonly AppDbContext _db;

        public SchoolController(AppDbContext db)
        {
            _db = db;
        }

        // GET api/schools
        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] string? keyword)
        {
            var query = _db.Schools.AsQueryable();

            if (!string.IsNullOrWhiteSpace(keyword))
            {
                keyword = keyword.Trim().ToLower();
                query = query.Where(s =>
                    s.Name.ToLower().Contains(keyword) ||
                    s.Code.ToLower().Contains(keyword) ||
                    s.Province.ToLower().Contains(keyword));
            }

            var result = await query
                .OrderBy(s => s.Name)
                .Select(s => new SchoolDto
                {
                    Id = s.Id,
                    Name = s.Name,
                    Code = s.Code,
                    Province = s.Province,
                    Description = s.Description,
                    LogoUrl = s.LogoUrl
                })
                .ToListAsync();

            return Ok(result);
        }

        // GET api/schools/5
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var s = await _db.Schools.FindAsync(id);
            if (s == null) return NotFound("Không tìm thấy trường.");

            var dto = new SchoolDto
            {
                Id = s.Id,
                Name = s.Name,
                Code = s.Code,
                Province = s.Province,
                Description = s.Description,
                LogoUrl = s.LogoUrl
            };

            return Ok(dto);
        }

        // POST api/schools
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] SchoolCreateRequest req)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var existed = await _db.Schools
                .AnyAsync(x => x.Code == req.Code);
            if (existed) return BadRequest("Mã trường đã tồn tại.");

            var school = new School
            {
                Name = req.Name,
                Code = req.Code,
                Province = req.Province,
                Description = req.Description ?? "",
                LogoUrl = req.LogoUrl ?? ""
            };

            _db.Schools.Add(school);
            await _db.SaveChangesAsync();

            return Ok("Thêm trường thành công!");
        }

        // PUT api/schools/5
        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(int id, [FromBody] SchoolUpdateRequest req)
        {
            if (id != req.Id) return BadRequest("Id không khớp.");

            var s = await _db.Schools.FindAsync(id);
            if (s == null) return NotFound("Không tìm thấy trường.");

            // kiểm tra trùng mã
            var existed = await _db.Schools
                .AnyAsync(x => x.Id != id && x.Code == req.Code);
            if (existed) return BadRequest("Mã trường đã tồn tại.");

            s.Name = req.Name;
            s.Code = req.Code;
            s.Province = req.Province;
            s.Description = req.Description ?? "";
            s.LogoUrl = req.LogoUrl ?? "";

            await _db.SaveChangesAsync();
            return Ok("Cập nhật trường thành công!");
        }

        // DELETE api/schools/5
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var s = await _db.Schools.FindAsync(id);
            if (s == null) return NotFound("Không tìm thấy trường.");

            _db.Schools.Remove(s);
            await _db.SaveChangesAsync();
            return Ok("Đã xóa trường.");
        }
    }
}
