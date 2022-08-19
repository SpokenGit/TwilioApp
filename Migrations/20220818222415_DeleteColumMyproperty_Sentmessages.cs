using Microsoft.EntityFrameworkCore.Migrations;

namespace TwilioWeb.Migrations
{
    public partial class DeleteColumMyproperty_Sentmessages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "sentmessagess");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "sentmessagess",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
