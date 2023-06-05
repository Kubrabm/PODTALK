using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PodTalk.Migrations
{
    public partial class sosialmedia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SocialMedia_Footer_FooterId",
                table: "SocialMedia");

            migrationBuilder.DropColumn(
                name: "SocialMediaAddress",
                table: "SocialMedia");

            migrationBuilder.AlterColumn<int>(
                name: "FooterId",
                table: "SocialMedia",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "ImgUrl",
                table: "Footer",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_SocialMedia_Footer_FooterId",
                table: "SocialMedia",
                column: "FooterId",
                principalTable: "Footer",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SocialMedia_Footer_FooterId",
                table: "SocialMedia");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropColumn(
                name: "ImgUrl",
                table: "Footer");

            migrationBuilder.AlterColumn<int>(
                name: "FooterId",
                table: "SocialMedia",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SocialMediaAddress",
                table: "SocialMedia",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_SocialMedia_Footer_FooterId",
                table: "SocialMedia",
                column: "FooterId",
                principalTable: "Footer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
