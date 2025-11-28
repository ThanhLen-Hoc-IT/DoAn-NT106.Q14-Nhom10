using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CareerAdvisorApp.Server.ModelFromDB;

public partial class Region
{
    [Key]
    [Column("RegionID")]
    public int RegionId { get; set; }

    [StringLength(50)]
    public string RegionName { get; set; } = null!;

    public double BonusScore { get; set; }

    [InverseProperty("Region")]
    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
