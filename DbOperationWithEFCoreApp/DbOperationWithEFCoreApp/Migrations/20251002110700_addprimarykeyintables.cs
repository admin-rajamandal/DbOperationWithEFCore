using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DbOperationWithEFCoreApp.Migrations
{
    /// <inheritdoc />
    public partial class addprimarykeyintables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BookId",
                table: "BookPrices",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "CurrencyTypes",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CurrencyTypes",
                table: "CurrencyTypes",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CurrencyTypes",
                table: "CurrencyTypes");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "CurrencyTypes");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "BookPrices",
                newName: "BookId");
        }
    }
}
