using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using UniGate.Infrastructure.Data;
using UniGate.Domain.Entities;

namespace UniGate.Api.Controllers
{
    [ApiController]
    [Route("api/import")]
    public class MajorImportController : ControllerBase
    {
        private readonly AppDbContext _db;

        public MajorImportController(AppDbContext db)
        {
            _db = db;
        }

        [HttpPost("majors")]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> ImportMajors([FromForm] IFormFile file)
        {
            if (file == null || file.Length == 0)
                return BadRequest("File không hợp lệ!");

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using var stream = new MemoryStream();
            await file.CopyToAsync(stream);
            stream.Position = 0;

            using var package = new ExcelPackage(stream);
            var sheet = package.Workbook.Worksheets[0];
            if (sheet == null)
                return BadRequest("Không tìm thấy sheet!");

            int row = 2; 

            while (sheet.Cells[row, 1].Value != null)
            {
                string majorCode = sheet.Cells[row, 1].Text.Trim();
                string majorName = sheet.Cells[row, 2].Text.Trim();
                string schoolCode = sheet.Cells[row, 3].Text.Trim();
                string cutoffRaw = sheet.Cells[row, 4].Text.Trim();
                string combosRaw = sheet.Cells[row, 5].Text.Trim();

                if (string.IsNullOrWhiteSpace(majorCode) || string.IsNullOrWhiteSpace(majorName))
                {
                    row++;
                    continue;
                }

                //Lấy SchoolId từ SchoolCode
                var school = _db.Schools.FirstOrDefault(s => s.Code == schoolCode);
                if (school == null)
                {
                    row++;
                    continue; 
                }

                float cutoff = 0;
                float.TryParse(cutoffRaw, out cutoff);

                // Tạo hoặc cập nhật Major 
                var major = _db.Majors.FirstOrDefault(m => m.MajorCode == majorCode);

                if (major == null)
                {
                    major = new Major
                    {
                        Id = Guid.NewGuid(),
                        MajorCode = majorCode,
                        Name = majorName,
                        SchoolId = school.Id,
                        CutoffScore = cutoff
                    };
                    _db.Majors.Add(major);
                    await _db.SaveChangesAsync();
                }
                else
                {
                    // update
                    major.Name = majorName;
                    major.SchoolId = school.Id;
                    major.CutoffScore = cutoff;
                    await _db.SaveChangesAsync();
                }

                // xử lý tổ hợp 
                var oldCombos = _db.MajorCombos.Where(x => x.MajorId == major.Id);
                _db.MajorCombos.RemoveRange(oldCombos);

                var comboCodes = combosRaw.Split(',')
                                          .Select(c => c.Trim())
                                          .Where(c => c != "")
                                          .ToList();

                foreach (var c in comboCodes)
                {
                    var combo = _db.Combos.FirstOrDefault(cb => cb.Code == c);
                    if (combo == null) continue;

                    _db.MajorCombos.Add(new MajorCombo
                    {
                        MajorId = major.Id,
                        ComboId = combo.Id
                    });
                }

                await _db.SaveChangesAsync();
                row++;
            }

            return Ok("Import danh sách ngành thành công!");
        }
    }
}
