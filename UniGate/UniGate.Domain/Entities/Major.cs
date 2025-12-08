using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniGate.Domain.Entities
{
    public class Major
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string MajorCode { get; set; } = string.Empty;
        public double CutoffScore { get; set; }

        public int SchoolId { get; set; }
        public School School { get; set; }  = null!;

        public ICollection<MajorCombo> MajorCombos { get; set; } = new List<MajorCombo>();
        public ICollection<MajorCutoff> Cutoffs { get; set; } = new List<MajorCutoff>();

    }

}
