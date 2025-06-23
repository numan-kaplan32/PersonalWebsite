using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web.Model.Migrations
{
    /// <inheritdoc />
    public partial class add_pass_column : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Personals",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "Personals");
        }
    }
}
