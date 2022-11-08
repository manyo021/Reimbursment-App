using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReimbursmentApp.Migrations
{
    /// <inheritdoc />
    public partial class UserTicketRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "tickets",
                type: "decimal(18,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "tickets",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tickets_UserId",
                table: "tickets",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_tickets_Users_UserId",
                table: "tickets",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tickets_Users_UserId",
                table: "tickets");

            migrationBuilder.DropIndex(
                name: "IX_tickets_UserId",
                table: "tickets");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "tickets");

            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "tickets",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)");
        }
    }
}
