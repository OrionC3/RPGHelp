using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WorkGroup_RPGHelp.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedCampaign : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Campagn",
                columns: new[] { "Id", "Description", "IdGM", "IsFinish", "Name" },
                values: new object[,]
                {
                    { 4, "Exploration du château de Strahd", 3, false, "L'Ombre de Ravenloft" },
                    { 5, "Campagne d'introduction terminée", 4, true, "Les Mines de Phandalin" },
                    { 6, "Chapitre 3 : En route vers Baldur's Gate", 1, false, "Le Trésor de la Reine Dragon" },
                    { 7, "Groupe décimé au chapitre 5", 2, true, "La Malédiction de Strahd" },
                    { 8, "Fuite des drows réussie", 3, false, "Odyssée dans l'Outreterre" },
                    { 9, "Bloqués dans la jungle de Chult", 4, false, "Le Tombeau de l'Annihilation" },
                    { 10, "Bataille finale imminente", 1, false, "L'Ascension de Tiamat" },
                    { 11, "Enquête urbaine en cours", 2, false, "Waterdeep : Le Vol des Dragons" },
                    { 12, "Voyage en enfer", 3, false, "Descente en Avernus" },
                    { 13, "Série de donjons one-shot", 4, true, "Les Contes du Portail Béant" },
                    { 14, "Survie dans le grand nord", 1, false, "Le Froid d'Icewind Dale" },
                    { 15, "Mystère antique", 2, false, "La Citadelle de Verre" },
                    { 16, "Guerre contre les géants de feu", 3, false, "L'Héritage des Géants" },
                    { 17, "Aventure maritime", 4, false, "Les Pirates de la Côte des Épées" },
                    { 18, "Horreur cosmique", 1, true, "Le Réveil de l'Ancien" },
                    { 19, "Intrigue politique et trains-éclairs", 2, false, "Les Éclats d'Eberron" },
                    { 20, "Quête pour les artefacts", 3, false, "La Prophétie de l'Oracle" },
                    { 21, "Donjon classique", 4, false, "Sous la Montagne de Feu" },
                    { 22, "Défense de la ville terminée", 1, true, "Le Siège de Neverwinter" },
                    { 23, "Suite d'Avernus", 2, false, "L'Hérésie de Zariel" },
                    { 24, "Rencontre avec les Dryades", 3, false, "La Forêt des Murmures" },
                    { 25, "Académie de magie en péril", 4, false, "Le Secret des Arcanes" },
                    { 26, "Chasse au trésor céleste", 1, false, "Le Vol du Phénix" },
                    { 27, "Campagne nostalgique terminée", 2, true, "Les Chroniques de Greyhawk" },
                    { 28, "Exploration de cité perdue", 3, false, "La Ruine d'Omu" },
                    { 29, "Invocations incontrôlées", 4, false, "La Colère des Éléments" },
                    { 30, "Scénario d'une soirée", 1, true, "Le Festin des Gobelins" },
                    { 31, "Niveau 5 atteint", 2, false, "La Tour du Mage Fou" },
                    { 32, "Aventure dans le désert", 3, false, "L'Oasis de Diamant" },
                    { 33, "Horreur rurale", 4, false, "Les Sombres Adrets" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Campagn",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Campagn",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Campagn",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Campagn",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Campagn",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Campagn",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Campagn",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Campagn",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Campagn",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Campagn",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Campagn",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Campagn",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Campagn",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Campagn",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Campagn",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Campagn",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Campagn",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Campagn",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Campagn",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Campagn",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Campagn",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Campagn",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Campagn",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Campagn",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Campagn",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Campagn",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Campagn",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Campagn",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Campagn",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Campagn",
                keyColumn: "Id",
                keyValue: 33);
        }
    }
}
