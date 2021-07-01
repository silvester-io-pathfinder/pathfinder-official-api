using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Artifacts.Instances
{
    public class PhilosophersExtractor : Template
    {
        public static readonly Guid ID = Guid.Parse("7b9cb35a-6622-4e64-ab2e-142cfa2e413f");

        protected override Artifact GetArtifact()
        {
            return new Artifact
            {
                Id = ID,
                Name = "Philosopher's Extractor",
                Destruction = "Simultaneously feeding the philosopher’s extractor sizable portions of an aeon, angel, archon, azata, daemon, demon, devil, protean, and psychopomp, each of at least 14th level, along with a philosopher’s stone causes the device to jam, overheat, and explode. Creatures within 60 feet of the explosion must succeed at a DC 55 Reflex save or become covered in an alchemical slurry that transforms them into a horrifying amalgam of at least two of the creatures used to destroy the machine.",
                ItemLevel = 28,
                BulkId = Bulks.Instances.EightBulk.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("8efd9689-5eac-43fb-922a-4caf975cb2da"), Type = TextBlockType.Text, Text = "This bizarre machine is a complex arrangement of flasks, tubes, and other alchemical equipment. The philosopher’s extractor is designed to create the ultimate alchemical concoctions. The extractor functions as an exceptional set of alchemist’s tools, granting a +4 item bonus to Crafting checks related to alchemy. When using the extractor to Craft an alchemical item or with infused reagents as part of your daily preparations, you can create impeccable alchemical items. An impeccable alchemical item always uses the maximum numerical value possible for any rolls it requires, such as dealing maximum damage with alchemist’s fire or restoring the maximum number of Hit Points with an elixir of life. If the impeccable item has a duration, it lasts twice as long as normal. Finally, an impeccable alchemical item never has a drawback." };
        }

        protected override IEnumerable<ArtifactAction> GetActions()
        {
            yield return new ArtifactAction
            {
                Id = Guid.Parse("e9e1579f-d07d-4ef9-8017-5cc4ba739a42"),
                Name = "Interact",
                Frequency = "Once per minute.",
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                Effects = new[]
                {
                    new TextBlock { Id = Guid.Parse("538565fe-5267-4a72-bc1a-a18fb4a9f2a9"), Type = TextBlockType.Text, Text = "You use the extractor to produce an alchemical item of your level or lower whose formula you know. The extractor can create 56 levels’ worth of items per day in this way. For example, the extractor could create two true elixirs of life (19th level) and two moderate elixirs of life (9th level), or eight comprehension elixirs (7th level), and so on." }
                }
            };

            yield return new ArtifactAction
            {
                Id = Guid.Parse("e3bb1e33-abaa-45ba-a001-297875d2b602"),
                Name = "Interact",
                RequiredTime = "1 hour.",
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                Effects = new[]
                {
                    new TextBlock { Id = Guid.Parse("575d4f2b-fcde-42c4-9a44-a3110f0a5158"), Type = TextBlockType.Text, Text = "You take a sizable portion of a creature (at least two-thirds of its original mass) and filter it through the mechanisms of the extractor. After the end of the process, the philosopher’s extractor creates a transmogrifying mutagen that imparts the essence of the creature to the drinker. The extractor can make several transmogrifying mutagens simultaneously using the same activation if enough mass is provided at once, up to a maximum of 10 concurrent mutagens. Drinking a transmogrifying mutagen imparts you with one of the creature’s unique abilities for 1 hour. This could grant one of several abilities such as a dragon’s Breath Weapon, darkvision, flight, frightful presence, or immunity to sleep. The ability functions as it did for the original creature, except it uses your class DC or your spell DC (whichever is higher) instead of the creature’s DC. The mutagen grants only abilities based on a creature’s physiology and never grants magic-related abilities such as innate spells or spellcasting ability. The GM ultimately decides what ability a transmogrifying mutagen grants." },
                    new TextBlock { Id = Guid.Parse("c8d7b7c0-41cf-487d-aa74-6d4892600b31"), Type = TextBlockType.Text, Text = "Unlike normal for mutagens and effects, you can drink multiple transmogrifying mutagens and gain benefits from each. When you drink transmogrifying mutagens made from different creatures, you receive abilities from each creature. When you drink multiple transmogrifying mutagens made from the same type of creature, such as multiple mutagens made from trolls, you gain an additional ability for each transmogrifying mutagen you drink, and the duration of the abilities from that creature type increases by 1 hour for each additional concoction you drink." },
                    new TextBlock { Id = Guid.Parse("68162d70-bf62-4e51-9bd1-4aa46b357977"), Type = TextBlockType.Text, Text = "However, these additional benefits come with a risk; if you drink a transmogrifying mutagen while at least one other is active, after drinking it, you must succeed at a flat check with a DC equal to the total number of active transmogrifying mutagens you’ve consumed. On a failure, you fully transform into a member of the species of the latest transmogrifying mutagen you drank, and you almost always go berserk from your change. The transformation may leave some amount of your personality and memories intact, at the GM’s discretion." }
                }
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Rare.ID;
            yield return Traits.Instances.Artifact.ID;
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Magical.ID;
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2f256873-91d1-4c12-af13-f344cf88f7cf"),
                SourceId = Sources.Instances.GamemasteryGuide.ID,
                Page = 112
            };
        }
    }
}
