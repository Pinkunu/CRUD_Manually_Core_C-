using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_UI_Javascript.Migrations
{
    public partial class initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Employeeid = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    EmployeeName = table.Column<string>(nullable: true),
                    Position = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Employeeid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
