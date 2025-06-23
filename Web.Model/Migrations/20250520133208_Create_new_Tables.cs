using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web.Model.Migrations
{
    /// <inheritdoc />
    public partial class Create_new_Tables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PersonalDesc",
                table: "Personals",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PersonalDesc",
                table: "Personals");
        }
    }
}
