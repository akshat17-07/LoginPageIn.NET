using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserLogin.Migrations
{
    /// <inheritdoc />
    public partial class RemovedImage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "AspNetUsers");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "AspNetUsers",
                type: "image",
                nullable: false,
                defaultValue: new byte[0]);
        }
    }
}
