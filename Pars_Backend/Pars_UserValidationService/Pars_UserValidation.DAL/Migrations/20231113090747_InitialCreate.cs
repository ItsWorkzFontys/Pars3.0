using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pars_UserValidation.DAL.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserValidation_Db",
                columns: table => new
                {
                    UserValidationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserValidation_Db", x => x.UserValidationId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserValidation_Db");
        }
    }
}
