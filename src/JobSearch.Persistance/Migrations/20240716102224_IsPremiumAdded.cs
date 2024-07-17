using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobSearch.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class IsPremiumAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsPremium",
                table: "Announcment",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsPremium",
                table: "Announcment");
        }
    }
}
