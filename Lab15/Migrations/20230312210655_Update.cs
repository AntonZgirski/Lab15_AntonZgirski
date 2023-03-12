using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab15.Migrations
{
    /// <inheritdoc />
    public partial class Update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Emploeyys_Departments_DepartmentId",
                table: "Emploeyys");

            migrationBuilder.DropForeignKey(
                name: "FK_Emploeyys_Roles_RoleId",
                table: "Emploeyys");

            migrationBuilder.DropIndex(
                name: "IX_Emploeyys_DepartmentId",
                table: "Emploeyys");

            migrationBuilder.DropIndex(
                name: "IX_Emploeyys_RoleId",
                table: "Emploeyys");

            migrationBuilder.RenameColumn(
                name: "RoleId",
                table: "Emploeyys",
                newName: "RoleID");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "Emploeyys",
                newName: "DepartmentID");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "RoleID",
                table: "Emploeyys",
                newName: "RoleId");

            migrationBuilder.RenameColumn(
                name: "DepartmentID",
                table: "Emploeyys",
                newName: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Emploeyys_DepartmentId",
                table: "Emploeyys",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Emploeyys_RoleId",
                table: "Emploeyys",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Emploeyys_Departments_DepartmentId",
                table: "Emploeyys",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "DepartmentID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Emploeyys_Roles_RoleId",
                table: "Emploeyys",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "RoleID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
