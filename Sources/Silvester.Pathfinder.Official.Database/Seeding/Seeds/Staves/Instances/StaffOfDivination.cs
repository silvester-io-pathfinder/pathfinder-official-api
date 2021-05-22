using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Staves.Instances
{
    public class StaffOfDivination : Template
    {
        public static readonly Guid ID = Guid.Parse("eb4a1b1e-d1e0-495f-aeab-6605377a6082");

        protected override Stave GetStave()
        {
            return new Stave
            {
                Id = ID,
                Name = "Staff of Divination",
                Usage = "Held in 1 hand",
                Activate = "Cast a Spell.",
                CraftingRequirements = "Supply one casting of all listed levels of all listed spells.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("eb4a1b1e-d1e0-495f-aeab-6605377a6082"), Type = TextBlockType.Text, Text = "Semiprecious gemstones emerge, seemingly at random, from the surface of this gnarled wooden staff. While wielding it, you gain a +2 circumstance bonus to checks to identify divination magic." };
        }

        protected override IEnumerable<ActionEffect> GetActionEffects()
        {
            yield return new ActionEffect
            {
                Id = Guid.Parse("eb4a1b1e-d1e0-495f-aeab-6605377a6082"),
                Name = "Cast a Spell",
                ActionTypeId = ActionTypes.Instances.OneToThreeActions.ID,
                Effects = new TextBlock[]
                {
                    new TextBlock { Id = Guid.Parse("eb4a1b1e-d1e0-495f-aeab-6605377a6082"), Type = TextBlockType.Text, Text = "You expend a number of charges from the staff to cast a spell from its list." }
                }
            };
        }

        protected override IEnumerable<StavePotencyBinding> GetPotencies()
        {
            yield return new StavePotencyBinding
            {
                Id = Guid.Parse("eb4a1b1e-d1e0-495f-aeab-6605377a6082"),
                Price = 23000,
                ItemLevel = 6,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Unclassified.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("eb4a1b1e-d1e0-495f-aeab-6605377a6082"), SpellId = Spells.Instances.DetectMagic.ID},
                    new StaveSpell { Id = Guid.Parse("eb4a1b1e-d1e0-495f-aeab-6605377a6082"), Level = 1, SpellId = Spells.Instances.TrueStrike.ID},
                    new StaveSpell { Id = Guid.Parse("eb4a1b1e-d1e0-495f-aeab-6605377a6082"), Level = 2, SpellId = Spells.Instances.ComprehendLanguage.ID},
                    new StaveSpell { Id = Guid.Parse("eb4a1b1e-d1e0-495f-aeab-6605377a6082"), Level = 2, SpellId = Spells.Instances.Darkvision.ID},
                    new StaveSpell { Id = Guid.Parse("eb4a1b1e-d1e0-495f-aeab-6605377a6082"), Level = 2, SpellId = Spells.Instances.SeeInvisibility.ID},
                },
            };

            yield return new StavePotencyBinding
            {
                Id = Guid.Parse("eb4a1b1e-d1e0-495f-aeab-6605377a6082"),
                Price = 90000,
                ItemLevel = 10,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Greater.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("eb4a1b1e-d1e0-495f-aeab-6605377a6082"), Level = 3, SpellId = Spells.Instances.Clairaudience.ID},
                    new StaveSpell { Id = Guid.Parse("eb4a1b1e-d1e0-495f-aeab-6605377a6082"), Level = 3, SpellId = Spells.Instances.Darkvision.ID},
                    new StaveSpell { Id = Guid.Parse("eb4a1b1e-d1e0-495f-aeab-6605377a6082"), Level = 4, SpellId = Spells.Instances.Clairvoyance.ID},
                    new StaveSpell { Id = Guid.Parse("eb4a1b1e-d1e0-495f-aeab-6605377a6082"), Level = 4, SpellId = Spells.Instances.ComprehendLanguage.ID},
                    new StaveSpell { Id = Guid.Parse("eb4a1b1e-d1e0-495f-aeab-6605377a6082"), Level = 4, SpellId = Spells.Instances.Telepathy.ID},
                },
            };

            yield return new StavePotencyBinding
            {
                Id = Guid.Parse("eb4a1b1e-d1e0-495f-aeab-6605377a6082"),
                Price = 400000,
                ItemLevel = 14,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Major.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("eb4a1b1e-d1e0-495f-aeab-6605377a6082"), Level = 5, SpellId = Spells.Instances.PryingEye.ID},
                    new StaveSpell { Id = Guid.Parse("eb4a1b1e-d1e0-495f-aeab-6605377a6082"), Level = 5, SpellId = Spells.Instances.Sending.ID},
                    new StaveSpell { Id = Guid.Parse("eb4a1b1e-d1e0-495f-aeab-6605377a6082"), Level = 6, SpellId = Spells.Instances.Telepathy.ID},
                    new StaveSpell { Id = Guid.Parse("eb4a1b1e-d1e0-495f-aeab-6605377a6082"), Level = 6, SpellId = Spells.Instances.TrueSeeing.ID},
                },
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Divination.ID;
            yield return Traits.Instances.Magical.ID;
            yield return Traits.Instances.Staff.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("eb4a1b1e-d1e0-495f-aeab-6605377a6082"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 594
            };
        }
    }
}
