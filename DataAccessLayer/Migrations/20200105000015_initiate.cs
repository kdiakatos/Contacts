using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class initiate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactNumbers");

            migrationBuilder.AddColumn<string>(
                name: "Phone1",
                table: "Contacts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone2",
                table: "Contacts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone3",
                table: "Contacts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone4",
                table: "Contacts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Phone1",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "Phone2",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "Phone3",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "Phone4",
                table: "Contacts");

            migrationBuilder.CreateTable(
                name: "ContactNumbers",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactID = table.Column<long>(type: "bigint", nullable: true),
                    PhoneNumber = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactNumbers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ContactNumbers_Contacts_ContactID",
                        column: x => x.ContactID,
                        principalTable: "Contacts",
                        principalColumn: "ContactID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContactNumbers_ContactID",
                table: "ContactNumbers",
                column: "ContactID");
        }
    }
}
