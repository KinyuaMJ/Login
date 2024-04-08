using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LoginTestAPI.Migrations
{
    /// <inheritdoc />
    public partial class Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2bace4ea-8423-44cc-914a-6ef4c830aa17", "2bace4ea-8423-44cc-914a-6ef4c830aa17", "Manager", "MANAGER" },
                    { "2be07a0f-1f55-43e3-87e5-1daa83f845c7]", "2be07a0f-1f55-43e3-87e5-1daa83f845c7]", "Officer", "OFFICER" },
                    { "bc03dfe9-feb1-41e2-852d-21545e4d3aff", "bc03dfe9-feb1-41e2-852d-21545e4d3aff", "Supervisor", "SUPERVISOR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2bace4ea-8423-44cc-914a-6ef4c830aa17");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2be07a0f-1f55-43e3-87e5-1daa83f845c7]");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bc03dfe9-feb1-41e2-852d-21545e4d3aff");
        }
    }
}
