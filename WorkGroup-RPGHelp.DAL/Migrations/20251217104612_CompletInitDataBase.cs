using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WorkGroup_RPGHelp.DAL.Migrations
{
    /// <inheritdoc />
    public partial class CompletInitDataBase : Migration
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
                    BonusName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BonusValue = table.Column<int>(type: "int", nullable: false),
                    MalusName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MalusValue = table.Column<int>(type: "int", nullable: false)
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
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsFinish = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdGM = table.Column<int>(type: "int", nullable: false)
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
                name: "Spell",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spell", x => x.Id);
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

            migrationBuilder.CreateTable(
                name: "Characteres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
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
                    CampagnId = table.Column<int>(type: "int", nullable: true),
                    RaceId = table.Column<int>(type: "int", nullable: false)
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
                        name: "FK_Characteres_Race_RaceId",
                        column: x => x.RaceId,
                        principalTable: "Race",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Characteres_User__UserId",
                        column: x => x.UserId,
                        principalTable: "User_",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RaceSpell",
                columns: table => new
                {
                    RacesId = table.Column<int>(type: "int", nullable: false),
                    SpellsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RaceSpell", x => new { x.RacesId, x.SpellsId });
                    table.ForeignKey(
                        name: "FK_RaceSpell_Race_RacesId",
                        column: x => x.RacesId,
                        principalTable: "Race",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RaceSpell_Spell_SpellsId",
                        column: x => x.SpellsId,
                        principalTable: "Spell",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "BonusRacial",
                columns: new[] { "Id", "BonusName", "BonusValue", "MalusName", "MalusValue" },
                values: new object[,]
                {
                    { 1, "Dexterity", 2, "Strength", -2 },
                    { 2, "Intelligence", 2, "Wisdom", -2 },
                    { 3, "Constitution", 2, "Charisma", -2 },
                    { 4, "Strength", 2, "Intelligence", -2 },
                    { 5, "Wisdom", 2, "Dexterity", -2 },
                    { 6, "Charisma", 2, "Constitution", -2 },
                    { 7, "Dexterity", 2, "Charisma", -2 },
                    { 8, "Strength", 2, "Wisdom", -2 },
                    { 9, "Intelligence", 2, "Strength", -2 },
                    { 10, "Constitution", 2, "Dexterity", -2 },
                    { 11, "Wisdom", 2, "Charisma", -2 },
                    { 12, "Charisma", 2, "Strength", -2 },
                    { 13, "Intelligence", 2, "Constitution", -2 },
                    { 14, "Strength", 2, "Dexterity", -2 },
                    { 15, "Dexterity", 2, "Intelligence", -2 },
                    { 16, "Constitution", 2, "Wisdom", -2 },
                    { 17, "Wisdom", 2, "Strength", -2 },
                    { 18, "Charisma", 2, "Intelligence", -2 },
                    { 19, "Strength", 2, "Constitution", -2 },
                    { 20, "Dexterity", 2, "Wisdom", -2 },
                    { 21, "Intelligence", 2, "Charisma", -2 },
                    { 22, "Constitution", 2, "Strength", -2 },
                    { 23, "Wisdom", 2, "Intelligence", -2 }
                });

            migrationBuilder.InsertData(
                table: "Campagn",
                columns: new[] { "Id", "Description", "IdGM", "IsFinish", "Name" },
                values: new object[,]
                {
                    { 1, "Chapter 4 finished", 1, false, "Ma première Campagne" },
                    { 2, "Chapter 2 started", 2, false, "True Story" },
                    { 3, null, 1, false, "Dragon First" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Admin" },
                    { 2, "User" }
                });

            migrationBuilder.InsertData(
                table: "Spell",
                columns: new[] { "Id", "Description", "Level", "Name" },
                values: new object[,]
                {
                    { 1, "A bolt of flame shoots from your fingertips, searing your target.\r\nDamage: 1d10 fire damage (scales with level)", 0, "Firebolt" },
                    { 2, "A spear of pure shadow pierces a single enemy, ignoring armor.\r\nDamage: 2d8 necrotic damage, ignores non-magical defense.", 0, "Shadow Lance" },
                    { 3, "A shimmering barrier of force surrounds you.\r\n+5 AC until the start of your next turn.", 0, "Shielding Ward" }
                });

            migrationBuilder.InsertData(
                table: "User_",
                columns: new[] { "Id", "Email", "Password" },
                values: new object[,]
                {
                    { 1, "fabian@test.com", "$argon2id$v=19$m=65536,t=3,p=1$LHZG57rDMJ+sJvIkpI3Jqw$XXx4Ov08UZCFXAOoP+kZTmpI9MVfnJkZ5lP77JNgt/s" },
                    { 2, "mathieu@test.com", "$argon2id$v=19$m=65536,t=3,p=1$LHZG57rDMJ+sJvIkpI3Jqw$XXx4Ov08UZCFXAOoP+kZTmpI9MVfnJkZ5lP77JNgt/s" },
                    { 3, "user@example.com", "$argon2id$v=19$m=65536,t=3,p=1$LHZG57rDMJ+sJvIkpI3Jqw$XXx4Ov08UZCFXAOoP+kZTmpI9MVfnJkZ5lP77JNgt/s" },
                    { 4, "brandt.fabian@gmail.com", "$argon2id$v=19$m=65536,t=3,p=1$LHZG57rDMJ+sJvIkpI3Jqw$XXx4Ov08UZCFXAOoP+kZTmpI9MVfnJkZ5lP77JNgt/s" }
                });

            migrationBuilder.InsertData(
                table: "CampagnUsers",
                columns: new[] { "CampagnsId", "UsersId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "Race",
                columns: new[] { "Id", "BonusRacialId", "Name", "TravelSpeed" },
                values: new object[,]
                {
                    { 1, 1, "Elf", 0 },
                    { 2, 2, "Orc", 0 },
                    { 3, 3, "Half Elf", 0 },
                    { 4, 16, "Dwarf", 0 },
                    { 5, 7, "Halfling", 0 },
                    { 6, 4, "Dragonborn", 0 },
                    { 7, 9, "Gnome", 0 },
                    { 8, 18, "Tiefling", 0 },
                    { 9, 22, "Half-Orc", 0 },
                    { 10, 15, "Tabaxi", 0 },
                    { 11, 5, "Firbolg", 0 },
                    { 12, 19, "Goliath", 0 },
                    { 13, 20, "Kenku", 0 },
                    { 14, 10, "Lizardfolk", 0 },
                    { 15, 11, "Aasimar", 0 },
                    { 16, 13, "Hobgoblin", 0 },
                    { 17, 14, "Bugbear", 0 },
                    { 18, 23, "Kobold", 0 },
                    { 19, 21, "Yuan-ti", 0 },
                    { 20, 8, "Genasi (Earth)", 0 },
                    { 21, 12, "Genasi (Fire)", 0 },
                    { 22, 6, "Satyr", 0 },
                    { 23, 17, "Tortle", 0 }
                });

            migrationBuilder.InsertData(
                table: "RoleUsers",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 4 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 2, 4 }
                });

            migrationBuilder.InsertData(
                table: "Characteres",
                columns: new[] { "Id", "BaseAttackBonus", "CampagnId", "Charisma", "Constitution", "Defence", "Dexterity", "FortitudeSave", "Initiative", "Intelligence", "Level", "Name", "PVCurrent", "PVMax", "RaceId", "ReflexeSave", "Speed", "Strength", "UserId", "WillpowerSave", "Wisdom", "XP" },
                values: new object[,]
                {
                    { 1, 1, 1, 10, 14, 17, 10, 4, 0, 8, 1, "Arik le Solide", 12, 12, 1, 0, 30, 16, 1, 1, 12, 0 },
                    { 2, 0, 1, 8, 12, 15, 18, 1, 4, 10, 1, "Elara la Furtive", 10, 10, 2, 6, 30, 10, 2, 2, 14, 0 },
                    { 3, 1, 2, 8, 16, 16, 12, 5, 1, 10, 1, "Borin Pied-de-Fer", 14, 14, 3, 1, 20, 14, 1, 0, 10, 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Campagn_Name",
                table: "Campagn",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CampagnUsers_UsersId",
                table: "CampagnUsers",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_Characteres_CampagnId",
                table: "Characteres",
                column: "CampagnId");

            migrationBuilder.CreateIndex(
                name: "IX_Characteres_RaceId",
                table: "Characteres",
                column: "RaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Characteres_UserId",
                table: "Characteres",
                column: "UserId");

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
                name: "IX_RaceSpell_SpellsId",
                table: "RaceSpell",
                column: "SpellsId");

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
                name: "IX_Spell_Name",
                table: "Spell",
                column: "Name",
                unique: true);

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
                name: "CampagnUsers");

            migrationBuilder.DropTable(
                name: "Characteres");

            migrationBuilder.DropTable(
                name: "RaceSpell");

            migrationBuilder.DropTable(
                name: "RoleUsers");

            migrationBuilder.DropTable(
                name: "Campagn");

            migrationBuilder.DropTable(
                name: "Race");

            migrationBuilder.DropTable(
                name: "Spell");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "User_");

            migrationBuilder.DropTable(
                name: "BonusRacial");
        }
    }
}
