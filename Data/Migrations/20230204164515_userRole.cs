using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaseDeDatosPrueba.Data.Migrations
{
    public partial class userRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bec9cdd8-5173-4d89-bd38-efa0177c0adf", "7a35ded0-0de2-46ff-9e9d-586f4c85e321", "Administrador", "ADMINISTRADOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a4a18b40-862f-42a8-9445-b76e41a5813e", 0, "220c82a8-7dba-449a-af01-ff12892f9932", "ApplicationUser", "martinezjohnny324@gmail.com", true, false, null, "MARTINEZJOHNNY324@GMAIL.COM", "MARTINEZJOHNNY324@GMAIL.COM", "AQAAAAEAACcQAAAAEGE8PtvvOx7wTMFimIPxu+KB29c8dL/5pWTL0jRingsE/LU+VkjAyw32KyKe2PNFRw==", null, false, "7b64bd96-e010-4056-a933-d0d856de6e8a", false, "martinezjohnny324@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "bec9cdd8-5173-4d89-bd38-efa0177c0adf", "a4a18b40-862f-42a8-9445-b76e41a5813e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bec9cdd8-5173-4d89-bd38-efa0177c0adf", "a4a18b40-862f-42a8-9445-b76e41a5813e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bec9cdd8-5173-4d89-bd38-efa0177c0adf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a4a18b40-862f-42a8-9445-b76e41a5813e");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");
        }
    }
}
