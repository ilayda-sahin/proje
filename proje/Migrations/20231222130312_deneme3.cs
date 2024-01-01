using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace proje.Migrations
{
    /// <inheritdoc />
    public partial class deneme3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AppointmentId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Users_AppointmentId",
                table: "Users",
                column: "AppointmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Appointments_AppointmentId",
                table: "Users",
                column: "AppointmentId",
                principalTable: "Appointments",
                principalColumn: "AppointmentId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Appointments_AppointmentId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_AppointmentId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "AppointmentId",
                table: "Users");
        }
    }
}
