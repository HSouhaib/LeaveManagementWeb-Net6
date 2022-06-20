using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class RemovingEmployeeTableFromDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8e4a43a43-9f07-4124-957cbbd-c60bb846e7abf",
                column: "ConcurrencyStamp",
                value: "b2ba56f7-5023-49ec-b23b-6874e7ebb688");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8e4a4a43-9f07-4124-957d-c60bb846e7bf",
                column: "ConcurrencyStamp",
                value: "a29891d4-83ef-443b-9e05-9c5247c3dcc2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "654dae5c-6726-4c62-8f4a-70933c2951a6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "746af416-72a9-4e7c-bcc9-73bf370704e5", "AQAAAAEAACcQAAAAEOFonqFkjWcT6p51Fx1CBHmmtYkVGRMUtXIkVuFq4arhly/vh4OpxJwqSe6KvwQCrw==", "807cfcea-e2d7-4e2f-ac0c-7b9e7798bebc" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8e4a43a43-9f07-4124-957cbbd-c60bb846e7abf",
                column: "ConcurrencyStamp",
                value: "644aeb49-d85c-4525-ab50-25a3eb923443");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8e4a4a43-9f07-4124-957d-c60bb846e7bf",
                column: "ConcurrencyStamp",
                value: "76af3237-d48e-496d-bd2a-71db67992d93");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "654dae5c-6726-4c62-8f4a-70933c2951a6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d93db165-82d7-4cf2-9959-50993fad8e18", "AQAAAAEAACcQAAAAEMCsQq60Ggl5w/2+cicYOTXUTv3IkU1zVbvAIRT9VHfbgUt//nBYnu3/v11yIxW6pg==", "8426a458-08ae-4b96-8174-8ef2b9c542bd" });
        }
    }
}
