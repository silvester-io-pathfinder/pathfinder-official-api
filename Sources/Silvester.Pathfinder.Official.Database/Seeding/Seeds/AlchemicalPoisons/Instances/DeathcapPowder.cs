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
    public class DeathcapPowder : AbstractAlchemicalPoisonTemplate
    {
        public static readonly Guid ID = Guid.Parse("ae0386af-cfaf-40c0-83b4-8dd5a8d80d9a");

        protected override AlchemicalPoison GetAlchemicalPoison(AlchemicalPoisonSeeder seeder)
        {
            return new AlchemicalPoison
            {
                Id = ID,
                Name = "Deathcap Powder",
                ItemLevel = 13,
                Price = 45000,
                Usage = "Held in 1 hand",
                BulkId = seeder.GetBulkByName("L").Id,
                ActionId = Interact.ID,
                ActionTypeId = seeder.GetActionTypeByName("One Action").Id,
            };
        }

        protected override StaggeredEffect GetPoisonEffect(AlchemicalPoisonSeeder seeder)
        {
            return new StaggeredEffect
            {
                Id = Guid.Parse("cbd1a958-ac5e-4a17-9b53-affb4831ffca"),
                DifficultyCheck = 33,
                SavingThrowStatId = seeder.GetSavingThrowStatByName("Fortitude").Id,
                Onset = "10 Minutes",
                MaximumDuration = "6 Minutes",
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
            yield return new AlchemicalPoisonDetailBlock { Id = Guid.Parse("86a05df2-37ef-4162-9576-46a53b42e381"), Text = "The toxic deathcap mushroom can be dried, ground, and treated to form a flavorless powder with accelerated effects." };
        }

        protected override IEnumerable<StaggeredEffectStage> GetAlchemicalPoisonStages(AlchemicalPoisonSeeder seeder)
        {
            yield return new StaggeredEffectStage
            {
                Id = Guid.Parse("101a5abd-b68c-4ec5-92ac-a568358d2eda"),
                Duration = "1 Minute",
                Effects = new StaggeredEffectStageEffect[]
                {
                    new DamagePoisonStageEffect { Id = Guid.Parse("522e11c6-2156-4c69-8ced-b2ff70428e30"), Damage = "13d6", DamageTypeId = seeder.GetDamageTypeByName("Poison").Id},
                }
            };

            yield return new StaggeredEffectStage
            {
                Id = Guid.Parse("03e91a70-68d4-4048-b785-2f7c52e1a5ab"),
                Duration = "1 Minute",
                Effects = new StaggeredEffectStageEffect[]
                {
                    new DamagePoisonStageEffect { Id = Guid.Parse("289600b9-a130-42f0-84eb-9d0875ef6d45"), Damage = "17d6", DamageTypeId = seeder.GetDamageTypeByName("Poison").Id},
                    new ConditionPoisonStageEffect { Id = Guid.Parse("802df304-2287-4d04-99d6-c5a3dee6eb31"),  ConditionId = Sickened.ID, Severity = 2}
                }
            };

            yield return new StaggeredEffectStage
            {
                Id = Guid.Parse("37604a6a-f8cb-40a2-8ad8-15dc110662f8"),
                Duration = "1 Minute",
                Effects = new StaggeredEffectStageEffect[]
                {
                    new DamagePoisonStageEffect { Id = Guid.Parse("0927240a-dbdf-41a5-a145-a63234f3398b"), Damage = "20d6", DamageTypeId = seeder.GetDamageTypeByName("Poison").Id},
                    new ConditionPoisonStageEffect { Id = Guid.Parse("3efd49c0-5197-484d-862d-0f00e9357f5a"),  ConditionId = Sickened.ID, Severity = 3}
                }
            };
        }

        protected override SourcePage? GetSourcePage(AlchemicalPoisonSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("a2779414-69b9-416c-abda-71ae15fe3b10"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 551
            };
        }
    }
}
