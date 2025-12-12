using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UniGate.Infrastructure.Data.ModelFromDB;

[Index("UserId", "TestTypeId", Name = "UQ_TestResult_UserType", IsUnique = true)]
public partial class TestResult
{
    [Key]
    [Column("ResultID")]
    public int ResultId { get; set; }

    [Column("UserID")]
    public int UserId { get; set; }

    [Column("TestTypeID")]
    public int TestTypeId { get; set; }

    [StringLength(10)]
    public string ResultCode { get; set; } = null!;

    [StringLength(500)]
    public string? ResultText { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TestDate { get; set; }

    [ForeignKey("TestTypeId")]
    [InverseProperty("TestResults")]
    public virtual TestType TestType { get; set; } = null!;

    [ForeignKey("UserId")]
    [InverseProperty("TestResults")]
    public virtual User User { get; set; } = null!;
}
