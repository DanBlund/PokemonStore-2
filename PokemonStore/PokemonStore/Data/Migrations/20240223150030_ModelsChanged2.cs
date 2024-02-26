using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonStore.Migrations
{
    /// <inheritdoc />
    public partial class ModelsChanged2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Pokemons",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pokemons_UserId",
                table: "Pokemons",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemons_AspNetUsers_UserId",
                table: "Pokemons",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pokemons_AspNetUsers_UserId",
                table: "Pokemons");

            migrationBuilder.DropIndex(
                name: "IX_Pokemons_UserId",
                table: "Pokemons");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Pokemons");
        }
    }
}
