using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace StudyMaster.Migrations
{
    public partial class SlugUpdate_Exam : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Slug",
                table: "Exams",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.CreateIndex(
                name: "IX_Exams_Slug",
                table: "Exams",
                column: "Slug",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Exams_Slug",
                table: "Exams");

            migrationBuilder.AlterColumn<string>(
                name: "Slug",
                table: "Exams",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
