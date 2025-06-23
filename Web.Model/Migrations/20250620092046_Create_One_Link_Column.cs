using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web.Model.Migrations
{
    /// <inheritdoc />
    public partial class Create_One_Link_Column : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProjectLink",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProjectLink",
                table: "Projects");
        }
    }
}
