﻿using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class ThreefoldAspect : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Threefold Aspect",
                Level = 3,
                CastTime = "1 minute.",
                IsDismissable = true,
                Duration = "Until the next time you make your daily preparations.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.LongAction.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "This spell allows you to change between three versions of yourself of different ages: a maiden (young adult), a mother (adult), or a matriarch (elderly). Choose one when you Cast the Spell. While the spell lasts, you can change the age to any of the three or to your natural age with a single action, which has the concentrate trait. Your form always looks like you regardless of the age, and creatures who know you still recognize you and can tell your age is different." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Threefold aspect alters your physical appearance and personality to present an authentic version of yourself at various ages. This grants you a +4 status bonus to Deception checks to pass as the chosen age, and you can add your level as a proficiency bonus to these checks even if you’re untrained. Furthermore, unless a creature specifically uses a Seek action or otherwise carefully examines you, it doesn’t get a chance to notice that you aren’t at your true age. You can Dismiss this spell." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield break;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Primal.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Polymorph.ID;
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 226
            };
        }
    }
}
