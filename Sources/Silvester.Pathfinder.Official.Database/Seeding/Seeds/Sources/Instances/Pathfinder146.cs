﻿using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances
{
    public class Pathfinder146 : AbstractSourceTemplate
    {
        public static readonly Guid ID = Guid.Parse("a5d364de-b6eb-4fed-a4f6-9ddde9e87958");

        protected override Source GetSource()
        {
            return new Source
            {
                Id = ID,
                Name = "Pathfinder #146: Cult of Cinders"
            };
        }
    }
}
