using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore; // Cần thêm nếu chưa có
using System.Linq; // Cần thêm nếu chưa có
using System.Threading.Tasks; // Cần thêm nếu chưa có

using UniGate.Api.ModelFromDB;
// Đổi dòng using UniGate.Domain.Entities; thành dùng alias để tránh xung đột
using DomainUser = UniGate.Domain.Entities.User; // <-- SỬA DÒNG NÀY

namespace UniGate.Api.Controllers
{
    // Route mặc định: /UniGate
    [Route("[controller]")]
    [ApiController]
    public class UniGateController : ControllerBase
    {
        // Sử dụng private readonly và tên biến _context chuẩn
        private readonly CSDL_DOANContext _context;

        // 1. SỬA LỖI CÚ PHÁP: Constructor Injection (Thêm tên biến 'context')
        public UniGateController(CSDL_DOANContext context)
        {
            _context = context; // Gán giá trị vào biến _context
        }

        // -------------------------------------------------------------------
        // 1. READ (GET) - Lấy danh sách Người dùng
        // Route: GET /UniGate/users/list
        // -------------------------------------------------------------------

        [HttpGet("users/list")]
        public async Task<IActionResult> GetUserList()
        {
            // Giả định bảng Users được ánh xạ là DbSet<User>
            var users = await _context.Users
                                      .Include(u => u.Role)
                                      .ToListAsync();

            return Ok(new { data = users });
        }

        // -------------------------------------------------------------------
        // 2. CREATE (POST) - Thêm người dùng mới
        // Route: POST /UniGate/users/add
        // -------------------------------------------------------------------

        [HttpPost("users/add")]
        public async Task<IActionResult> CreateUser([FromBody] User newUser)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Users.Add(newUser);
            await _context.SaveChangesAsync();

            // Trả về 201 Created
            return CreatedAtAction(nameof(GetUserList), new { id = newUser.UserId }, newUser);
        }

        // -------------------------------------------------------------------
        // 3. UPDATE (PUT) - Cập nhật thông tin người dùng
        // Route: PUT /UniGate/users/update/{id}
        // -------------------------------------------------------------------

        [HttpPut("users/update/{id}")]
        public async Task<IActionResult> UpdateUser(int id, [FromBody] User updatedUser)
        {
            if (id != updatedUser.UserId)
            {
                return BadRequest("ID không khớp.");
            }

            _context.Entry(updatedUser).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Users.Any(e => e.UserId == id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent(); // 204 No Content
        }

        // -------------------------------------------------------------------
        // 4. DELETE (DELETE) - Xóa người dùng
        // Route: DELETE /UniGate/users/delete/{id}
        // -------------------------------------------------------------------

        [HttpDelete("users/delete/{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return Ok(user);
        }
    }
}