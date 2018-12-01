using Microsoft.EntityFrameworkCore.Migrations;

namespace ASPNETCore_Nhom13.Migrations
{
    public partial class tesst : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Hinh",
                table: "TinTucs",
                nullable: true,
                oldClrType: typeof(string));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Hinh",
                table: "TinTucs",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
