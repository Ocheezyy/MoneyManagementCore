using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFDataAccessLibrary.Migrations
{
    public partial class inial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dccus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Transaction_Number = table.Column<string>(maxLength: 200, nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(maxLength: 200, nullable: true),
                    Memo = table.Column<string>(maxLength: 200, nullable: true),
                    Amount_Debit = table.Column<string>(maxLength: 20, nullable: true),
                    Balance = table.Column<double>(nullable: false),
                    Fees = table.Column<string>(maxLength: 30, nullable: true),
                    Principal = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dccus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Discs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Trans_Date = table.Column<DateTime>(nullable: false),
                    Post_Date = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: true),
                    Amount = table.Column<double>(nullable: false),
                    Category = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dccus");

            migrationBuilder.DropTable(
                name: "Discs");
        }
    }
}
