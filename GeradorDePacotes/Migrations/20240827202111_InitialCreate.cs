using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeradorDePacotes.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FilesToDelete",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NameFile = table.Column<string>(type: "TEXT", nullable: false),
                    Disconsider = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilesToDelete", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FilesToVerify",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NameFile = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilesToVerify", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FoldersToDelete",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NameFolder = table.Column<string>(type: "TEXT", nullable: false),
                    Disconsider = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoldersToDelete", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FoldersToVerify",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NameFolder = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoldersToVerify", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ParKeys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ParName = table.Column<string>(type: "TEXT", nullable: false),
                    ParValue = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParKeys", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FilesToDelete");

            migrationBuilder.DropTable(
                name: "FilesToVerify");

            migrationBuilder.DropTable(
                name: "FoldersToDelete");

            migrationBuilder.DropTable(
                name: "FoldersToVerify");

            migrationBuilder.DropTable(
                name: "ParKeys");
        }
    }
}
