﻿using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances
{
    public class WorldGuide : AbstractSourceTemplate
    {
        public static readonly Guid ID = Guid.Parse("fc93169c-2136-4e9c-9868-c5f0bb79b331");

        protected override Source GetSource()
        {
            return new Source
            {
                Id = ID,
                Name = "World Guide"
            };
        }
    }
}
