using Microsoft.EntityFrameworkCore.Migrations;

namespace IdentityByExamples.Migrations
{
    public partial class InsertedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2cca1be7-c2c4-4d86-99b5-aab92c9e4e53", "dc64c510-4ad7-435c-b323-7af669f0f5f2", "Supervisor", "SUPERVISOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "04c1a382-9773-4f7d-90ef-e0dec5ae5570", "698e2da5-9e47-408d-89b5-b8b3364e4524", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ab689abb-998f-4560-a69e-366b17870184", "bfea12f0-ea08-4ec4-87c3-044a38eaba0b", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "04c1a382-9773-4f7d-90ef-e0dec5ae5570");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2cca1be7-c2c4-4d86-99b5-aab92c9e4e53");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ab689abb-998f-4560-a69e-366b17870184");
        }
    }
}
