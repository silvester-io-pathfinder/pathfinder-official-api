﻿using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Swashbuckler : AbstractTraitTemplate
    {
        public static readonly Guid ID = Guid.Parse("6f2863ac-71a4-480a-92b5-b7dbfa82218f");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Swashbuckler",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("08658627-1b01-436d-8436-9cd782f05c54"), Type = TextBlockType.Text, Text = "This trait indicates abilities from the swashbuckler class." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("53d34959-9e6b-4617-aaae-43a6e70fa4d3"),
                SourceId = AdvancedPlayersGuide.ID,
                Page = 270
            };
        }
    }
}
