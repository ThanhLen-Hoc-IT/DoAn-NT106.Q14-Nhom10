using UniGate.Domain.Entities;

public class Combo
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Code { get; set; } = string.Empty;

    public ICollection<ComboSubject> ComboSubjects { get; set; } = new List<ComboSubject>();
    public ICollection<MajorCombo> MajorCombos { get; set; }  = new List<MajorCombo>();
}
