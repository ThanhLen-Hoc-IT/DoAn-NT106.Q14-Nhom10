using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniGate.Application.DTOs.School
{
    public class SchoolDto
    {
        public int Id { get; set; }            // Khóa chính
        public string Name { get; set; }       // Tên trường
        public string Code { get; set; }       // Mã trường
        public string Province { get; set; }   // Tỉnh / TP
        public string Description { get; set; }// Mô tả
        public string LogoUrl { get; set; }    // Đường dẫn logo (nếu có)
    }
}
