﻿using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Staves.Instances
{
    public class StaffOfEvocation : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Stave GetStave()
        {
            return new Stave
            {
                Id = ID,
                Name = "Staff of Evocation",
                Usage = "Held in 1 hand",
                Activate = "Cast a Spell.",
                Effect = "You expend a number of charges from the staff to cast a spell from its list.",
                CraftingRequirements = "Supply one casting of all listed levels of all listed spells.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "This staff is tapered at the base and carved into a gem-studded twist at the top. While wielding the staff, you gain a +2 circumstance bonus to checks to identify evocation magic." };
        }

        protected override IEnumerable<StavePotencyBinding> GetPotencies()
        {
            yield return new StavePotencyBinding
            {
                Id = Guid.Parse(""),
                Price = 23000,
                ItemLevel = 6,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Unclassified.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse(""), Level = 0, SpellId = Spells.Instances.RayOfFrostSpell.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 1, SpellId = Spells.Instances.MagicMissileSpell.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 1, SpellId = Spells.Instances.ShockingGraspSpell.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 2, SpellId = Spells.Instances.AcidArrow.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 2, SpellId = Spells.Instances.GlitterdustSpell.ID},
                },
            };

            yield return new StavePotencyBinding
            {
                Id = Guid.Parse(""),
                Price = 90000,
                ItemLevel = 10,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Greater.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse(""), Level = 3, SpellId = Spells.Instances.LightningBoltSpell.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 3, SpellId = Spells.Instances.MagicMissileSpell.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 4, SpellId = Spells.Instances.FireballSpell.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 4, SpellId = Spells.Instances.WeaponStormSpell.ID},
                },
            };

            yield return new StavePotencyBinding
            {
                Id = Guid.Parse(""),
                Price = 400000,
                ItemLevel = 14,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Major.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse(""), Level = 5, SpellId = Spells.Instances.ConeOfCold.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 5, SpellId = Spells.Instances.MagicMissileSpell.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 6, SpellId = Spells.Instances.ChainLightning.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 6, SpellId = Spells.Instances.WallOfForceSpell.ID},
                },
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Magical.ID;
            yield return Traits.Instances.Staff.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 593
            };
        }
    }
}
