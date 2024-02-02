using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Authors_AuthorId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Categories_CategoriseId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Press_PresId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Themes_ThemeId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Facultises_FacultiseId",
                table: "Groups");

            migrationBuilder.DropForeignKey(
                name: "FK_S_Cards_Books_BookId",
                table: "S_Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_S_Cards_Libs_LibId",
                table: "S_Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_S_Cards_Students_StudentId",
                table: "S_Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Groups_GroupId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_T_Cards_Books_BookId",
                table: "T_Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_T_Cards_Libs_LibId",
                table: "T_Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_T_Cards_Teachers_TeacherId",
                table: "T_Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Departments_DepartmentId",
                table: "Teachers");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "Teachers",
                newName: "Id_Dep");

            migrationBuilder.RenameIndex(
                name: "IX_Teachers_DepartmentId",
                table: "Teachers",
                newName: "IX_Teachers_Id_Dep");

            migrationBuilder.RenameColumn(
                name: "TeacherId",
                table: "T_Cards",
                newName: "Id_Teacher");

            migrationBuilder.RenameColumn(
                name: "LibId",
                table: "T_Cards",
                newName: "Id_Lib");

            migrationBuilder.RenameColumn(
                name: "BookId",
                table: "T_Cards",
                newName: "Id_Book");

            migrationBuilder.RenameIndex(
                name: "IX_T_Cards_TeacherId",
                table: "T_Cards",
                newName: "IX_T_Cards_Id_Teacher");

            migrationBuilder.RenameIndex(
                name: "IX_T_Cards_LibId",
                table: "T_Cards",
                newName: "IX_T_Cards_Id_Lib");

            migrationBuilder.RenameIndex(
                name: "IX_T_Cards_BookId",
                table: "T_Cards",
                newName: "IX_T_Cards_Id_Book");

            migrationBuilder.RenameColumn(
                name: "GroupId",
                table: "Students",
                newName: "Id_Group");

            migrationBuilder.RenameIndex(
                name: "IX_Students_GroupId",
                table: "Students",
                newName: "IX_Students_Id_Group");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "S_Cards",
                newName: "Id_Student");

            migrationBuilder.RenameColumn(
                name: "LibId",
                table: "S_Cards",
                newName: "Id_Lib");

            migrationBuilder.RenameColumn(
                name: "BookId",
                table: "S_Cards",
                newName: "Id_Book");

            migrationBuilder.RenameIndex(
                name: "IX_S_Cards_StudentId",
                table: "S_Cards",
                newName: "IX_S_Cards_Id_Student");

            migrationBuilder.RenameIndex(
                name: "IX_S_Cards_LibId",
                table: "S_Cards",
                newName: "IX_S_Cards_Id_Lib");

            migrationBuilder.RenameIndex(
                name: "IX_S_Cards_BookId",
                table: "S_Cards",
                newName: "IX_S_Cards_Id_Book");

            migrationBuilder.RenameColumn(
                name: "FacultiseId",
                table: "Groups",
                newName: "Id_Faculty");

            migrationBuilder.RenameIndex(
                name: "IX_Groups_FacultiseId",
                table: "Groups",
                newName: "IX_Groups_Id_Faculty");

            migrationBuilder.RenameColumn(
                name: "ThemeId",
                table: "Books",
                newName: "Id_Theme");

            migrationBuilder.RenameColumn(
                name: "PresId",
                table: "Books",
                newName: "Id_Press");

            migrationBuilder.RenameColumn(
                name: "CategoriseId",
                table: "Books",
                newName: "Id_Category");

            migrationBuilder.RenameColumn(
                name: "AuthorId",
                table: "Books",
                newName: "Id_Author");

            migrationBuilder.RenameIndex(
                name: "IX_Books_ThemeId",
                table: "Books",
                newName: "IX_Books_Id_Theme");

            migrationBuilder.RenameIndex(
                name: "IX_Books_PresId",
                table: "Books",
                newName: "IX_Books_Id_Press");

            migrationBuilder.RenameIndex(
                name: "IX_Books_CategoriseId",
                table: "Books",
                newName: "IX_Books_Id_Category");

            migrationBuilder.RenameIndex(
                name: "IX_Books_AuthorId",
                table: "Books",
                newName: "IX_Books_Id_Author");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Themes",
                type: "nvarchar(30)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Teachers",
                type: "nvarchar(25)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Teachers",
                type: "nvarchar(15)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateIn",
                table: "T_Cards",
                type: "datetime",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOut",
                table: "T_Cards",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 2, 22, 23, 36, 56, DateTimeKind.Local).AddTicks(9381));

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Students",
                type: "nvarchar(25)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Students",
                type: "nvarchar(15)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateIn",
                table: "S_Cards",
                type: "datetime",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOut",
                table: "S_Cards",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 2, 22, 23, 36, 56, DateTimeKind.Local).AddTicks(8196));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Press",
                type: "nvarchar(30)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Libs",
                type: "nvarchar(25)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Libs",
                type: "nvarchar(15)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Groups",
                type: "nvarchar(10)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Facultises",
                type: "nvarchar(20)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Departments",
                type: "nvarchar(40)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(30)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Books",
                type: "nvarchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Authors",
                type: "nvarchar(25)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Authors",
                type: "nvarchar(15)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Authors_Id_Author",
                table: "Books",
                column: "Id_Author",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Categories_Id_Category",
                table: "Books",
                column: "Id_Category",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Press_Id_Press",
                table: "Books",
                column: "Id_Press",
                principalTable: "Press",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Themes_Id_Theme",
                table: "Books",
                column: "Id_Theme",
                principalTable: "Themes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_Facultises_Id_Faculty",
                table: "Groups",
                column: "Id_Faculty",
                principalTable: "Facultises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_S_Cards_Books_Id_Book",
                table: "S_Cards",
                column: "Id_Book",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_S_Cards_Libs_Id_Lib",
                table: "S_Cards",
                column: "Id_Lib",
                principalTable: "Libs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_S_Cards_Students_Id_Student",
                table: "S_Cards",
                column: "Id_Student",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Groups_Id_Group",
                table: "Students",
                column: "Id_Group",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_T_Cards_Books_Id_Book",
                table: "T_Cards",
                column: "Id_Book",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_T_Cards_Libs_Id_Lib",
                table: "T_Cards",
                column: "Id_Lib",
                principalTable: "Libs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_T_Cards_Teachers_Id_Teacher",
                table: "T_Cards",
                column: "Id_Teacher",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_Departments_Id_Dep",
                table: "Teachers",
                column: "Id_Dep",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Authors_Id_Author",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Categories_Id_Category",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Press_Id_Press",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Themes_Id_Theme",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Facultises_Id_Faculty",
                table: "Groups");

            migrationBuilder.DropForeignKey(
                name: "FK_S_Cards_Books_Id_Book",
                table: "S_Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_S_Cards_Libs_Id_Lib",
                table: "S_Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_S_Cards_Students_Id_Student",
                table: "S_Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Groups_Id_Group",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_T_Cards_Books_Id_Book",
                table: "T_Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_T_Cards_Libs_Id_Lib",
                table: "T_Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_T_Cards_Teachers_Id_Teacher",
                table: "T_Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Departments_Id_Dep",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "DateIn",
                table: "T_Cards");

            migrationBuilder.DropColumn(
                name: "DateOut",
                table: "T_Cards");

            migrationBuilder.DropColumn(
                name: "DateIn",
                table: "S_Cards");

            migrationBuilder.DropColumn(
                name: "DateOut",
                table: "S_Cards");

            migrationBuilder.RenameColumn(
                name: "Id_Dep",
                table: "Teachers",
                newName: "DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Teachers_Id_Dep",
                table: "Teachers",
                newName: "IX_Teachers_DepartmentId");

            migrationBuilder.RenameColumn(
                name: "Id_Teacher",
                table: "T_Cards",
                newName: "TeacherId");

            migrationBuilder.RenameColumn(
                name: "Id_Lib",
                table: "T_Cards",
                newName: "LibId");

            migrationBuilder.RenameColumn(
                name: "Id_Book",
                table: "T_Cards",
                newName: "BookId");

            migrationBuilder.RenameIndex(
                name: "IX_T_Cards_Id_Teacher",
                table: "T_Cards",
                newName: "IX_T_Cards_TeacherId");

            migrationBuilder.RenameIndex(
                name: "IX_T_Cards_Id_Lib",
                table: "T_Cards",
                newName: "IX_T_Cards_LibId");

            migrationBuilder.RenameIndex(
                name: "IX_T_Cards_Id_Book",
                table: "T_Cards",
                newName: "IX_T_Cards_BookId");

            migrationBuilder.RenameColumn(
                name: "Id_Group",
                table: "Students",
                newName: "GroupId");

            migrationBuilder.RenameIndex(
                name: "IX_Students_Id_Group",
                table: "Students",
                newName: "IX_Students_GroupId");

            migrationBuilder.RenameColumn(
                name: "Id_Student",
                table: "S_Cards",
                newName: "StudentId");

            migrationBuilder.RenameColumn(
                name: "Id_Lib",
                table: "S_Cards",
                newName: "LibId");

            migrationBuilder.RenameColumn(
                name: "Id_Book",
                table: "S_Cards",
                newName: "BookId");

            migrationBuilder.RenameIndex(
                name: "IX_S_Cards_Id_Student",
                table: "S_Cards",
                newName: "IX_S_Cards_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_S_Cards_Id_Lib",
                table: "S_Cards",
                newName: "IX_S_Cards_LibId");

            migrationBuilder.RenameIndex(
                name: "IX_S_Cards_Id_Book",
                table: "S_Cards",
                newName: "IX_S_Cards_BookId");

            migrationBuilder.RenameColumn(
                name: "Id_Faculty",
                table: "Groups",
                newName: "FacultiseId");

            migrationBuilder.RenameIndex(
                name: "IX_Groups_Id_Faculty",
                table: "Groups",
                newName: "IX_Groups_FacultiseId");

            migrationBuilder.RenameColumn(
                name: "Id_Theme",
                table: "Books",
                newName: "ThemeId");

            migrationBuilder.RenameColumn(
                name: "Id_Press",
                table: "Books",
                newName: "PresId");

            migrationBuilder.RenameColumn(
                name: "Id_Category",
                table: "Books",
                newName: "CategoriseId");

            migrationBuilder.RenameColumn(
                name: "Id_Author",
                table: "Books",
                newName: "AuthorId");

            migrationBuilder.RenameIndex(
                name: "IX_Books_Id_Theme",
                table: "Books",
                newName: "IX_Books_ThemeId");

            migrationBuilder.RenameIndex(
                name: "IX_Books_Id_Press",
                table: "Books",
                newName: "IX_Books_PresId");

            migrationBuilder.RenameIndex(
                name: "IX_Books_Id_Category",
                table: "Books",
                newName: "IX_Books_CategoriseId");

            migrationBuilder.RenameIndex(
                name: "IX_Books_Id_Author",
                table: "Books",
                newName: "IX_Books_AuthorId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Themes",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Teachers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Teachers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Press",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Libs",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Libs",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Groups",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Facultises",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Departments",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Authors",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Authors",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Authors_AuthorId",
                table: "Books",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Categories_CategoriseId",
                table: "Books",
                column: "CategoriseId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Press_PresId",
                table: "Books",
                column: "PresId",
                principalTable: "Press",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Themes_ThemeId",
                table: "Books",
                column: "ThemeId",
                principalTable: "Themes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_Facultises_FacultiseId",
                table: "Groups",
                column: "FacultiseId",
                principalTable: "Facultises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_S_Cards_Books_BookId",
                table: "S_Cards",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_S_Cards_Libs_LibId",
                table: "S_Cards",
                column: "LibId",
                principalTable: "Libs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_S_Cards_Students_StudentId",
                table: "S_Cards",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Groups_GroupId",
                table: "Students",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_T_Cards_Books_BookId",
                table: "T_Cards",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_T_Cards_Libs_LibId",
                table: "T_Cards",
                column: "LibId",
                principalTable: "Libs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_T_Cards_Teachers_TeacherId",
                table: "T_Cards",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_Departments_DepartmentId",
                table: "Teachers",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
