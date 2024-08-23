using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Practice9_EFCore.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class new_migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Buildings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: false),
                    XPosition = table.Column<double>(type: "double precision", nullable: false),
                    YPosition = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buildings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rubrics",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    ParentRubricId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rubrics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rubrics_Rubrics_ParentRubricId",
                        column: x => x.ParentRubricId,
                        principalTable: "Rubrics",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Phones = table.Column<List<string>>(type: "text[]", nullable: false),
                    BuildingId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Companies_Buildings_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "Buildings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CompanyEntityRubricEntity",
                columns: table => new
                {
                    CompaniesId = table.Column<Guid>(type: "uuid", nullable: false),
                    RubricsId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyEntityRubricEntity", x => new { x.CompaniesId, x.RubricsId });
                    table.ForeignKey(
                        name: "FK_CompanyEntityRubricEntity_Companies_CompaniesId",
                        column: x => x.CompaniesId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompanyEntityRubricEntity_Rubrics_RubricsId",
                        column: x => x.RubricsId,
                        principalTable: "Rubrics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Buildings",
                columns: new[] { "Id", "Address", "XPosition", "YPosition" },
                values: new object[,]
                {
                    { new Guid("58e5045c-1fe3-4bfe-81e5-4d0df71b607f"), "Блюхера, 32/1", 32.5, 12.6 },
                    { new Guid("aae64205-018c-462b-a4b0-f75cc4176149"), "Сахарова, 72/15", 231.31999999999999, 1.5 }
                });

            migrationBuilder.InsertData(
                table: "Rubrics",
                columns: new[] { "Id", "Name", "ParentRubricId" },
                values: new object[] { new Guid("db3517e4-d76c-42f0-8595-22f7a56d8797"), "Еда", null });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "BuildingId", "Name", "Phones" },
                values: new object[,]
                {
                    { new Guid("4d8ce470-28a5-4f63-96ba-f84fc36b0f48"), new Guid("58e5045c-1fe3-4bfe-81e5-4d0df71b607f"), "ООО Рога и Копыта", new List<string> { "2-222-222", "3-333-333" } },
                    { new Guid("a6c018b1-0b1f-4f9c-b821-27a41a207d5e"), new Guid("aae64205-018c-462b-a4b0-f75cc4176149"), "ООО Мясной Продукт", new List<string> { "8-923-666-13-13" } }
                });

            migrationBuilder.InsertData(
                table: "Rubrics",
                columns: new[] { "Id", "Name", "ParentRubricId" },
                values: new object[] { new Guid("22636eed-e20e-422f-af9e-589e091821ca"), "Полуфабрикаты оптом", new Guid("db3517e4-d76c-42f0-8595-22f7a56d8797") });

            migrationBuilder.InsertData(
                table: "CompanyEntityRubricEntity",
                columns: new[] { "CompaniesId", "RubricsId" },
                values: new object[] { new Guid("4d8ce470-28a5-4f63-96ba-f84fc36b0f48"), new Guid("22636eed-e20e-422f-af9e-589e091821ca") });

            migrationBuilder.InsertData(
                table: "Rubrics",
                columns: new[] { "Id", "Name", "ParentRubricId" },
                values: new object[] { new Guid("d853397a-8af6-45e6-8c56-2bb2743a941c"), "Мясная продукция", new Guid("22636eed-e20e-422f-af9e-589e091821ca") });

            migrationBuilder.InsertData(
                table: "CompanyEntityRubricEntity",
                columns: new[] { "CompaniesId", "RubricsId" },
                values: new object[] { new Guid("a6c018b1-0b1f-4f9c-b821-27a41a207d5e"), new Guid("d853397a-8af6-45e6-8c56-2bb2743a941c") });

            migrationBuilder.CreateIndex(
                name: "IX_Companies_BuildingId",
                table: "Companies",
                column: "BuildingId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyEntityRubricEntity_RubricsId",
                table: "CompanyEntityRubricEntity",
                column: "RubricsId");

            migrationBuilder.CreateIndex(
                name: "IX_Rubrics_ParentRubricId",
                table: "Rubrics",
                column: "ParentRubricId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyEntityRubricEntity");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Rubrics");

            migrationBuilder.DropTable(
                name: "Buildings");
        }
    }
}
