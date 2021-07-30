using Microsoft.EntityFrameworkCore.Migrations;

namespace api.Migrations
{
    public partial class SampleDat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Desc", "Name" },
                values: new object[] { 1, "Serie De gta Rolplay, ooc: muy buena", "Marbella Vice" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Desc", "Name" },
                values: new object[] { 2, "Serie de Minecract creada por Auron", "TortillaLand" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Desc", "Name" },
                values: new object[] { 3, "Seria de el juego Day Z con duracion de 14 Dias", "14Days" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "Age", "Character", "MovieId", "name" },
                values: new object[] { 15, null, "Iris Marquez", 1, "Elisa Waves" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "Age", "Character", "MovieId", "name" },
                values: new object[] { 6, null, "Greco Rodrigues", 1, "Karchez" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "Age", "Character", "MovieId", "name" },
                values: new object[] { 7, null, "Fedor", 1, "Carola" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "Age", "Character", "MovieId", "name" },
                values: new object[] { 8, null, "carola", 2, "carola" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "Age", "Character", "MovieId", "name" },
                values: new object[] { 9, null, "toni gambino", 2, "auron" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "Age", "Character", "MovieId", "name" },
                values: new object[] { 10, null, "elisa", 3, "Elisa Waves" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "Age", "Character", "MovieId", "name" },
                values: new object[] { 11, null, "Ronnie", 3, "Ronnie 6" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
