using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UniGate.Api.ModelFromDB;

public partial class Question
{
    [Key]
    [Column("QuestionID")]
    public int QuestionId { get; set; }

    [Column("TestTypeID")]
    public int TestTypeId { get; set; }

    [StringLength(500)]
    public string QuestionText { get; set; } = null!;

    [StringLength(200)]
    public string? OptionA { get; set; }

    [StringLength(200)]
    public string? OptionB { get; set; }

    [StringLength(200)]
    public string? OptionC { get; set; }

    [StringLength(200)]
    public string? OptionD { get; set; }

    [StringLength(10)]
    public string? CorrectOption { get; set; }

    [ForeignKey("TestTypeId")]
    [InverseProperty("Questions")]
    public virtual TestType TestType { get; set; } = null!;

    [InverseProperty("Question")]
    public virtual ICollection<UserAnswer> UserAnswers { get; set; } = new List<UserAnswer>();
}
