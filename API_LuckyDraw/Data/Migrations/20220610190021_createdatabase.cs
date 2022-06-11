using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_LuckyDraw.Data.Migrations
{
    public partial class createdatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GIFT",
                columns: table => new
                {
                    CODE = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DESCRIPTION = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ACTIVE = table.Column<bool>(type: "bit", nullable: true),
                    CREATEDATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CODEUSAGELIMIT = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GIFT", x => x.CODE);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GIFT");
        }
    }
}
