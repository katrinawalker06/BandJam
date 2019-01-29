using Microsoft.EntityFrameworkCore.Migrations;

namespace BandJam.Migrations
{
    public partial class bandmemberlink : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BandName",
                table: "BandMembers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BandName",
                table: "BandMembers");
        }
    }
}
