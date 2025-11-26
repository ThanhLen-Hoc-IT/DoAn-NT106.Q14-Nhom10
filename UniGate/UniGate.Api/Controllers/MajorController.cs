using Microsoft.AspNetCore.Mvc;
using UniGate.Application.DTOs.Major;
using UniGate.Domain.Entities;
using UniGate.Infrastructure.Data;

namespace UniGate.Api.Controllers
{
    [ApiController]
    [Route("api/majors")]
    public class MajorController : ControllerBase
    {
        private readonly AppDbContext _db;

        public MajorController(AppDbContext db)
        {
            _db = db;
        }

        // get major by id
        // GET api/majors/{id}
        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var m = _db.Majors
                .Where(x => x.Id == id)
                .Select(x => new
                {
                    x.Id,
                    x.MajorCode,
                    x.Name,
                    x.CutoffScore,
                    Combos = x.MajorCombos.Select(c => c.Combo.Code).ToList()
                })
                .FirstOrDefault();

            if (m == null)
                return NotFound("Ngành không tồn tại!");

            return Ok(m);
        }


        // get by school
        [HttpGet]
        public IActionResult GetMajorsBySchool([FromQuery] int schoolId)
        {
            var majors = _db.Majors
                .Where(m => m.SchoolId == schoolId)
                .Select(m => new
                {
                    m.Id,
                    m.MajorCode,
                    m.Name,
                    m.CutoffScore,
                    Combos = m.MajorCombos.Select(x => x.Combo.Code).ToList()
                })
                .ToList();

            return Ok(majors);
        }

        // get by combo
        [HttpGet("by-combos/{userId}")]
        public IActionResult GetMajorsByUserCombos(Guid userId)
        {
            var selectedComboIds = _db.UserSelectedCombos
                .Where(x => x.UserId == userId)
                .Select(x => x.ComboId)
                .ToList();

            if (!selectedComboIds.Any())
                return Ok(new List<MajorResponse>());

            var majors = _db.Majors
                .Where(m => m.MajorCombos.Any(c => selectedComboIds.Contains(c.ComboId)))
                .Select(m => new MajorResponse
                {
                    MajorId = m.Id,
                    Name = m.Name,
                    SchoolName = m.School.Name,
                    ComboCodes = m.MajorCombos.Select(x => x.Combo.Code).ToList(),
                    LastYearScore = m.CutoffScore
                })
                .ToList();

            return Ok(majors);
        }


        // create
        [HttpPost]
        public IActionResult Create(MajorCreateRequest req)
        {
            var school = _db.Schools.Find(req.SchoolId);
            if (school == null)
                return BadRequest("SchoolId không tồn tại!");

            var major = new Major
            {
                Id = Guid.NewGuid(),
                MajorCode = req.MajorCode,
                Name = req.Name,
                CutoffScore = (float)req.CutoffScore,
                SchoolId = req.SchoolId
            };

            _db.Majors.Add(major);
            _db.SaveChanges();

            foreach (var comboId in req.ComboIds)
            {
                if (_db.Combos.Find(comboId) == null) continue;

                _db.MajorCombos.Add(new MajorCombo
                {
                    MajorId = major.Id,
                    ComboId = comboId
                });
            }

            _db.SaveChanges();
            return Ok("Thêm ngành thành công!");
        }

        // update
        [HttpPut("{id}")]
        public IActionResult Update(Guid id, MajorUpdateRequest req)
        {
            var major = _db.Majors.Find(id);
            if (major == null)
                return NotFound("Không tìm thấy ngành!");

            var school = _db.Schools.Find(req.SchoolId);
            if (school == null)
                return BadRequest("SchoolId không tồn tại!");

            major.MajorCode = req.MajorCode;
            major.Name = req.Name;
            major.CutoffScore = (float)req.CutoffScore;
            major.SchoolId = req.SchoolId;

            var old = _db.MajorCombos.Where(x => x.MajorId == id).ToList();
            _db.MajorCombos.RemoveRange(old);

            foreach (var comboId in req.ComboIds)
            {
                if (_db.Combos.Find(comboId) == null) continue;

                _db.MajorCombos.Add(new MajorCombo
                {
                    MajorId = id,
                    ComboId = comboId
                });
            }

            _db.SaveChanges();
            return Ok("Cập nhật thành công!");
        }

        // delete
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var major = _db.Majors.Find(id);
            if (major == null)
                return NotFound();

            _db.Majors.Remove(major);
            _db.SaveChanges();
            return Ok();
        }
    }
}
