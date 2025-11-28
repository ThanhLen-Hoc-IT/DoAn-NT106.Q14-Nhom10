using CareerAdvisorApp.Server.ModelFromDB;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

// Đảm bảo tên namespace trùng khớp với cấu trúc project của bạn
namespace CareerAdvisorApp.Server.Controllers
{
    [Route("[controller]")] // Route mặc định sẽ là /CareerAdv
    [ApiController]
    public class CareerAdvController : ControllerBase
    {
        private readonly CSDL_DOANContext _context; // Sử dụng convention _tên_biến

        // Constructor Injection: Tiêm DbContext vào Controller
        public CareerAdvController(CSDL_DOANContext context)
        {
            _context = context;
        }

        // -------------------------------------------------------------------
        // 1. READ (GET) - Xem danh sách và chi tiết
        // -------------------------------------------------------------------

        // Lấy toàn bộ danh sách câu trả lời
        // Ví dụ: GET /CareerAdv/List
        [HttpGet("List")]
        public async Task<IActionResult> GetList()
        {
            // Sử dụng ToListAsync() để thao tác không đồng bộ (Async) hiệu quả hơn
            var data = await _context.UserAnswers
                                     .Include(ua => ua.User)       // Nạp dữ liệu User liên quan (Nếu cần)
                                     .Include(ua => ua.Question)   // Nạp dữ liệu Question liên quan (Nếu cần)
                                     .ToListAsync();

            // Trả về dữ liệu thành công
            return Ok(new { data = data });
        }

        // Lấy chi tiết một câu trả lời theo ID
        // Ví dụ: GET /CareerAdv/Details/5
        [HttpGet("Details/{id}")]
        public async Task<IActionResult> GetDetails(int id)
        {
            var answer = await _context.UserAnswers.FindAsync(id);

            if (answer == null)
            {
                return NotFound($"Không tìm thấy câu trả lời với ID: {id}");
            }

            return Ok(answer);
        }

        // -------------------------------------------------------------------
        // 2. CREATE (POST) - Thêm mới dữ liệu (Thêm Câu trả lời mới)
        // -------------------------------------------------------------------

        // Ví dụ: POST /CareerAdv/Add
        [HttpPost("Add")]
        public async Task<IActionResult> CreateAnswer([FromBody] UserAnswer newAnswer)
        {
            // Kiểm tra tính hợp lệ của Model được gửi lên (Validation)
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); // Trả về lỗi nếu dữ liệu không hợp lệ
            }

            // Do AnswerID là IDENTITY nên không cần gán
            _context.UserAnswers.Add(newAnswer);
            await _context.SaveChangesAsync();

            // Trả về 201 Created và đối tượng vừa được tạo
            // new { id = newAnswer.AnswerId } giúp client biết ID của đối tượng mới
            return CreatedAtAction(nameof(GetDetails), new { id = newAnswer.AnswerId }, newAnswer);
        }

        // -------------------------------------------------------------------
        // 3. UPDATE (PUT) - Cập nhật dữ liệu
        // -------------------------------------------------------------------

        // Ví dụ: PUT /CareerAdv/Update/5
        [HttpPut("Update/{id}")]
        public async Task<IActionResult> UpdateAnswer(int id, [FromBody] UserAnswer updatedAnswer)
        {
            // Kiểm tra ID trong URL có khớp với ID trong Body không
            if (id != updatedAnswer.AnswerId)
            {
                return BadRequest("ID không khớp.");
            }

            // Theo dõi trạng thái của đối tượng để Entity Framework biết cần UPDATE
            _context.Entry(updatedAnswer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                // Kiểm tra xem đối tượng có tồn tại không
                if (!_context.UserAnswers.Any(e => e.AnswerId == id))
                {
                    return NotFound($"Không tìm thấy câu trả lời với ID: {id}");
                }
                else
                {
                    throw; // Ném lỗi nếu có vấn đề đồng thời khác
                }
            }

            return NoContent(); // Trả về 204 No Content (cập nhật thành công)
        }

        // -------------------------------------------------------------------
        // 4. DELETE (DELETE) - Xóa dữ liệu
        // -------------------------------------------------------------------

        // Ví dụ: DELETE /CareerAdv/Delete/5
        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> DeleteAnswer(int id)
        {
            var answer = await _context.UserAnswers.FindAsync(id);
            if (answer == null)
            {
                return NotFound($"Không tìm thấy câu trả lời với ID: {id}");
            }

            _context.UserAnswers.Remove(answer);
            await _context.SaveChangesAsync();

            return Ok(new { message = $"Đã xóa câu trả lời ID: {id}", deletedItem = answer });
        }
    }
}