namespace UniGate.Application.DTOs.Score
{
    public class UserComboCodeSelectRequest
    {
        public Guid UserId { get; set; }
        public List<string> ComboCodes { get; set; }
    }
}
