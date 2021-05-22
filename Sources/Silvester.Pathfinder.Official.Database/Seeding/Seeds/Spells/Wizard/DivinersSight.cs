using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class DivinersSight : Template
    {
        public static readonly Guid ID = Guid.Parse("2c02685a-da10-4dea-879d-e9b59b7f7e23");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Diviner's Sight",
                Level = 1,
                Range = "30 feet.",
                Duration = "Until the end of your next turn.",
                Targets = "1 willing living creature.",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Wizard.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2c02685a-da10-4dea-879d-e9b59b7f7e23"), Type = TextBlockType.Text, Text = "You glimpse into the target’s future. Roll a d20; when the target attempts a non-secret saving throw or skill check, it can use the number you rolled instead of rolling, and the spell ends. Alternatively, you can instead reveal the result of the die roll for one of the target’s secret checks during the duration, and the spell ends. Casting it again ends any active diviner’s sight you have cast, as well as any active diviner’s sight on the target." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Concentrate.ID;
            yield return Traits.Instances.Divination.ID;
            yield return Traits.Instances.Fortune.ID;
            yield return Traits.Instances.Wizard.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2c02685a-da10-4dea-879d-e9b59b7f7e23"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 406
            };
        }
    }
}
