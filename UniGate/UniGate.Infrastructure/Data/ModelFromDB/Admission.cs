using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UniGate.Infrastructure.Data.ModelFromDB;

[Index("UniversityId", "MajorId", "GroupId", "Year", Name = "UQ_Admission_Unique", IsUnique = true)]
public partial class Admission
{
    [Key]
    [Column("AdmissionID")]
    public int AdmissionId { get; set; }

    [Column("UniversityID")]
    public int UniversityId { get; set; }

    [Column("MajorID")]
    public int MajorId { get; set; }

    [Column("GroupID")]
    public int GroupId { get; set; }

    public short Year { get; set; }

    public double MinScore { get; set; }

    public double? MedianScore { get; set; }

    public double? Percentile25 { get; set; }

    public double? Percentile75 { get; set; }

    public double? MaxScore { get; set; }

    [ForeignKey("GroupId")]
    [InverseProperty("Admissions")]
    public virtual SubjectGroup Group { get; set; } = null!;

    [ForeignKey("MajorId")]
    [InverseProperty("Admissions")]
    public virtual Major Major { get; set; } = null!;

    [ForeignKey("UniversityId")]
    [InverseProperty("Admissions")]
    public virtual University University { get; set; } = null!;
}
