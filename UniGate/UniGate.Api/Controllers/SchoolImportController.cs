using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using UniGate.Infrastructure.Data;
using UniGate.Domain.Entities;

namespace UniGate.Api.Controllers
{
    [ApiController]
    [Route("api/import")]
    public class SchoolImportController : ControllerBase
    {
        private readonly AppDbContext _db;

        public SchoolImportController(AppDbContext db)
        {
            _db = db;
        }

        [HttpPost("schools")]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> ImportSchools([FromForm] IFormFile file)
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

            int row = 2; // bỏ tiêu đề

            while (sheet.Cells[row, 1].Value != null)
            {
                var code = sheet.Cells[row, 1].Text.Trim();
                var name = sheet.Cells[row, 2].Text.Trim();
                var province = sheet.Cells[row, 3].Text.Trim();
                var description = sheet.Cells[row, 4].Text?.Trim() ?? "";
                var logoUrl = sheet.Cells[row, 5].Text?.Trim() ?? "";

                if (string.IsNullOrWhiteSpace(code) || string.IsNullOrWhiteSpace(name))
                {
                    row++;
                    continue;
                }

                var school = _db.Schools.FirstOrDefault(s => s.Code == code);
                if (school == null)
                {
                    school = new School
                    {
                        Code = code,
                        Name = name,
                        Province = province,
                        Description = description,
                        LogoUrl = logoUrl
                    };
                    _db.Schools.Add(school);
                }
                else
                {
                    // update nếu đã tồn tại
                    school.Name = name;
                    school.Province = province;
                    school.Description = description;
                    school.LogoUrl = logoUrl;
                }

                row++;
            }

            await _db.SaveChangesAsync();
            return Ok("Import danh sách trường thành công!");
        }
    }
}
