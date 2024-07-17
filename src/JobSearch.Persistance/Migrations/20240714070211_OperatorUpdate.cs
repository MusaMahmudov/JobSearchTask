using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobSearch.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class OperatorUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PhoneNumberOperators_Operator_OperatorId",
                table: "PhoneNumberOperators");

            migrationBuilder.DropTable(
                name: "Operator");

            migrationBuilder.DropIndex(
                name: "IX_PhoneNumberOperators_OperatorId",
                table: "PhoneNumberOperators");

            migrationBuilder.DropColumn(
                name: "OperatorId",
                table: "PhoneNumberOperators");

            migrationBuilder.AddColumn<string>(
                name: "Operator",
                table: "PhoneNumberOperators",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Operator",
                table: "PhoneNumberOperators");

            migrationBuilder.AddColumn<Guid>(
                name: "OperatorId",
                table: "PhoneNumberOperators",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Operator",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operator", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumberOperators_OperatorId",
                table: "PhoneNumberOperators",
                column: "OperatorId");

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneNumberOperators_Operator_OperatorId",
                table: "PhoneNumberOperators",
                column: "OperatorId",
                principalTable: "Operator",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
