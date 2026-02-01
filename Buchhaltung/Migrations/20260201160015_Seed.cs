using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Buchhaltung.Migrations
{
    /// <inheritdoc />
    public partial class Seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "DKB" },
                    { 2, "Sparkasse" },
                    { 3, "TR Cash" },
                    { 4, "TR Portfolio" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
