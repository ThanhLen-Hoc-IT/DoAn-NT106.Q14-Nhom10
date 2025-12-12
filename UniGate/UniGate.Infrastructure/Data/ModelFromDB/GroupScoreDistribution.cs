using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UniGate.Infrastructure.Data.ModelFromDB;

[Index("GroupId", "ExamYear", "TotalScoreLevel", Name = "IX_GSD_Query")]
[Index("GroupId", "ExamYear", "TotalScoreLevel", Name = "UQ_GSD_GroupYearScore", IsUnique = true)]
public partial class GroupScoreDistribution
{
    [Key]
    [Column("DistDetailID")]
    public int DistDetailId { get; set; }

    [Column("GroupID")]
    public int GroupId { get; set; }

    public short ExamYear { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal TotalScoreLevel { get; set; }

    public int CountStudents { get; set; }

    public double ProbDistribution { get; set; }

    [ForeignKey("GroupId")]
    [InverseProperty("GroupScoreDistributions")]
    public virtual SubjectGroup Group { get; set; } = null!;
}
