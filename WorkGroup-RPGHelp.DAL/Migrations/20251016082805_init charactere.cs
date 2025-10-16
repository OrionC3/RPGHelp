using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WorkGroup_RPGHelp.DAL.Migrations
{
    /// <inheritdoc />
    public partial class initcharactere : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CampagnUsers",
                columns: table => new
                {
                    CampagnsId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampagnUsers", x => new { x.CampagnsId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_CampagnUsers_Campagn_CampagnsId",
                        column: x => x.CampagnsId,
                        principalTable: "Campagn",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CampagnUsers_User__UsersId",
                        column: x => x.UsersId,
                        principalTable: "User_",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Characteres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IdRace = table.Column<int>(type: "int", nullable: false),
                    PVMax = table.Column<int>(type: "int", nullable: false),
                    PVCurrent = table.Column<int>(type: "int", nullable: false),
                    Strength = table.Column<int>(type: "int", nullable: false),
                    Dexterity = table.Column<int>(type: "int", nullable: false),
                    Constitution = table.Column<int>(type: "int", nullable: false),
                    Intelligence = table.Column<int>(type: "int", nullable: false),
                    Wisdom = table.Column<int>(type: "int", nullable: false),
                    Charisma = table.Column<int>(type: "int", nullable: false),
                    Defence = table.Column<int>(type: "int", nullable: false, defaultValue: 10),
                    Initiative = table.Column<int>(type: "int", nullable: false),
                    BaseAttackBonus = table.Column<int>(type: "int", nullable: false),
                    FortitudeSave = table.Column<int>(type: "int", nullable: false),
                    ReflexeSave = table.Column<int>(type: "int", nullable: false),
                    WillpowerSave = table.Column<int>(type: "int", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    XP = table.Column<int>(type: "int", nullable: false),
                    Speed = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CampagnId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characteres", x => x.Id);
                    table.CheckConstraint("CK_Charactere__Charisma", "Charisma >= 0");
                    table.CheckConstraint("CK_Charactere__Constitution", "Constitution >= 0");
                    table.CheckConstraint("CK_Charactere__Dexterity", "Dexterity >= 0");
                    table.CheckConstraint("CK_Charactere__Intelligence", "Intelligence >= 0");
                    table.CheckConstraint("CK_Charactere__Level", "Level >= 0");
                    table.CheckConstraint("CK_Charactere__PVMax", "PVMax > 0");
                    table.CheckConstraint("CK_Charactere__Speed", "Speed >= 0");
                    table.CheckConstraint("CK_Charactere__Strength", "Strength >= 0");
                    table.CheckConstraint("CK_Charactere__Wisdom", "Wisdom >= 0");
                    table.CheckConstraint("CK_Charactere__XP", "XP >= 0");
                    table.ForeignKey(
                        name: "FK_Characteres_Campagn_CampagnId",
                        column: x => x.CampagnId,
                        principalTable: "Campagn",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Characteres_User__UserId",
                        column: x => x.UserId,
                        principalTable: "User_",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Characteres",
                columns: new[] { "Id", "BaseAttackBonus", "CampagnId", "Charisma", "Constitution", "Defence", "Dexterity", "FortitudeSave", "IdRace", "Initiative", "Intelligence", "Level", "Name", "PVCurrent", "PVMax", "ReflexeSave", "Speed", "Strength", "UserId", "WillpowerSave", "Wisdom", "XP" },
                values: new object[,]
                {
                    { 1, 1, null, 10, 14, 17, 10, 4, 1, 0, 8, 1, "Arik le Solide", 12, 12, 0, 30, 16, 1, 1, 12, 0 },
                    { 2, 0, null, 8, 12, 15, 18, 1, 2, 4, 10, 1, "Elara la Furtive", 10, 10, 6, 30, 10, 2, 2, 14, 0 },
                    { 3, 1, null, 8, 16, 16, 12, 5, 3, 1, 10, 1, "Borin Pied-de-Fer", 14, 14, 1, 20, 14, 1, 0, 10, 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CampagnUsers_UsersId",
                table: "CampagnUsers",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_Characteres_CampagnId",
                table: "Characteres",
                column: "CampagnId");

            migrationBuilder.CreateIndex(
                name: "IX_Characteres_UserId",
                table: "Characteres",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CampagnUsers");

            migrationBuilder.DropTable(
                name: "Characteres");
        }
    }
}
