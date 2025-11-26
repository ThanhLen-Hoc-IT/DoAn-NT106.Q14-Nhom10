using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniGate.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Combos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Combos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Schools",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Province = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogoUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schools", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ComboSubjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComboId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComboSubjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ComboSubjects_Combos_ComboId",
                        column: x => x.ComboId,
                        principalTable: "Combos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Majors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MajorCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SchoolId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Majors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Majors_Schools_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "Schools",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserScores",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HB_Toan_10 = table.Column<float>(type: "real", nullable: true),
                    HB_Toan_11 = table.Column<float>(type: "real", nullable: true),
                    HB_Toan_12 = table.Column<float>(type: "real", nullable: true),
                    HB_Van_10 = table.Column<float>(type: "real", nullable: true),
                    HB_Van_11 = table.Column<float>(type: "real", nullable: true),
                    HB_Van_12 = table.Column<float>(type: "real", nullable: true),
                    HB_Su_10 = table.Column<float>(type: "real", nullable: true),
                    HB_Su_11 = table.Column<float>(type: "real", nullable: true),
                    HB_Su_12 = table.Column<float>(type: "real", nullable: true),
                    HB_Dia_10 = table.Column<float>(type: "real", nullable: true),
                    HB_Dia_11 = table.Column<float>(type: "real", nullable: true),
                    HB_Dia_12 = table.Column<float>(type: "real", nullable: true),
                    HB_GDKTPL_10 = table.Column<float>(type: "real", nullable: true),
                    HB_GDKTPL_11 = table.Column<float>(type: "real", nullable: true),
                    HB_GDKTPL_12 = table.Column<float>(type: "real", nullable: true),
                    HB_Ly_10 = table.Column<float>(type: "real", nullable: true),
                    HB_Ly_11 = table.Column<float>(type: "real", nullable: true),
                    HB_Ly_12 = table.Column<float>(type: "real", nullable: true),
                    HB_Hoa_10 = table.Column<float>(type: "real", nullable: true),
                    HB_Hoa_11 = table.Column<float>(type: "real", nullable: true),
                    HB_Hoa_12 = table.Column<float>(type: "real", nullable: true),
                    HB_Sinh_10 = table.Column<float>(type: "real", nullable: true),
                    HB_Sinh_11 = table.Column<float>(type: "real", nullable: true),
                    HB_Sinh_12 = table.Column<float>(type: "real", nullable: true),
                    HB_Tin_10 = table.Column<float>(type: "real", nullable: true),
                    HB_Tin_11 = table.Column<float>(type: "real", nullable: true),
                    HB_Tin_12 = table.Column<float>(type: "real", nullable: true),
                    HB_CongNghe_10 = table.Column<float>(type: "real", nullable: true),
                    HB_CongNghe_11 = table.Column<float>(type: "real", nullable: true),
                    HB_CongNghe_12 = table.Column<float>(type: "real", nullable: true),
                    HB_NgoaiNgu_Mon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HB_NgoaiNgu_10 = table.Column<float>(type: "real", nullable: true),
                    HB_NgoaiNgu_11 = table.Column<float>(type: "real", nullable: true),
                    HB_NgoaiNgu_12 = table.Column<float>(type: "real", nullable: true),
                    Thpt_Toan = table.Column<float>(type: "real", nullable: true),
                    Thpt_Van = table.Column<float>(type: "real", nullable: true),
                    Thpt_TuChon1_Mon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Thpt_TuChon1_Diem = table.Column<float>(type: "real", nullable: true),
                    Thpt_TuChon2_Mon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Thpt_TuChon2_Diem = table.Column<float>(type: "real", nullable: true),
                    DGNL_NgonNgu = table.Column<float>(type: "real", nullable: true),
                    DGNL_Toan = table.Column<float>(type: "real", nullable: true),
                    DGNL_TuDuy = table.Column<float>(type: "real", nullable: true),
                    KhuVuc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DoiTuong = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiemCongThem = table.Column<float>(type: "real", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserScores", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_UserScores_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserSelectedCombos",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ComboId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSelectedCombos", x => new { x.UserId, x.ComboId });
                    table.ForeignKey(
                        name: "FK_UserSelectedCombos_Combos_ComboId",
                        column: x => x.ComboId,
                        principalTable: "Combos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserSelectedCombos_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MajorCombos",
                columns: table => new
                {
                    MajorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ComboId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MajorCombos", x => new { x.MajorId, x.ComboId });
                    table.ForeignKey(
                        name: "FK_MajorCombos_Combos_ComboId",
                        column: x => x.ComboId,
                        principalTable: "Combos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MajorCombos_Majors_MajorId",
                        column: x => x.MajorId,
                        principalTable: "Majors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ComboSubjects_ComboId",
                table: "ComboSubjects",
                column: "ComboId");

            migrationBuilder.CreateIndex(
                name: "IX_MajorCombos_ComboId",
                table: "MajorCombos",
                column: "ComboId");

            migrationBuilder.CreateIndex(
                name: "IX_Majors_SchoolId",
                table: "Majors",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSelectedCombos_ComboId",
                table: "UserSelectedCombos",
                column: "ComboId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComboSubjects");

            migrationBuilder.DropTable(
                name: "MajorCombos");

            migrationBuilder.DropTable(
                name: "UserScores");

            migrationBuilder.DropTable(
                name: "UserSelectedCombos");

            migrationBuilder.DropTable(
                name: "Majors");

            migrationBuilder.DropTable(
                name: "Combos");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Schools");
        }
    }
}
