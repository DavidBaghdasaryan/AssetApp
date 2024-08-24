using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class up : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsUpdated",
                table: "Rooms",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsUpdated",
                table: "Projects",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsUpdated",
                table: "Elements",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsUpdated",
                table: "Buildings",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsUpdated",
                table: "BuildingGroups",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsUpdated",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "IsUpdated",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "IsUpdated",
                table: "Elements");

            migrationBuilder.DropColumn(
                name: "IsUpdated",
                table: "Buildings");

            migrationBuilder.DropColumn(
                name: "IsUpdated",
                table: "BuildingGroups");
        }
    }
}
