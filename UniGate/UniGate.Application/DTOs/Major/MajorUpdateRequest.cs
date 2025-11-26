using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniGate.Application.DTOs.Major
{
    public class MajorUpdateRequest
    {
        public Guid Id { get; set; }
        public string MajorCode { get; set; }
        public string Name { get; set; }
        public int SchoolId { get; set; }
        public double CutoffScore { get; set; }

        public List<Guid> ComboIds { get; set; }
    }
}
