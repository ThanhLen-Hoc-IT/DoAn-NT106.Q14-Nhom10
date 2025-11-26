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
        public string Name { get; set; }
        public string MajorCode { get; set; }
        public double CutoffScore { get; set; }

        public int SchoolId { get; set; }
        public School School { get; set; }

        public ICollection<MajorCombo> MajorCombos { get; set; }
        public ICollection<MajorCutoff> Cutoffs { get; set; }

    }

}
