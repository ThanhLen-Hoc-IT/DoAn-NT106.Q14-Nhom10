using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
using UniGate.Domain.Entities;

namespace UniGate.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // ====== Các bảng ======
        public DbSet<User> Users { get; set; }
        public DbSet<UserScores> UserScores { get; set; }

        public DbSet<School> Schools { get; set; }
        public DbSet<Major> Majors { get; set; }

        public DbSet<Combo> Combos { get; set; }
        public DbSet<ComboSubject> ComboSubjects { get; set; }
        public DbSet<MajorCombo> MajorCombos { get; set; }

        public DbSet<UserSelectedCombo> UserSelectedCombos { get; set; }

        public DbSet<MajorCutoff> MajorCutoffs { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // ===== User – UserScores (1:1) =====
            modelBuilder.Entity<UserScores>()
                .HasKey(x => x.UserId);

            modelBuilder.Entity<UserScores>()
                .HasOne(x => x.User)
                .WithOne(x => x.Scores)
                .HasForeignKey<UserScores>(x => x.UserId);

            // ===== Major – Combo (n:n) =====
            modelBuilder.Entity<MajorCombo>()
                .HasKey(mc => new { mc.MajorId, mc.ComboId });

            modelBuilder.Entity<MajorCombo>()
                .HasOne(mc => mc.Major)
                .WithMany(m => m.MajorCombos)
                .HasForeignKey(mc => mc.MajorId);

            modelBuilder.Entity<MajorCombo>()
                .HasOne(mc => mc.Combo)
                .WithMany(c => c.MajorCombos)
                .HasForeignKey(mc => mc.ComboId);

            //userselectedcombo
            modelBuilder.Entity<UserSelectedCombo>()
        .HasKey(x => new { x.UserId, x.ComboId });

            modelBuilder.Entity<UserSelectedCombo>()
                .HasOne(x => x.User)
                .WithMany()
                .HasForeignKey(x => x.UserId);

            modelBuilder.Entity<UserSelectedCombo>()
                .HasOne(x => x.Combo)
                .WithMany()
                .HasForeignKey(x => x.ComboId);

            //điểm chuẩn
            modelBuilder.Entity<MajorCutoff>()
    .HasOne(mc => mc.Major)
    .WithMany(m => m.Cutoffs)
    .HasForeignKey(mc => mc.MajorId);

        }
    }
}

