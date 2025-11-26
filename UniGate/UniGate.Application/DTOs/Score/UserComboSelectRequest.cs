using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniGate.Application.DTOs.Score
{
    public class UserComboSelectRequest
    {
        public Guid UserId { get; set; }
        public List<Guid> ComboIds { get; set; } = new();
    }
}
