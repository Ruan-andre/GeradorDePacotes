using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeradorDePacotes.Migrations
{
    /// <inheritdoc />
    public partial class AddColumnLastSelectedFile : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "LastSelected",
                table: "FileNameOutputLogs",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastSelected",
                table: "FileNameOutputLogs");
        }
    }
}
