using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GenerateDocs.Migrations
{
    /// <inheritdoc />
    public partial class RenameColumnNameToYear : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "EducationProgramms",
                newName: "Year");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Year",
                table: "EducationProgramms",
                newName: "Name");
        }
    }
}
