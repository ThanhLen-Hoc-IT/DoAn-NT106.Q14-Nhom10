using Microsoft.AspNetCore.Http;

namespace UniGate.Api.DTOs
{
    public class ComboUploadDto
    {
        public IFormFile File { get; set; }
    }
}
