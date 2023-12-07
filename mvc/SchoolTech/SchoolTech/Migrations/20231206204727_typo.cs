using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolTech.Migrations
{
    public partial class typo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GebuikerRol_Gebruiker_GebruikerId",
                table: "GebuikerRol");

            migrationBuilder.DropForeignKey(
                name: "FK_GebuikerRol_Rol_RolId",
                table: "GebuikerRol");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GebuikerRol",
                table: "GebuikerRol");

            migrationBuilder.RenameTable(
                name: "GebuikerRol",
                newName: "GebruikerRol");

            migrationBuilder.RenameIndex(
                name: "IX_GebuikerRol_RolId",
                table: "GebruikerRol",
                newName: "IX_GebruikerRol_RolId");

            migrationBuilder.RenameIndex(
                name: "IX_GebuikerRol_GebruikerId",
                table: "GebruikerRol",
                newName: "IX_GebruikerRol_GebruikerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GebruikerRol",
                table: "GebruikerRol",
                column: "GebruikerRolId");

            migrationBuilder.AddForeignKey(
                name: "FK_GebruikerRol_Gebruiker_GebruikerId",
                table: "GebruikerRol",
                column: "GebruikerId",
                principalTable: "Gebruiker",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GebruikerRol_Rol_RolId",
                table: "GebruikerRol",
                column: "RolId",
                principalTable: "Rol",
                principalColumn: "RolId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GebruikerRol_Gebruiker_GebruikerId",
                table: "GebruikerRol");

            migrationBuilder.DropForeignKey(
                name: "FK_GebruikerRol_Rol_RolId",
                table: "GebruikerRol");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GebruikerRol",
                table: "GebruikerRol");

            migrationBuilder.RenameTable(
                name: "GebruikerRol",
                newName: "GebuikerRol");

            migrationBuilder.RenameIndex(
                name: "IX_GebruikerRol_RolId",
                table: "GebuikerRol",
                newName: "IX_GebuikerRol_RolId");

            migrationBuilder.RenameIndex(
                name: "IX_GebruikerRol_GebruikerId",
                table: "GebuikerRol",
                newName: "IX_GebuikerRol_GebruikerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GebuikerRol",
                table: "GebuikerRol",
                column: "GebruikerRolId");

            migrationBuilder.AddForeignKey(
                name: "FK_GebuikerRol_Gebruiker_GebruikerId",
                table: "GebuikerRol",
                column: "GebruikerId",
                principalTable: "Gebruiker",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GebuikerRol_Rol_RolId",
                table: "GebuikerRol",
                column: "RolId",
                principalTable: "Rol",
                principalColumn: "RolId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
