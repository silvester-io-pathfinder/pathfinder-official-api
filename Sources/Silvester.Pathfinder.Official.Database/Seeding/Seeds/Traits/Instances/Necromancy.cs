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
    public class Necromancy : AbstractTraitTemplate
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Trait GetTrait(TraitSeeder seeder)
        {
            return new Trait
            {
                Id = ID,
                Name = "Necromancy",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Effects and magic items with this trait are associated with the necromancy school of magic, typically involving forces of life and death." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = CoreRulebook.ID,
                Page = 634
            };
        }
    }
}