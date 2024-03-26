using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PostgreSQL.Migrations
{
    /// <inheritdoc />
    public partial class AddUser111 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Country_CountryId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_CountryId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "Company",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Company_CountryId",
                table: "Company",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Company_Country_CountryId",
                table: "Company",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Company_Country_CountryId",
                table: "Company");

            migrationBuilder.DropIndex(
                name: "IX_Company_CountryId",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Company");

            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "Users",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_CountryId",
                table: "Users",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Country_CountryId",
                table: "Users",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id");
        }
    }
}
