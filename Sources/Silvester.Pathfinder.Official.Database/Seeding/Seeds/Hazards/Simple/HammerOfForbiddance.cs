﻿using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Hazards.Simple
{
    public class HammerOfForbiddance : AbstractHazardTemplate
    {
        public static readonly Guid ID = Guid.Parse("d88ecdc0-c9bd-4a42-8409-a215f4a5c034");

        protected override Hazard GetHazard(HazardSeeder seeder)
        {
            return new Hazard
            {
                Id = ID,
                Name = "Hammer of Forbiddance",
                Description = "An enormous hammer at an edifice’s entrance swings down in an attempt to damage a creature entering an area, push it back, and prevent it from going any further.",
                Level = 11,
                ArmorClass = 32,
                Fortitude = 24,
                Reflex = 15,
                Reset = "The trap resets over the course of the round, and is ready to swing again 1 round later.",
                CanBeDetectedMagically = false,
                TypeId = seeder.GetHazardTypeByName("Traps").Id,
                ComplexityId = seeder.GetComplexityByName("Simple").Id
            };
        }

        protected override IEnumerable<HazardComponent> GetComponents(HazardSeeder seeder)
        {
            yield return new HazardComponent
            {
                Id = Guid.Parse("3d2b0564-6171-438a-850b-329c7e33b072"),
                Name = "Hammer",
                HitPoints = 88,
                Hardness = 22,
                BrokenThreshold = 44,
            };

            yield return new HazardComponent
            {
                Id = Guid.Parse("363a661a-06ba-4d70-ab3d-dc1156c964be"),
                Name = "Joint",
                HitPoints = 64,
                Hardness = 16,
                BrokenThreshold = 32,
            };
        }

        protected override IEnumerable<string> GetImmunities()
        {
            yield return "Critical Hits";
            yield return "Object Immunities";
            yield return "Precision Damage";
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "Magical";
            yield return "Mechanical";
            yield return "Trap";
        }

        protected override IEnumerable<HazardAction> GetActions(HazardSeeder seeder)
        {
            yield return new HazardAction
            {
                Id = Guid.Parse("2eb1837d-c49c-447e-98d7-b30c858912f0"),
                Name = "Forbid Entry",
                Traits = seeder.FilterTraits("Abjuration", "Divine"),
                Trigger = "A creature attempts to enter through the entrance",
                ActionTypeId = seeder.GetActionTypeByName("Reaction").Id,
                Details = new List<TextBlock>
                {
                    new TextBlock { Id = Guid.Parse("356c9040-4be1-4428-a454-8e39c037da0c"), Type = TextBlockType.Text, Text = "The hammer swings down, making a Strike against the triggering creature." },
                },
                Effects =
                {
                     new AttackHazardActionEffect
                     {
                        Id = Guid.Parse("12bd4ee5-1bb3-406a-845b-be5e69a7f94b"),
                        AttackTypeId = seeder.GetAttackTypeByName("Melee").Id,
                        ActionTypeId = seeder.GetActionTypeByName("No Action").Id,
                        DamageTypeId = seeder.GetDamageTypeByName("Bludgeoning").Id,
                        Addendum = "The target is knocked back 10 feet and must succeed at a DC 30 Will save or be unable to enter the edifice through any entrance for 24 hours (on a critical hit, the target automatically fails the Will save); no multiple attack penalty.",
                        Damage = "6d8+20",
                        Weapon = "Hammer",
                        ProficiencyBonus = 28
                     },
                }
            };
        }

        protected override HazardDetectionRequirement GetDetectionRequirement(HazardSeeder seeder)
        {
            return new HazardDetectionRequirement
            {
                Id = Guid.Parse("9c5b1455-5d22-4b85-baee-aa7a7e9aabd9"),
                RequiredProficiencyId = seeder.GetProficiencyByName("Expert").Id,
                DifficultyCheck = 30
            };
        }

        protected override IEnumerable<HazardDisableRequirement> GetDisableRequirements(HazardSeeder seeder)
        {
            yield return new HazardDisableRequirement
            {
                Id = Guid.Parse("b477f38d-c91a-44c7-9095-7e6e9c52d81d"),
                SkillId = seeder.GetSkillByName("Thievery").Id,
                RequiredProficiencyId = seeder.GetProficiencyByName("Expert").Id,
                Description = "once on the hammer itself and once on its joint to prevent the hammer from swinging",
                DifficultyCheck = 28
            };
        }

        protected override IEnumerable<HazardDispellRequirement> GetDispellRequirements(HazardSeeder seeder)
        {
            yield break;
        }

        protected override SourcePage GetSourcePage(HazardSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("7fe355f0-54eb-46b1-9472-7d4a53a4db08"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 525
            };
        }
    }
}