using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UniGate.Api.ModelFromDB;

[Index("TestName", Name = "UQ_TestTypes_TestName", IsUnique = true)]
public partial class TestType
{
    [Key]
    [Column("TestTypeID")]
    public int TestTypeId { get; set; }

    [StringLength(50)]
    public string TestName { get; set; } = null!;

    [StringLength(255)]
    public string? Description { get; set; }

    [InverseProperty("TestType")]
    public virtual ICollection<CareerSuggestion> CareerSuggestions { get; set; } = new List<CareerSuggestion>();

    [InverseProperty("TestType")]
    public virtual ICollection<Question> Questions { get; set; } = new List<Question>();

    [InverseProperty("TestType")]
    public virtual ICollection<TestResult> TestResults { get; set; } = new List<TestResult>();
}
