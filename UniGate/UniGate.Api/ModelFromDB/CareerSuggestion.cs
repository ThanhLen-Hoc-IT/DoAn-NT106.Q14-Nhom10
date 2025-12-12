using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UniGate.Api.ModelFromDB;

public partial class CareerSuggestion
{
    [Key]
    [Column("SuggestionID")]
    public int SuggestionId { get; set; }

    [Column("TestTypeID")]
    public int TestTypeId { get; set; }

    [StringLength(10)]
    public string ResultCode { get; set; } = null!;

    [Column("MajorID")]
    public int MajorId { get; set; }

    [StringLength(255)]
    public string? Note { get; set; }

    [ForeignKey("MajorId")]
    [InverseProperty("CareerSuggestions")]
    public virtual Major Major { get; set; } = null!;

    [ForeignKey("TestTypeId")]
    [InverseProperty("CareerSuggestions")]
    public virtual TestType TestType { get; set; } = null!;
}
