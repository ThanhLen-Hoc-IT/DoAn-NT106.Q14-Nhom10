using System.Collections.Generic;

namespace UniGate.Client.Models
{
    // Lưu điểm 1 nhóm Holland
    public class HollandScore
    {
        public char Group { get; set; }   // 'R','I','A','S','E','C'
        public int Score { get; set; }
    }

    // Helper (nếu muốn convert từ Dictionary<string,int>)
    public static class HollandScoreHelper
    {
        public static List<HollandScore> FromDictionary(Dictionary<string, int> dict)
        {
            var list = new List<HollandScore>();

            void Add(char g)
            {
                dict.TryGetValue(g.ToString(), out var v);
                list.Add(new HollandScore
                {
                    Group = g,
                    Score = v
                });
            }

            Add('R');
            Add('I');
            Add('A');
            Add('S');
            Add('E');
            Add('C');

            return list;
        }
    }
}
