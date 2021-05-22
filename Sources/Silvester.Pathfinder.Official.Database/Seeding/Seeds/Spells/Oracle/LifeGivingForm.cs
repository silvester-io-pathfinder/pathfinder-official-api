﻿using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class LifeGivingForm : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Life-Giving Form",
                Level = 6,
                IsDismissable = true,
                Duration = "1 minute.",
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Oracle.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID,
                MysteryId = Mysteries.Instances.Life.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You transcend your physical form, becoming a beacon of healing energy. Your body exudes bright light like a torch. You gain resistance 5 to precision damage and weakness 5 to negative damage, and your unarmed Strikes deal an extra 1d4 positive damage." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You can touch a living creature with an Interact action to restore 6d8 Hit Points to it, and when a creature touches you with an Interact action you can allow it to gain the same healing; either way, the creature becomes temporarily immune to life-giving form’s healing for 1 minute. This is a positive healing effect. You can’t heal yourself with life-giving form. A creature harmed by positive damage (such as an undead) that touches you or damages you with an unarmed attack or non-reach melee weapon instead takes 3d4 positive damage, and it doesn’t become temporarily immune." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You can Dismiss this spell." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse(""),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Increase the Hit Points restored with an Interact action by 1d8, the positive damage by 1, and the resistance and weakness by 1." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Cursebound.ID;
            yield return Traits.Instances.Healing.ID;
            yield return Traits.Instances.Light.ID;
            yield return Traits.Instances.Necromancy.ID;
            yield return Traits.Instances.Oracle.ID;
            yield return Traits.Instances.Positive.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 232
            };
        }
    }
}
