﻿using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions.Instances
{
    public class Hostile : AbstractConditionTemplate
    {
        public static readonly Guid ID = Guid.Parse("d56a5083-fa2f-4d9c-a968-0b7664e1c9cd");

        public override Condition GetCondition(ConditionSeeder seeder)
        {
            return new Condition
            {
                Id = ID,
                Name = "Hostile",
                ConditionCategoryId = seeder.GetCategoryByName("Attitudes").Id
            };
        }

        public override IEnumerable<TextBlock> GetConditionDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c921983d-388a-4891-b90b-7f024cfc9b6b"), Type = Utilities.Text.TextBlockType.Text, Text = "This condition reflects a creature’s disposition toward a particular character, and only supernatural effects (like a spell) can impose this condition on a PC. A creature that is hostile to a character actively seeks to harm that character. It doesn’t necessarily attack, but it won’t accept Requests from the character." };
        }

        public override SourcePage? GetSourcePage(ConditionSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("17f5c739-aab8-4631-8ca7-8ab7508205d5"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 620
            };
        }
    }
}