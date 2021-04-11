﻿using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Actions.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions.Instances;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AlchemicalPoisons.Instances
{
    public class Hemlock : AbstractAlchemicalPoisonTemplate
    {
        public static readonly Guid ID = Guid.Parse("7c923c5c-7005-4f1b-9005-5c79b289b056");

        protected override AlchemicalPoison GetAlchemicalPoison(AlchemicalPoisonSeeder seeder)
        {
            return new AlchemicalPoison
            {
                Id = ID,
                Name = "Hemlock",
                ItemLevel = 17,
                Price = 225000,
                Usage = "Held in 1 hand",
                BulkId = seeder.GetBulkByName("L").Id,
                ActionId = Interact.ID,
                ActionTypeId = seeder.GetActionTypeByName("One Action").Id,
            };
        }

        protected override PoisonEffect GetPoisonEffect(AlchemicalPoisonSeeder seeder)
        {
            return new PoisonEffect
            {
                Id = Guid.Parse(""),
                Name = "Hemlock",
                DifficultyCheck = 40,
                SavingThrowStatId = seeder.GetSavingThrowStatByName("Fortitude").Id,
                Onset = "30 Minutes",
                MaximumDuration = "60 Minutes",
            };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "Alchemical";
            yield return "Poison";
            yield return "Consumable";
            yield return "Ingested";
        }

        protected override IEnumerable<AlchemicalPoisonDetailBlock> GetDetailBlocks()
        {
            yield return new AlchemicalPoisonDetailBlock { Id = Guid.Parse("7045ff07-e29c-4f30-9a90-8d4b94e64335"), Text = "Concentrated hemlock is a particularly deadly toxin that halts muscle action—including that of the victim’s heart." };
        }

        protected override IEnumerable<PoisonEffectStage> GetAlchemicalPoisonStages(AlchemicalPoisonSeeder seeder)
        {
            yield return new PoisonEffectStage
            {
                Id = Guid.Parse("0b046df0-35c7-4ce5-9e8a-ef267997af29"),
                Duration = "10 Minutes",
                Effects = new PoisonEffectStageEffect[]
                {
                    new DamagePoisonStageEffect { Id = Guid.Parse("5fe5412a-564e-4a9a-bf76-c34b7d3da595"), Damage = "17d6", DamageType = seeder.GetDamageTypeByName("Poison")},
                    new ConditionPoisonStageEffect { Id = Guid.Parse("6ae69ff8-919d-4a88-a8a6-b0292096d4cc"),  ConditionId = Enfeebled.ID, Severity = 2}
                }
            };

            yield return new PoisonEffectStage
            {
                Id = Guid.Parse("a9d1a6a2-beff-45bd-8557-83718005de78"),
                Duration = "10 Minutes",
                Effects = new PoisonEffectStageEffect[]
                {
                    new DamagePoisonStageEffect { Id = Guid.Parse("610afeb6-7789-4aaf-b020-483aff478009"), Damage = "21d6", DamageType = seeder.GetDamageTypeByName("Poison")},
                    new ConditionPoisonStageEffect { Id = Guid.Parse("7762e24a-96b6-44a5-b5e6-fa0810975e64"),  ConditionId = Enfeebled.ID, Severity = 3}
                }
            };

            yield return new PoisonEffectStage
            {
                Id = Guid.Parse("4ee75b8e-2d54-4748-abbc-280cae951532"),
                Duration = "10 Minutes",
                Effects = new PoisonEffectStageEffect[]
                {
                    new DamagePoisonStageEffect { Id = Guid.Parse("c239d60f-0e66-4b61-9f04-311b09d80272"), Damage = "26d6", DamageType = seeder.GetDamageTypeByName("Poison")},
                    new ConditionPoisonStageEffect { Id = Guid.Parse("bbd15e86-b959-4126-b304-9d7991c252bf"),  ConditionId = Enfeebled.ID, Severity = 4}
                }
            };
        }

        protected override SourcePage? GetSourcePage(AlchemicalPoisonSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("fc948d2b-fe6e-4a8c-937f-ea8c597e92e5"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 552
            };
        }
    }
}
