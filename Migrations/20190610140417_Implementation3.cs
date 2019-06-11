using Microsoft.EntityFrameworkCore.Migrations;

namespace AFFMUSA.Migrations
{
    public partial class Implementation3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Countries_CountryID",
                table: "Clients");

            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                table: "Clients",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CountryID",
                table: "Clients",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientID",
                keyValue: 1,
                column: "CountryID",
                value: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Countries_CountryID",
                table: "Clients",
                column: "CountryID",
                principalTable: "Countries",
                principalColumn: "CountryID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Countries_CountryID",
                table: "Clients");

            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                table: "Clients",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "CountryID",
                table: "Clients",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientID",
                keyValue: 1,
                column: "CountryID",
                value: null);

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Countries_CountryID",
                table: "Clients",
                column: "CountryID",
                principalTable: "Countries",
                principalColumn: "CountryID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
