﻿using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class DeafnessSpell : AbstractSpellTemplate
    {
        public static readonly Guid ID = Guid.Parse("509c9a55-433c-4f99-8a7a-609d38f23ed1");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Deafness",
                Level = 2,
                Range = 30,
                Targets = "1 creature.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4957d652-3659-4c6f-b259-ea076a4a861b"), Type = Utilities.Text.TextBlockType.Text, Text = "The target loses hearing; it must attempt a Fortitude save. The target is then temporarily immune for 1 minute." };
        }

        public override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect 
            {
                Id = Guid.Parse("fa67be43-2108-4e4d-ab58-18edad117031"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target is deafened for 1 round.",
                Failure = "The target is deafened for 10 minutes.",
                CriticalFailure = "The target is deafened permanently."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Necromancy.ID;
        }
    }
}
