using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab15.Migrations
{
    /// <inheritdoc />
    public partial class Update1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Emploeyys_Departments_FK_Emploeyy_Department",
                table: "Emploeyys");

            migrationBuilder.DropForeignKey(
                name: "FK_Emploeyys_Roles_FK_Emploeyy_Role",
                table: "Emploeyys");

            migrationBuilder.DropIndex(
                name: "IX_Emploeyys_FK_Emploeyy_Department",
                table: "Emploeyys");

            migrationBuilder.DropIndex(
                name: "IX_Emploeyys_FK_Emploeyy_Role",
                table: "Emploeyys");

            migrationBuilder.DropColumn(
                name: "FK_Emploeyy_Department",
                table: "Emploeyys");

            migrationBuilder.DropColumn(
                name: "FK_Emploeyy_Role",
                table: "Emploeyys");

            migrationBuilder.CreateIndex(
                name: "IX_Emploeyys_DepartmentID",
                table: "Emploeyys",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Emploeyys_RoleID",
                table: "Emploeyys",
                column: "RoleID");

            migrationBuilder.AddForeignKey(
                name: "FK_Emploeyys_Departments_DepartmentID",
                table: "Emploeyys",
                column: "DepartmentID",
                principalTable: "Departments",
                principalColumn: "DepartmentID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Emploeyys_Roles_RoleID",
                table: "Emploeyys",
                column: "RoleID",
                principalTable: "Roles",
                principalColumn: "RoleID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Emploeyys_Departments_DepartmentID",
                table: "Emploeyys");

            migrationBuilder.DropForeignKey(
                name: "FK_Emploeyys_Roles_RoleID",
                table: "Emploeyys");

            migrationBuilder.DropIndex(
                name: "IX_Emploeyys_DepartmentID",
                table: "Emploeyys");

            migrationBuilder.DropIndex(
                name: "IX_Emploeyys_RoleID",
                table: "Emploeyys");

            migrationBuilder.AddColumn<int>(
                name: "FK_Emploeyy_Department",
                table: "Emploeyys",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FK_Emploeyy_Role",
                table: "Emploeyys",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Emploeyys_FK_Emploeyy_Department",
                table: "Emploeyys",
                column: "FK_Emploeyy_Department");

            migrationBuilder.CreateIndex(
                name: "IX_Emploeyys_FK_Emploeyy_Role",
                table: "Emploeyys",
                column: "FK_Emploeyy_Role");

            migrationBuilder.AddForeignKey(
                name: "FK_Emploeyys_Departments_FK_Emploeyy_Department",
                table: "Emploeyys",
                column: "FK_Emploeyy_Department",
                principalTable: "Departments",
                principalColumn: "DepartmentID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Emploeyys_Roles_FK_Emploeyy_Role",
                table: "Emploeyys",
                column: "FK_Emploeyy_Role",
                principalTable: "Roles",
                principalColumn: "RoleID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
