using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class UpdatedRequestedComment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComment",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComment",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8e4a43a43-9f07-4124-957cbbd-c60bb846e7abf",
                column: "ConcurrencyStamp",
                value: "31cedf7a-f247-4e75-b20b-1ea136ffc307");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8e4a4a43-9f07-4124-957d-c60bb846e7bf",
                column: "ConcurrencyStamp",
                value: "0027f977-e82d-4cd6-872e-07fbb345b0a7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "654dae5c-6726-4c62-8f4a-70933c2951a6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c0fede37-eb79-4bda-9c13-6459387badfe", "AQAAAAEAACcQAAAAEPFS2KYqreSohJH3F93Z6j7X4n6sc8fTGcPAitLv3UQC3BkOdPRyQVpwEMm1dZ/G/g==", "4bea5d9e-38f2-47af-857c-aefa2935dceb" });
        }
    }
}
