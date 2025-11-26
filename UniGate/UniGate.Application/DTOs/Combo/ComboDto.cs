namespace UniGate.Application.DTOs.Combo
{
   
        public class ComboDto
        {
            public Guid Id { get; set; }
            public string Code { get; set; }
            public List<string> Subjects { get; set; }

            public override string ToString()
            {
                string mons = (Subjects != null && Subjects.Any())
                    ? string.Join(", ", Subjects)
                    : "(Không có môn)";

                return $"{Code} – {mons}";
            }
        }
    
}
