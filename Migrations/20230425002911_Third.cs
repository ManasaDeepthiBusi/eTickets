using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTickets.Migrations
{
    /// <inheritdoc />
    public partial class Third : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actors_Movies_Actors_ActorID",
                table: "Actors_Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Actors_Movies_Movies_MovieID",
                table: "Actors_Movies");

            migrationBuilder.RenameColumn(
                name: "FullNamee",
                table: "Producers",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "MovieID",
                table: "Actors_Movies",
                newName: "MovieId");

            migrationBuilder.RenameColumn(
                name: "ActorID",
                table: "Actors_Movies",
                newName: "ActorId");

            migrationBuilder.RenameIndex(
                name: "IX_Actors_Movies_MovieID",
                table: "Actors_Movies",
                newName: "IX_Actors_Movies_MovieId");

            migrationBuilder.RenameColumn(
                name: "FullNamee",
                table: "Actors",
                newName: "FullName");

            migrationBuilder.AddForeignKey(
                name: "FK_Actors_Movies_Actors_ActorId",
                table: "Actors_Movies",
                column: "ActorId",
                principalTable: "Actors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Actors_Movies_Movies_MovieId",
                table: "Actors_Movies",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actors_Movies_Actors_ActorId",
                table: "Actors_Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Actors_Movies_Movies_MovieId",
                table: "Actors_Movies");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Producers",
                newName: "FullNamee");

            migrationBuilder.RenameColumn(
                name: "MovieId",
                table: "Actors_Movies",
                newName: "MovieID");

            migrationBuilder.RenameColumn(
                name: "ActorId",
                table: "Actors_Movies",
                newName: "ActorID");

            migrationBuilder.RenameIndex(
                name: "IX_Actors_Movies_MovieId",
                table: "Actors_Movies",
                newName: "IX_Actors_Movies_MovieID");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Actors",
                newName: "FullNamee");

            migrationBuilder.AddForeignKey(
                name: "FK_Actors_Movies_Actors_ActorID",
                table: "Actors_Movies",
                column: "ActorID",
                principalTable: "Actors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Actors_Movies_Movies_MovieID",
                table: "Actors_Movies",
                column: "MovieID",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
