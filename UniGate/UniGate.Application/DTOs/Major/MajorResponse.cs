namespace UniGate.Application.DTOs.Major
{
    public class MajorResponse
    {
        public Guid MajorId { get; set; }
        public string Name { get; set; }
        public string SchoolName { get; set; }
        public List<string> ComboCodes { get; set; }
        public double? LastYearScore { get; set; }
    }
}
