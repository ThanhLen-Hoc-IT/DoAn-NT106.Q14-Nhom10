namespace UniGate.Client.Models
{
    public class MajorResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string SchoolName { get; set; }
        public List<string> ComboCodes { get; set; }
        public double? LastYearScore { get; set; }
    }
}
