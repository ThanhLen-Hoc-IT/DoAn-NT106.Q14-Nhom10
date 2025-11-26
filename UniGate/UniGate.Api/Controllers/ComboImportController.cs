using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using UniGate.Infrastructure.Data;
using UniGate.Domain.Entities;
using UniGate.Api.DTOs;
//này để up file tổ hợp lên swagger thoai chứ ko quan trọng nhóe
namespace UniGate.Api.Controllers
{
    [ApiController]
    [Route("api/import")]
    public class ComboImportController : ControllerBase
    {
        private readonly AppDbContext _db;

        public ComboImportController(AppDbContext db)
        {
            _db = db;
        }

        [HttpPost("combos")]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> ImportCombos([FromForm] ComboUploadDto request)
        {
            var file = request.File;

            if (file == null || file.Length == 0)
                return BadRequest("File không hợp lệ!");

            // EPPlus yêu cầu câu này
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using var stream = new MemoryStream();
            await file.CopyToAsync(stream);
            stream.Position = 0;

            using var package = new ExcelPackage(stream);
            var sheet = package.Workbook.Worksheets[0];

            if (sheet == null)
                return BadRequest("Không tìm thấy sheet trong file Excel!");

            int row = 2; 

            while (sheet.Cells[row, 1].Value != null)
            {
                string comboCode = sheet.Cells[row, 1].Text.Trim();
                string subjects = sheet.Cells[row, 2].Text.Trim(); // Ví dụ: "Toán, Lý, Hoá"

                if (string.IsNullOrWhiteSpace(comboCode))
                {
                    row++;
                    continue;
                }

                // Kiểm tra xem Combo đã có chưa
                var combo = _db.Combos.FirstOrDefault(x => x.Code == comboCode);
                if (combo == null)
                {
                    combo = new Combo { Code = comboCode };
                    _db.Combos.Add(combo);
                    await _db.SaveChangesAsync();
                }

                // Xoá dữ liệu cũ trước khi thêm môn mới
                var oldSubs = _db.ComboSubjects.Where(x => x.ComboId == combo.Id);
                _db.ComboSubjects.RemoveRange(oldSubs);

                // Tách môn
                var subjectList = subjects.Split(',')
                                          .Select(x => x.Trim())
                                          .Where(x => x.Length > 0)
                                          .ToList();

                foreach (var sub in subjectList)
                {
                    _db.ComboSubjects.Add(new ComboSubject
                    {
                        ComboId = combo.Id,
                        Subject = sub
                    });
                }

                await _db.SaveChangesAsync();
                row++;
            }

            return Ok("Import tổ hợp môn thành công!");
        }
    }
}
