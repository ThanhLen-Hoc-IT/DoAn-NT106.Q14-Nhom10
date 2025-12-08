using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UniGate.Api.ModelFromDB;

[Index("MajorCode", Name = "UQ__Majors__64E58F9447D5C072", IsUnique = true)]
public partial class Major
{
    [Key]
    [Column("MajorID")]
    public int MajorId { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? MajorCode { get; set; }

    [StringLength(150)]
    public string MajorName { get; set; } = null!;

    [StringLength(500)]
    public string? Description { get; set; }

    [InverseProperty("Major")]
    public virtual ICollection<Admission> Admissions { get; set; } = new List<Admission>();

    [InverseProperty("Major")]
    public virtual ICollection<CareerSuggestion> CareerSuggestions { get; set; } = new List<CareerSuggestion>();

    [InverseProperty("Major")]
    public virtual ICollection<MajorGroup> MajorGroups { get; set; } = new List<MajorGroup>();
}
