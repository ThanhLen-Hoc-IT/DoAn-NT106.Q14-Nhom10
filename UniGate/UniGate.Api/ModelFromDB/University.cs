using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UniGate.Api.ModelFromDB;

[Index("UniversityCode", Name = "UQ__Universi__8A42ECF46F348B2F", IsUnique = true)]
public partial class University
{
    [Key]
    [Column("UniversityID")]
    public int UniversityId { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? UniversityCode { get; set; }

    [StringLength(255)]
    public string UniversityName { get; set; } = null!;

    [StringLength(100)]
    public string? Province { get; set; }

    [StringLength(255)]
    public string? Website { get; set; }

    [InverseProperty("University")]
    public virtual ICollection<Admission> Admissions { get; set; } = new List<Admission>();
}
