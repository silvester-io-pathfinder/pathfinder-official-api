﻿using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Hazards.Complex
{
    public class SummoniningRune : AbstractHazardTemplate
    {
        public static readonly Guid ID = Guid.Parse("6f1cd8de-db91-4b60-9ae6-e9328c13cceb");

        protected override Hazard GetHazard(HazardSeeder seeder)
        {
            return new Hazard
            {
                Id = ID,
                Name = "Summonining Rune",
                Description = "A cloud of invisible magical sensors in a 10-foot radius surrounds an invisible wall or floor rune the size of the creature to be summoned.",
                Level = 1,
                Reset = "The trap resets each day at dawn.",
                CanBeDetectedMagically = false,
                TypeId = seeder.GetHazardTypeByName("Traps").Id,
                ComplexityId = seeder.GetComplexityByName("Complex").Id
            };
        }

        protected override IEnumerable<HazardComponent> GetComponents(HazardSeeder seeder)
        {
            yield break;
        }

        protected override IEnumerable<string> GetImmunities()
        {
            yield break;
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "Complex";
            yield return "Magical";
            yield return "Trap";
        }

        protected override IEnumerable<HazardAction> GetActions(HazardSeeder seeder)
        {
            yield return new HazardAction
            {
                Id = Guid.Parse("16402edb-38d3-4cae-a93d-687c9e1814b2"),
                Name = "Summon Monster",
                Traits = seeder.FilterTraits("Arcane", "Conjuration", "Summon"),
                Trigger = "A creature enters the cloud of magical sensors",
                ActionTypeId = seeder.GetActionTypeByName("Reaction").Id,
                Details = 
                {
                    new TextBlock { Id = Guid.Parse("cabdbcb0-95c9-461d-a9f5-e1858af03802"), Type = TextBlockType.Text, Text = "This trap summons a specific level 1 creature, determined when the trap is created. The creature rolls initiative and remains for 2d6 rounds, after which the spell ends and the creature disappears. The creature also disappears if someone disables the trap before the duration expires. The summoned creature can use 3 actions each round and can use reactions, unlike most summoned creatures." },
                }
            };
        }

        protected override HazardDetectionRequirement GetDetectionRequirement(HazardSeeder seeder)
        {
            return new HazardDetectionRequirement
            {
                Id = Guid.Parse("921b94a1-3783-49b6-8b5f-b22217494c66"),
                RequiredProficiencyId = seeder.GetProficiencyByName("Trained").Id,
                DifficultyCheck = 7
            };
        }

        protected override IEnumerable<HazardDisableRequirement> GetDisableRequirements(HazardSeeder seeder)
        {
            yield return new HazardDisableRequirement
            {
                Id = Guid.Parse("04d08fc4-3f5d-4407-8b34-d0cae8372e4c"),
                SkillId = seeder.GetSkillByName("Acrobatics").Id,
                RequiredProficiencyId = seeder.GetProficiencyByName("Untrained").Id,
                Description = "to approach without triggering the trap",
                DifficultyCheck = 15
            };

            yield return new HazardDisableRequirement
            {
                Id = Guid.Parse("e91c1fb3-ddbe-4523-919d-9c70f72a4a82"),
                SkillId = seeder.GetSkillByName("Thievery").Id,
                RequiredProficiencyId = seeder.GetProficiencyByName("Trained").Id,
                Description = "to erase the rune",
                DifficultyCheck = 17
            };
        }

        protected override IEnumerable<HazardDispellRequirement> GetDispellRequirements(HazardSeeder seeder)
        {
            yield return new HazardDispellRequirement
            {
                Id = Guid.Parse("f599f5f3-a8a9-409a-9be4-24efa7bc2eea"),
                Level = 1,
                Description = "to counteract the rune",
                CounteractDifficultyCheck = 15
            };
        }

        protected override SourcePage GetSourcePage(HazardSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("d3f23187-4e4d-4989-9b34-40a4f42da1fe"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 526
            };
        }
    }
}