using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WorkGroup_RPGHelp.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddRace : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BonusRacial",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Bonus = table.Column<int>(type: "int", nullable: false),
                    Name2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Malus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BonusRacial", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Campagn",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campagn", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User_",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Race",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    TravelSpeed = table.Column<int>(type: "int", nullable: false),
                    BonusRacialId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Race", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Race_BonusRacial_BonusRacialId",
                        column: x => x.BonusRacialId,
                        principalTable: "BonusRacial",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoleUsers",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleUsers", x => new { x.RoleId, x.UserId });
                    table.ForeignKey(
                        name: "FK_RoleUsers_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoleUsers_User__UserId",
                        column: x => x.UserId,
                        principalTable: "User_",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "BonusRacial",
                columns: new[] { "Id", "Bonus", "Malus", "Name", "Name2" },
                values: new object[,]
                {
                    { 1, 2, -2, "Dexterity", "Strength" },
                    { 2, 2, -2, "Intelligence", "Strength" },
                    { 3, 2, -2, "Constitution", "Charisma" }
                });

            migrationBuilder.InsertData(
                table: "Campagn",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Ma première Campagne" },
                    { 2, "True Story" },
                    { 3, "Dragon First" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Admin" },
                    { 2, "GM" },
                    { 3, "Players" }
                });

            migrationBuilder.InsertData(
                table: "User_",
                columns: new[] { "Id", "Email", "Password" },
                values: new object[,]
                {
                    { 1, "fabian@test.com", "" },
                    { 2, "mathieu@test.com", "" }
                });

            migrationBuilder.InsertData(
                table: "Race",
                columns: new[] { "Id", "BonusRacialId", "Name", "TravelSpeed" },
                values: new object[,]
                {
                    { 1, 1, "Elf", 0 },
                    { 2, 2, "Orc", 0 },
                    { 3, 3, "Half Elf", 0 }
                });

            migrationBuilder.InsertData(
                table: "RoleUsers",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BonusRacial_Name",
                table: "BonusRacial",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Campagn_Name",
                table: "Campagn",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Race_BonusRacialId",
                table: "Race",
                column: "BonusRacialId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Race_Name",
                table: "Race",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Roles_Name",
                table: "Roles",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RoleUsers_UserId",
                table: "RoleUsers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_User__Email",
                table: "User_",
                column: "Email",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Campagn");

            migrationBuilder.DropTable(
                name: "Race");

            migrationBuilder.DropTable(
                name: "RoleUsers");

            migrationBuilder.DropTable(
                name: "BonusRacial");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "User_");
        }
    }
}
