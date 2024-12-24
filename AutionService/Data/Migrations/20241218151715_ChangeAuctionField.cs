using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutionService.Data.Migrations
{
    /// <inheritdoc />
    public partial class ChangeAuctionField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AutionEnd",
                table: "Auctions",
                newName: "AuctionEnd");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AuctionEnd",
                table: "Auctions",
                newName: "AutionEnd");
        }
    }
}
