using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace UniGate.Infrastructure.Data.ModelFromDB;

public partial class CSDL_DOANContext : DbContext
{
    public CSDL_DOANContext()
    {
    }

    public CSDL_DOANContext(DbContextOptions<CSDL_DOANContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Admission> Admissions { get; set; }

    public virtual DbSet<CareerSuggestion> CareerSuggestions { get; set; }

    public virtual DbSet<GroupScoreDistribution> GroupScoreDistributions { get; set; }

    public virtual DbSet<Major> Majors { get; set; }

    public virtual DbSet<MajorGroup> MajorGroups { get; set; }

    public virtual DbSet<PasswordResetToken> PasswordResetTokens { get; set; }

    public virtual DbSet<Question> Questions { get; set; }

    public virtual DbSet<Region> Regions { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<ScoreConversion> ScoreConversions { get; set; }

    public virtual DbSet<SubjectGroup> SubjectGroups { get; set; }

    public virtual DbSet<TestResult> TestResults { get; set; }

    public virtual DbSet<TestType> TestTypes { get; set; }

    public virtual DbSet<University> Universities { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserAnswer> UserAnswers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DELL-010824-01; Initial Catalog=CSDL_DOAN; Persist Security Info=True; User ID=sa; Password=Kimngan17052006; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Admission>(entity =>
        {
            entity.HasKey(e => e.AdmissionId).HasName("PK__Admissio__C97EEFA22A05FB0F");

            entity.HasOne(d => d.Group).WithMany(p => p.Admissions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Admission__Group__71D1E811");

            entity.HasOne(d => d.Major).WithMany(p => p.Admissions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Admission__Major__70DDC3D8");

            entity.HasOne(d => d.University).WithMany(p => p.Admissions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Admission__Unive__6FE99F9F");
        });

        modelBuilder.Entity<CareerSuggestion>(entity =>
        {
            entity.HasKey(e => e.SuggestionId).HasName("PK__CareerSu__940995280A6F3C23");

            entity.HasOne(d => d.Major).WithMany(p => p.CareerSuggestions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CareerSug__Major__75A278F5");

            entity.HasOne(d => d.TestType).WithMany(p => p.CareerSuggestions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CareerSug__TestT__74AE54BC");
        });

        modelBuilder.Entity<GroupScoreDistribution>(entity =>
        {
            entity.HasKey(e => e.DistDetailId).HasName("PK__GroupSco__745A9E15CF607C18");

            entity.HasOne(d => d.Group).WithMany(p => p.GroupScoreDistributions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__GroupScor__Group__797309D9");
        });

        modelBuilder.Entity<Major>(entity =>
        {
            entity.HasKey(e => e.MajorId).HasName("PK__Majors__D5B8BFB19B4855AD");
        });

        modelBuilder.Entity<MajorGroup>(entity =>
        {
            entity.HasKey(e => e.MajorGroupId).HasName("PK__MajorGro__4F8668CACEADF360");

            entity.HasOne(d => d.Group).WithMany(p => p.MajorGroups)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__MajorGrou__Group__6C190EBB");

            entity.HasOne(d => d.Major).WithMany(p => p.MajorGroups)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__MajorGrou__Major__6B24EA82");
        });

        modelBuilder.Entity<PasswordResetToken>(entity =>
        {
            entity.HasKey(e => e.TokenId).HasName("PK__Password__658FEE8ABB626A6B");

            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.User).WithMany(p => p.PasswordResetTokens)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Token_User");
        });

        modelBuilder.Entity<Question>(entity =>
        {
            entity.HasKey(e => e.QuestionId).HasName("PK__Question__0DC06F8CB0F9BEA9");

            entity.HasOne(d => d.TestType).WithMany(p => p.Questions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Questions__TestT__534D60F1");
        });

        modelBuilder.Entity<Region>(entity =>
        {
            entity.HasKey(e => e.RegionId).HasName("PK__Regions__ACD84443B438C4F0");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("PK__Roles__8AFACE3A512EAA2D");
        });

        modelBuilder.Entity<ScoreConversion>(entity =>
        {
            entity.HasKey(e => e.ConversionId).HasName("PK__ScoreCon__A7A07F9306106EF5");
        });

        modelBuilder.Entity<SubjectGroup>(entity =>
        {
            entity.HasKey(e => e.GroupId).HasName("PK__SubjectG__149AF30A77F44226");
        });

        modelBuilder.Entity<TestResult>(entity =>
        {
            entity.HasKey(e => e.ResultId).HasName("PK__TestResu__9769022879A7FAE2");

            entity.Property(e => e.TestDate).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.TestType).WithMany(p => p.TestResults)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TestResul__TestT__5EBF139D");

            entity.HasOne(d => d.User).WithMany(p => p.TestResults)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TestResul__UserI__5DCAEF64");
        });

        modelBuilder.Entity<TestType>(entity =>
        {
            entity.HasKey(e => e.TestTypeId).HasName("PK__TestType__9BB87646E8E270C9");
        });

        modelBuilder.Entity<University>(entity =>
        {
            entity.HasKey(e => e.UniversityId).HasName("PK__Universi__9F19E19CEB361637");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Users__1788CCACAECC2FE2");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Region).WithMany(p => p.Users).HasConstraintName("FK__Users__RegionID__44FF419A");

            entity.HasOne(d => d.Role).WithMany(p => p.Users)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Users__RoleID__440B1D61");
        });

        modelBuilder.Entity<UserAnswer>(entity =>
        {
            entity.HasKey(e => e.AnswerId).HasName("PK__UserAnsw__D48250240D14360D");

            entity.Property(e => e.AnswerDate).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Question).WithMany(p => p.UserAnswers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__UserAnswe__Quest__59063A47");

            entity.HasOne(d => d.User).WithMany(p => p.UserAnswers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__UserAnswe__UserI__5812160E");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
