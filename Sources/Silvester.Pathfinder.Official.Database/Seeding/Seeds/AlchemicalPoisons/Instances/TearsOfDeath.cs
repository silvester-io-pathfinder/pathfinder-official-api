﻿using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Actions.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AlchemicalPoisons.Instances
{
    public class TearsOfDeath : AbstractAlchemicalPoisonTemplate
    {
        public static readonly Guid ID = Guid.Parse("0e9adbb7-41e0-4935-8e1e-5339b7b076d0");

        protected override AlchemicalPoison GetAlchemicalPoison(AlchemicalPoisonSeeder seeder)
        {
            return new AlchemicalPoison
            {
                Id = ID,
                Name = "Tears of Death",
                ItemLevel = 20,
                Price = 1200000,
                Usage = "Held in 2 hands",
                BulkId = seeder.GetBulkByName("L").Id,
                ActionId = Interact.ID,
                ActionTypeId = seeder.GetActionTypeByName("One Action").Id,
            };
        }

        protected override StaggeredEffect GetPoisonEffect(AlchemicalPoisonSeeder seeder)
        {
            return new StaggeredEffect
            {
                Id = Guid.Parse("213ba841-ab7d-40e2-93ef-70f3984b3d26"),
                DifficultyCheck = 46,
                SavingThrowStatId = seeder.GetSavingThrowStatByName("Fortitude").Id,
                Onset = "1 Minute",
                MaximumDuration = "10 Minutes",
            };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "Alchemical";
            yield return "Poison";
            yield return "Consumable";
            yield return "Contact";
            yield return "Virulent";
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e61c1c37-3720-4a0d-8c2b-956bc8f7e9d1"), Text = "Tears of death are among the most powerful of alchemical poisons, distilled from extracts of five other deadly poisons in just the right ratios." };
        }

        protected override IEnumerable<StaggeredEffectStage> GetAlchemicalPoisonStages(AlchemicalPoisonSeeder seeder)
        {
            yield return new StaggeredEffectStage
            {
                Id = Guid.Parse("4cdc2685-68fc-4b72-a7cd-0aa14e057ef3"),
                Duration = "1 Minute",
                Effects = new StaggeredEffectStageEffect[]
                {
                    new DamagePoisonStageEffect { Id = Guid.Parse("e1de345d-5e5a-4103-99cc-bf818d653478"), Damage = "18d6", DamageTypeId = seeder.GetDamageTypeByName("Poison").Id},
                    new ConditionPoisonStageEffect { Id = Guid.Parse("dd54ff19-7b01-40c7-80e7-f2c80cc3d5da"),  ConditionId = Paralyzed.ID}
                }
            };

            yield return new StaggeredEffectStage
            {
                Id = Guid.Parse("608b96fd-baa6-4acf-9c71-983a8a11ea6e"),
                Duration = "1 Minute",
                Effects = new StaggeredEffectStageEffect[]
                {
                    new DamagePoisonStageEffect { Id = Guid.Parse("8971c661-b31b-41aa-a17d-36641bd8d368"), Damage = "25d6", DamageTypeId = seeder.GetDamageTypeByName("Poison").Id},
                    new ConditionPoisonStageEffect { Id = Guid.Parse("6a7a8f08-e882-4f8d-9aa6-d69febb46bf8"),  ConditionId = Paralyzed.ID}
                }
            };
            
            yield return new StaggeredEffectStage
            {
                Id = Guid.Parse("78f1b6ff-e864-4e1e-9792-5d7315050373"),
                Duration = "1 Minute",
                Effects = new StaggeredEffectStageEffect[]
                {
                    new DamagePoisonStageEffect { Id = Guid.Parse("0efd65bc-b1ab-4577-a023-ce31044392dd"), Damage = "30d6", DamageTypeId = seeder.GetDamageTypeByName("Poison").Id},
                    new ConditionPoisonStageEffect { Id = Guid.Parse("5232864d-00f2-4081-b065-7d25921188b5"),  ConditionId = Paralyzed.ID}
                }
            };
        }

        protected override SourcePage? GetSourcePage(AlchemicalPoisonSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("4c959f5c-c614-464e-85aa-8157adcf9154"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 553
            };
        }
    }
}