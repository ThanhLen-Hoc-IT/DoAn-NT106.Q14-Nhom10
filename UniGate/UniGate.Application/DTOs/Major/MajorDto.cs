using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniGate.Application.DTOs.Major
{
    public class MajorDto
    {
        public Guid Id { get; set; }
        public string MajorCode { get; set; }
        public string Name { get; set; }
        public int SchoolId { get; set; }
        public string SchoolName { get; set; }
        public double CutoffScore { get; set; }

        public List<string> Combos { get; set; }   // danh sách A00, A01, D01
    }
}
