using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PostgreSQL.Migrations
{
    /// <inheritdoc />
    public partial class AddUser110 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddCheckConstraint(
                name: "ValidAge",
                table: "Users",
                sql: "\"Age\" > 0 AND \"Age\" < 120");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "ValidAge",
                table: "Users");
        }
    }
}
