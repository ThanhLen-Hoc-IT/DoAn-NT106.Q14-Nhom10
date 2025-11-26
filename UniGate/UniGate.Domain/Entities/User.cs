using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniGate.Domain.Entities
{
    public class User
    {
        public Guid Id { get; set; }

        public string UserName { get; set; }
        public string Email { get; set; }

        public string PasswordHash { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }

        public bool IsActive { get; set; } = true;

        public UserScores Scores { get; set; }   // 1 user → 1 bảng điểm
    }

}
