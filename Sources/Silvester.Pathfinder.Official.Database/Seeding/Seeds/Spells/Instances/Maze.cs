﻿using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class Maze : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Maze",
                Level = 8,
                Range = "30 feet.",
                IsDismissable = true,
                Duration = "Sustained.",
                Targets = "1 creature.",
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You transport the target into an extradimensional maze of eldritch origin and trap it there. Once each turn, the target can spend 1 action to attempt a Survival check or Perception check against your spell DC to escape the maze. The possible outcomes are as follows." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Teleportation magic doesn’t help the creature escape unless the magic can transport across planes, such as plane shift. When the spell ends, either because the target escaped or the duration ran out, the target returns to the space it occupied when it was banished, or to the nearest space if the original is now filled." };
        }

        public override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse(""),
                CriticalSuccess = "The target escapes and the spell ends.",
                Success = "The target is on the right path to the exit. If the target was already on the right path, it escapes the maze and the spell ends.",
                Failure = "The target makes no progress toward escape.",
                CriticalFailure = "The target makes no progress toward escape, and if it was on the right path, it no longer is."
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
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Conjuration.ID;
            yield return Traits.Instances.Extradimensional.ID;
            yield return Traits.Instances.Teleportation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 350
            };
        }
    }
}
