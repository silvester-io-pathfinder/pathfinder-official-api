﻿using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Staves.Instances
{
    public class StaffOfImpossibleVisions : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Stave GetStave()
        {
            return new Stave
            {
                Id = ID,
                Name = "StaffOof Impossible Visions",
                Usage = "Held in 1 hand",
                Activate = "Cast a Spell.",
                CraftingRequirements = "Supply one casting of all listed levels of all listed spells.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "This bizarre staff is made from oak, capped with a cluster of eye-shaped gemstones that seem to move and undulate at the corner of your vision. While wielding the staff, you can peer through the eyes, using your normal visual senses (including any benefits of spells affecting your vision, like see invisibility). You can maneuver the staff to see things around corners, at higher elevations, or in places where the staff can fit but your head can't. This doesn't provide sufficient line of effect to target creatures around corners. The eyes are as vulnerable as your eyes and can be affected by anything that alters your vision, such as a blinding flash of light." };
        }

        protected override IEnumerable<ActionEffect> GetActionEffects()
        {
            yield return new ActionEffect
            {
                Id = Guid.Parse(""),
                Name = "Cast a Spell",
                ActionTypeId = ActionTypes.Instances.OneToThreeActions.ID,
                Effects = new TextBlock[]
                {
                    new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You expend a number of charges from the staff to cast a spell from its list." }
                }
            };
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
                    new StaveSpell { Id = Guid.Parse(""), SpellId = Spells.Instances.Daze.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 1, SpellId = Spells.Instances.Fear.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 1, SpellId = Spells.Instances.PhantomPain.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 2, SpellId = Spells.Instances.Augury.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 2, SpellId = Spells.Instances.Paranoia.ID},
                },
            };

            yield return new StavePotencyBinding
            {
                Id = Guid.Parse(""),
                Price = 180000,
                ItemLevel = 12,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Greater.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse(""), Level = 3, SpellId = Spells.Instances.HypnoticPattern.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 3, SpellId = Spells.Instances.Paralyze.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 4, SpellId = Spells.Instances.CountlessEyes.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 4, SpellId = Spells.Instances.PhantasmalKiller.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 5, SpellId = Spells.Instances.StrangeGeometry.ID},
                },
            };

            yield return new StavePotencyBinding
            {
                Id = Guid.Parse(""),
                Price = 1000000,
                ItemLevel = 16,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Major.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse(""), Level = 6, SpellId = Spells.Instances.BlindingFury.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 6, SpellId = Spells.Instances.PhantasmalCalamity.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 7, SpellId = Spells.Instances.VisionsOfDanger.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 7, SpellId = Spells.Instances.WarpMind.ID},
                },
            };

            yield return new StavePotencyBinding
            {
                Id = Guid.Parse(""),
                Price = 7000000,
                ItemLevel = 20,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.True.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse(""), Level = 8, SpellId = Spells.Instances.SpiritSong.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 8, SpellId = Spells.Instances.UncontrollableDance.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 9, SpellId = Spells.Instances.UnfathomableSong.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 9, SpellId = Spells.Instances.Weird.ID},
                },
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Illusion.ID;
            yield return Traits.Instances.Magical.ID;
            yield return Traits.Instances.Staff.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 263
            };
        }
    }
}
