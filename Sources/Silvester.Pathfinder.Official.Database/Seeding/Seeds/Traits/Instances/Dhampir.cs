﻿using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Dhampir : AbstractTraitTemplate
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Trait GetTrait(TraitSeeder seeder)
        {
            return new Trait
            {
                Id = ID,
                Name = "Dhampir",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "A creature with this trait has the dhampir versatile heritage. These humanoids are the immortal offspring of vampires and members of other ancestries." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = AdvancedPlayersGuide.ID,
                Page = 267
            };
        }
    }
}
