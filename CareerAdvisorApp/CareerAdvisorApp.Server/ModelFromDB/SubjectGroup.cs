using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CareerAdvisorApp.Server.ModelFromDB;

[Index("GroupName", Name = "UQ_SubjectGroups_GroupName", IsUnique = true)]
public partial class SubjectGroup
{
    [Key]
    [Column("GroupID")]
    public int GroupId { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string GroupName { get; set; } = null!;

    [StringLength(100)]
    public string Subjects { get; set; } = null!;

    [InverseProperty("Group")]
    public virtual ICollection<Admission> Admissions { get; set; } = new List<Admission>();

    [InverseProperty("Group")]
    public virtual ICollection<GroupScoreDistribution> GroupScoreDistributions { get; set; } = new List<GroupScoreDistribution>();

    [InverseProperty("Group")]
    public virtual ICollection<MajorGroup> MajorGroups { get; set; } = new List<MajorGroup>();
}
