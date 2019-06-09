using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AFFMUSA.Migrations
{
    public partial class Implementation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    ClientID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Company_Name = table.Column<string>(maxLength: 50, nullable: false),
                    Contact_Name = table.Column<string>(maxLength: 30, nullable: false),
                    Job_Title = table.Column<string>(maxLength: 20, nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    Ext = table.Column<int>(maxLength: 5, nullable: false),
                    Fax = table.Column<string>(nullable: true),
                    City = table.Column<string>(maxLength: 30, nullable: false),
                    ZipCode = table.Column<int>(nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    Photo = table.Column<string>(nullable: true),
                    AllowBilling = table.Column<bool>(nullable: false),
                    CountryID = table.Column<int>(nullable: true),
                    StateID = table.Column<int>(nullable: true)

                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.ClientID);
                });

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    CountryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CountryName = table.Column<string>(maxLength: 30, nullable: false),
                  
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.CountryID);
                    table.ForeignKey(
                        name: "FK_Country_Client_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Client",
                        principalColumn: "ClientID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "States",
                columns: table => new
                {
                    StatesID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StateName = table.Column<string>(maxLength: 30, nullable: false),
                    ClientID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_States", x => x.StatesID);
                    table.ForeignKey(
                        name: "FK_States_Client_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Client",
                        principalColumn: "ClientID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Country_ClientID",
                table: "Country",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_States_ClientID",
                table: "States",
                column: "ClientID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropTable(
                name: "States");

            migrationBuilder.DropTable(
                name: "Client");
        }
    }
}
