using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Assignment_01.Migrations
{
    /// <inheritdoc />
    public partial class AddRelationsAndLazyLoading : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Dep_Id1",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Dept_ID1",
                table: "Instructors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Ins_ID1",
                table: "Departments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Top_ID1",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Students_Dep_Id1",
                table: "Students",
                column: "Dep_Id1");

            migrationBuilder.CreateIndex(
                name: "IX_Stud_Courses_Course_ID",
                table: "Stud_Courses",
                column: "Course_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_Dept_ID",
                table: "Instructors",
                column: "Dept_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_Ins_ID",
                table: "Departments",
                column: "Ins_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_Top_ID1",
                table: "Courses",
                column: "Top_ID1");

            migrationBuilder.CreateIndex(
                name: "IX_Course_Insts_Course_ID",
                table: "Course_Insts",
                column: "Course_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Insts_Courses_Course_ID",
                table: "Course_Insts",
                column: "Course_ID",
                principalTable: "Courses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Insts_Instructors_inst_ID",
                table: "Course_Insts",
                column: "inst_ID",
                principalTable: "Instructors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Topics_Top_ID1",
                table: "Courses",
                column: "Top_ID1",
                principalTable: "Topics",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Instructors_Ins_ID",
                table: "Departments",
                column: "Ins_ID",
                principalTable: "Instructors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Departments_Dept_ID",
                table: "Instructors",
                column: "Dept_ID",
                principalTable: "Departments",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Stud_Courses_Courses_Course_ID",
                table: "Stud_Courses",
                column: "Course_ID",
                principalTable: "Courses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stud_Courses_Students_stud_ID",
                table: "Stud_Courses",
                column: "stud_ID",
                principalTable: "Students",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Departments_Dep_Id1",
                table: "Students",
                column: "Dep_Id1",
                principalTable: "Departments",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Insts_Courses_Course_ID",
                table: "Course_Insts");

            migrationBuilder.DropForeignKey(
                name: "FK_Course_Insts_Instructors_inst_ID",
                table: "Course_Insts");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Topics_Top_ID1",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Instructors_Ins_ID",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Departments_Dept_ID",
                table: "Instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_Stud_Courses_Courses_Course_ID",
                table: "Stud_Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Stud_Courses_Students_stud_ID",
                table: "Stud_Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Departments_Dep_Id1",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_Dep_Id1",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Stud_Courses_Course_ID",
                table: "Stud_Courses");

            migrationBuilder.DropIndex(
                name: "IX_Instructors_Dept_ID",
                table: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_Departments_Ins_ID",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Courses_Top_ID1",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Course_Insts_Course_ID",
                table: "Course_Insts");

            migrationBuilder.DropColumn(
                name: "Dep_Id1",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Dept_ID1",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "Ins_ID1",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "Top_ID1",
                table: "Courses");
        }
    }
}
