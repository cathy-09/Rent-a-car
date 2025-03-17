using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rent_a_car.Data.Migrations
{
    public partial class CreateTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e94ff9da-18fb-4bbc-a29d-daedc2bc360a", "AQAAAAEAACcQAAAAEHWf8pm5/1kM6p26HW8u5hE4MvajI4f9iZJ2yRIo2jRSrQeyh3iitMx3g3vcs6euOQ==", "dcb3c335-b3b8-4258-8342-59c8e2b3d455" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "835ce7ed-6d3f-4930-b65d-57b35010cce4", "AQAAAAEAACcQAAAAEP9r2vDkQcxSKmfmsp9sxxi2X+yCci9bE4zJvXfxjB8Li4CqDtiEa9D8tZ795HMTYA==", "de4d1de6-06d9-41fa-ad57-ea715eb148c2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "88787b41-c331-4055-9883-a9cd8beed47e", "AQAAAAEAACcQAAAAEH9pJjlOPLYnedS4WmvORSVHlyYvIfgCIQzmq3Q2bwFJDlBNm1rShRVLOglV6P3gTQ==", "3a73040f-2882-424d-a15b-b6b7a4ee0b36" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ce405598-e092-45bf-9bcb-b42f37589b49", "AQAAAAEAACcQAAAAEF0bxzKdPT1AZKHdHjCW/k4kxVgc8kh/OgJXROj5TLy3mDqhN0SjFN0KOMx4chYWfg==", "9f49ed04-d273-4ccc-880c-1b34e2ab4c17" });
        }
    }
}
