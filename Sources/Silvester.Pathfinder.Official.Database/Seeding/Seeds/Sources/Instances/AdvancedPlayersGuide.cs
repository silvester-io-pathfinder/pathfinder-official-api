﻿using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances
{
    public class AdvancedPlayersGuide : AbstractSourceTemplate
    {
        public static readonly Guid ID = Guid.Parse("979e79d5-05ab-4c2f-b8eb-872f89367ddc");

        protected override Source GetSource()
        {
            return new Source
            {
                Id = ID,
                Name = "Advanced Player's Guide"
            };
        }
    }
}
