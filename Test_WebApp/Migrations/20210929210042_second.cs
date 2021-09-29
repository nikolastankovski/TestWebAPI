using Microsoft.EntityFrameworkCore.Migrations;

namespace Test_WebApp.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_referenceTypes_References_Reference_Id",
                table: "referenceTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_referenceTypes",
                table: "referenceTypes");

            migrationBuilder.RenameTable(
                name: "referenceTypes",
                newName: "ReferenceTypes");

            migrationBuilder.RenameIndex(
                name: "IX_referenceTypes_Reference_Id",
                table: "ReferenceTypes",
                newName: "IX_ReferenceTypes_Reference_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReferenceTypes",
                table: "ReferenceTypes",
                column: "ReferenceType_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ReferenceTypes_References_Reference_Id",
                table: "ReferenceTypes",
                column: "Reference_Id",
                principalTable: "References",
                principalColumn: "Reference_Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReferenceTypes_References_Reference_Id",
                table: "ReferenceTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReferenceTypes",
                table: "ReferenceTypes");

            migrationBuilder.RenameTable(
                name: "ReferenceTypes",
                newName: "referenceTypes");

            migrationBuilder.RenameIndex(
                name: "IX_ReferenceTypes_Reference_Id",
                table: "referenceTypes",
                newName: "IX_referenceTypes_Reference_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_referenceTypes",
                table: "referenceTypes",
                column: "ReferenceType_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_referenceTypes_References_Reference_Id",
                table: "referenceTypes",
                column: "Reference_Id",
                principalTable: "References",
                principalColumn: "Reference_Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
