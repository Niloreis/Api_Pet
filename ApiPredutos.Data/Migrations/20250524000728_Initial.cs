using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiPredutos.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CLIENTES",
                columns: table => new
                {
                    IDCLIENTE = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NOMEPET = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ANONASCIMENTOPET = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    RACA = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TUTOR = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NUMEROTUTOR = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLIENTES", x => x.IDCLIENTE);
                });

            migrationBuilder.CreateTable(
                name: "AGENDA",
                columns: table => new
                {
                    IDAGENDA = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NOMEPET = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TIME = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DATA = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TIPO = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    OBS = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    IdCliente = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AGENDA", x => x.IDAGENDA);
                    table.ForeignKey(
                        name: "FK_AGENDA_CLIENTES_IdCliente",
                        column: x => x.IdCliente,
                        principalTable: "CLIENTES",
                        principalColumn: "IDCLIENTE");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AGENDA_IdCliente",
                table: "AGENDA",
                column: "IdCliente");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AGENDA");

            migrationBuilder.DropTable(
                name: "CLIENTES");
        }
    }
}
