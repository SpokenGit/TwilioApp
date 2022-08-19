using Microsoft.EntityFrameworkCore.Migrations;

namespace TwilioWeb.Migrations
{
    public partial class AddingTwilio_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "twilioCredentials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TSID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TTOKEN = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_twilioCredentials", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "twilioCredentials");
        }
    }
}
