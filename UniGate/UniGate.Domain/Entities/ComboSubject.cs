using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniGate.Domain.Entities
{
    public class ComboSubject
    {
        public int Id { get; set; }
        public Guid ComboId { get; set; }

        public string Subject { get; set; }

        public Combo Combo { get; set; }
    }
}
