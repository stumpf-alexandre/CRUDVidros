using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CRUD.Migrations
{
    public partial class InitialMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Glasses",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    amount = table.Column<long>(type: "bigint", nullable: false),
                    composition = table.Column<string>(type: "longtext", nullable: true),
                    height = table.Column<long>(type: "bigint", nullable: false),
                    invoice = table.Column<long>(type: "bigint", nullable: false),
                    millim = table.Column<long>(type: "bigint", nullable: false),
                    provider = table.Column<string>(type: "longtext", nullable: true),
                    width = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Glasses", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Glasses");
        }
    }
}
