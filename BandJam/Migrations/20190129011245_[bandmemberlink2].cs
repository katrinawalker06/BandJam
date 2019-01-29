using Microsoft.EntityFrameworkCore.Migrations;

namespace BandJam.Migrations
{
    public partial class bandmemberlink2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BandId",
                table: "BandMembers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BandMembers_BandId",
                table: "BandMembers",
                column: "BandId");

            migrationBuilder.AddForeignKey(
                name: "FK_BandMembers_Bands_BandId",
                table: "BandMembers",
                column: "BandId",
                principalTable: "Bands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BandMembers_Bands_BandId",
                table: "BandMembers");

            migrationBuilder.DropIndex(
                name: "IX_BandMembers_BandId",
                table: "BandMembers");

            migrationBuilder.DropColumn(
                name: "BandId",
                table: "BandMembers");
        }
    }
}
