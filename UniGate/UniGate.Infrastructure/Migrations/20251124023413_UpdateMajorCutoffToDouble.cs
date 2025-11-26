using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniGate.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateMajorCutoffToDouble : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "CutoffScore",
                table: "Majors",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "CutoffScore",
                table: "Majors",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }
    }
}
