﻿using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Races.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Heritages.Instances
{
    public class CavernElf : AbstractHeritageTemplate
    {
        public static readonly Guid ID = Guid.Parse("3623e7a3-e6e0-49d6-bddf-86374cd4e5d3");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Cavern Elf", 
                Description = "You were born or spent many years in underground tunnels or caverns where light is scarce. You gain darkvision." 
            };
        }

        protected override IEnumerable<Guid> GetRaces()
        {
            yield return Elf.ID;
        }
    }
}
