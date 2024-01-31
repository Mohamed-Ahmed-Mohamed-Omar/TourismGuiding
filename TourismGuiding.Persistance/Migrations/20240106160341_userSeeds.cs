using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TourismGuiding.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class userSeeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                   table: "AspNetUsers",
                   columns: new[] { "Id", "FullName", "UserName", "NormalizedUserName", "Email", "NormalizedEmail", "EmailConfirmed", "PasswordHash", "SecurityStamp", "ConcurrencyStamp", "PhoneNumber", "PhoneNumberConfirmed", "TwoFactorEnabled", "LockoutEnd", "LockoutEnabled", "AccessFailedCount" },
                   values: new object[]
                   {
            Guid.NewGuid().ToString(), "Zidan", "admin", "ADMIN", "admin@tourguiding.com", "ADMIN@EXAMPLE.COM", true,
            new PasswordHasher<IdentityUser>().HashPassword(null, "tHdv.@3kljxlokcvm41."), Guid.NewGuid().ToString(), "01007144974", "01007144974",
            false, false, null, false, 0
                   });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [AspNetUsers]");
        }

    }
}
