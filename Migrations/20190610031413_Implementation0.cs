using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AFFMUSA.Migrations
{
    public partial class Implementation0 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    ClientID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Company_Name = table.Column<string>(maxLength: 50, nullable: false),
                    Contact_Name = table.Column<string>(maxLength: 30, nullable: false),
                    Job_Title = table.Column<string>(maxLength: 30, nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    Ext = table.Column<int>(nullable: false),
                    Fax = table.Column<string>(nullable: true),
                    City = table.Column<string>(maxLength: 30, nullable: false),
                    States = table.Column<int>(nullable: false),
                    ZipCode = table.Column<int>(nullable: false),
                    Country = table.Column<int>(nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    AllowBilling = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ClientID);
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ClientID", "AllowBilling", "City", "Company_Name", "Contact_Name", "Country", "Email", "Ext", "Fax", "Job_Title", "Notes", "Phone", "States", "ZipCode" },
                values: new object[] { 1, false, "Texas", "HR Company", "Julio", 0, "julio@hrcompany.com", 123, "7487583758", "Encargado de Suministros", "good worker", "890-878-8979", 0, 54000 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}
