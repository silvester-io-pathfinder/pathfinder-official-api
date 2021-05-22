using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class ZealousConviction : Template
    {
        public static readonly Guid ID = Guid.Parse("c031cae9-f3f1-4a95-9044-25d13216dc9b");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Zealous Conviction",
                Level = 6,
                Range = "30 feet.",
                Duration = "10 minutes.",
                Targets = "Up to 10 willing creatures.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c031cae9-f3f1-4a95-9044-25d13216dc9b"), Type = TextBlockType.Text, Text = "You bypass your targets’ rational minds, instilling them with unshakable conviction and zeal. The targets each gain 12 temporary Hit Points and a +2 status bonus to Will saves against mental effects, as their faith overrides the signals from their own bodies and minds. If you tell a target to do something, it must comply with your request, though if it would normally find the task repugnant, it can attempt a Will save at the end of its turn each round due to the cognitive dissonance. On a success, it ends the spell’s effects on itself entirely." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("c031cae9-f3f1-4a95-9044-25d13216dc9b"), 
                Level = "9th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("c031cae9-f3f1-4a95-9044-25d13216dc9b"), Type = TextBlockType.Text, Text = "The temporary Hit Points increase to 18, and the status bonus to Will saves increases to +3." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Emotion.ID;
            yield return Traits.Instances.Enchantment.ID;
            yield return Traits.Instances.Mental.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c031cae9-f3f1-4a95-9044-25d13216dc9b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 385
            };
        }
    }
}
