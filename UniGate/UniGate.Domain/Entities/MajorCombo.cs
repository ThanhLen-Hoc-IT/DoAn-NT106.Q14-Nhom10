using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniGate.Domain.Entities
{
    public class MajorCombo
    {
        public Guid MajorId { get; set; }
        public Major Major { get; set; } = null!;

        public Guid ComboId { get; set; }
        public Combo Combo { get; set; } = null!;
    }

}
