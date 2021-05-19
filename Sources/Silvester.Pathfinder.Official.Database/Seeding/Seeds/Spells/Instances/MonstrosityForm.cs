﻿using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class MonstrosityForm : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Monstrosity Form",
                Level = 8,
                IsDismissable = true,
                Duration = "1 minute.",
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You transform into the shape of a legendary monster, assuming a Huge battle form. You must have enough space to expand into or the spell is lost. When you cast this spell, choose phoenix, purple worm, or sea serpent. While in this form, you gain the beast trait (for phoenix) or the animal trait (for purple worm or sea serpent). You can Dismiss the spell." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You gain the following statistics and abilities regardless of which battle form you choose:" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "AC = 20 + your level. Ignore your armor’s check penalty and Speed reduction." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "20 temporary Hit Points." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Darkvision." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "One or more unarmed melee attacks specific to the battle form you choose, which are the only attacks you can use. You’re trained with them. Your attack modifier is +28, and you use the listed damage. These attacks are Strength based (for the purpose of the enfeebled condition, for example). If your unarmed attack modifier is higher, you can use it instead." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Athletics modifier of +30, unless your own modifier is higher." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You also gain specific abilities based on the type of monster you choose:" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Phoenix - Speed 30 feet, fly Speed 90 feet; Melee [one-action] beak (reach 15 feet), Damage 2d6+12 piercing plus 2d4 fire and 2d4 persistent fire; Melee [one-action] talon (agile, reach 15 feet), Damage 2d8+12 slashing; Shroud of Flame (aura, evocation, fire, primal) 20 feet. You gain an aura of fire that extends out from you. A creature that enters or ends its turn within the aura takes 2d6 fire damage. A creature can take this damage only once per turn. You can use a single action, which has the concentrate trait, to activate or deactivate this aura." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Purple - Worm Speed 40 feet, burrow Speed 30 feet, swim Speed 20 feet; Melee [one-action] jaws (reach 10 feet), Damage 2d12+20 piercing; Melee [one-action] stinger (agile, reach 10 feet), Damage 2d8+15 piercing plus 2d6 persistent poison; Melee [one-action] body (reach 10 feet) Damage 2d8+20 bludgeoning; Inexorable You automatically recover from the paralyzed, slowed, and stunned conditions at the end of each of your turns. You’re also immune to being immobilized and ignore difficult terrain and greater difficult terrain." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Sea Serpent - Speed 20 feet, swim Speed 90 feet; Melee [one-action] jaws (reach 15 feet), Damage 2d12+20 piercing; Melee [one-action] tail (reach 25 feet), Damage 2d8+20 bludgeoning; Spine Rake [two-actions] (move) You extend your spines and Swim or Stride. Each creature you’re adjacent to at any point during your movement takes 4d8+10 slashing damage (basic Reflex against your spell DC)." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse(""), 
                Level = "9th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You instead gain AC = 22 + your level, 25 temporary HP, attack modifier +31, increase damage by one damage die, and Athletics +33." }
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
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Primal.ID;
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
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 353
            };
        }
    }
}
