using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web.Model.Migrations
{
    /// <inheritdoc />
    public partial class Update_Table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PostalCode",
                table: "Personals");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PostalCode",
                table: "Personals",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
