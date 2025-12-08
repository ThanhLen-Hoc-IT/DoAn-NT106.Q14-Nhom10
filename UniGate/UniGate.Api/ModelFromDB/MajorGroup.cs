using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UniGate.Api.ModelFromDB;

[Index("MajorId", "GroupId", "ExamYear", Name = "UQ_MajorGroup_Link", IsUnique = true)]
public partial class MajorGroup
{
    [Key]
    [Column("MajorGroupID")]
    public int MajorGroupId { get; set; }

    [Column("MajorID")]
    public int MajorId { get; set; }

    [Column("GroupID")]
    public int GroupId { get; set; }

    public short? ExamYear { get; set; }

    [ForeignKey("GroupId")]
    [InverseProperty("MajorGroups")]
    public virtual SubjectGroup Group { get; set; } = null!;

    [ForeignKey("MajorId")]
    [InverseProperty("MajorGroups")]
    public virtual Major Major { get; set; } = null!;
}
