using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UniGate.Api.ModelFromDB;

[Index("CertificateName", "OriginalScore", "ExamYear", Name = "UQ_ScoreConversion", IsUnique = true)]
public partial class ScoreConversion
{
    [Key]
    [Column("ConversionID")]
    public int ConversionId { get; set; }

    [StringLength(50)]
    public string CertificateName { get; set; } = null!;

    public double OriginalScore { get; set; }

    public double ConvertedScore { get; set; }

    public short? ExamYear { get; set; }
}
