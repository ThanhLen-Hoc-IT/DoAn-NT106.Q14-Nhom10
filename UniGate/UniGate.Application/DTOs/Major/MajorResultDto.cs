using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniGate.Application.DTOs.Major
{
    public class MajorResultDto
    {
        public Guid MajorId { get; set; }

        public string MajorName { get; set; }
        public string MajorCode { get; set; }

        public string SchoolName { get; set; }
        public string SchoolCode { get; set; }

        public List<string> Combos { get; set; }
    }
}
