using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorkGroup_RPGHelp.DL.Entities;

namespace WorkGroup_RPGHelp.DAL.Configs
{
    public class CampagnSeed : IEntityTypeConfiguration<Campagn>
    {
        public void Configure(EntityTypeBuilder<Campagn> builder)
        {
            builder.HasData(
                new Campagn { Id = 1, Name = "Ma première Campagne", Description = "Chapter 4 finished", IsFinish = false, IdGM = 1 },
                new Campagn { Id = 2, Name = "True Story", Description = "Chapter 2 started", IsFinish = false, IdGM = 2 },
                new Campagn { Id = 3, Name = "Dragon First", IsFinish = false, IdGM = 1 },
                new Campagn { Id = 4, Name = "L'Ombre de Ravenloft", Description = "Exploration du château de Strahd", IsFinish = false, IdGM = 3 },
                new Campagn { Id = 5, Name = "Les Mines de Phandalin", Description = "Campagne d'introduction terminée", IsFinish = true, IdGM = 4 },
                new Campagn { Id = 6, Name = "Le Trésor de la Reine Dragon", Description = "Chapitre 3 : En route vers Baldur's Gate", IsFinish = false, IdGM = 1 },
                new Campagn { Id = 7, Name = "La Malédiction de Strahd", Description = "Groupe décimé au chapitre 5", IsFinish = true, IdGM = 2 },
                new Campagn { Id = 8, Name = "Odyssée dans l'Outreterre", Description = "Fuite des drows réussie", IsFinish = false, IdGM = 3 },
                new Campagn { Id = 9, Name = "Le Tombeau de l'Annihilation", Description = "Bloqués dans la jungle de Chult", IsFinish = false, IdGM = 4 },
                new Campagn { Id = 10, Name = "L'Ascension de Tiamat", Description = "Bataille finale imminente", IsFinish = false, IdGM = 1 },
                new Campagn { Id = 11, Name = "Waterdeep : Le Vol des Dragons", Description = "Enquête urbaine en cours", IsFinish = false, IdGM = 2 },
                new Campagn { Id = 12, Name = "Descente en Avernus", Description = "Voyage en enfer", IsFinish = false, IdGM = 3 },
                new Campagn { Id = 13, Name = "Les Contes du Portail Béant", Description = "Série de donjons one-shot", IsFinish = true, IdGM = 4 },
                new Campagn { Id = 14, Name = "Le Froid d'Icewind Dale", Description = "Survie dans le grand nord", IsFinish = false, IdGM = 1 },
                new Campagn { Id = 15, Name = "La Citadelle de Verre", Description = "Mystère antique", IsFinish = false, IdGM = 2 },
                new Campagn { Id = 16, Name = "L'Héritage des Géants", Description = "Guerre contre les géants de feu", IsFinish = false, IdGM = 3 },
                new Campagn { Id = 17, Name = "Les Pirates de la Côte des Épées", Description = "Aventure maritime", IsFinish = false, IdGM = 4 },
                new Campagn { Id = 18, Name = "Le Réveil de l'Ancien", Description = "Horreur cosmique", IsFinish = true, IdGM = 1 },
                new Campagn { Id = 19, Name = "Les Éclats d'Eberron", Description = "Intrigue politique et trains-éclairs", IsFinish = false, IdGM = 2 },
                new Campagn { Id = 20, Name = "La Prophétie de l'Oracle", Description = "Quête pour les artefacts", IsFinish = false, IdGM = 3 },
                new Campagn { Id = 21, Name = "Sous la Montagne de Feu", Description = "Donjon classique", IsFinish = false, IdGM = 4 },
                new Campagn { Id = 22, Name = "Le Siège de Neverwinter", Description = "Défense de la ville terminée", IsFinish = true, IdGM = 1 },
                new Campagn { Id = 23, Name = "L'Hérésie de Zariel", Description = "Suite d'Avernus", IsFinish = false, IdGM = 2 },
                new Campagn { Id = 24, Name = "La Forêt des Murmures", Description = "Rencontre avec les Dryades", IsFinish = false, IdGM = 3 },
                new Campagn { Id = 25, Name = "Le Secret des Arcanes", Description = "Académie de magie en péril", IsFinish = false, IdGM = 4 },
                new Campagn { Id = 26, Name = "Le Vol du Phénix", Description = "Chasse au trésor céleste", IsFinish = false, IdGM = 1 },
                new Campagn { Id = 27, Name = "Les Chroniques de Greyhawk", Description = "Campagne nostalgique terminée", IsFinish = true, IdGM = 2 },
                new Campagn { Id = 28, Name = "La Ruine d'Omu", Description = "Exploration de cité perdue", IsFinish = false, IdGM = 3 },
                new Campagn { Id = 29, Name = "La Colère des Éléments", Description = "Invocations incontrôlées", IsFinish = false, IdGM = 4 },
                new Campagn { Id = 30, Name = "Le Festin des Gobelins", Description = "Scénario d'une soirée", IsFinish = true, IdGM = 1 },
                new Campagn { Id = 31, Name = "La Tour du Mage Fou", Description = "Niveau 5 atteint", IsFinish = false, IdGM = 2 },
                new Campagn { Id = 32, Name = "L'Oasis de Diamant", Description = "Aventure dans le désert", IsFinish = false, IdGM = 3 },
                new Campagn { Id = 33, Name = "Les Sombres Adrets", Description = "Horreur rurale", IsFinish = false, IdGM = 4 }
            );            

            builder.HasMany(c => c.Users)
                .WithMany(u => u.Campagns).UsingEntity(j => j.HasData(
                    new { UsersId = 1, CampagnsId = 1 },
                    new { UsersId = 1, CampagnsId = 2 },
                    new { UsersId = 2, CampagnsId = 1 }
                    ));
        }
    }
}
