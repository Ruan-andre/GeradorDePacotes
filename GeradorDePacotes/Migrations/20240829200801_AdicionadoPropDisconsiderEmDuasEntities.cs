using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeradorDePacotes.Migrations
{
    /// <inheritdoc />
    public partial class AdicionadoPropDisconsiderEmDuasEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Disconsider",
                table: "FoldersToVerify",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Disconsider",
                table: "FilesToVerify",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Disconsider",
                table: "FoldersToVerify");

            migrationBuilder.DropColumn(
                name: "Disconsider",
                table: "FilesToVerify");
        }
    }
}
