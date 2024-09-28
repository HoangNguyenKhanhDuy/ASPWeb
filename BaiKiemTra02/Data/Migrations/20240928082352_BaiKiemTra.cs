using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaiKiemTra02.Data.Migrations
{
    /// <inheritdoc />
    public partial class BaiKiemTra : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_LopHocs",
                table: "LopHocs");

            migrationBuilder.RenameTable(
                name: "LopHocs",
                newName: "LopHoc");

            migrationBuilder.AlterColumn<string>(
                name: "NamRaTruong",
                table: "LopHoc",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "NamNhapHoc",
                table: "LopHoc",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LopHoc",
                table: "LopHoc",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_LopHoc",
                table: "LopHoc");

            migrationBuilder.RenameTable(
                name: "LopHoc",
                newName: "LopHocs");

            migrationBuilder.AlterColumn<int>(
                name: "NamRaTruong",
                table: "LopHocs",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "NamNhapHoc",
                table: "LopHocs",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LopHocs",
                table: "LopHocs",
                column: "Id");
        }
    }
}
