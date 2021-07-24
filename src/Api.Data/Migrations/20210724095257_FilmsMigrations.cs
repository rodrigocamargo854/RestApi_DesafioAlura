using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class FilmsMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Videos",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    CreatAt = table.Column<DateTime>(nullable: true),
                    UpdateAt = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Videos", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Videos");
        }
    }
}
