using UniGate.Domain.Entities;

public class Combo
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Code { get; set; }

    public ICollection<ComboSubject> ComboSubjects { get; set; }
    public ICollection<MajorCombo> MajorCombos { get; set; }
}
