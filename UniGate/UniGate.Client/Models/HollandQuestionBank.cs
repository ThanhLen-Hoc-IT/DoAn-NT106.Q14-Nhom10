using System.Collections.Generic;

namespace UniGate.Client.Models
{
    /// <summary>
    /// Ngân hàng câu hỏi Holland (mới demo vài câu).
    /// Vy tự thêm tiếp cho đủ 60 câu chia theo R, I, A, S, E, C.
    /// </summary>
    public static class HollandQuestionBank
    {
        public static List<HollandQuestion> GetQuestions()
        {
            var list = new List<HollandQuestion>
            {
                new HollandQuestion { Id = 1, Text = "Sửa chữa đồ điện tử",           Group = 'R' },
                new HollandQuestion { Id = 2, Text = "Lắp ráp máy móc",               Group = 'R' },
                new HollandQuestion { Id = 3, Text = "Làm thí nghiệm khoa học",       Group = 'I' },
                new HollandQuestion { Id = 4, Text = "Giải các bài toán khó",         Group = 'I' },
                new HollandQuestion { Id = 5, Text = "Vẽ tranh, thiết kế poster",     Group = 'A' },
                new HollandQuestion { Id = 6, Text = "Viết truyện, làm thơ",          Group = 'A' },
                new HollandQuestion { Id = 7, Text = "Giúp đỡ, tư vấn cho người khác",Group = 'S' },
                new HollandQuestion { Id = 8, Text = "Làm việc nhóm, hoạt động CLB",  Group = 'S' },
                new HollandQuestion { Id = 9, Text = "Thuyết trình, bán hàng",        Group = 'E' },
                new HollandQuestion { Id = 10, Text = "Lãnh đạo, tổ chức sự kiện",    Group = 'E' },
                new HollandQuestion { Id = 11, Text = "Sắp xếp hồ sơ, giấy tờ",       Group = 'C' },
                new HollandQuestion { Id = 12, Text = "Làm việc với số liệu, bảng tính", Group = 'C' },
                // TODO: Vy tự bổ sung tiếp cho đủ 60 câu
            };

            return list;
        }
    }
}
