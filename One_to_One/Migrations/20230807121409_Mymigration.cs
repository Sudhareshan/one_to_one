using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace One_to_One.Migrations
{
    /// <inheritdoc />
    public partial class Mymigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employes",
                columns: table => new
                {
                    EmployeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JoinDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employes", x => x.EmployeId);
                });

            migrationBuilder.CreateTable(
                name: "AdharDeatails",
                columns: table => new
                {
                    EmployeId = table.Column<int>(type: "int", nullable: false),
                    AdharNumber = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdharDeatails", x => x.EmployeId);
                    table.ForeignKey(
                        name: "FK_AdharDeatails_Employes_EmployeId",
                        column: x => x.EmployeId,
                        principalTable: "Employes",
                        principalColumn: "EmployeId",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdharDeatails");

            migrationBuilder.DropTable(
                name: "Employes");
        }
    }
}
