using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToffeeTavern.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "C_CHARACTER",
                columns: table => new
                {
                    C_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    C_NAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    C_LEVEL = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_C_CHARACTER", x => x.C_ID);
                });

            migrationBuilder.CreateTable(
                name: "Q_QUEST",
                columns: table => new
                {
                    Q_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Q_C_ID = table.Column<int>(type: "int", nullable: false),
                    Q_TITLE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Q_DESCRIPTION = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Q_QUEST_GIVER = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Q_LOCATION = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Q_PRIORITY = table.Column<int>(type: "int", nullable: false),
                    Q_TYPE = table.Column<int>(type: "int", nullable: false),
                    Q_STATUS = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Q_QUEST", x => x.Q_ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "C_CHARACTER");

            migrationBuilder.DropTable(
                name: "Q_QUEST");
        }
    }
}
