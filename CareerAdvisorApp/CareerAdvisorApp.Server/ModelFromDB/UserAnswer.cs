using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CareerAdvisorApp.Server.ModelFromDB;

[Index("UserId", "QuestionId", Name = "UQ_UserAnswer_Test", IsUnique = true)]
public partial class UserAnswer
{
    [Key]
    [Column("AnswerID")]
    public int AnswerId { get; set; }

    [Column("UserID")]
    public int UserId { get; set; }

    [Column("QuestionID")]
    public int QuestionId { get; set; }

    [StringLength(10)]
    public string SelectedOption { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? AnswerDate { get; set; }

    [ForeignKey("QuestionId")]
    [InverseProperty("UserAnswers")]
    public virtual Question Question { get; set; } = null!;

    [ForeignKey("UserId")]
    [InverseProperty("UserAnswers")]
    public virtual User User { get; set; } = null!;
}
