using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniGate.Domain.Entities
{
    public class MajorCutoff
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public Guid MajorId { get; set; }
        public Major Major { get; set; } = null!;

        public float Cutoff { get; set; }  // điểm chuẩn gần nhất
    }
}
