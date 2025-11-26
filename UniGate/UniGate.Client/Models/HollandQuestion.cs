using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UniGate.Client.Models
{
    /// <summary>
    /// 1 câu trong bài test Holland
    /// </summary>
    public class HollandQuestion
    {
        public int Id { get; set; }          // số thứ tự câu hỏi (1..60)
        public string Text { get; set; } = ""; // nội dung câu
        public char Group { get; set; }      // 'R', 'I', 'A', 'S', 'E', 'C'
    }
}
