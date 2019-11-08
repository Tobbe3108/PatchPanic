using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PatchPanic.DAL.Migrations
{
    public partial class Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CategoryFields",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CategoryId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    TypeOf = table.Column<string>(nullable: false),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryFields", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Entities",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    CategoryId = table.Column<Guid>(nullable: false),
                    LastCheckUp = table.Column<string>(nullable: false),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EntityDependencies",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    EntityId = table.Column<Guid>(nullable: false),
                    ParentId = table.Column<Guid>(nullable: false),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntityDependencies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EntityEntries",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    EntityId = table.Column<Guid>(nullable: false),
                    CategoryFieldId = table.Column<Guid>(nullable: false),
                    Value = table.Column<string>(nullable: false),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntityEntries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Headline = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Deadline = table.Column<string>(nullable: false),
                    CreatedById = table.Column<Guid>(nullable: false),
                    AssignedToId = table.Column<Guid>(nullable: false),
                    Completed = table.Column<byte>(nullable: false),
                    RecurringInterval = table.Column<int>(nullable: false),
                    EntityId = table.Column<Guid>(nullable: false),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "CategoryFields");

            migrationBuilder.DropTable(
                name: "Entities");

            migrationBuilder.DropTable(
                name: "EntityDependencies");

            migrationBuilder.DropTable(
                name: "EntityEntries");

            migrationBuilder.DropTable(
                name: "Tasks");
        }
    }
}
