using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HomeWork28._05.Migrations
{
    public partial class InitCrate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Quotes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Text = table.Column<string>(nullable: false),
                    Author = table.Column<string>(nullable: true),
                    InsertDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quotes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "InsertDate", "Text" },
                values: new object[] { 1, "Master Ugvey", new DateTime(2012, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Случайности не случайные" });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "InsertDate", "Text" },
                values: new object[] { 2, "Master Ugvey", new DateTime(2013, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Случайности не случайные" });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "InsertDate", "Text" },
                values: new object[] { 3, "Master Ugvey", new DateTime(2014, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Случайности не случайные" });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "InsertDate", "Text" },
                values: new object[] { 4, "Master Ugvey", new DateTime(2015, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Случайности не случайные" });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "InsertDate", "Text" },
                values: new object[] { 5, "Master Ugvey", new DateTime(2016, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Случайности не случайные" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Quotes");
        }
    }
}
