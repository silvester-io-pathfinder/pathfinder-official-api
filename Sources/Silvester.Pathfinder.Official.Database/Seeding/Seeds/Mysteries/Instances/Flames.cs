﻿using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Tables;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Mysteries.Instances
{
    public class Flames : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Mystery GetMystery()
        {
            return new Mystery
            {
                Id = ID,
                Name = "Flames",
                InitialRevelationId = Spells.Instances.IncendiaryAura.ID,
                AdvancedRevelationId = Spells.Instances.WhirlingFlames.ID,
                GreaterRevelationId = Spells.Instances.FlamingFusillade.ID,
                GrantedCantripId = Spells.Instances.ProduceFlame.ID,
                TrainedSkillId = Skills.Instances.Acrobatics.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Fire lives at the center of the world, the center of the sun, and the center of civilization. You might revere this elemental force, siphon power from the Elemental Plane of Fire, or venerate a collection of deities such as Asmodeus, Sarenrae, the Tian goddess of disasters and volcanoes Lady Nanbyo, or the elemental lord of fire Ymeri." };
        }

        protected override IEnumerable<TextBlock> GetBenefitBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Like fire itself, you flicker and dance, avoiding effects that would quench your vitality. You have expert proficiency in Reflex saves. At 13th level, if you gain the lightning reflexes class feature, your proficiency rank for Reflex saves increases to master, and when you roll a success on a Reflex save, you get a critical success instead." };
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Fire.ID;
            yield return Domains.Instances.Sun.ID;
        }

        protected override MysteryCurse GetCurse()
        {
            return new MysteryCurse
            {
                Id = Guid.Parse(""),
                Name = "Curse of Engulfing Flames",
                SourcePage = new SourcePage
                {
                    Id = Guid.Parse(""),
                    SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                    Page = 76
                },
                Details = new TextBlock[]
                {
                    new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You see flames and smoke wherever you look. These flames might be imagined, or they might be a preternatural glimpse of the metaphorical fires that empower the entire multiverse—but you always see them. Fires flare noticeably (though not dangerously) in your presence, you occasionally smoke slightly, and your body is almost painfully hot to the touch." }
                },
                Potencies = new MysteryCursePotency[]
                {
                    new MysteryCursePotency
                    {
                        Id = Guid.Parse(""),
                        PotencyId = Potencies.Instances.Minor.ID,
                        Details = new TextBlock[] 
                        { 
                            new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The smoke, heat, and crackling flames of your curse fill your vision and all your other senses. Creatures further than 30 feet are concealed from you. You can't benefit from effects that would allow you to ignore or mitigate this concealment, as normal for effects of an oracular curse." }
                        }
                    },
                    new MysteryCursePotency
                    {
                        Id = Guid.Parse(""),
                        PotencyId = Potencies.Instances.Moderate.ID,
                        Details = new TextBlock[]
                        {
                            new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Smoke and flickering visions of flame fill your senses more completely, and harmless flickers of obscuring flames also fill your space. You are concealed from other creatures, though as the other creatures aren't cursed themselves, they can benefit from effects that would allow them to ignore or mitigate the concealed condition, as normal. All other creatures and objects are concealed from you regardless of distance; however, when casting a fire spell, you automatically succeed at the flat check for this concealed condition for targets within 30 feet." },
                            new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "All your senses become imprecise beyond 30 feet, meaning everything past 30 feet that you'd normally be able to see is hidden from you." }
                        }
                    },
                    new MysteryCursePotency
                    {
                        Id = Guid.Parse(""),
                        PotencyId = Potencies.Instances.Major.ID,
                        Details = new TextBlock[]
                        {
                            new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The flames surrounding you are no longer simply visions. An aura of fire surrounds you in a 10-foot emanation, dealing 4d6 fire damage (basic Reflex save) to all other creatures in the aura at the end of each of your turns. You lose 1d6 Hit Points at the end of your turn each round, with no save; if you have a weakness to fire, increase the number of HP you lose by that weakness." },
                            new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You can suppress your aura until the start of your next turn by spending a single action, which has the concentrate trait, to diminish the flames, causing neither you nor anyone in the aura to take damage. While Refocusing to reduce your curse, you are continually diminishing the flames, so you don't lose HP. The flames subside if you fall unconscious, but they resume when you wake up unless you rested for long enough to reset your curse. As usual for oracular curses, you can't mitigate or reduce the lost Hit Points in any way, though you can still heal the lost HP normally after the fact." }
                        }
                    }
                },
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 76
            };
        }
    }
}
