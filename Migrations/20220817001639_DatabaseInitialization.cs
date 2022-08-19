using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TwilioWeb.Migrations
{
    public partial class DatabaseInitialization : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "messagess",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    datecreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    to_field = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    message = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_messagess", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "sentmessagess",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MyProperty = table.Column<int>(type: "int", nullable: false),
                    messagesId = table.Column<int>(type: "int", nullable: false),
                    sentdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    cofirmationcode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sentmessagess", x => x.Id);
                    table.ForeignKey(
                        name: "FK_sentmessagess_messagess_messagesId",
                        column: x => x.messagesId,
                        principalTable: "messagess",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_sentmessagess_messagesId",
                table: "sentmessagess",
                column: "messagesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "sentmessagess");

            migrationBuilder.DropTable(
                name: "messagess");
        }
    }
}
