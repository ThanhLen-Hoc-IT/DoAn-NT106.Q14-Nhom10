using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniGate.Application.DTOs.School
{
    public class SchoolUpdateRequest
    {
        public int Id { get; set; }               // bắt buộc

        public string Name { get; set; }
        public string Code { get; set; }
        public string Province { get; set; }
        public string Description { get; set; }
        public string LogoUrl { get; set; }
    }
}
