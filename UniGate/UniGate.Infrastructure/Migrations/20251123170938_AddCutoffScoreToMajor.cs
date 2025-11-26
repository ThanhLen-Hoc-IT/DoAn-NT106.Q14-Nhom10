using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniGate.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddCutoffScoreToMajor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "CutoffScore",
                table: "Majors",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CutoffScore",
                table: "Majors");
        }
    }
}
