using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UniGate.Infrastructure.Data.ModelFromDB;

[Index("TokenCode", Name = "UQ__Password__1AA20E15B0BDD667", IsUnique = true)]
public partial class PasswordResetToken
{
    [Key]
    [Column("TokenID")]
    public int TokenId { get; set; }

    [Column("UserID")]
    public int UserId { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string TokenCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ExpiryDate { get; set; }

    public bool IsUsed { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("PasswordResetTokens")]
    public virtual User User { get; set; } = null!;
}
