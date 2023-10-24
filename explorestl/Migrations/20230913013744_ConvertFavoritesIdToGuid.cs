using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace explorestl.Migrations
{
    public partial class ConvertFavoritesIdToGuid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AlterColumn<Guid>(
                name: "SightId",
                table: "UserSightFavorites",
                type: "char(36)",
                nullable: false,
                collation: "ascii_general_ci",
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "SightId",
                table: "UserSightFavorites",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "char(36)")
                .OldAnnotation("Relational:Collation", "ascii_general_ci");
        }
    }
}
