namespace UniGate.Domain.Entities
{
    public class UserSelectedCombo
    {
        public Guid UserId { get; set; }
        public Guid ComboId { get; set; }

        public User User { get; set; } = null!;
        public Combo Combo { get; set; } = null!;
    }
}
